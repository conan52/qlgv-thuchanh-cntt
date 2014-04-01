using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace DluWebHelper
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
            var webRequest = new DluWebRequest();
            var timetable = webRequest.GetCurentTimeTable();
            var week = timetable.CurrentWeek;
            // var week = 35;
            var classNames = timetable.Class
                .Where(c => c.StartsWith("CT"))
                .ToList();
            var teacherCodes = timetable.TeacherCodes
                .Where(c => c.StartsWith("CT"))
                .ToList();




            var studenttb = new List<StudentTimeTable>();
            var cThread = new Thread(() =>
            {
                foreach (var className in classNames)
                {
                    studenttb.Add(webRequest.GetClassTimeTable(className, week));
                    Console.WriteLine(className);
                }
            });


            var teachertb = new List<TeacherTimeTable>();
            var tThread = new Thread(() =>
            {
                foreach (var teacherCode in teacherCodes)
                {
                    teachertb.Add(webRequest.GetTeacherTimeTable(teacherCode, week));
                    Console.WriteLine(teacherCode);
                }
            });
            cThread.Start();
            tThread.Start();
            cThread.Join();
            tThread.Join();

            var student = studenttb.SelectMany(t => t.Lessons.Select(ls => new {ls.Group, ls.Room, ls.Start, ls.End, ls.Subject, t.ClassCode, ls.DayOfWeek})).ToList();
            var teacher = teachertb.SelectMany(t => t.Lessons.Select(ls => new {ls.Group, ls.Room, ls.Start, ls.End, ls.Subject, t.TeacherCode, ls.DayOfWeek})).ToList();

            var q = from category in teacher
                join prod in student on new {category.DayOfWeek, category.Start, category.Room} equals new {prod.DayOfWeek, prod.Start, prod.Room} into prodGroup
                select prodGroup.DefaultIfEmpty();

            var x = q.ToList();
            var query =
                from t in teacher
                from j in student.Where(j => j.Room == t.Room && j.Start == t.Start && j.DayOfWeek == t.DayOfWeek).DefaultIfEmpty()
                select new
                {
                    t.Room,
                    t.DayOfWeek,
                    t.Start
                };
            */


            List<ClassA> a = new List<ClassA>()
            {
                new ClassA("Thay quy", 1,2),
                new ClassA("Thay quy", 1,4),
                new ClassA("Thay phuc", 4,3),
                new ClassA("Thay phuc", 4,2),
            };

            List<ClassB> b = new List<ClassB>()
            {
                new ClassB(1,2,"CTK34"),
                new ClassB(1,2,"CTK34"),
                new ClassB(1,4,"CTK34"),
                new ClassB(4,3,"CTK32"),
                new ClassB(6,3,"CTK33")
            };

            List<ClassC> r = new List<ClassC>();
            foreach (ClassA classA in a)
            {
                ClassC c = new ClassC()
                {
                    SCol1 = classA.SCol1,
                    Col2 = classA.Col2,
                    Col3 = classA.Col2,
                };
                var j = b.Find(cb => cb.Col2 == classA.Col2 && cb.Col3 == classA.Col3);
                if (j != null)
                    c.SCol4 = j.SCol4;
                r.Add(c);
            }
        }
    }

    class ClassA
    {
        public string SCol1;
        public int Col2;
        public int Col3;

        public ClassA(string sCol1, int col2, int col3)
        {
            SCol1 = sCol1;
            Col2 = col2;
            Col3 = col3;
        }
    }

    class ClassB
    {
        public int Col2;
        public int Col3;
        public string SCol4;

        public ClassB(int col2, int col3, string col4)
        {
            Col2 = col2;
            Col3 = col3;
            SCol4 = col4;
        }
    }

    class ClassC
    {
        public string SCol1;
        public int Col2;
        public int Col3;
        public string SCol4;
    }
}