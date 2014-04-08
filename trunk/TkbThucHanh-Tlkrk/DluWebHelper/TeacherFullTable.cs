using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DluWebHelper
{
    public class TeacherFullTable
    {
        public string TeacherCode { get; set; }
        public int Group { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
        public string Subject { get; set; }
        public string Room { get; set; }
        public int DayOfWeek { get; set; }
        public string ClassCode { get; set; }

        public TeacherFullTable(string teacherCode, int g, int start, int end, string subject, string room, int dayOfWeek)
        {
            TeacherCode = teacherCode;
            Group = g;
            Start = start;
            End = end;
            Subject = subject;
            Room = room;
            DayOfWeek = dayOfWeek;
        }


        public static List<TeacherFullTable> GetFullTimeTable(List<StudentTimeTable> st, List<TeacherTimeTable> tt)
        {
            var ttf = tt.SelectMany(t => t.Lessons.Select(tm => new { tm.DayOfWeek, tm.End, tm.Start, tm.Subject, tm.Group, tm.Room, t.TeacherCode }).ToList());
            var stf = st.SelectMany(t => t.Lessons.Select(tm => new { tm.DayOfWeek, tm.End, tm.Start, tm.Subject, tm.Group, tm.Room, t.ClassCode }).ToList());
            var result = new List<TeacherFullTable>();

            foreach (var x in ttf)
            {
                var f = new TeacherFullTable(x.TeacherCode, x.Group, x.Start, x.End, x.Subject, x.Room, x.DayOfWeek);
                var j = stf.ToList().Find(cb => cb.DayOfWeek == x.DayOfWeek && cb.Start == x.Start && cb.Room == x.Room);
                if (j != null)
                    f.ClassCode = j.ClassCode;
                result.Add(f);
            }
            return result;
        }

        public static List<TeacherFullTable> GetFullTimeTable(int week, IEnumerable<string> courses, IEnumerable<string> teachers)
        {
            var webRequest = new DluWebRequest();
            var studenttb = new List<StudentTimeTable>();
            var cThread = new Thread(() =>
            {
                foreach (var className in courses)
                {
                    studenttb.Add(webRequest.GetClassTimeTable(className, week));
                    Console.WriteLine(className);
                }
            });

            var teachertb = new List<TeacherTimeTable>();
            var tThread = new Thread(() =>
            {
                foreach (var teacherCode in teachers)
                {
                    teachertb.Add(webRequest.GetTeacherTimeTable(teacherCode, week));
                    Console.WriteLine(teacherCode);
                }
            });

            cThread.Start();
            tThread.Start();
            cThread.Join();
            tThread.Join();

            return GetFullTimeTable(studenttb, teachertb);
        }
    }
}
