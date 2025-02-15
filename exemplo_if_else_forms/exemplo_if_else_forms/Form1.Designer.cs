namespace exemplo_if_else_forms
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
            this.rdb_tarde = new System.Windows.Forms.RadioButton();
            this.rdb_noite = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_manha = new System.Windows.Forms.RadioButton();
            this.btn_escolha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.btn_conferir = new System.Windows.Forms.Button();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdb_tarde
            // 
            this.rdb_tarde.AutoSize = true;
            this.rdb_tarde.Location = new System.Drawing.Point(26, 53);
            this.rdb_tarde.Name = "rdb_tarde";
            this.rdb_tarde.Size = new System.Drawing.Size(53, 17);
            this.rdb_tarde.TabIndex = 1;
            this.rdb_tarde.Text = "Tarde";
            this.rdb_tarde.UseVisualStyleBackColor = true;
            // 
            // rdb_noite
            // 
            this.rdb_noite.AutoSize = true;
            this.rdb_noite.Location = new System.Drawing.Point(26, 76);
            this.rdb_noite.Name = "rdb_noite";
            this.rdb_noite.Size = new System.Drawing.Size(50, 17);
            this.rdb_noite.TabIndex = 2;
            this.rdb_noite.Text = "Noite";
            this.rdb_noite.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_manha);
            this.groupBox1.Controls.Add(this.btn_escolha);
            this.groupBox1.Controls.Add(this.rdb_noite);
            this.groupBox1.Controls.Add(this.rdb_tarde);
            this.groupBox1.Location = new System.Drawing.Point(27, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha o Período";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdb_manha
            // 
            this.rdb_manha.AutoSize = true;
            this.rdb_manha.Location = new System.Drawing.Point(26, 30);
            this.rdb_manha.Name = "rdb_manha";
            this.rdb_manha.Size = new System.Drawing.Size(58, 17);
            this.rdb_manha.TabIndex = 5;
            this.rdb_manha.TabStop = true;
            this.rdb_manha.Text = "Manhã";
            this.rdb_manha.UseVisualStyleBackColor = true;
            // 
            // btn_escolha
            // 
            this.btn_escolha.Location = new System.Drawing.Point(163, 53);
            this.btn_escolha.Name = "btn_escolha";
            this.btn_escolha.Size = new System.Drawing.Size(75, 23);
            this.btn_escolha.TabIndex = 4;
            this.btn_escolha.Text = "Escolher";
            this.btn_escolha.UseVisualStyleBackColor = true;
            this.btn_escolha.Click += new System.EventHandler(this.btn_escolha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite um número";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(36, 182);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 20);
            this.txt_numero.TabIndex = 5;
            // 
            // btn_conferir
            // 
            this.btn_conferir.Location = new System.Drawing.Point(36, 221);
            this.btn_conferir.Name = "btn_conferir";
            this.btn_conferir.Size = new System.Drawing.Size(75, 23);
            this.btn_conferir.TabIndex = 6;
            this.btn_conferir.Text = "Conferir";
            this.btn_conferir.UseVisualStyleBackColor = true;
            this.btn_conferir.Click += new System.EventHandler(this.btn_conferir_Click);
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(153, 182);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.ReadOnly = true;
            this.txt_resultado.Size = new System.Drawing.Size(224, 20);
            this.txt_resultado.TabIndex = 7;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(161, 185);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(55, 13);
            this.lbl_resultado.TabIndex = 8;
            this.lbl_resultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 636);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.btn_conferir);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdb_tarde;
        private System.Windows.Forms.RadioButton rdb_noite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_escolha;
        private System.Windows.Forms.RadioButton rdb_manha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Button btn_conferir;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

