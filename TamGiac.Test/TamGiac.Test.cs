using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamGiac;
using NUnit.Framework;

namespace TamGiac.Test
{
    [TestFixture]
    class TamGiacTest
    {
        [Test]
        public void TestHamDungMacDinh()
        {
            TamGiac tg = new TamGiac();
            Assert.AreEqual(0, tg.A.X, "Sai toa do X cua diem thu nhat");
            Assert.AreEqual(0, tg.A.Y, "Sai toa do Y cua diem thu nhat");

            Assert.AreEqual(0, tg.B.X, "Sai toa do X cua diem thu hai");
            Assert.AreEqual(0, tg.B.Y, "Sai toa do Y cua diem thu hai");

            Assert.AreEqual(0, tg.C.X, "Sai toa do X cua diem thu ba");
            Assert.AreEqual(0, tg.C.Y, "Sai toa do Y cua diem thu ba");
        }

        [Test]
        public void TestHamDung3ThamSo()
        {
            Diem a = new Diem(1, 2);
            Diem b = new Diem(3, 7);
            Diem c = new Diem(5, 5);

            TamGiac tg = new TamGiac(a, b, c);

            Assert.IsTrue(LaHaiDiemGiongNhau(tg.A, a), "Sai diem thu nhat");
            Assert.IsTrue(LaHaiDiemGiongNhau(tg.B, b), "Sai diem thu hai");
            Assert.IsTrue(LaHaiDiemGiongNhau(tg.C, c), "Sai diem thu ba");
        }

        public bool LaHaiDiemGiongNhau(Diem d1, Diem d2)
        {
            return d1.X == d2.X && d1.Y == d2.Y;
        }

        [Test]
        public void TestTinhChuVi()
        {
            TamGiac tg = new TamGiac(new Diem(0, 0), new Diem(0, 8), new Diem(6, 0));
            double cv = tg.ChuVi();
            double expected = 20.0;

            Assert.AreEqual(cv, expected, "Tinh sai chu vi");
        }

        [Test]
        public void TestXacDinhCoPhaiLaTamGiacHayKhong()
        {
            // Cac test case cho truong hop khong phai la tam giac
            // 3 diem trung nhau
            TamGiac ktg1 = new TamGiac(new Diem(0, 0), new Diem(0, 0), new Diem(0, 0));
            Assert.AreEqual(-1, ktg1.LoaiTamGiac(), "Xac dinh sai co phai la tam giac hay khong");

            // 2 diem trung nhau
            TamGiac ktg2 = new TamGiac(new Diem(1, 2), new Diem(1, 2), new Diem(2, 4));
            Assert.AreEqual(-1, ktg2.LoaiTamGiac(), "Xac dinh sai co phai la tam giac hay khong");

            TamGiac ktg3 = new TamGiac(new Diem(2, 4), new Diem(1, 2), new Diem(1, 2));
            Assert.AreEqual(-1, ktg3.LoaiTamGiac(), "Xac dinh sai co phai la tam giac hay khong");

            TamGiac ktg4 = new TamGiac(new Diem(1, 2), new Diem(2, 4), new Diem(1, 2));
            Assert.AreEqual(-1, ktg4.LoaiTamGiac(), "Xac dinh sai co phai la tam giac hay khong");

            // 3 diem nam tren 1 duong thang
            TamGiac ktg5 = new TamGiac(new Diem(0, 0), new Diem(0, 1), new Diem(0, 2));
            Assert.AreEqual(-1, ktg5.LoaiTamGiac(), "Xac dinh sai co phai la tam giac hay khong");
        }

        [Test]
        public void TestXacDinhTamGiacThuong()
        {
            // Test case xac dinh tam giac thuong
            TamGiac tgt = new TamGiac(new Diem(0, 0), new Diem(2, 5), new Diem(10, 4));
            Assert.AreEqual(0, tgt.LoaiTamGiac(), "Xac dinh sai tam giac thuong");
        }

        [Test]
        public void TestXacDinhTamGiacCan()
        {
            // Test case xac dinh tam giac can
            TamGiac tgc1 = new TamGiac(new Diem(0, 0), new Diem(0, 4), new Diem(4, 0));
            Assert.AreEqual(1, tgc1.LoaiTamGiac(), "Xac dinh sai tam giac can");

            TamGiac tgc2 = new TamGiac(new Diem(0, 4), new Diem(0, 0), new Diem(4, 0));
            Assert.AreEqual(1, tgc2.LoaiTamGiac(), "Xac dinh sai tam giac can");

            TamGiac tgc3 = new TamGiac(new Diem(0, 4), new Diem(0, 4), new Diem(0, 0));
            Assert.AreEqual(1, tgc3.LoaiTamGiac(), "Xac dinh sai tam giac can");
        }

        [Test]
        public void TestXacDinhTamGiacDeu()
        {
            // Test case xac dinh tam giac deu
            TamGiac tgd = new TamGiac(new Diem(0, 0), new Diem(2, 0), new Diem(1, Math.Sqrt(3)));
            Assert.AreEqual(2, tgd.LoaiTamGiac(), "Xac dinh sai tam giac deu");
        }
    }
}
