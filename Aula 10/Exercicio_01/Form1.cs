using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercícios_Aula10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (verificaCampos())
            {
                try{
                    MessageBox.Show("Resultado: " + realizaCalculo(Double.Parse(txtValor1.Text), Double.Parse(txtValor2.Text), cbxOperacao.Text), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }catch(Exception){
                    MessageBox.Show("Digite valores válidos", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool verificaCampos()
        {
            if (txtValor1.Text == string.Empty)
            {
                MessageBox.Show("Digite o valor 1", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtValor2.Text == string.Empty)
            {
                MessageBox.Show("Digite o valor 2", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbxOperacao.Text == string.Empty)
            {
                MessageBox.Show("Escolha uma operação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private double realizaCalculo(double valor1, double valor2, string op)
        {
            double resultado = 0;
            switch (op)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "*":
                    resultado = valor1 * valor2;
                    break;
                case "/":
                    resultado = valor1 / valor2;
                    break;
                case "%":
                    resultado = valor1 % valor2;
                    break;
                default:
                    MessageBox.Show("Operação inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            return resultado;
        }
    }
}
