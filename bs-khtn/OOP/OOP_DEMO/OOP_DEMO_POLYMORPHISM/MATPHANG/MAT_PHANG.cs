using System;
namespace OOP_DEMO_INHERITANCE.MATPHANG
{
   
    public class MAT_PHANG
    {
        private HINH_TRON[] dsHinhTron;
        private HINH_CHU_NHAT[] dsHinhChuNhat;

        public void NhapMatPhang(string ghiChu)
        {
           
            Console.WriteLine("Nhap so luong hinh tron: ");
            int N = int.Parse(Console.ReadLine());
            this.dsHinhTron = new HINH_TRON[N];
            for (int i = 0; i < this.dsHinhTron.Length; i++)
            {
                this.dsHinhTron[i] = new HINH_TRON();
                this.dsHinhTron[i].NhapHinh($"Nhap hinh tron thu {i + 1}");
            }

            Console.WriteLine("Nhap so luong hinh chu nhat : ");
            int M = int.Parse(Console.ReadLine());
            this.dsHinhChuNhat = new HINH_CHU_NHAT[M];
            for (int i = 0; i < this.dsHinhChuNhat.Length; i++)
            {
                this.dsHinhChuNhat[i] = new HINH_CHU_NHAT();
                this.dsHinhChuNhat[i].NhapHinh($"Nhap hinh chu nhat thu {i + 1}");
            }
        }

        public double TinhTongChuVi()
        {
            double P = 0;
            for (int i = 0; i < dsHinhTron.Length; i++)
            {
                P = P + dsHinhTron[i].TinhChuVi();
            }

            for (int j = 0; j < dsHinhChuNhat.Length; j++)
            {
                P = P + dsHinhChuNhat[j].TinhChuVi();
            }
            return P;
        }
    }
        

}
