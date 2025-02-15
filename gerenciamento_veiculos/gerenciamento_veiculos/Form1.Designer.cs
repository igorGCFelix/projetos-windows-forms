namespace gerenciamento_veiculos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ano_fabricacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_numero_portas = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.res_numero_portas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.res_ano_fabricacao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.res_cor = new System.Windows.Forms.TextBox();
            this.res_modelo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_enviar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_numero_portas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_ano_fabricacao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_cor);
            this.groupBox1.Controls.Add(this.txt_modelo);
            this.groupBox1.Location = new System.Drawing.Point(26, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preencha as informações";
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(16, 37);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(219, 20);
            this.txt_modelo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modelo do carro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cor do carro";
            // 
            // txt_cor
            // 
            this.txt_cor.Location = new System.Drawing.Point(16, 88);
            this.txt_cor.Name = "txt_cor";
            this.txt_cor.Size = new System.Drawing.Size(219, 20);
            this.txt_cor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ano de fabricação do carro";
            // 
            // txt_ano_fabricacao
            // 
            this.txt_ano_fabricacao.Location = new System.Drawing.Point(16, 142);
            this.txt_ano_fabricacao.Name = "txt_ano_fabricacao";
            this.txt_ano_fabricacao.Size = new System.Drawing.Size(219, 20);
            this.txt_ano_fabricacao.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número de portas do carro";
            // 
            // txt_numero_portas
            // 
            this.txt_numero_portas.Location = new System.Drawing.Point(16, 198);
            this.txt_numero_portas.Name = "txt_numero_portas";
            this.txt_numero_portas.Size = new System.Drawing.Size(219, 20);
            this.txt_numero_portas.TabIndex = 2;
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(63, 248);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(123, 23);
            this.btn_enviar.TabIndex = 1;
            this.btn_enviar.Text = "Enviar as informações";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.res_numero_portas);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.res_ano_fabricacao);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.res_cor);
            this.groupBox2.Controls.Add(this.res_modelo);
            this.groupBox2.Location = new System.Drawing.Point(26, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 244);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado das informações";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Número de portas do carro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ano de fabricação do carro";
            // 
            // res_numero_portas
            // 
            this.res_numero_portas.Location = new System.Drawing.Point(16, 198);
            this.res_numero_portas.Name = "res_numero_portas";
            this.res_numero_portas.Size = new System.Drawing.Size(219, 20);
            this.res_numero_portas.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cor do carro";
            // 
            // res_ano_fabricacao
            // 
            this.res_ano_fabricacao.Location = new System.Drawing.Point(16, 142);
            this.res_ano_fabricacao.Name = "res_ano_fabricacao";
            this.res_ano_fabricacao.Size = new System.Drawing.Size(219, 20);
            this.res_ano_fabricacao.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Modelo do carro";
            // 
            // res_cor
            // 
            this.res_cor.Location = new System.Drawing.Point(16, 88);
            this.res_cor.Name = "res_cor";
            this.res_cor.Size = new System.Drawing.Size(219, 20);
            this.res_cor.TabIndex = 2;
            // 
            // res_modelo
            // 
            this.res_modelo.Location = new System.Drawing.Point(16, 37);
            this.res_modelo.Name = "res_modelo";
            this.res_modelo.Size = new System.Drawing.Size(219, 20);
            this.res_modelo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 661);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_numero_portas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ano_fabricacao;
        private System.Windows.Forms.TextBox txt_cor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox res_numero_portas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox res_ano_fabricacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox res_cor;
        private System.Windows.Forms.TextBox res_modelo;
    }
}

