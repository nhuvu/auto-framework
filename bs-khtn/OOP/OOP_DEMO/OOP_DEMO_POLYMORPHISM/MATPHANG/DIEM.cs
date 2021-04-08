using System;
namespace OOP_DEMO_INHERITANCE.MATPHANG
{
    public class DIEM
    {
        private int X;
        private int Y;
     
        //public DIEM()
        //{
        //    this.X = 0;
        //    this.Y = 0;
        //}
        //public DIEM(int hoanhDo, int tungDo)
        //{
        //    this.X = hoanhDo;
        //    this.Y = tungDo;
        //}
        public void NhapDiem(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap hoanh do: ");
            this.X = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap tung do: ");
            this.Y = int.Parse(Console.ReadLine());
        }

        public double TinhKhoangCach(DIEM b)
        {
            double kc;
            kc = Math.Sqrt((this.X - b.X) * (this.X - b.X) + (this.Y - b.Y) * (this.Y - b.Y));
            return kc;
        }

        
    }
}
