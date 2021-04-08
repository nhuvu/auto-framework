using System;
namespace OOP_DEMO_INHERITANCE
{
    public class CONG_TY
    {
        private string tenCty;
        private NHAN_VIEN_VP[] dsNVVP;
        private NHAN_VIEN_SX[] dsNVSX;

        public void NhapCty(string ghiChu)
        {
            Console.WriteLine("Nhap ten cong ty: ");
            this.tenCty = Console.ReadLine();

            Console.WriteLine("Nhap so luong nhan vien san xuat: ");
            int N = int.Parse(Console.ReadLine());
            this.dsNVSX = new NHAN_VIEN_SX[N];
            for (int i = 0; i < this.dsNVSX.Length; i++)
            {
                this.dsNVSX[i] = new NHAN_VIEN_SX();
                this.dsNVSX[i].NhapNV($"Nhap nhan vien san xuat thu {i + 1}");
            }

            Console.WriteLine("Nhap so luong nhan vien van : ");
            int M = int.Parse(Console.ReadLine());
            this.dsNVVP = new NHAN_VIEN_VP[M];
            for (int i = 0; i < this.dsNVVP.Length; i++)
            {
                this.dsNVVP[i] = new NHAN_VIEN_VP();
                this.dsNVVP[i].NhapNV($"Nhap nhan vien van phong thu {i + 1}");
            }
        }

        public double TinhTongLuong()
        {
            double S = 0;
            for (int i = 0; i < dsNVSX.Length; i++)
            {
                S = S + dsNVSX[i].tinhLuong();
            }

            for (int j = 0; j < dsNVVP.Length; j++)
            {
                S = S + dsNVSX[j].tinhLuong();
            }
            return S;
        }
    }
}
