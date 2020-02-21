using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kunin_Prakt_6
{
    public class Person
    {
        public int openkey_e;
        public int openkey_d;
        public int symbol;
    }
    public partial class Form1 : Form
    {
        public int Coprime_i = 0;
        public int D_i = 0;

        public int _E = 0;
        public int _D = 0;

        public int _q = 0;
        public int _p = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void FindKeys_Click(object sender, EventArgs e)
        {
            int Q = Convert.ToInt32(Box_For_q.Text);
            int P = Convert.ToInt32(Box_For_p.Text);

            method_start(Q,P);
        }

        public void method_start(int q, int p)
        {
            _q = q;
            _p = p;
            int[] simple_numbers = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31,
                                               37, 41, 43, 47, 53, 59, 61, 67, 71, 73,
                                               79, 83, 89, 97, 101, 103, 107, 109, 113};

            
            int n = p * q;

            int exp = 0;
            int Eller_Func = (p - 1) * (q - 1);
            for (; Coprime_i < simple_numbers.Length; Coprime_i++)
            {
                int e = simple_numbers[Coprime_i];
                if (e < Eller_Func)
                {
                    if (IsCoprime(e, Eller_Func))
                    {
                        exp = e;
                        _E = e;
                        break;

                    }
                }
            }

            OpenKey.Text = "(" + exp + "; " + n + ")";
            MessageBox.Show("Пара ключей e,n : (" + exp + ";" + n + ")");

            int d = 0;
            for (; D_i < 10000; D_i++)
            {
                if((D_i * exp)% Eller_Func  == 1)
                {
                    d = D_i;
                    _D = d;
                    break;
                }
            }
            ClosedKey.Text = "(" + d + "; " + n + ")";
            MessageBox.Show("Пара ключей d,n : (" + d + ";" + n + ")");

        }
        private bool IsCoprime(int a, int b)
        {
            return a == b
                   ? a == 1
                   : a > b
                        ? IsCoprime(a - b, b)
                        : IsCoprime(b - a, a);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            method_start(_q, _p);
            Coprime_i ++;
            D_i ++;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
           Person1_E.Text = "" + _E;
           Person1_D.Text = "" + _D;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Person2_E.Text = "" + _E;
            Person2_D.Text = "" + _D;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Person3_E.Text = "" + _E;
            Person3_D.Text = "" + _D;
        }

        private void StartAlghorytm_Click(object sender, EventArgs e)
        {

        }
    }
}
