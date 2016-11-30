using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TamGiac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonChuVi_Click(object sender, EventArgs e)
        {
            TamGiac tg = new TamGiac();
            tg.A.X = int.Parse(textBoxAx.Text);
            tg.A.Y = int.Parse(textBoxAy.Text);
            tg.B.X = int.Parse(textBoxBx.Text);
            tg.B.Y = int.Parse(textBoxBy.Text);
            tg.C.X = int.Parse(textBoxCx.Text);
            tg.C.Y = int.Parse(textBoxCy.Text);
            double cv = tg.ChuVi();
            textBoxChuVi.Text = cv.ToString();
        }

        private void buttonLoaiTamGiac_Click(object sender, EventArgs e)
        {
            TamGiac tg = new TamGiac();
            tg.A.X = int.Parse(textBoxAx.Text);
            tg.A.Y = int.Parse(textBoxAy.Text);
            tg.B.X = int.Parse(textBoxBx.Text);
            tg.B.Y = int.Parse(textBoxBy.Text);
            tg.C.X = int.Parse(textBoxCx.Text);
            tg.C.Y = int.Parse(textBoxCy.Text);
            switch (tg.LoaiTamGiac())
            {
                case -1: 
                    textBoxLoaiTamGiac.Text = "Khong la tam giac";
                    break;
                case 0: 
                    textBoxLoaiTamGiac.Text = "Tam giac thuong";
                    break;
                case 1: 
                    textBoxLoaiTamGiac.Text = "Tam giac can";
                    break;
                case 2: 
                    textBoxLoaiTamGiac.Text = "Tam giac deu";
                    break;
            }
        }
    }
}
