using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace _1.zadanie.TViMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                int n = Convert.ToInt32(textBox1.Text);
                int m = Convert.ToInt32(textBox2.Text);

                if (n >= 0 && m >= 0 && m <= n)
                {
                    //I Число размещений из n по m

                    //Факториал числа n
                    int db = int.Parse(textBox1.Text);
                    int P = 1;
                    for (int d = 1; d <= db; d++)
                        P = P * d;


                    //Факториал (n-m)
                    int db1 = (int.Parse(textBox1.Text) - int.Parse(textBox2.Text));
                    int P1 = 1;
                    for (int d1 = 1; d1 <= db1; d1++)
                        P1 = P1 * d1;

                    //Вычисление числа всех размещений
                    int A = P / P1;
                    textBox5.Text = A.ToString();

                    //II Число размещений из n по m с повторениями

                    int A1 = Convert.ToInt32(Math.Pow(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text)));
                    textBox4.Text = A1.ToString();

                    // III Число перестановок из n
                    textBox3.Text = P.ToString();

                    // IV Число сочетаний из n по m

                    //Факториал числа m
                    int db2 = int.Parse(textBox2.Text);
                    int P2 = 1;
                    for (int d2 = 1; d2 <= db2; d2++)
                        P2 = P2 * d2;

                    //Число всех сочетаний
                    int C = A / P2;
                    textBox6.Text = C.ToString();
                }

                else MessageBox.Show("n или k меньше нуля или n меньше k");

            }
            catch
            {
                MessageBox.Show("Неправильно введены данные");
            }










        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
