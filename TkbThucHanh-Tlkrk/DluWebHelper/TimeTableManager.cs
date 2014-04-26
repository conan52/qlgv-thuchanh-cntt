using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DluWebHelper
{
    public class TimeTableManager
    {
        public static TimeTableProcessStatus Status;
        private static object syncRoot;
        private static object syncLesson;

        static TimeTableManager()
        {
            Status = new TimeTableProcessStatus();
            syncRoot = new object();
            syncLesson = new object();
        }

        public static TimeTableProcessStatus GetStatus()
        {
            lock (syncRoot)
            {
                return Status.Clone();
            }
        }

        public static void AddTask()
        {
            lock (syncRoot)
            {
                Status.Done++;
                Console.WriteLine("{0} / {1}", Status.Done, Status.Total);
            }
        }


        public List<Lesson> GetTimeFullTable(List<string> teachers, List<string> courses, List<int> weeks)
        {
            Status = new TimeTableProcessStatus();
            var Lessons = new List<Lesson>();


            var request = new DluWebRequest();
            var init = weeks.Select(request.GetCurentTimeTable).ToList();
            foreach (TimeTableWebResult i in init)
            {
                i.TeacherCodes = i.TeacherCodes.Intersect(teachers).ToList();
                i.Class = i.Class.Intersect(courses).ToList();
            }
            Status.Total = init.Sum(i => i.Class.Count + i.TeacherCodes.Count);

            var t = new List<Thread>();
            foreach (var i in init)
            {
                t.AddRange(i.Class.Select(c => new Thread(() =>
                {
                    var rq = new DluWebRequest();
                    var ls = rq.GetClassTimeTable(c, i.CurrentWeek);
                    lock (syncLesson)
                    {
                        Lessons.AddRange(ls);
                    }
                    AddTask();
                })));
                t.AddRange(i.TeacherCodes.Select(tc => new Thread(() =>
                {
                    var rq = new DluWebRequest();
                    var ls = rq.GetTeacherTimeTable(tc, i.CurrentWeek);
                    lock (syncLesson)
                    {
                        Lessons.AddRange(ls);
                    }
                    AddTask();
                })));
            }
            foreach (var thread in t)
            {
                thread.Start();
            }
            foreach (var thread in t)
            {
                thread.Join();
            }
            Status.AllDone = true;

            var result = from l in Lessons
                group l by new {l.Room, l.Start, l.Week, l.DayOfWeek, l.Subject, l.End}
                into g
                where g.Any(v => v.TeacherCode != null)
                select new Lesson()
                {
                    ClassCode = g.Max(v => v.ClassCode),
                    TeacherCode = g.Max(v => v.TeacherCode),
                    DayOfWeek = g.Key.DayOfWeek,
                    Room = g.Key.Room,
                    End = g.Key.End,
                    Start = g.Key.Start,
                    Subject = g.Key.Subject,
                    Week = g.Key.Week
                };
            return result.ToList();
        }
    }
}
