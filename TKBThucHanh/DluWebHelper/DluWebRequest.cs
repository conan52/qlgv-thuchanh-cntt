using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace DluWebHelper
{
    class DluWebRequest
    {
        public TimeTableWebResult GetCurentTimeTable()
        {
            var result = new TimeTableWebResult();
            var wc = new WebClient { Encoding = Encoding.UTF8 };
            var s = wc.DownloadString("http://203.113.164.162/timetable.aspx");
            var doc = new HtmlDocument();
            doc.LoadHtml(s);

            var weeks = doc.DocumentNode.SelectNodes("//select[@name='cboWeek']/option");
            if (weeks != null)
                result.Weeks.AddRange(weeks.Where(n => !string.IsNullOrWhiteSpace(n.Attributes["value"].Value)).Select(n => Convert.ToInt32(n.Attributes["value"].Value)));

            var clas = doc.DocumentNode.SelectNodes("//select[@name='cboCourse']/option");
            if (clas != null)
                result.Class.AddRange(clas.Where(n => !string.IsNullOrWhiteSpace(n.Attributes["value"].Value)).Select(n => n.Attributes["value"].Value));

            var teacherCode = doc.DocumentNode.SelectNodes("//select[@name='cboTeacher']/option");
            if (teacherCode != null)
                result.TeacherCodes.AddRange(teacherCode.Where(n => !string.IsNullOrWhiteSpace(n.Attributes["value"].Value)).Select(n => n.Attributes["value"].Value));

            Match m = Regex.Match(s, @"từ ngày (\d{1,2}/\d{1,2}/\d{4})\s*đến\sngày\s*(\d{1,2}/\d{1,2}/\d{4})");
            result.StartDate = DateTime.ParseExact(m.Groups[1].Value, "d/M/yyyy", null);
            result.EndDate = DateTime.ParseExact(m.Groups[2].Value, "d/M/yyyy", null);

            return result;
        }



        List<Lesson> getLessons(string content)
        {
            List<Lesson>  result = new List<Lesson>();
            return result;
        } 
    }
}
