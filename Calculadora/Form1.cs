using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private static int contOperadores = 0;
        private static String textPantalla = "";
        private static int contMuerte = 0;
        private static int centinelaRes = 0;
        private void btn1_Click(object sender, EventArgs e)
        {
            lblResultado.ForeColor = Color.White;

            textPantalla += "1";
            lblResultado.Text = textPantalla;

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblResultado.ForeColor = Color.White;

            textPantalla += "2";
            lblResultado.Text = textPantalla;


        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblResultado.ForeColor = Color.White;

            textPantalla += "3";
            lblResultado.Text = textPantalla;


        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblResultado.ForeColor = Color.White;

            textPantalla += "4";
            lblResultado.Text = textPantalla;


        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblResultado.ForeColor = Color.White;

            textPantalla += "5";
            lblResultado.Text = textPantalla;


        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblResultado.ForeColor = Color.White;

            textPantalla += "6";
            lblResultado.Text = textPantalla;


        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblResultado.ForeColor = Color.White;

            textPantalla += "7";
            lblResultado.Text = textPantalla;


        }

        private void btn8_Click(object sender, EventArgs e)

        {
            lblResultado.ForeColor = Color.White;

            textPantalla += "8";
            lblResultado.Text = textPantalla;


        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblResultado.ForeColor = Color.White;

            textPantalla += "9";
            lblResultado.Text = textPantalla;


        }

        private void btn10_Click(object sender, EventArgs e)
        {
            lblResultado.ForeColor = Color.White;

            textPantalla += "0";
            lblResultado.Text = textPantalla;


        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (contOperadores < 1)
            {
                textPantalla += " - ";
                lblResultado.Text = textPantalla;
                contOperadores++;
            } else
            {
                label1.Text = "solo puede realizar una operacion";
            }
            


        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            if (contOperadores < 1)
            {
                textPantalla += " + ";
                lblResultado.Text = textPantalla;
                contOperadores++;
            } else
            {
                label1.Text = "solo puede realizar una operacion";
            }


        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (contOperadores < 1)
            {
                textPantalla += " x ";
                lblResultado.Text = textPantalla;
                contOperadores++;
            } else
            {
                label1.Text = "solo puede realizar una operacion";
            }


        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (contOperadores < 1)
            {
                textPantalla += " / ";
                lblResultado.Text = textPantalla;
                contOperadores++;
            } else
            {
                label1.Text = "solo puede realizar una operacion";
            }


        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            lblResultado.ForeColor = Color.White;

            textPantalla += ",";
            lblResultado.Text = textPantalla;

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            string[] operacion = textPantalla.Split(' ');
            int n = 0;
            Double num1 = 0;
            Double num2 = 0;
            string operador = "";

            double resultado = 0;

            foreach (string word in operacion)
            {
                n++;   
            }

            if (n == 1 || n == 2)
            {
                int i = 0;
                foreach (string word in operacion)
                {  
                    if (i == 0)
                    {
                        lblResultado.Text = word;
                        i++;
                    }
                    
                }
                
            } else if (n == 3)
            {

            foreach (string word in operacion)
            {
                if (n==0)
                {
                    Console.WriteLine(word);

                    num1 = Double.Parse(word);
                    Console.WriteLine(num1);
                    n++;
                    
                    
                } else if (n==1)
                {
                    Console.WriteLine(word);

                    operador = word;
                    n++;
                } else if (n==2)
                {
                    Console.WriteLine(word);
                    
                    num2 = Double.Parse(word);
                    
                    Console.WriteLine(num2);
                    n++;
                    
                    
                }
            }

            switch (operador)
            {
                case  "-":
                    resultado = num1 - num2;
                    Console.WriteLine(resultado);

                    break;

                case "+":
                    resultado = num1 + num2;
                    Console.WriteLine(resultado);

                    break;

                case "x":
                    resultado = num1 * num2;
                    Console.WriteLine(resultado);

                    break;
                case "/":
                    resultado = num1 / num2;
                    Console.WriteLine(resultado);

                    break;

            }

            if (contMuerte == 5)
            {
                lblResultado.ForeColor = Color.Red;
                
                lblResultado.Text = "No";
            } else
            {
                lblResultado.ForeColor = Color.White;
                lblResultado.Text = resultado.ToString();
            }
            }

            
            textPantalla = "";
            contOperadores = 0;
            label1.Text = "";
            contMuerte++;

        }

        
       
    }
}
