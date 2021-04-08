using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_DEMO_2020_12
{
    class DA_GIAC
    {
        public List<DIEM> dsDinh;

        public void NhapDaGiac(string ghiChu)
        {
            Console.WriteLine("Nhap da giac: ");
            Console.WriteLine("Nhap so dinh: ");
            int N = int.Parse(Console.ReadLine());
            this.dsDinh = new List<DIEM>();
            for (int i = 0; i < N; i++)
            {
                DIEM a = new DIEM();
                a.NhapDiem($"Nhap dinh A[{i}]");
                dsDinh.Add(a);
            }

        }

        public double TinhChuVi()
        {
            double chuVi = 0;
            for(int i = 0; i<this.dsDinh.Count - 1; i++)
            {
                chuVi = chuVi + this.dsDinh[i].TinhKhoangCach(this.dsDinh[i + 1]);
            }
            chuVi = chuVi + this.dsDinh[0].TinhKhoangCach(this.dsDinh[this.dsDinh.Count - 1]);
            return chuVi;
        }

    }
}
