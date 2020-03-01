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

    public partial class Form1 : Form
    {
        const string alphabet = "АБВГДЕЁЖЗИКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ" ;
        int n = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public class Person
        {
            public string openkey_e;
            public string closedkey_d;
            public string symbol;
            public Person(string e, string d, string s)
            {
                openkey_e = e;
                closedkey_d = d;
                symbol = s;
            }
        }
        public int Coprime_i = 0;
        public int D_i = 0;

        public int _E = 0;
        public int _D = 0;

        public int _q = 0;
        public int _p = 0;

        private void FindKeys_Click_1(object sender, EventArgs e)
        {
            int Q = Convert.ToInt32(Box_For_q.Text);
            int P = Convert.ToInt32(Box_For_p.Text);

            method_start(Q, P);
        }

        public void method_start(int q, int p)
        {
            _q = q;
            _p = p;
            int[] simple_numbers = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31,
                                               37, 41, 43, 47, 53, 59, 61, 67, 71, 73,
                                               79, 83, 89, 97, 101, 103, 107, 109, 113};


            n = p * q;


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
            //MessageBox.Show("Пара ключей e,n : (" + exp + ";" + n + ")");

            int d = 0;
            for (; D_i < 10000; D_i++)
            {
                if ((D_i * exp) % Eller_Func == 1)
                {
                    d = D_i;
                    _D = d;
                    break;
                }
            }
            ClosedKey.Text = "(" + d + "; " + n + ")";
            //MessageBox.Show("Пара ключей d,n : (" + d + ";" + n + ")");

        }
        private bool IsCoprime(int a, int b)
        {
            return a == b
                   ? a == 1
                   : a > b
                        ? IsCoprime(a - b, b)
                        : IsCoprime(b - a, a);
        }

        private void ReUp_Click(object sender, EventArgs e)
        {
            method_start(_q, _p);
            Coprime_i++;
            D_i++;
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
            Person name1 = new Person(Person1_E.Text, Person1_D.Text, let1.Text);
            Person name2 = new Person(Person2_E.Text, Person2_D.Text, let2.Text);
            Person name3 = new Person(Person3_E.Text, Person3_D.Text, let3.Text);

            //Человек 1 добавляет случайное x = 6 к своему символу, шифрует с помощью открытого ключа человека 2 и отсылает ему.

            double a = Double.Parse(name1.symbol) + 6.0;

            double message = Math.Pow(a,
                Double.Parse(name2.openkey_e))%n;

            //Человек 2 принимает message дешифрует с помощью своего зкарытого ключа, добавляет к нему свой символ и шифрует
            //с помощью открытого ключа человека 3 и отсылает ему

            double inmessage = Math.Pow(message, Double.Parse(name2.closedkey_d)) % n;

            double message2 = Math.Pow((inmessage + Double.Parse(name2.symbol)), Double.Parse(name3.openkey_e)) % n;

            //Человек 3 получает message2 дешифрует его с помощью своего закрытого ключа, 
            //добавляет к нему свой символ и шифрует с помощью открытого ключа человека 1 и отсылает ему

            double inmessage1 = Math.Pow(message2, Double.Parse(name3.closedkey_d)) % n;

            double message3 = Math.Pow((inmessage1 + Double.Parse(name3.symbol)), Double.Parse(name1.openkey_e)) % n;

            //Человек 1 получает message3 дешифрует его с помощью закрытого ключа, отнимает х и считает среднее

            double inmessage2 = Math.Pow(message3, Double.Parse(name1.closedkey_d)) % n;

            double outmessage = inmessage2 - 6;

            label4.Text = "После алгоритма получено среднее значение:" + outmessage / 3;

            double abc = double.Parse(name1.symbol) + double.Parse(name2.symbol) + double.Parse(name3.symbol);
            label5.Text = "Фактически равно: " + ( abc / 3);

        }

        private void SurnamePerson1_TextChanged(object sender, EventArgs e)
        {
            if(SurnamePerson1.TextLength!=0)
            {
                char[] letter1 = SurnamePerson1.Text.ToUpper().ToCharArray();
                int index1 = alphabet.IndexOf(letter1[0]);

                let1.Text = "" + index1;
            }
            
        }

        private void SurnamePerson2_TextChanged(object sender, EventArgs e)
        {
            if (SurnamePerson2.TextLength != 0)
            {
                char[] letter2 = SurnamePerson2.Text.ToUpper().ToCharArray();
                int index2 = alphabet.IndexOf(letter2[0]);

                let2.Text = "" + index2;
            }
        }

        private void SurnamePerson3_TextChanged(object sender, EventArgs e)
        {
            if (SurnamePerson3.TextLength != 0)

            {
                char[] letter3 = SurnamePerson3.Text.ToUpper().ToCharArray();
                int index3 = alphabet.IndexOf(letter3[0]);

                let3.Text = "" + index3;
            }
        }
    }
}
