using System;
namespace OOP_DEMO_INHERITANCE
{
    public class NHAN_VIEN_VP : NHAN_VIEN
    {
        private double heso;
        private double phucap;

        //co tu khoa 'new' thi cho base.NhapNV se goi ham NhapNV lop co so
        public new void NhapNV(string ghiChu)
        {
            //Từ khoá base: dai dien cho doi tuong lop co so
            base.NhapNV(ghiChu);
            Console.WriteLine("Nhap he so nhan vien: ");
            this.heso = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap phu cap nhan vien: ");
            this.phucap = double.Parse(Console.ReadLine());
        }

        public double tinhLuong()
        {
            return this.heso * 10 + this.phucap;
        }
    }
}
