namespace crud_animal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label_id = new Label();
            label7 = new Label();
            txt_id = new TextBox();
            label6 = new Label();
            txt_cor_pele = new TextBox();
            label5 = new Label();
            txt_peso = new TextBox();
            label4 = new Label();
            txt_comprimento = new TextBox();
            label3 = new Label();
            txt_sexo = new TextBox();
            label2 = new Label();
            txt_familia = new TextBox();
            label1 = new Label();
            txt_nome_cientifico = new TextBox();
            txt_nome_comum = new TextBox();
            btn_excluir = new Button();
            btn_salvar = new Button();
            groupBox2 = new GroupBox();
            btn_consultar = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label_id);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txt_id);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_cor_pele);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_peso);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_comprimento);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_sexo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_familia);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_nome_cientifico);
            groupBox1.Controls.Add(txt_nome_comum);
            groupBox1.Controls.Add(btn_excluir);
            groupBox1.Controls.Add(btn_salvar);
            groupBox1.Location = new Point(36, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 587);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulário";
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Location = new Point(29, 457);
            label_id.Name = "label_id";
            label_id.Size = new Size(17, 15);
            label_id.TabIndex = 11;
            label_id.Text = "Id";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 391);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 9;
            label7.Text = "Cor da Pele";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(29, 475);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(276, 23);
            txt_id.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 333);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 7;
            label6.Text = "Peso";
            // 
            // txt_cor_pele
            // 
            txt_cor_pele.Location = new Point(29, 409);
            txt_cor_pele.Name = "txt_cor_pele";
            txt_cor_pele.Size = new Size(276, 23);
            txt_cor_pele.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 272);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 7;
            label5.Text = "Comprimento";
            // 
            // txt_peso
            // 
            txt_peso.Location = new Point(29, 351);
            txt_peso.Name = "txt_peso";
            txt_peso.Size = new Size(276, 23);
            txt_peso.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 211);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 7;
            label4.Text = "Sexo";
            // 
            // txt_comprimento
            // 
            txt_comprimento.Location = new Point(29, 290);
            txt_comprimento.Name = "txt_comprimento";
            txt_comprimento.Size = new Size(276, 23);
            txt_comprimento.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 150);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 7;
            label3.Text = "Família";
            // 
            // txt_sexo
            // 
            txt_sexo.Location = new Point(29, 229);
            txt_sexo.Name = "txt_sexo";
            txt_sexo.Size = new Size(276, 23);
            txt_sexo.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 92);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 7;
            label2.Text = "Nome Cientifico";
            // 
            // txt_familia
            // 
            txt_familia.Location = new Point(29, 168);
            txt_familia.Name = "txt_familia";
            txt_familia.Size = new Size(276, 23);
            txt_familia.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 40);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome Comum";
            // 
            // txt_nome_cientifico
            // 
            txt_nome_cientifico.Location = new Point(29, 110);
            txt_nome_cientifico.Name = "txt_nome_cientifico";
            txt_nome_cientifico.Size = new Size(276, 23);
            txt_nome_cientifico.TabIndex = 6;
            // 
            // txt_nome_comum
            // 
            txt_nome_comum.Location = new Point(29, 58);
            txt_nome_comum.Name = "txt_nome_comum";
            txt_nome_comum.Size = new Size(276, 23);
            txt_nome_comum.TabIndex = 4;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(210, 529);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(95, 37);
            btn_excluir.TabIndex = 3;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(28, 529);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(95, 37);
            btn_salvar.TabIndex = 2;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_consultar);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(428, 34);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(608, 532);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Consulta";
            // 
            // btn_consultar
            // 
            btn_consultar.Location = new Point(257, 467);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(95, 37);
            btn_consultar.TabIndex = 3;
            btn_consultar.Text = "Consultar";
            btn_consultar.UseVisualStyleBackColor = true;
            btn_consultar.Click += btn_consultar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(565, 396);
            dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 701);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_excluir;
        private Button btn_salvar;
        private GroupBox groupBox2;
        private Button btn_consultar;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txt_nome_comum;
        private Label label6;
        private Label label5;
        private TextBox txt_peso;
        private Label label4;
        private TextBox txt_comprimento;
        private Label label3;
        private TextBox txt_sexo;
        private Label label2;
        private TextBox txt_familia;
        private TextBox txt_nome_cientifico;
        private Label label7;
        private TextBox txt_cor_pele;
        private Label label_id;
        private TextBox txt_id;
    }
}
