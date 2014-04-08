using System;
using System.Collections.Generic;

namespace DluWebHelper
{
    public class ListLessonResult
    {
        public ListLessonResult()
        {
            Lessons = new List<Lesson>();
        }

        public List<Lesson> Lessons { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public void AddLesson(Lesson l)
        {
            Lessons.Add(l);
        }
    }
}