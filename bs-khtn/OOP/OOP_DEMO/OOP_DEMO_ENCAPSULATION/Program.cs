using System;

namespace OOP_DEMO_2020_12
{
    class Program
    {
        static void Main(string[] args)
        {

            PHANSO a, b;
            a = XL_PHANSO.NhapPhanSo("Nhap phan so a");
            b = XL_PHANSO.NhapPhanSo("Nhap phan so b");

            PHANSO tongPS;
            tongPS = XL_PHANSO.CongPS(a, b);

            string Chuoi = "Ket qua la: " + XL_PHANSO.XuatPS(tongPS);
            Console.WriteLine(Chuoi);


            /* OOP */
            //1. Khai bao phan so va tinh tong
            //PHAN_SO a, b;
            //Khai bao doi tuong - ham new()
            //a = new PHAN_SO();
            //b = new PHAN_SO();
            ////Yeu cau doi tuong a thuc hien hanh dong nhap
            //a.NhapPhanSo("Nhap Phan So a: ");
            ////Yeu cau doi tuong b thuc hien hanh dong nhap
            //b.NhapPhanSo("Nhap Phan So b: ");

            //Yeu cau doi tuong a thuc hien hanh dong congPS voi b
            //PHAN_SO kq;
            //kq = a.CongPS(b);

            //string Chuoi = "Ket qua la: " + kq.XuatPS();
            //Console.WriteLine(Chuoi);

            //2. Nhap 2 diem va tinh khoang cach
            DIEM i, j;
            i = new DIEM();
            j = new DIEM();
            i.NhapDiem("Nhap diem i: ");
            j.NhapDiem("Nhap diem j: ");

            double kc;
            kc = i.TinhKhoangCach(j);

            Console.WriteLine("Khoang cach giua 2 diem la: " + kc);

            //3. Nhap tam giac & tinh chu vi
            TAM_GIAC abc;
            abc = new TAM_GIAC();
            abc.NhapTamGiac("Nhap tam giac ABC: ");

            double chuVi;
            chuVi = abc.TinhChuVi();
            Console.WriteLine("Chu vi tam giac la: " + chuVi);

            //4. Nhap da giac & tinh chu vi
            DA_GIAC dg;
            dg = new DA_GIAC();
            dg.NhapDaGiac("Nhap da giac: ");

            double chuViDaGiac;
            chuViDaGiac = dg.TinhChuVi();
            Console.WriteLine("Chu vi da giac la: " + chuViDaGiac);



        }

    }
}
