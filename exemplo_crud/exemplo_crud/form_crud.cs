using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_crud
{
    public partial class form_crud : Form
    {
        public form_crud()
        {
            InitializeComponent();
        }
        colaborador c = new colaborador();

        public void exibirRegistro(int i)
        {
            txt_codigo.Text = " " + dataGridView1[0, i].Value;
            txt_cpf.Text = " " + dataGridView1[3, i].Value;
            txt_nome.Text = " " + dataGridView1[1, i].Value;
            txt_sobrenome.Text = " " + dataGridView1[2, i].Value;
        }







        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                c.setCpf(txt_cpf.Text);
                c.setNome(txt_nome.Text);
                c.setSobreNome(txt_sobrenome.Text);
                //Chamar o método inserir
                c.inserir();
                dataGridView1.DataSource = c.Consultar();
                dataGridView1.Columns["nome_colaborador"].HeaderText = "Nome";
                dataGridView1.Columns["cpf_colaborador"].HeaderText = "CPF";
                dataGridView1.Columns["codigo_colaborador"].HeaderText = "Codigo";
                dataGridView1.Columns["sobrenome_colaborador"].HeaderText = "Sobrenome";
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso");
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.Consultar();
            //Alteração dos nomes das colunas do datagridview
            dataGridView1.Columns["nome_colaborador"].HeaderText = "Nome";
            dataGridView1.Columns["cpf_colaborador"].HeaderText = "CPF";
            dataGridView1.Columns["codigo_colaborador"].HeaderText = "Codigo";
            dataGridView1.Columns["sobrenome_colaborador"].HeaderText = "Sobrenome";
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                c.setCodigo(txt_codigo.Text);
                c.excluir();
                dataGridView1.DataSource = c.Consultar();
                dataGridView1.Columns["nome_colaborador"].HeaderText = "Nome";
                dataGridView1.Columns["cpf_colaborador"].HeaderText = "CPF";
                dataGridView1.Columns["codigo_colaborador"].HeaderText = "Codigo";
                dataGridView1.Columns["sobrenome_colaborador"].HeaderText = "Sobrenome";
            }
            finally
            {
                MessageBox.Show("Informações excluídas com sucesso");
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                //Adicionar o código
                c.setCodigo(txt_codigo.Text);
                c.setCpf(txt_cpf.Text);
                c.setNome(txt_nome.Text);
                c.setSobreNome(txt_sobrenome.Text);
                //Chamar o método alterar
                c.alterar();
                dataGridView1.DataSource = c.Consultar();
                dataGridView1.Columns["nome_colaborador"].HeaderText = "Nome";
                dataGridView1.Columns["cpf_colaborador"].HeaderText = "CPF";
                dataGridView1.Columns["codigo_colaborador"].HeaderText = "Codigo";
                dataGridView1.Columns["sobrenome_colaborador"].HeaderText = "Sobrenome";
            }
            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_nome.Text = "";
            txt_sobrenome.Text = "";
            txt_cpf.Text = "";
         }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            exibirRegistro(dataGridView1.CurrentRow.Index);
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_principal formulario = new form_principal();
            formulario.Show();
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja mesmo sair?", "Exemplo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
