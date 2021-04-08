using System;
namespace OOP_DEMO_INHERITANCE.MATPHANG
{
    public class HINH_TRON : HINH
    {
        private const string GhiChu = "Nhap tam I: ";
        private DIEM tamI;
        private int banKinh;

        public new void NhapHinh(string note)
        {
            base.NhapHinh(note);
            tamI.NhapDiem("Nhap tam I: ");
            Console.WriteLine("Nhap ban kinh: ");
            this.banKinh = int.Parse(Console.ReadLine());
        }

       public double TinhChuVi()
        {
            return this.banKinh * 2 * Math.PI;
        }
    }
}
