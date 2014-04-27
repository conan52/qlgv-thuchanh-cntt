using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace DluWebHelper
{
    public class TimeTableManager
    {
        public static TimeTableProcessStatus Status;
        private static readonly object syncRoot;
        private static readonly object syncLesson;

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
            List<TimeTableWebResult> init = weeks.Select(request.GetCurentTimeTable).ToList();
            foreach (TimeTableWebResult i in init)
            {
                i.TeacherCodes = i.TeacherCodes.Intersect(teachers).ToList();
                i.Class = i.Class.Intersect(courses).ToList();
            }
            Status.Total = init.Sum(i => i.Class.Count + i.TeacherCodes.Count);

            var t = new List<Thread>();
            foreach (TimeTableWebResult i in init)
            {
                t.AddRange(i.Class.Select(c => new Thread(() =>
                {
                    var rq = new DluWebRequest();
                    List<Lesson> ls = rq.GetClassTimeTable(c, i.CurrentWeek);
                    lock (syncLesson)
                    {
                        Lessons.AddRange(ls);
                    }
                    AddTask();
                })));
                t.AddRange(i.TeacherCodes.Select(tc => new Thread(() =>
                {
                    var rq = new DluWebRequest();
                    List<Lesson> ls = rq.GetTeacherTimeTable(tc, i.CurrentWeek);
                    lock (syncLesson)
                    {
                        Lessons.AddRange(ls);
                    }
                    AddTask();
                })));
            }
            foreach (Thread thread in t)
            {
                thread.Start();
            }
            foreach (Thread thread in t)
            {
                thread.Join();
            }
            Status.AllDone = true;

            IEnumerable<Lesson> result = from l in Lessons
                group l by new {l.Room, l.Start, l.Week, l.DayOfWeek, l.Subject, l.End}
                into g
                where g.Any(v => v.TeacherCode != null)
                select new Lesson
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