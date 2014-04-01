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

        }
    }
}