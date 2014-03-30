using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DluWebHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            var webRequest  =new DluWebRequest();
            //webRequest.GetCurentTimeTable();
            webRequest.GetClassTimeTable("CTK34b", 36);

        }
    }
}
