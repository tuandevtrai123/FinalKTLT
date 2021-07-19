using System;
namespace CAU2
{
    public class TaiKhoan
    {
        private string soTK;
        private string tenTK;
        private double? soDu;
        private static double laiSuat;



        public TaiKhoan()
        {
            soTK = "";
            tenTK = "";
            soDu = 0;
        }
        public TaiKhoan(string tentk, string sotk, double? sodu)
        {
            soTK = sotk;
            tenTK = tentk;
            soDu = sodu;
        }
        public string SoTK { get; set; }
        public string TenTK { get; set; }
        public double? SoDu { get; set; }

        public static double LaiSuat
        {
            get
            {
                return laiSuat;
            }
            set
            {
                while(value<0 || value >(double)20/100)
                {
                    Console.WriteLine("Nhap lai gia tri lai suat >0 va < hon 20: ");
                    value = double.Parse(Console.ReadLine());
                }
                laiSuat = value;
            }
        }

        // Method
        public void NapTien(double soTien)
        {
            if(soTien <=0)
            {
                Console.WriteLine("So tien chua dung: ");
                return;
            }
            this.soDu += soTien;
        }
        public void RutTien(double soTien)
        {
            if(soTien> this.soDu)
            {
                Console.WriteLine("So tien muon rut lon hon so du tai khoan: ");
                return;
            }
            this.soDu -= soTien;
        }
        public string ThongTinTK ()
        {
            string thongtinTK = "Ten TK: " + this.tenTK + " So TK: " + this.soTK + " So du: " + this.soDu;
            return thongtinTK;
        }

        public void TinhLai()
        {
            double tienLai = (double)soDu * laiSuat;
            this.soDu += tienLai;
        }
    }
}
