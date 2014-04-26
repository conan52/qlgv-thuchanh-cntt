namespace TkbThucHanhCNTT.Models.Viewer
{
    public class TietHoc
    {
        public TietHoc()
        {
            TietBatDau = 1;
            TietKetThuc = 4;
        }

        public int TietBatDau { get; set; }
        public int TietKetThuc { get; set; }

        public override string ToString()
        {
            return string.Format("{0}-{1}", TietBatDau, TietKetThuc);
        }
    }
}