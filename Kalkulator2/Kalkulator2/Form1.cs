/**
  
  \details Aplikacja okienkowa kalkulatora wraz z przelicznikiem jednostek
   
  \brief Autorzy: Dominik Platos, Dorota Wrona
 
**/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator2  /// przesten deklaracji kalkulatora
{
    public partial class Form1 : Form /// klasa glowna 
    {
        public double a;  
        public double b;
        private string dzialanie=""; ///zmienna string odopwiedzialna za rodzaj dzialania
        public Form1()
        {
            InitializeComponent();
        }

       

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e) /// klawisz odpowiedzialny za zamykanie aplikacji
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)  ///przycisk odpowiedzialny za kasowanie wpisanych w wyswietlaczu kalkulatora liczb
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            a = 0;
            b = 0;
            dzialanie = "";

        }


        public void wynik()  ///definicje operacji arytmetycznych 
        {
            b = System.Double.Parse(textBox1.Text);
            switch(dzialanie) ///wybor wykonywanego dzialania zalezy od nacisnietego klawisza
            {
                case "+":
                    a = a + b;  /// operacja dodawnia
                    dzialanie = "";
                    break;
                case "-":
                    a = a - b; /// operacja odejmowania
                    dzialanie = "";
                    break;
                case "/":
                    if (b != 0) a = a / b; ///operacja dzielenia
                    else textBox2.Text = "Nie dziel przez 0";
                    dzialanie = "";
                    break;
                case "*":
                    a = a * b;  /// operacja mnozenia
                    dzialanie = "";
                    break;
                case "^":
                    a = Math.Pow(a,b);  ///operacja potegowania
                    dzialanie = "";
                    break;
            }
            textBox1.Text = a.ToString(); /// funkcja odpowiedzialna za wyswiwetlanie wyniku na wyswietlaczu kalkulatora
            
        }
        public void przelicznik() ///definicje przelicznika
        {
            
            switch (dzialanie)  ///wybor wykonywanego rodzaju przeliczania
            {

                case "kmm":
                    a = a / 1.609344; ///przeliczanie kilometrow na mile
                    dzialanie = "";
                    
                    break;
                case "mkm":
                    a = a * 1.609344; ///przeliczanie mil na kilometry
                    dzialanie = "";
                    textBox2.Text = textBox1.Text;
                    break;
                case "mft":
                    a = a / 0.3048;  ///przeliczanie metrow na stopy
                    dzialanie = "";
                    
                    break;
                case "ftm":  ///przeliczanie stop na metry
                    a = a * 0.3048;
                    dzialanie = "";
                    
                    break;
                case "minus":  ///obsluga liczb przeciwnych
                    a = -a;
                    dzialanie = "";
                    break;
            }
            textBox1.Text = a.ToString();  ///konwersja doubla na stringa
            dzialanie = "przel";
            //textBox2.Text = textBox1.Text;
        }

        private void button16_Click(object sender, EventArgs e)  ///obsluga klawisza '='
        {
            wynik(); ///wyswietlanie wyniku
            dzialanie = "=";
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (dzialanie == "")
            {
                a = System.Double.Parse(textBox1.Text); ///obsluga klawisza '+'
                dzialanie = "+";
                textBox1.Text = "";
                textBox2.Text += "+";
            }
            else
            {
                wynik();
                a = System.Double.Parse(textBox1.Text);///obsluga klawisza '+' w przypadku operacji wieloargumentowych
                dzialanie = "+";
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                textBox2.Text += "+";
            }
        }
        /**
  
  \details Przyciski liczbowe
   
  \brief Szereg przyciskow odpowiedzialnych za wyswietlanie przypisanych im wartosci na wyswietlaczu kalkulatora
 
**/
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
            textBox2.Text += button1.Text;


        }
        private void button2_Click(object sender, EventArgs e)  
        {
            textBox1.Text += button2.Text;
            textBox2.Text += button2.Text;
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
                a = System.Double.Parse(textBox1.Text);  ///obsluga klawisza '-'
                dzialanie = "-"; 
                textBox1.Text = "";
                textBox2.Text += "-";
            }
            else
            {
                wynik();  ///obsluga klawisza '-' w przypadku operacji wieloargumentowych
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
                a = System.Double.Parse(textBox1.Text); ///obsluga klawisza '/'
                dzialanie = "/";
                textBox1.Text = "";
                textBox2.Text += "/";
            }
            else
            {
                wynik();
                a = System.Double.Parse(textBox1.Text);///obsluga klawisza '/' w przypadku operacji wieloargumentowych
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
                a = System.Double.Parse(textBox1.Text); ///obsluga klawisza '*'
                dzialanie = "*";               
                textBox1.Text = "";
                textBox2.Text += "*";
            }
            else
            {
                wynik();
                a = System.Double.Parse(textBox1.Text); ///obsluga klawisza '*' w przypadku operacji wieloargumentowych 
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
                a = System.Double.Parse(textBox1.Text);  ///obsluga klawisza '^'
                dzialanie = "^";
                textBox1.Text = "";
                textBox2.Text += "^";
            }
            else
            {
                wynik();
                a = System.Double.Parse(textBox1.Text); ///obsluga klawisza '^' w przypadku operacji wieloargumentowych
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
                a = System.Double.Parse(textBox1.Text); ///obsluga klawisza 'km->mile' 
                dzialanie = "kmm";
                textBox1.Text = "";
                przelicznik();
            }
            else
            {
                wynik();
                a = System.Double.Parse(textBox1.Text); ///obsluga klawisza 'km->mile' w przypadku operacji wieloargumentowych
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
                a = System.Double.Parse(textBox1.Text); ///obsluga klawisza 'mile->km' 
                dzialanie = "mkm";
                textBox1.Text = "";
                przelicznik();
            }
            else
            {
                wynik();
                a = System.Double.Parse(textBox1.Text); ///obsluga klawisza 'mile->km' w przypadku operacji wieloargumentowych
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
                a = System.Double.Parse(textBox1.Text); ///obsluga klawisza 'm->stopy'
                dzialanie = "mft";
                textBox1.Text = "";
                przelicznik();
            }
            else
            {
                wynik();
                a = System.Double.Parse(textBox1.Text);
                dzialanie = "mft"; ///obsluga klawisza 'm->stopy' w przypadku operacji wieloargumentowych
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                przelicznik();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (dzialanie == "")
            {
                a = System.Double.Parse(textBox1.Text); ///obsluga klawisza 'stopy->m'
                dzialanie = "ftm"; 
                textBox1.Text = "";
                przelicznik();
            }
            else
            {
                wynik();
                a = System.Double.Parse(textBox1.Text); ///obsluga klawisza 'stopy->m' w przypadku operacji wieloargumentowych
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
                a = (System.Double.Parse(textBox1.Text));  //////obsluga klawisza zwiazanego z liczbami odwrotnymi
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
