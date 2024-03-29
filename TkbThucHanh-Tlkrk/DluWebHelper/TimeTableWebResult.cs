﻿using System;
using System.Collections.Generic;

namespace DluWebHelper
{
    public class TimeTableWebResult
    {
        public TimeTableWebResult()
        {
            Weeks = new List<int>();
            Class = new List<string>();
            TeacherCodes = new List<string>();
        }

        public List<int> Weeks { get; set; }
        public List<string> Class { get; set; }
        public List<string> TeacherCodes { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int CurrentWeek { get; set; }
    }
}