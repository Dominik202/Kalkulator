using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator2
{
    public partial class Form1 : Form
    {
        public double a;
        public double b;
        private string dzialanie="";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
            textBox2.Text += button2.Text;
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            a = 0;
            b = 0;
            dzialanie = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
            textBox2.Text += button1.Text;
            

        }
        public void wynik()
        {
            b = System.Double.Parse(textBox1.Text);
            switch(dzialanie)
            {
                case "+":
                    a = a + b;
                    dzialanie = "";
                    break;
                case "-":
                    a = a - b;
                    dzialanie = "";
                    break;
                case "/":
                    if (b != 0) a = a / b;
                    else textBox2.Text = "Nie dziel przez 0";
                    dzialanie = "";
                    break;
                case "*":
                    a = a * b;
                    dzialanie = "";
                    break;
                case "^":
                    a = Math.Pow(a,b);
                    dzialanie = "";
                    break;
            }
            textBox1.Text = a.ToString();
            
        }
        public void przelicznik()
        {
            
            switch (dzialanie)
            {

                case "kmm":
                    a = a / 1.609344;
                    dzialanie = "";
                    
                    break;
                case "mkm":
                    a = a * 1.609344;
                    dzialanie = "";
                    textBox2.Text = textBox1.Text;
                    break;
                case "mft":
                    a = a / 0.3048;
                    dzialanie = "";
                    
                    break;
                case "ftm":
                    a = a * 0.3048;
                    dzialanie = "";
                    
                    break;
                case "minus":
                    a = -a;
                    dzialanie = "";
                    break;
            }
            textBox1.Text = a.ToString();
            dzialanie = "przel";
            //textBox2.Text = textBox1.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            wynik();
            dzialanie = "=";
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (dzialanie == "")
            {
                a = System.Double.Parse(textBox1.Text);
                dzialanie = "+";
                textBox1.Text = "";
                textBox2.Text += "+";
            }
            else
            {
                wynik();
                a = System.Double.Parse(textBox1.Text);
                dzialanie = "+";
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                textBox2.Text += "+";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
            textBox2.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
            textBox2.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
            textBox2.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
            textBox2.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
            textBox2.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
            textBox2.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
            textBox2.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
            textBox2.Text += button10.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += button17.Text;
            textBox2.Text += button17.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (dzialanie == "")
            {
                a = System.Double.Parse(textBox1.Text);
                dzialanie = "-";
                textBox1.Text = "";
                textBox2.Text += "-";
            }
            else
            {
                wynik();
                a = System.Double.Parse(textBox1.Text);
                dzialanie = "-";
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                textBox2.Text += "-";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (dzialanie == "")
            {
                a = System.Double.Parse(textBox1.Text);
                dzialanie = "/";
                textBox1.Text = "";
                textBox2.Text += "/";
            }
            else
            {
                wynik();
                a = System.Double.Parse(textBox1.Text);
                dzialanie = "/";
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                textBox2.Text += "/";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

            if (dzialanie == "")
            {
                a = System.Double.Parse(textBox1.Text);
                dzialanie = "*";               
                textBox1.Text = "";
                textBox2.Text += "*";
            }
            else
            {
                wynik();
                a = System.Double.Parse(textBox1.Text);
                dzialanie = "*";
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                textBox2.Text += "*";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (dzialanie == "")
            {
                a = System.Double.Parse(textBox1.Text);
                dzialanie = "^";
                textBox1.Text = "";
                textBox2.Text += "^";
            }
            else
            {
                wynik();
                a = System.Double.Parse(textBox1.Text);
                dzialanie = "^";
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                textBox2.Text += "^";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (dzialanie == "")
            {
                a = System.Double.Parse(textBox1.Text);
                dzialanie = "kmm";
                textBox1.Text = "";
                przelicznik();
            }
            else
            {
                wynik();
                a = System.Double.Parse(textBox1.Text);
                dzialanie = "kmm";
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                przelicznik();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (dzialanie == "")
            {
                a = System.Double.Parse(textBox1.Text);
                dzialanie = "mkm";
                textBox1.Text = "";
                przelicznik();
            }
            else
            {
                wynik();
                a = System.Double.Parse(textBox1.Text);
                dzialanie = "mkm";
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                przelicznik();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (dzialanie == "")
            {
                a = System.Double.Parse(textBox1.Text);
                dzialanie = "mft";
                textBox1.Text = "";
                przelicznik();
            }
            else
            {
                wynik();
                a = System.Double.Parse(textBox1.Text);
                dzialanie = "mft";
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                przelicznik();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (dzialanie == "")
            {
                a = System.Double.Parse(textBox1.Text);
                dzialanie = "ftm";
                textBox1.Text = "";
                przelicznik();
            }
            else
            {
                wynik();
                a = System.Double.Parse(textBox1.Text);
                dzialanie = "ftm";
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                przelicznik();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (dzialanie == "")
            {
                a = (System.Double.Parse(textBox1.Text));
                dzialanie = "minus";
                textBox1.Text = "";
                przelicznik();
            }
            else
            {
                wynik();
                a = (System.Double.Parse(textBox1.Text));
                dzialanie = "minus";
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                przelicznik();
            }
        }


    }
}
