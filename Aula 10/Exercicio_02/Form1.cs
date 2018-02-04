using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtTemperatura.Text != string.Empty)
            {
                try
                {
                    MessageBox.Show("Resultado da conversão: " + calculaTemperatura(Double.Parse(txtTemperatura.Text)), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Digite um valor válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Digite uma temperatura para converter.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double calculaTemperatura(double temperatura)
        {
            double resultado = 0;

            if (radConversao1.Checked) resultado = temperatura * 1.8 + 32;
            if (radConversao2.Checked) resultado = (temperatura - 32) / 1.8;
            if (radConversao3.Checked) resultado = temperatura + 273.15;
            if (radConversao4.Checked) resultado = temperatura - 273.15;
            if (radConversao5.Checked) resultado = (temperatura + 459.67) / 1.8;
            if (radConversao6.Checked) resultado = temperatura * 1.8 - 459.67;

            return resultado;
        }


    }
}
