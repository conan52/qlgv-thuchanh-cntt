using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DluWebHelper
{
    class ListLessonResult
    {
        public List<Lesson> Lessons { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
