using System;
namespace OOP_DEMO_INHERITANCE.MATPHANG
{
    public class HINH
    {
        private string tenHinh;
        private string mauSac;

        public void NhapHinh(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap ten hinh: ");
            this.tenHinh = Console.ReadLine();
            Console.WriteLine("Nhap mau sac: ");
            this.mauSac = Console.ReadLine();
        }
    }
}
