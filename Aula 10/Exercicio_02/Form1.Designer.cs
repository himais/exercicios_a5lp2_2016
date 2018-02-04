namespace Exercicio_02
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
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.groupConversao = new System.Windows.Forms.GroupBox();
            this.radConversao1 = new System.Windows.Forms.RadioButton();
            this.radConversao2 = new System.Windows.Forms.RadioButton();
            this.radConversao3 = new System.Windows.Forms.RadioButton();
            this.radConversao4 = new System.Windows.Forms.RadioButton();
            this.radConversao5 = new System.Windows.Forms.RadioButton();
            this.radConversao6 = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupConversao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(23, 26);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(67, 13);
            this.lblTemperatura.TabIndex = 0;
            this.lblTemperatura.Text = "Temperatura";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(112, 23);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(114, 20);
            this.txtTemperatura.TabIndex = 1;
            // 
            // groupConversao
            // 
            this.groupConversao.Controls.Add(this.radConversao6);
            this.groupConversao.Controls.Add(this.radConversao5);
            this.groupConversao.Controls.Add(this.radConversao4);
            this.groupConversao.Controls.Add(this.radConversao3);
            this.groupConversao.Controls.Add(this.radConversao2);
            this.groupConversao.Controls.Add(this.radConversao1);
            this.groupConversao.Location = new System.Drawing.Point(26, 58);
            this.groupConversao.Name = "groupConversao";
            this.groupConversao.Size = new System.Drawing.Size(200, 161);
            this.groupConversao.TabIndex = 2;
            this.groupConversao.TabStop = false;
            this.groupConversao.Text = "Conversão";
            // 
            // radConversao1
            // 
            this.radConversao1.AutoSize = true;
            this.radConversao1.Checked = true;
            this.radConversao1.Location = new System.Drawing.Point(15, 19);
            this.radConversao1.Name = "radConversao1";
            this.radConversao1.Size = new System.Drawing.Size(135, 17);
            this.radConversao1.TabIndex = 0;
            this.radConversao1.TabStop = true;
            this.radConversao1.Text = "Celsius para Fahrenheit";
            this.radConversao1.UseVisualStyleBackColor = true;
            // 
            // radConversao2
            // 
            this.radConversao2.AutoSize = true;
            this.radConversao2.Location = new System.Drawing.Point(15, 42);
            this.radConversao2.Name = "radConversao2";
            this.radConversao2.Size = new System.Drawing.Size(135, 17);
            this.radConversao2.TabIndex = 1;
            this.radConversao2.TabStop = true;
            this.radConversao2.Text = "Fahrenheit para Celsius";
            this.radConversao2.UseVisualStyleBackColor = true;
            // 
            // radConversao3
            // 
            this.radConversao3.AutoSize = true;
            this.radConversao3.Location = new System.Drawing.Point(15, 65);
            this.radConversao3.Name = "radConversao3";
            this.radConversao3.Size = new System.Drawing.Size(114, 17);
            this.radConversao3.TabIndex = 2;
            this.radConversao3.TabStop = true;
            this.radConversao3.Text = "Celsius para Kelvin";
            this.radConversao3.UseVisualStyleBackColor = true;
            // 
            // radConversao4
            // 
            this.radConversao4.AutoSize = true;
            this.radConversao4.Location = new System.Drawing.Point(15, 88);
            this.radConversao4.Name = "radConversao4";
            this.radConversao4.Size = new System.Drawing.Size(114, 17);
            this.radConversao4.TabIndex = 3;
            this.radConversao4.TabStop = true;
            this.radConversao4.Text = "Kelvin para Celsius";
            this.radConversao4.UseVisualStyleBackColor = true;
            // 
            // radConversao5
            // 
            this.radConversao5.AutoSize = true;
            this.radConversao5.Location = new System.Drawing.Point(15, 111);
            this.radConversao5.Name = "radConversao5";
            this.radConversao5.Size = new System.Drawing.Size(131, 17);
            this.radConversao5.TabIndex = 4;
            this.radConversao5.TabStop = true;
            this.radConversao5.Text = "Fahrenheit para Kelvin";
            this.radConversao5.UseVisualStyleBackColor = true;
            // 
            // radConversao6
            // 
            this.radConversao6.AutoSize = true;
            this.radConversao6.Location = new System.Drawing.Point(15, 134);
            this.radConversao6.Name = "radConversao6";
            this.radConversao6.Size = new System.Drawing.Size(131, 17);
            this.radConversao6.TabIndex = 5;
            this.radConversao6.TabStop = true;
            this.radConversao6.Text = "Kelvin para Fahrenheit";
            this.radConversao6.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(150, 231);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 270);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupConversao);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.lblTemperatura);
            this.Name = "Form1";
            this.Text = "Conversão de temperatura";
            this.groupConversao.ResumeLayout(false);
            this.groupConversao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.GroupBox groupConversao;
        private System.Windows.Forms.RadioButton radConversao1;
        private System.Windows.Forms.RadioButton radConversao3;
        private System.Windows.Forms.RadioButton radConversao2;
        private System.Windows.Forms.RadioButton radConversao6;
        private System.Windows.Forms.RadioButton radConversao5;
        private System.Windows.Forms.RadioButton radConversao4;
        private System.Windows.Forms.Button btnCalcular;
    }
}

