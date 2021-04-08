using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_DEMO_2020_12
{
    class TAM_GIAC
    {
        public DIEM A;
        public DIEM B;
        public DIEM C;

        public void NhapTamGiac(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            this.A = new DIEM();
            this.B = new DIEM();
            this.C = new DIEM();
            this.A.NhapDiem("Nhap dinh A");
            this.B.NhapDiem("Nhap dinh B");
            this.C.NhapDiem("Nhap dinh C");
        }

        public double TinhChuVi()
        {
            double a, b, c;
            a = this.A.TinhKhoangCach(this.B);
            b = this.B.TinhKhoangCach(this.C);
            c = this.C.TinhKhoangCach(this.A);
            return a + b + c;
        }
    }
}
