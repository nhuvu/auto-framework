using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_DEMO_2020_12
{
      class DIEM
    {
      private int x;
      private int y;

        public DIEM()
        {
            this.x = 0;
            this.y = 0;
        }
        public DIEM(int hoanhDo, int tungDo)
        {
            this.x = hoanhDo;
            this.y = tungDo;
        }
        public void NhapDiem(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap hoanh do: ");
            this.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap tung do: ");
            this.y = int.Parse(Console.ReadLine());
        }

        public double TinhKhoangCach(DIEM b)
        {
            double kc;
            kc = Math.Sqrt((this.x - b.x) * (this.x - b.x) + (this.y - b.y) * (this.y - b.y));
            return kc;
        }  
        
        public int DIEM_X
        {
            get
            {
                return this.x; 
            }
            set
            {
                this.x = value;
            }
        }

        public int DIEM_Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

    }
}
