namespace DluWebHelper
{
    public class StudentTimeTable : ListLessonResult
    {
        public string ClassCode { get; set; }

        public StudentTimeTable(ListLessonResult r, string code)
        {
            ClassCode = code;
            EndDate = r.EndDate;
            Lessons = r.Lessons;
            StartDate = r.StartDate;
        }
    }
}