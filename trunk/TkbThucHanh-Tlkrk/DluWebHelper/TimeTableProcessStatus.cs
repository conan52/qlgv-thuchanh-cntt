using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DluWebHelper
{
    public class TimeTableProcessStatus
    {
        public string CurrentWork { get; set; }
        public int Done { get; set; }
        public int Total { get; set; }
        public bool AllDone { get; set; }


        public TimeTableProcessStatus()
        {
            Done = Total = 0;
            CurrentWork = "Init...";
            AllDone = false;
        }

        public TimeTableProcessStatus Clone()
        {
            return new TimeTableProcessStatus {Total = Total, CurrentWork = CurrentWork, Done = Done};
        }
    }
}
