namespace exemplo_operacao_forms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_numero1 = new System.Windows.Forms.TextBox();
            this.txt_numero2 = new System.Windows.Forms.TextBox();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.btn_divisao = new System.Windows.Forms.Button();
            this.btn_subtracao = new System.Windows.Forms.Button();
            this.btn_multiplicacao = new System.Windows.Forms.Button();
            this.btn_soma = new System.Windows.Forms.Button();
            this.txt_numero3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite o 2° número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Digite o 1° número";
            // 
            // txt_numero1
            // 
            this.txt_numero1.Location = new System.Drawing.Point(33, 53);
            this.txt_numero1.Name = "txt_numero1";
            this.txt_numero1.Size = new System.Drawing.Size(100, 20);
            this.txt_numero1.TabIndex = 4;
            // 
            // txt_numero2
            // 
            this.txt_numero2.Location = new System.Drawing.Point(33, 101);
            this.txt_numero2.Name = "txt_numero2";
            this.txt_numero2.Size = new System.Drawing.Size(100, 20);
            this.txt_numero2.TabIndex = 5;
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(33, 194);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.ReadOnly = true;
            this.txt_resultado.Size = new System.Drawing.Size(100, 20);
            this.txt_resultado.TabIndex = 6;
            // 
            // btn_divisao
            // 
            this.btn_divisao.Image = global::exemplo_operacao_forms.Properties.Resources._1486505258_divide_division_dote_square_81435;
            this.btn_divisao.Location = new System.Drawing.Point(326, 151);
            this.btn_divisao.Name = "btn_divisao";
            this.btn_divisao.Size = new System.Drawing.Size(95, 80);
            this.btn_divisao.TabIndex = 9;
            this.btn_divisao.Text = "Divisão";
            this.btn_divisao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_divisao.UseVisualStyleBackColor = true;
            this.btn_divisao.Click += new System.EventHandler(this.btn_divisao_Click);
            // 
            // btn_subtracao
            // 
            this.btn_subtracao.Image = global::exemplo_operacao_forms.Properties.Resources.icon_subtr;
            this.btn_subtracao.Location = new System.Drawing.Point(326, 37);
            this.btn_subtracao.Name = "btn_subtracao";
            this.btn_subtracao.Size = new System.Drawing.Size(95, 80);
            this.btn_subtracao.TabIndex = 8;
            this.btn_subtracao.Text = "Subtração";
            this.btn_subtracao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_subtracao.UseVisualStyleBackColor = true;
            this.btn_subtracao.Click += new System.EventHandler(this.btn_subtracao_Click);
            // 
            // btn_multiplicacao
            // 
            this.btn_multiplicacao.Image = global::exemplo_operacao_forms.Properties.Resources.xbutton_837491;
            this.btn_multiplicacao.Location = new System.Drawing.Point(181, 151);
            this.btn_multiplicacao.Name = "btn_multiplicacao";
            this.btn_multiplicacao.Size = new System.Drawing.Size(95, 80);
            this.btn_multiplicacao.TabIndex = 7;
            this.btn_multiplicacao.Text = "Multiplicação";
            this.btn_multiplicacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_multiplicacao.UseVisualStyleBackColor = true;
            this.btn_multiplicacao.Click += new System.EventHandler(this.btn_multiplicacao_Click);
            // 
            // btn_soma
            // 
            this.btn_soma.Image = global::exemplo_operacao_forms.Properties.Resources.icon;
            this.btn_soma.Location = new System.Drawing.Point(181, 37);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(95, 80);
            this.btn_soma.TabIndex = 0;
            this.btn_soma.Text = "Somar";
            this.btn_soma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_soma.UseVisualStyleBackColor = true;
            this.btn_soma.Click += new System.EventHandler(this.btn_soma_Click);
            // 
            // txt_numero3
            // 
            this.txt_numero3.Location = new System.Drawing.Point(33, 143);
            this.txt_numero3.Name = "txt_numero3";
            this.txt_numero3.Size = new System.Drawing.Size(100, 20);
            this.txt_numero3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Digite o 3° número";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 621);
            this.Controls.Add(this.txt_numero3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_divisao);
            this.Controls.Add(this.btn_subtracao);
            this.Controls.Add(this.btn_multiplicacao);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.txt_numero2);
            this.Controls.Add(this.txt_numero1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_soma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_numero1;
        private System.Windows.Forms.TextBox txt_numero2;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Button btn_multiplicacao;
        private System.Windows.Forms.Button btn_subtracao;
        private System.Windows.Forms.Button btn_divisao;
        private System.Windows.Forms.TextBox txt_numero3;
        private System.Windows.Forms.Label label4;
    }
}

