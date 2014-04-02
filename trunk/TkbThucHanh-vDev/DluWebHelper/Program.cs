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

            var r = TeacherFullTable.GetFullTimeTable(studenttb, teachertb);
        }
    }
}