using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;


namespace Calculadora
{
    public partial class Form1 : Form
    {
        double valor1 = 0, valor2 = 0, resultado = 0;
        string operacion = "";
        double memoria = 0;
        double ans = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void Numeros_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textpantalla.Text += btn.Text;
        }

        private void Operacion_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (textpantalla.Text != "")
            {
                valor1 = double.Parse(textpantalla.Text);
                operacion = btn.Text;
                textpantalla.Clear();
            }
        }

        private void buttonigual_Click(object sender, EventArgs e)
        {
            if (textpantalla.Text == "") return;
            valor2 = double.Parse(textpantalla.Text);

            switch (operacion)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "x":
                    resultado = valor1 * valor2;
                    break;
                case "/":
                    resultado = valor2 != 0 ? valor1 / valor2 : 0;
                    break;
                case "%":
                    resultado = valor1 % valor2;
                    break;
                case "^":
                    resultado = Math.Pow(valor1, valor2);
                    break;
            }

            ans = resultado;
            textpantalla.Text = resultado.ToString();
        }

        private void buttonraiz_Click(object sender, EventArgs e)
        {
            if (textpantalla.Text != "")
            {
                double valor = double.Parse(textpantalla.Text);
                resultado = Math.Sqrt(valor);
                ans = resultado;
                textpantalla.Text = resultado.ToString();
            }
        }

        private void buttonlog_Click(object sender, EventArgs e)
        {
            if (textpantalla.Text != "")
            {
                double valor = double.Parse(textpantalla.Text);
                resultado = Math.Log10(valor);
                ans = resultado;
                textpantalla.Text = resultado.ToString();
            }
        }

        private void buttonpi_Click(object sender, EventArgs e)
        {
            textpantalla.Text = Math.PI.ToString();
        }

        private void buttonANS_Click(object sender, EventArgs e)
        {
            textpantalla.Text += ans.ToString();
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            if (textpantalla.Text.Length > 0)
                textpantalla.Text = textpantalla.Text.Substring(0, textpantalla.Text.Length - 1);
        }

        private void buttonCe_Click(object sender, EventArgs e)
        {
            textpantalla.Clear();
            valor1 = valor2 = resultado = 0;
            operacion = "";
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            memoria = 0;
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            textpantalla.Text = memoria.ToString();
        }

        private void buttonmas_Click(object sender, EventArgs e)
        {
            if (textpantalla.Text != "")
                memoria += double.Parse(textpantalla.Text);
        }

        private void buttonmenos_Click(object sender, EventArgs e)
        {
            if (textpantalla.Text != "")
                memoria -= double.Parse(textpantalla.Text);
        }
    }
}