﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace DluWebHelper
{
    public class DluWebRequest
    {
        static DluWebRequest()
        {
            ServicePointManager.DefaultConnectionLimit = 1000;
        }
        public TimeTableWebResult GetCurentTimeTable(int week = -1)
        {
            var result = new TimeTableWebResult();
            var wc = new WebClient { Encoding = Encoding.UTF8 };
            var url = "http://203.113.164.162/timetable.aspx?week=" + (week > 0 ? week.ToString() : "");
            var s = wc.DownloadString(url);
            var doc = new HtmlDocument();
            doc.LoadHtml(s);

            var weeks = doc.DocumentNode.SelectNodes("//select[@name='cboWeek']/option");
            if (weeks != null)
                result.Weeks.AddRange(
                    weeks.Where(n => !string.IsNullOrWhiteSpace(n.Attributes["value"].Value))
                        .Select(n => Convert.ToInt32(n.Attributes["value"].Value)));

            var clas = doc.DocumentNode.SelectNodes("//select[@name='cboCourse']/option");
            if (clas != null)
                result.Class.AddRange(
                    clas.Where(n => !string.IsNullOrWhiteSpace(n.Attributes["value"].Value))
                        .Select(n => n.Attributes["value"].Value));

            var teacherCode = doc.DocumentNode.SelectNodes("//select[@name='cboTeacher']/option");
            if (teacherCode != null)
                result.TeacherCodes.AddRange(
                    teacherCode.Where(n => !string.IsNullOrWhiteSpace(n.Attributes["value"].Value))
                        .Select(n => n.Attributes["value"].Value));

            var m = Regex.Match(s, @"từ ngày (\d{1,2}/\d{1,2}/\d{4})\s*đến\sngày\s*(\d{1,2}/\d{1,2}/\d{4})");
            result.StartDate = DateTime.ParseExact(m.Groups[1].Value, "d/M/yyyy", null);
            result.EndDate = DateTime.ParseExact(m.Groups[2].Value, "d/M/yyyy", null);
            result.CurrentWeek = week < 0 ? result.Weeks.Max() : week;
            return result;
        }

        public List<Lesson> GetClassTimeTable(string className, int week)
        {
            var url = string.Format("http://203.113.164.162/timetable_display.aspx?course={0}&week={1}", className,
                week);
            var c = GetLessonResult(url);
            c.ForEach(l =>
            {
                l.Week = week;
                l.ClassCode = className;
            });
            return c;
        }

        public List<Lesson> GetTeacherTimeTable(string teacherCode, int week)
        {
            var url = string.Format(
                "http://203.113.164.162/timetable_teacher_display.aspx?teachercode={0}&week={1}", teacherCode, week);
            var c = GetLessonResult(url);
           c.ForEach(l =>
           {
               l.Week = week;
               l.TeacherCode = teacherCode;
           });
            return c;
        }

        private List<Lesson> GetLessonResult(string url)
        {
            var wc = new WebClient { Encoding = Encoding.UTF8 };
            var s = wc.DownloadString(url);
            var m = Regex.Match(s, @"(\d{1,2}/\d{1,2}/\d{4})\s*->\s*(\d{1,2}/\d{1,2}/\d{4})");
            if (!m.Success)
                return null;
            var result =new List<Lesson>();
            var doc = new HtmlDocument();
            doc.LoadHtml(s);
            for (var i = 1; i <= 7; i++)
            {
                var nodes = doc.DocumentNode
                    .SelectNodes("//div[@class='fl pad_l6 tl']/div/table/tr[4]/td/table/tr[2]/td[" + i +
                                 "]/table/tr/td[@align='center']");
                if (nodes == null) continue;
                foreach (var node in nodes)
                {
                    var lesson = getLesson(node.InnerHtml);
                    lesson.DayOfWeek = i;
                    result.Add(lesson);
                }
            }

            Console.Beep();
            return result;
        }

        private Lesson getLesson(string str)
        {
            var content = Regex.Split(str, @"\s*<br>\s*", RegexOptions.IgnorePatternWhitespace)
                .Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();
            var lesson = new Lesson();
            lesson.Subject = content[0];

            var mNhom = Regex.Match(content[1], @"Nhóm\s+:\s+(\d+)");
            lesson.Group = Convert.ToInt32(mNhom.Groups[1].Value);

            var mPhong = Regex.Match(content[3], @"Phòng\s+(.+)\s*$");
            lesson.Room = mPhong.Groups[1].Value.Trim();


            var mTiet = Regex.Match(content[2], @"Tiết\s+(\d+)\s*-\s*(\d+)");
            lesson.Start = Convert.ToInt32(mTiet.Groups[1].Value);
            lesson.End = Convert.ToInt32(mTiet.Groups[2].Value);

            return lesson;
        }
    }
}