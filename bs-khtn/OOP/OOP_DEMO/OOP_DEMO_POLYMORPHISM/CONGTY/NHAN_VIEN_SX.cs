using System;
namespace OOP_DEMO_INHERITANCE
{
    public class NHAN_VIEN_SX : NHAN_VIEN
    {
        private int soSanPham;

        public new void NhapNV(string ghiChu)
        {
            base.NhapNV(ghiChu);
            Console.WriteLine("Nhap so san pham: ");
            this.soSanPham = int.Parse(Console.ReadLine());

        }

        public double tinhLuong()
        {
            return this.soSanPham * 100;
        }
    }
}
