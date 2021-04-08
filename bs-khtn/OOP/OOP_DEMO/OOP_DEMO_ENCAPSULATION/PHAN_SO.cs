using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_DEMO_2020_12
{
    class PHAN_SO
    {
        //Thanh phan du lieu - để private (khong can khai bao TuSo nua khi da co get,set ben duoi)
        //private int TuSo;
        private int MauSo;

        //Construtor:
        //- Tên hàm trùng với tên Class
        //- Tự động dc gọi khi khởi tạo đối tượng với new
        //- Dùng để khởi tạo giá trị ban đầu cho đối tượng
        //- Không có giá trị trả về
        public PHAN_SO()
        {
            this.TuSo = 0;
            this.MauSo = 1; //Mau phai khac 0
        }
        public PHAN_SO(int tuSo, int mauSo)
        {
            this.TuSo = tuSo;
            if (mauSo != 0)
                this.MauSo = mauSo;
            else
                this.MauSo = 1;
        }

        //getter, setter
        public int TuSo
        {
            get; set;
        }

        public int MAU_SO
        {
            get
            {
                return this.MauSo;
            }
            set
            {
                if (value != 0) //Kiem tra hop le
                    this.MauSo = value;
            }
        }
        }
    }
