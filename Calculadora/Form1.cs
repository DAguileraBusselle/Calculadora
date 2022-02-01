using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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

        private static String ultimaIntroCaracter = "";
        private static String operacion = "";
        private static Boolean resultadoAlmacenado = false;
        private static int contPuntos = 0;

        private void btn1_Click(object sender, EventArgs e)
        {
            if(resultadoAlmacenado)
            {
                operacion = "1";
                resultadoAlmacenado = false;
                lblResultado.Text = operacion;
            }
            else
            {
                operacion += "1";
                lblResultado.Text = operacion;
            }
                ultimaIntroCaracter = "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {


            if (resultadoAlmacenado)
            {
                operacion = "2";
                resultadoAlmacenado = false;
                lblResultado.Text = operacion;

            }
            else
            {
                operacion += "2";
                lblResultado.Text = operacion;
            }
            ultimaIntroCaracter = "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (resultadoAlmacenado)
            {
                operacion = "3";
                resultadoAlmacenado = false;
                lblResultado.Text = operacion;

            }
            else
            {
                operacion += "3";
                lblResultado.Text = operacion;
            }
            ultimaIntroCaracter = "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {

            if (resultadoAlmacenado)
            {
                operacion = "4";
                resultadoAlmacenado = false;
                lblResultado.Text = operacion;

            }
            else
            {
                operacion += "4";
                lblResultado.Text = operacion;
            }
            ultimaIntroCaracter = "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (resultadoAlmacenado)
            {
                operacion = "5";
                resultadoAlmacenado = false;
                lblResultado.Text = operacion;

            }
            else
            {
                operacion += "5";
                lblResultado.Text = operacion;
            }
            ultimaIntroCaracter = "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {

            if (resultadoAlmacenado)
            {
                operacion = "6";
                resultadoAlmacenado = false;
                lblResultado.Text = operacion;

            }
            else
            {
                operacion += "6";
                lblResultado.Text = operacion;
            }
            ultimaIntroCaracter = "6";

        }

        private void btn7_Click(object sender, EventArgs e)
        {

            if (resultadoAlmacenado)
            {
                operacion = "7";
                resultadoAlmacenado = false;
                lblResultado.Text = operacion;

            }
            else
            {
                operacion += "7";
                lblResultado.Text = operacion;
            }
            ultimaIntroCaracter = "7";

        }

        private void btn8_Click(object sender, EventArgs e)

        {
            if (resultadoAlmacenado)
            {
                operacion = "8";
                resultadoAlmacenado = false;
                lblResultado.Text = operacion;

            }
            else
            {
                operacion += "8";
                lblResultado.Text = operacion;
            }
            ultimaIntroCaracter = "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {

            if (resultadoAlmacenado)
            {
                operacion = "9";
                resultadoAlmacenado = false;
                lblResultado.Text = operacion;

            }
            else
            {
                operacion += "9";
                lblResultado.Text = operacion;
            }
            ultimaIntroCaracter = "9";

        }

        private void btn10_Click(object sender, EventArgs e)
        {

            if (resultadoAlmacenado)
            {
                operacion = "0";
                resultadoAlmacenado = false;
                lblResultado.Text = operacion;

            }
            else
            {
                operacion += "0";
                lblResultado.Text = operacion;
            }
            ultimaIntroCaracter = "0";

        }



        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (operacion.Length > 0)
            {

                if (ultimaIntroCaracter.Equals("+") || ultimaIntroCaracter.Equals("-") || ultimaIntroCaracter.Equals("x") || ultimaIntroCaracter.Equals("/"))
                {
                    operacion = operacion.Substring(0, operacion.Length - 1);
                    operacion += "-";
                    resultadoAlmacenado = false;

                    lblResultado.Text = operacion;

                    ultimaIntroCaracter = "-";
                }
                else
                {
                    operacion += "-";
                    resultadoAlmacenado = false;

                    lblResultado.Text = operacion;

                    ultimaIntroCaracter = "-";

                }
            }
            contPuntos = 0;

        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            if (operacion.Length > 0)
            {
                if (ultimaIntroCaracter.Equals("+") || ultimaIntroCaracter.Equals("-") || ultimaIntroCaracter.Equals("x") || ultimaIntroCaracter.Equals("/"))
                {
                    operacion = operacion.Substring(0, operacion.Length - 1);
                    operacion += "+";
                    resultadoAlmacenado = false;

                    lblResultado.Text = operacion;

                    ultimaIntroCaracter = "+";
                }
                else
                {
                    operacion += "+";
                    resultadoAlmacenado = false;

                    lblResultado.Text = operacion;

                    ultimaIntroCaracter = "+";

                }

            }
            contPuntos = 0;

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if(operacion.Length > 0)
            {
               if (ultimaIntroCaracter.Equals("+") || ultimaIntroCaracter.Equals("-") || ultimaIntroCaracter.Equals("x") || ultimaIntroCaracter.Equals("/"))
                {
                    operacion = operacion.Substring(0, operacion.Length - 1);
                    operacion += "x";
                    resultadoAlmacenado = false;

                    lblResultado.Text = operacion;

                    ultimaIntroCaracter = "x";
                }
                else
                {
                    operacion += "x";
                    resultadoAlmacenado = false;

                    lblResultado.Text = operacion;

                    ultimaIntroCaracter = "x";

                }
            }
            contPuntos = 0;

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (operacion.Length > 0)
            {
                if (ultimaIntroCaracter.Equals("+") || ultimaIntroCaracter.Equals("-") || ultimaIntroCaracter.Equals("x") || ultimaIntroCaracter.Equals("/"))
                {
                    operacion = operacion.Substring(0, operacion.Length - 1);
                    operacion += "/";
                    resultadoAlmacenado = false;

                    lblResultado.Text = operacion;

                    ultimaIntroCaracter = "/";
                }
                else
                {
                    operacion += "/";
                    resultadoAlmacenado = false;

                    lblResultado.Text = operacion;

                    ultimaIntroCaracter = "/";

                }
            }
            contPuntos = 0;

        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            if (contPuntos == 0)
            {
                if (resultadoAlmacenado)
                {
                    operacion = "0.";
                    resultadoAlmacenado = false;
                    lblResultado.Text = operacion;

                }
                else
                {
                    operacion += ".";
                    lblResultado.Text = operacion;
                }
                ultimaIntroCaracter = ".";
                contPuntos++;
            } 

            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Calc calc = new Calc();
            if (operacion.Length > 0) {
                operacion = operacion.Replace("x", "*");
                char ultimoCaracter = operacion[operacion.Length - 1];
                if (ultimoCaracter.Equals('+') || ultimoCaracter.Equals('-') || ultimoCaracter.Equals('*') || ultimoCaracter.Equals('/'))
                {
                    operacion = operacion.Substring(0, operacion.Length - 1);
                }
                Double resultado = calc.Resolver(operacion);
                operacion = resultado.ToString();
                lblResultado.Text = operacion;
                resultadoAlmacenado = true;
            } else
            {
                operacion = "";
                lblResultado.Text = operacion;
            }
            ultimaIntroCaracter = "=";
        }

        

        private void btnC_Click(object sender, EventArgs e)
        {
            operacion = "";
            label1.Text = "";
            lblResultado.Text = operacion;
            contPuntos = 0;
        }

        private void ChangeColourOnMouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(129, 197, 219);
        }

        private void ChangeColourOnMouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.White;
        }

        private void lblResultado_TextChanged(object sender, EventArgs e)
        {
            if (lblResultado.Text.Length == 0)
            {
                return;
            }

            float height = lblResultado.Height * 0.99f;
            float width = lblResultado.Width * 0.99f;

            lblResultado.SuspendLayout();

            Font tryFont = lblResultado.Font;
            Size tempSize = TextRenderer.MeasureText(lblResultado.Text, tryFont);

            float heightRatio = height / tempSize.Height;
            float widthRatio = width / tempSize.Width;

            tryFont = new Font(tryFont.FontFamily, tryFont.Size * Math.Min(widthRatio, heightRatio), tryFont.Style);

            lblResultado.Font = tryFont;
            lblResultado.ResumeLayout();


        }
    }

    public class Calc
    {
        public double Resolver(string ecuacion)
        {
            // Remove all spaces
            ecuacion = Regex.Replace(ecuacion, @"\s+", "");

            Operacion op = new Operacion();
            op.Parse(ecuacion);

            double resultado = op.Resolver();

            return resultado;
        }
    }

    public class Operacion
    {
        public Operacion numeroIzquierda { get; set; }
        public string operador { get; set; }
        public Operacion numeroDerecha { get; set; }

        private Regex sumaResta = new Regex("[+-]", RegexOptions.RightToLeft);
        private Regex multDiv = new Regex("[*/]", RegexOptions.RightToLeft);

        public void Parse(string ecuacion)
        {
            var posicionOperador = sumaResta.Match(ecuacion);
            if (!posicionOperador.Success)
            {
                posicionOperador = multDiv.Match(ecuacion);
            }

            if (posicionOperador.Success)
            {
                operador = posicionOperador.Value;

                numeroIzquierda = new Operacion();
                numeroIzquierda.Parse(ecuacion.Substring(0, posicionOperador.Index));

                numeroDerecha = new Operacion();
                numeroDerecha.Parse(ecuacion.Substring(posicionOperador.Index + 1));
            }
            else
            {
                operador = "v";
                resultado = double.Parse(ecuacion);
            }
        }

        private double resultado;

        public double Resolver()
        {
            switch (operador)
            {
                case "v":
                    break;
                case "+":
                    resultado = numeroIzquierda.Resolver() + numeroDerecha.Resolver();
                    break;
                case "-":
                    resultado = numeroIzquierda.Resolver() - numeroDerecha.Resolver();
                    break;
                case "*":
                    resultado = numeroIzquierda.Resolver() * numeroDerecha.Resolver();
                    break;
                case "/":
                    resultado = numeroIzquierda.Resolver() / numeroDerecha.Resolver();
                    break;
                default:
                    throw new Exception("Call Parse first.");
            }

            return resultado;
        }
    }
}
