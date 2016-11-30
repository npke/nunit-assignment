using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TamGiac
{
    class TamGiac
    {
        private Diem _a;

        public Diem A
        {
            get { return _a; }
            set { _a = value; }
        }
        private Diem _b;

        public Diem B
        {
            get { return _b; }
            set { _b = value; }
        }
        private Diem _c;

        public Diem C
        {
            get { return _c; }
            set { _c = value; }
        }

        /*
         * Ham khoi tao khong tham so
         * Dinh A,B,C deu co toa do 0,0
         */
        public TamGiac()
        {
            _a = new Diem(0, 0);
            _b = new Diem(0, 0);
            _c = new Diem(0, 0);
        }

        /*
         * Ham khoi tao 3 tham so Diem
         * Dinh A,B,C bang 3 tham so
         */
        public TamGiac(Diem a, Diem b, Diem c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        /*
         * Ham tinh chu vi
         * Ham tra ve chu vi cua tam giac
         */
        public double ChuVi()
        {
            double AB = _a.KhoangCach(_b);
            double AC = _a.KhoangCach(_c);
            double BC = _b.KhoangCach(_a);
            return AB + AC + BC;
        }

        /*
         * Ham xac dinh loai tam gia
         * Ham tra ve
         * -1: khong la tam gia
         * 0: tam giac thuong
         * 1: tam giac can
         * 2: tam giac deu
         */
        public int LoaiTamGiac()
        {
            double AB = _a.KhoangCach(_b);
            double AC = _a.KhoangCach(_c);
            double BC = _b.KhoangCach(_c);
            if ((AB + AC == BC) || (AB + BC == AC) || (AC + BC == AB)) return -1;
            if (AB==AC && AB==BC) return 1;
            if (AB == AC || AB == BC) return 2;

            return 0;
        }
    }
}
