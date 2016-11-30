using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TamGiac
{
    class Diem
    {
        private double _x;

        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        private double _y;

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /*
         * Ham dung khong tham so
         * Toa do _x=0, _y=0
         */
        public Diem()
        {
            _x = 0;
            _y = 0;
        }

        /*
         * Ham dung 2 tham so nguyen x,y 
         * Tham so _x=x va _y=y
         */
        public Diem(double x, double y)
        {
            _x = x;
            _y = y;
        }

        /*
         * Ham dung 1 tham so la chuoi dang "x,y"
         * Tham so _x=x va _y=y
         */
        public Diem(string chuoi)
        {
            string[] mang = chuoi.Split(',');
            _x = double.Parse(mang[0]);
            _y = double.Parse(mang[0]);
        }

        /*
         * Ham tinh khoang cach den 1 diem khac
         * Ham tra ve gia tri khoang cach
         */
        public double KhoangCach(Diem d)
        {
            double kc = Math.Sqrt((this._x - d._x) * (this._x - d._x) + (this._y - d._y) * (this._y - d._y));
            return kc;
        }

        /*
         * Ham biet diem thanh chuoi
         * Ham tra ve chuoi co dang "x,y"
         */
        public override string ToString()
        {
            return _x.ToString()+","+_y.ToString();
        } 
    }
}
