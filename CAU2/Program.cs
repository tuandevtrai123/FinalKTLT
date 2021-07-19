using System;

namespace CAU2
{
    class Program
    {
        static void Main(string[] args)
        {
            var tk = new TaiKhoan("Nguyen Gia Tuan", "0123456789",0);
            tk.NapTien(5000000);
            tk.RutTien(3000000);
            TaiKhoan.LaiSuat = (double)5 / 100;
            tk.TinhLai();
            Console.WriteLine(tk.ThongTinTK());
        }
    }
}
