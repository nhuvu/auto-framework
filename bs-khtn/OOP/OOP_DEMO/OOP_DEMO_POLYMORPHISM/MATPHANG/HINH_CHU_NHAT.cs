using System;
namespace OOP_DEMO_INHERITANCE.MATPHANG
{
    public class HINH_CHU_NHAT : HINH
    {
        private DIEM dinhA;
        private int chieuDai;
        private int chieuRong;

        public new void NhapHinh(string ghiChu)
        {
            base.NhapHinh(ghiChu);           
            this.dinhA.NhapDiem("Nhap dinh A: ");
            Console.WriteLine("Nhap chieu dai: ");
            this.chieuDai = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            this.chieuRong = int.Parse(Console.ReadLine());
        }

        public double TinhChuVi()
        {
            return (this.chieuDai + this.chieuRong) * 2; 
        }
    }
}
