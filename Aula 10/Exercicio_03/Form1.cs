using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                try
                {
                    double valorProduto = Double.Parse(txtValor.Text);
                    double valorFrete = calculaFrete(Double.Parse(txtValor.Text), cbxEstado.Text);

                    if (chbFidelidade.Checked) valorProduto = valorProduto - (valorProduto * 0.1);

                    //seta valores
                    lblResultadoValorProduto.Text = "R$"+ valorProduto;
                    lblResultadoValorFrete.Text = "R$" + valorFrete;
                    lblResultadoValorCompra.Text = "R$" + (valorProduto + valorFrete);
                }
                catch(Exception)
                {
                    MessageBox.Show("Informe valores válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private bool validaCampos()
        {
            if (txtValor.Text == string.Empty)
            {
                MessageBox.Show("Digite o valor da compra.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbxEstado.Text == string.Empty)
            {
                MessageBox.Show("Selecione seu estado de residência.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private double calculaFrete(double valor, string estado)
        {
            double resultado = 0;

            //calcula valor do sedex padrão
            if (estado == "SP") resultado = 20.00;
            if (estado == "RJ") resultado = 20.00 * 1.1;
            if (estado == "MG") resultado = 20.00 * 1.2;
            if (estado == "ES") resultado = 20.00 * 1.3;

            if (radTipoPostagem2.Checked) resultado = resultado * 1.2;

            return resultado;
        }
    }
}
