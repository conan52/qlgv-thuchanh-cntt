namespace DluWebHelper
{
    public class TeacherTimeTable : ListLessonResult
    {
        public string TeacherCode { get; set; }

        public TeacherTimeTable(ListLessonResult r, string code)
        {
            TeacherCode = code;
            EndDate = r.EndDate;
            Lessons = r.Lessons;
            StartDate = r.StartDate;
        }
    }
}