namespace DluWebHelper
{
    public class Lesson
    {
        public int Group { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
        public string Subject { get; set; }
        public string Room { get; set; }
        public int DayOfWeek { get; set; }


        public override string ToString()
        {
            return string.Format("{0} - {1} | {2} | {3}", Start, End, Room, Subject);
        }
    }
}
