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
    public class DiemTest
    {
        [Test]
        public void TestHamDungMacDinh()
        {
            Diem d = new Diem();
            Assert.AreEqual(0, d.X, "Loi hoanh do X");
            Assert.AreEqual(0, d.Y, "Loi hoanh do Y");
        }

        [Test]
        public void TestHamDungHaiThamSo()
        {
            Diem d = new Diem(5, 9);
            Assert.AreEqual(5, d.X, "Loi hoanh do X");
            Assert.AreEqual(9, d.Y, "Loi hoanh do Y");
        }

        [Test]
        public void TestHamDungTuChuoi()
        {
            Diem d = new Diem("6,9");
            Assert.AreEqual(6, d.X, "Loi hoanh do X");
            Assert.AreEqual(9, d.Y, "Loi hoanh do Y");
        }

        [Test]
        public void TestTinhKhoangCach()
        {
            Diem d1 = new Diem(0, 0);
            Diem d2 = new Diem(0, 5);

            double kc = d1.KhoangCach(d2);
            Assert.AreEqual(kc, 5.0, "Sai khoang cach");
        }

        [Test]
        public void TestToString()
        {
            Diem d = new Diem(5, 8);
            String strDiem = d.ToString();

            Assert.AreEqual("5,8", strDiem, "Chuyen ve chuoi sai");
        }
    }
}

