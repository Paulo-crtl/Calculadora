using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double V1, V2, V3, V4, R, R2=1;
        char op;

        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            textBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
            textBox2.Text += 1;
            textBox3.Text += 1;
        }

        private void B2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
            textBox2.Text += 2;
            textBox3.Text += 2;
        }

        private void B3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
            textBox2.Text += 3;
            textBox3.Text += 3;
        }

        private void B4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
            textBox2.Text += 4;
            textBox3.Text += 4;
        }

        private void B5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
            textBox2.Text += 5;
            textBox3.Text += 5;
        }

        private void B6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
            textBox2.Text += 6;
            textBox3.Text += 6;
        }

        private void B7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
            textBox2.Text += 7;
            textBox3.Text += 7;
        }

        private void B8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
            textBox2.Text += 8;
            textBox3.Text += 8;
        }

        private void B9_Click(object sender, EventArgs e)
        {
           textBox1.Text += 9;
           textBox2.Text += 9;
           textBox3.Text += 9;
        }

        private void B0_Click(object sender, EventArgs e)
        {
             textBox1.Text += 0;
             textBox2.Text += 0;
             textBox3.Text += 0;
        }

        private void Mais_Click(object sender, EventArgs e)
        {
            try
            {
                V2 = double.Parse(textBox2.Text);
                V1 += V2;
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Text += " + ";
                op = '+';
            }
            catch
            {
                
            }
            
        }

        private void Menos_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox2.Text == "0")
                {

                }
                else
                {
                    if (V1 > 0)
                    {
                        V1 -= double.Parse(textBox2.Text);
                    }
                    else
                    {
                        V1 = double.Parse(textBox2.Text);
                    }
                    textBox2.Clear();
                    textBox1.Text += "-";
                    op = '-';
                }
            }
            catch
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                V2 = double.Parse(textBox2.Text);
                V1 = V2 / 100;
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Text += " % ";
                op = '%';
            }
            catch
            {

            }
        }

        private void Vezes_Click(object sender, EventArgs e)
        {try
            {
                V2 = double.Parse(textBox2.Text);
                R2 *= V2;
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Text += " X ";
                op = 'X';
            }
            catch
            {

            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            V1 = 0;
            R2 = 1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                textBox2.Clear();
            }
            catch
            {
                MessageBox.Show("0");
                textBox2.Clear();
            }
        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "0")
                {

                }
                else
                {
                    if (V1 > 0)
                    {
                        V1 /= double.Parse(textBox2.Text);
                    }
                    else
                    {
                        V1 = double.Parse(textBox2.Text);
                    }
                }


                textBox2.Clear();
                textBox3.Clear();
                textBox1.Text += " : ";
                op = ':';
            }
            catch
            {

            }

        }  
        private void Igual_Click(object sender, EventArgs e)
        {
            try
            {
                V3 = double.Parse(textBox3.Text);
                V2 = double.Parse(textBox2.Text);
                textBox2.Clear();
                switch (op)
                {
                    case '+':
                        R = V1 + V3;
                        break;
                    case '-':
                        R = V1 - V2;
                        break;
                    case 'X':
                        R = R2 * V3;
                        break;
                    case ':':
                        R = V1 / V3;
                        break;
                    case '%':
                        R = V1 * V2;
                        break;
                }
                textBox2.Text = R.ToString();
            }
            catch
            {

            }
         }
    }
}
