namespace DluWebHelper
{
    public class TimeTableProcessStatus
    {
        public TimeTableProcessStatus()
        {
            Done = Total = 0;
            CurrentWork = "Init...";
            AllDone = false;
        }

        public string CurrentWork { get; set; }
        public int Done { get; set; }
        public int Total { get; set; }
        public bool AllDone { get; set; }


        public TimeTableProcessStatus Clone()
        {
            return new TimeTableProcessStatus {Total = Total, CurrentWork = CurrentWork, Done = Done};
        }
    }
}