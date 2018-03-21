using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            mwf(8, true);
        }

        private void mwf(int time, bool show)
        {
            RichTextBox m;
            RichTextBox w;
            RichTextBox f;

            switch (time)
            {
                case 8:
                    m = m8;
                    w = w8;
                    f = f8;
                    break;
                case 9:
                    m = m9;
                    w = w9;
                    f = f9;
                    break;
                case 10:
                    m = m10;
                    w = w10;
                    f = f10;
                    break;
                case 11:
                    m = m11;
                    w = w11;
                    f = f11;
                    break;
                case 12:
                    m = m12;
                    w = w12;
                    f = f12;
                    break;
                case 1:
                    m = m1;
                    w = w1;
                    f = f1;
                    break;
                case 2:
                    m = m2;
                    w = w2;
                    f = f2;
                    break;
                case 3:
                    m = m3;
                    w = w3;
                    f = f3;
                    break;
                default:
                    m = m8;
                    w = w8;
                    f = f8;
                    break;
            }

            if (show)
            {
                m.Show();
                w.Show();
                f.Show();
            }
            else
            {
                m.Hide();
                w.Hide();
                f.Hide();
            }
        }
    }
}
