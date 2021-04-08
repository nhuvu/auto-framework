using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_DEMO_2020_12
{   
    public struct PHANSO
    {
        public int TuSo;
        public int MauSo;
    }
    class XL_PHANSO
    {
        //Thanh phan xu ly - có thể để public
        public static PHANSO NhapPhanSo(String ghiChu)
        {
            PHANSO kq;
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap tu so: ");
            kq.TuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so: ");
            kq.MauSo = int.Parse(Console.ReadLine());
            return kq;
        }

        public static PHANSO CongPS(PHANSO a, PHANSO b)
        {
            PHANSO kq;
            kq.TuSo = a.TuSo * b.MauSo + a.MauSo * b.TuSo;
            kq.MauSo = a.MauSo * b.MauSo;
            return kq;
        }

        public static string XuatPS(PHANSO kq) {
            return string.Format("{0}/{1}", kq.TuSo, kq.MauSo);
        }

    }
}
