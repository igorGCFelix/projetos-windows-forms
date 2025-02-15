namespace exemplo_encapsulamento
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_mostrar_nome = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_mostrar_cpf = new System.Windows.Forms.Label();
            this.btn_armazenar = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(39, 63);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(178, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(39, 122);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(178, 20);
            this.txt_cpf.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite o CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NOME DO ALUNO:";
            // 
            // lbl_mostrar_nome
            // 
            this.lbl_mostrar_nome.AutoSize = true;
            this.lbl_mostrar_nome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_mostrar_nome.Location = new System.Drawing.Point(144, 178);
            this.lbl_mostrar_nome.Name = "lbl_mostrar_nome";
            this.lbl_mostrar_nome.Size = new System.Drawing.Size(73, 13);
            this.lbl_mostrar_nome.TabIndex = 5;
            this.lbl_mostrar_nome.Text = "Mostrar Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "CPF DO ALUNO:";
            // 
            // lbl_mostrar_cpf
            // 
            this.lbl_mostrar_cpf.AutoSize = true;
            this.lbl_mostrar_cpf.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_mostrar_cpf.Location = new System.Drawing.Point(144, 209);
            this.lbl_mostrar_cpf.Name = "lbl_mostrar_cpf";
            this.lbl_mostrar_cpf.Size = new System.Drawing.Size(65, 13);
            this.lbl_mostrar_cpf.TabIndex = 7;
            this.lbl_mostrar_cpf.Text = "Mostrar CPF";
            // 
            // btn_armazenar
            // 
            this.btn_armazenar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_armazenar.Location = new System.Drawing.Point(274, 52);
            this.btn_armazenar.Name = "btn_armazenar";
            this.btn_armazenar.Size = new System.Drawing.Size(107, 41);
            this.btn_armazenar.TabIndex = 8;
            this.btn_armazenar.Text = "Armazenar em Set";
            this.btn_armazenar.UseVisualStyleBackColor = false;
            this.btn_armazenar.Click += new System.EventHandler(this.btn_armazenar_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_mostrar.Location = new System.Drawing.Point(274, 110);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(107, 43);
            this.btn_mostrar.TabIndex = 9;
            this.btn_mostrar.Text = "Mostrar em Get";
            this.btn_mostrar.UseVisualStyleBackColor = false;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 263);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.btn_armazenar);
            this.Controls.Add(this.lbl_mostrar_cpf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_mostrar_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_mostrar_nome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_mostrar_cpf;
        private System.Windows.Forms.Button btn_armazenar;
        private System.Windows.Forms.Button btn_mostrar;
    }
}

