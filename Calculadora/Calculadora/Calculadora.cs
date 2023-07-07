using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        Color colorInicial;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colorInicial = this.BackColor;
            chkFondo.Checked = false;
            chkResultados.Checked = true;
            rbEstandar.Checked = true;
            ActualizoPantalla();
        }
        double NumeroDouble(String valor)
        {
            double resultado;

            if (!double.TryParse(valor, out resultado))
            {
                resultado = 0;
            }

            return resultado;
        }
        void Efectuo(String operacion)
        {
            Double num1, num2, resultado = 0;
            Boolean operok = true;
            num1 = NumeroDouble(txtNum1.Text);
            num2 = NumeroDouble(txtNum2.Text);
            txtNum1.Text = Convert.ToString(num1);
            txtNum2.Text = Convert.ToString(num2);
            String textoMostrar;

            switch(operacion){
    
                case "+": resultado = num1 + num2; break;
                case "-": resultado = num1 - num2; break;
                case "*": resultado = num1 * num2; break;
                case "/": if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        operok = false;
                    }
                    break;
                
            }

            if (operok)
            {
                lblResultado.Text = Convert.ToString(resultado);
                textoMostrar = num1 + operacion + num2 + "=" + resultado;
                cboResultados.Items.Add(textoMostrar);
                lstResultados.Items.Add(textoMostrar);
            }
            else
            {
                lblResultado.Text = "No existe";
            }
            
        }
        void ActualizoPantalla()
        {
            cboResultados.Visible = chkResultados.Checked;
            lstResultados.Visible = chkResultados.Checked;
            if (chkFondo.Checked)
            {
                this.BackColor = Color.Yellow;
            }
            else
            {
                this.BackColor = colorInicial;
            }
            gbCientificas.Visible = rbCientifica.Checked;
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            Efectuo("+");
            /*Double num1, num2, resultado;
             if(!double.TryParse(txtNum1.Text,out num1))
             {
                 num1 = 0;
             }
             if (!double.TryParse(txtNum2.Text, out num2))
             {
                 num2 = 0;
             }
            num1 = NumeroDouble(txtNum1.Text);
            num2 = NumeroDouble(txtNum2.Text);
            txtNum1.Text = Convert.ToString(num1);
            txtNum2.Text = Convert.ToString(num2);
            resultado = num1 + num2;
            lblResultado.Text = Convert.ToString(resultado);
            */
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            Efectuo("*");
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            Efectuo("-");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Efectuo("/");
        }

        private void chkResultados_CheckedChanged(object sender, EventArgs e)
        {
            ActualizoPantalla();
        }

        private void chkFondo_CheckedChanged(object sender, EventArgs e)
        {
            ActualizoPantalla();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rbEstandar_CheckedChanged(object sender, EventArgs e)
        {
            ActualizoPantalla();
        }

        private void rbCientifica_CheckedChanged(object sender, EventArgs e)
        {
            ActualizoPantalla();
        }
    }
}
