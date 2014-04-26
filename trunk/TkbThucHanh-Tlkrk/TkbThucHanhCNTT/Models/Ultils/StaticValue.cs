namespace TkbThucHanhCNTT.Models.Ultils
{
    public class StaticValue
    {
        private static int _pageNumber;

        public static int PageNumber
        {
            get
            {
                if (_pageNumber == 0)
                    return 10;
                return _pageNumber;
            }
            set { _pageNumber = value; }
        }

        public static string MaGv { get; set; }
    }
}