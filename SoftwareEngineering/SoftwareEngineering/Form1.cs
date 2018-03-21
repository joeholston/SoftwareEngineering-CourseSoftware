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

            mwfAll(false);
            trAll(false);
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

        private void tr(int time, bool show)
        {
            RichTextBox t;
            RichTextBox r;

            switch (time)
            {
                case 8:
                    t = t8;
                    r = r8;
                    break;
                case 10:
                    t = t10;
                    r = r10;
                    break;
                case 1130:
                    t = t1130;
                    r = r1130;
                    break;
                case 1:
                    t = t1;
                    r = r1;
                    break;
                case 230:
                    t = t230;
                    r = r230;
                    break;

                default:
                    t = t8;
                    r = r8;
                    break;
            }

            if (show)
            {
                t.Show();
                r.Show();
            }
            else
            {
                t.Hide();
                r.Hide();
            }
        }

        private void mwfAll(bool show)
        {
            if (show)
            {
                mwf(8, true);
                mwf(9, true);
                mwf(10, true);
                mwf(11, true);
                mwf(12, true);
                mwf(1, true);
                mwf(2, true);
                mwf(3, true);
            }
            else
            {
                mwf(8, false);
                mwf(9, false);
                mwf(10, false);
                mwf(11, false);
                mwf(12, false);
                mwf(1, false);
                mwf(2, false);
                mwf(3, false);
            }
        }

        private void trAll(bool show)
        {
            if (show)
            {
                tr(8, true);
                tr(10, true);
                tr(1130, true);
                tr(1, true);
                tr(215, true);
            }
            else
            {
                tr(8, false);
                tr(10, false);
                tr(1130, false);
                tr(1, false);
                tr(215, false);
            }
        }
    }
}
