namespace Exercicio_03
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFormulario1 = new System.Windows.Forms.Label();
            this.lblFormulario2 = new System.Windows.Forms.Label();
            this.chbFidelidade = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.groupPostagem = new System.Windows.Forms.GroupBox();
            this.radTipoPostagem2 = new System.Windows.Forms.RadioButton();
            this.radTipoPostagem1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblResultadoValorCompra = new System.Windows.Forms.Label();
            this.lblResultado3 = new System.Windows.Forms.Label();
            this.lblResultadoValorFrete = new System.Windows.Forms.Label();
            this.lblResultado2 = new System.Windows.Forms.Label();
            this.lblResultadoValorProduto = new System.Windows.Forms.Label();
            this.lblResultado1 = new System.Windows.Forms.Label();
            this.groupPostagem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormulario1
            // 
            this.lblFormulario1.AutoSize = true;
            this.lblFormulario1.Location = new System.Drawing.Point(18, 31);
            this.lblFormulario1.Name = "lblFormulario1";
            this.lblFormulario1.Size = new System.Drawing.Size(85, 13);
            this.lblFormulario1.TabIndex = 0;
            this.lblFormulario1.Text = "Valor do produto";
            // 
            // lblFormulario2
            // 
            this.lblFormulario2.AutoSize = true;
            this.lblFormulario2.Location = new System.Drawing.Point(63, 62);
            this.lblFormulario2.Name = "lblFormulario2";
            this.lblFormulario2.Size = new System.Drawing.Size(40, 13);
            this.lblFormulario2.TabIndex = 2;
            this.lblFormulario2.Text = "Estado";
            // 
            // chbFidelidade
            // 
            this.chbFidelidade.AutoSize = true;
            this.chbFidelidade.Location = new System.Drawing.Point(80, 86);
            this.chbFidelidade.Name = "chbFidelidade";
            this.chbFidelidade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbFidelidade.Size = new System.Drawing.Size(129, 17);
            this.chbFidelidade.TabIndex = 4;
            this.chbFidelidade.Text = "Cliente com fidelidade";
            this.chbFidelidade.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(295, 125);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(129, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular valores";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(109, 28);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 6;
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "MG",
            "ES"});
            this.cbxEstado.Location = new System.Drawing.Point(109, 59);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(100, 21);
            this.cbxEstado.TabIndex = 7;
            // 
            // groupPostagem
            // 
            this.groupPostagem.Controls.Add(this.radTipoPostagem2);
            this.groupPostagem.Controls.Add(this.radTipoPostagem1);
            this.groupPostagem.Location = new System.Drawing.Point(236, 28);
            this.groupPostagem.Name = "groupPostagem";
            this.groupPostagem.Size = new System.Drawing.Size(188, 75);
            this.groupPostagem.TabIndex = 8;
            this.groupPostagem.TabStop = false;
            this.groupPostagem.Text = "Tipo de postagem";
            // 
            // radTipoPostagem2
            // 
            this.radTipoPostagem2.AutoSize = true;
            this.radTipoPostagem2.Location = new System.Drawing.Point(101, 35);
            this.radTipoPostagem2.Name = "radTipoPostagem2";
            this.radTipoPostagem2.Size = new System.Drawing.Size(70, 17);
            this.radTipoPostagem2.TabIndex = 1;
            this.radTipoPostagem2.Text = "Sedex 10";
            this.radTipoPostagem2.UseVisualStyleBackColor = true;
            // 
            // radTipoPostagem1
            // 
            this.radTipoPostagem1.AutoSize = true;
            this.radTipoPostagem1.Checked = true;
            this.radTipoPostagem1.Location = new System.Drawing.Point(15, 35);
            this.radTipoPostagem1.Name = "radTipoPostagem1";
            this.radTipoPostagem1.Size = new System.Drawing.Size(55, 17);
            this.radTipoPostagem1.TabIndex = 0;
            this.radTipoPostagem1.TabStop = true;
            this.radTipoPostagem1.Text = "Sedex";
            this.radTipoPostagem1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupPostagem);
            this.groupBox1.Controls.Add(this.cbxEstado);
            this.groupBox1.Controls.Add(this.lblFormulario1);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.lblFormulario2);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.chbFidelidade);
            this.groupBox1.Location = new System.Drawing.Point(13, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 157);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calcular frete";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblResultadoValorCompra);
            this.groupBox2.Controls.Add(this.lblResultado3);
            this.groupBox2.Controls.Add(this.lblResultadoValorFrete);
            this.groupBox2.Controls.Add(this.lblResultado2);
            this.groupBox2.Controls.Add(this.lblResultadoValorProduto);
            this.groupBox2.Controls.Add(this.lblResultado1);
            this.groupBox2.Location = new System.Drawing.Point(13, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 84);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // lblResultadoValorCompra
            // 
            this.lblResultadoValorCompra.AutoSize = true;
            this.lblResultadoValorCompra.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblResultadoValorCompra.Location = new System.Drawing.Point(361, 58);
            this.lblResultadoValorCompra.Name = "lblResultadoValorCompra";
            this.lblResultadoValorCompra.Size = new System.Drawing.Size(45, 13);
            this.lblResultadoValorCompra.TabIndex = 5;
            this.lblResultadoValorCompra.Text = "R$ 0.00";
            // 
            // lblResultado3
            // 
            this.lblResultado3.AutoSize = true;
            this.lblResultado3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado3.Location = new System.Drawing.Point(217, 58);
            this.lblResultado3.Name = "lblResultado3";
            this.lblResultado3.Size = new System.Drawing.Size(128, 13);
            this.lblResultado3.TabIndex = 4;
            this.lblResultado3.Text = "Valor total da compra";
            // 
            // lblResultadoValorFrete
            // 
            this.lblResultadoValorFrete.AutoSize = true;
            this.lblResultadoValorFrete.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblResultadoValorFrete.Location = new System.Drawing.Point(361, 27);
            this.lblResultadoValorFrete.Name = "lblResultadoValorFrete";
            this.lblResultadoValorFrete.Size = new System.Drawing.Size(45, 13);
            this.lblResultadoValorFrete.TabIndex = 3;
            this.lblResultadoValorFrete.Text = "R$ 0.00";
            // 
            // lblResultado2
            // 
            this.lblResultado2.AutoSize = true;
            this.lblResultado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado2.Location = new System.Drawing.Point(261, 27);
            this.lblResultado2.Name = "lblResultado2";
            this.lblResultado2.Size = new System.Drawing.Size(84, 13);
            this.lblResultado2.TabIndex = 2;
            this.lblResultado2.Text = "Valor do frete";
            // 
            // lblResultadoValorProduto
            // 
            this.lblResultadoValorProduto.AutoSize = true;
            this.lblResultadoValorProduto.Location = new System.Drawing.Point(154, 27);
            this.lblResultadoValorProduto.Name = "lblResultadoValorProduto";
            this.lblResultadoValorProduto.Size = new System.Drawing.Size(45, 13);
            this.lblResultadoValorProduto.TabIndex = 1;
            this.lblResultadoValorProduto.Text = "R$ 0.00";
            // 
            // lblResultado1
            // 
            this.lblResultado1.AutoSize = true;
            this.lblResultado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado1.Location = new System.Drawing.Point(46, 27);
            this.lblResultado1.Name = "lblResultado1";
            this.lblResultado1.Size = new System.Drawing.Size(101, 13);
            this.lblResultado1.TabIndex = 0;
            this.lblResultado1.Text = "Valor do produto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 284);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Cálculo de frete";
            this.groupPostagem.ResumeLayout(false);
            this.groupPostagem.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFormulario1;
        private System.Windows.Forms.Label lblFormulario2;
        private System.Windows.Forms.CheckBox chbFidelidade;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.GroupBox groupPostagem;
        private System.Windows.Forms.RadioButton radTipoPostagem2;
        private System.Windows.Forms.RadioButton radTipoPostagem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblResultadoValorCompra;
        private System.Windows.Forms.Label lblResultado3;
        private System.Windows.Forms.Label lblResultadoValorFrete;
        private System.Windows.Forms.Label lblResultado2;
        private System.Windows.Forms.Label lblResultadoValorProduto;
        private System.Windows.Forms.Label lblResultado1;
    }
}

