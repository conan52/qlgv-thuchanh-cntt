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
