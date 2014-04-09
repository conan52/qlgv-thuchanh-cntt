using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace DluWebHelper
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TimeTableManager tm = new TimeTableManager();
            tm.GetTimeFullTable(
                new List<string>() { "CT46", "CT02", "CT13", "CT28", "CT65", "TN15" },
                new List<string>() { "CTK34A", "CTK34B", "CTK35", "CTK36", "CTK37", },
                new List<int>(){34,35,36,37}
                );
        }
    }
}