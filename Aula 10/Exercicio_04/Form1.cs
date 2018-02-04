using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            int pontuacao = 0;

            //verifica a pontuação e marca as mensagens
            //PERGUNTA 1 
            if (radP1R1.Checked)
            {
                pontuacao++;
                lblValidacaoP1.Text = "Você acertou a questão.";
                lblValidacaoP1.ForeColor = Color.ForestGreen;
            }
            else
            {
                lblValidacaoP1.Text = "Você errou a questão. ";
                lblValidacaoP1.ForeColor = Color.Red;
            }

            //PERGUNTA 2 
            if (radP2R3.Checked)
            {
                pontuacao++;
                lblValidacaoP2.Text = "Você acertou a questão.";
                lblValidacaoP2.ForeColor = Color.ForestGreen;
            }
            else
            {
                lblValidacaoP2.Text = "Você errou a questão.";
                lblValidacaoP2.ForeColor = Color.Red;
            }

            //PERGUNTA 3 
            if (radP3R2.Checked)
            {
                pontuacao++;
                lblValidacaoP3.Text = "Você acertou a questão.";
                lblValidacaoP3.ForeColor = Color.ForestGreen;
            }
            else
            {
                lblValidacaoP3.Text = "Você errou a questão. ";
                lblValidacaoP3.ForeColor = Color.Red;
            }

            //PERGUNTA 4 
            if (radP4R1.Checked)
            {
                pontuacao++;
                lblValidacaoP4.Text = "Você acertou a questão.";
                lblValidacaoP4.ForeColor = Color.ForestGreen;
            }
            else
            {
                lblValidacaoP4.Text = "Você errou a questão.";
                lblValidacaoP4.ForeColor = Color.Red;
            }

            //PERGUNTA 5 
            if (radP5R2.Checked)
            {
                pontuacao++;
                lblValidacaoP5.Text = "Você acertou a questão.";
                lblValidacaoP5.ForeColor = Color.ForestGreen;
            }
            else
            {
                lblValidacaoP5.Text = "Você errou a questão. ";
                lblValidacaoP5.ForeColor = Color.Red;
            }

            //exibe pontuação final
            DialogResult resposta = MessageBox.Show("Sua pontuação neste quiz foi de " + pontuacao + "/5 pontos. \nDeseja responder novamente?", "Resultado", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (resposta == DialogResult.Yes)
            {
                limpaCamposForm();
            }
        }

        public void limpaCamposForm()
        {
            //limpa radio button
            radP1R1.Checked = false;
            radP1R2.Checked = false;
            radP1R3.Checked = false;

            radP2R1.Checked = false;
            radP2R2.Checked = false;
            radP2R3.Checked = false;

            radP3R1.Checked = false;
            radP3R2.Checked = false;
            radP3R3.Checked = false;

            radP4R1.Checked = false;
            radP4R2.Checked = false;
            radP4R3.Checked = false;

            radP5R1.Checked = false;
            radP5R2.Checked = false;
            radP5R3.Checked = false;

            //limpa validação
            lblValidacaoP1.Text = "";
            lblValidacaoP2.Text = "";
            lblValidacaoP3.Text = "";
            lblValidacaoP4.Text = "";
            lblValidacaoP5.Text = "";
        }
    }
}
