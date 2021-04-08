using System;
namespace OOP_DEMO_INHERITANCE
{
    public class NHAN_VIEN
    {
        private int maNV;
        private string tenNV;
        private string diachi;

        public void NhapNV(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap ma nhan vien: ");
            this.maNV = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten nhan vien: ");
            this.tenNV = (Console.ReadLine());
            Console.WriteLine("Nhap dia chi nhan vien: ");
            this.tenNV = (Console.ReadLine());
        }
    }
}
