using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace crud_animal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        tubarao tutu = new tubarao();

        public void exibirRegistro(int i)
        {
            txt_id.Text = "" + dataGridView1[0, i].Value;
            txt_nome_comum.Text = "" + dataGridView1[1, i].Value;
            txt_nome_cientifico.Text = "" + dataGridView1[2, i].Value;
            txt_familia.Text = "" + dataGridView1[3, i].Value;
            txt_sexo.Text = "" + dataGridView1[4, i].Value;
            txt_comprimento.Text = "" + dataGridView1[5, i].Value;
            txt_peso.Text = "" + dataGridView1[6, i].Value;
            txt_cor_pele.Text = "" + dataGridView1[7, i].Value;
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                tutu.setNomeComum(txt_nome_comum.Text);
                tutu.setNomeCientifico(txt_nome_cientifico.Text);
                tutu.setFamilia(txt_familia.Text);
                tutu.setSexo(txt_sexo.Text);
                tutu.setComprimento(Convert.ToDouble(txt_comprimento.Text));
                tutu.setPeso(Convert.ToDouble(txt_peso.Text));
                tutu.setCorPele(txt_cor_pele.Text);
                tutu.setId(txt_id.Text);
                //Método inserir
                tutu.inserir();
                dataGridView1.DataSource = tutu.Consultar();
                dataGridView1.Columns["nomeComum"].HeaderText = "Nome";
                dataGridView1.Columns["nomeCientifico"].HeaderText = "Nome Científico";
                dataGridView1.Columns["familia"].HeaderText = "Família";
                dataGridView1.Columns["sexo"].HeaderText = "Sexo";
                dataGridView1.Columns["comprimento"].HeaderText = "Comprimento";
                dataGridView1.Columns["peso"].HeaderText = "Peso";
                dataGridView1.Columns["corPele"].HeaderText = "Cor de Pele";
                dataGridView1.Columns["id"].HeaderText = "ID";
            }
            finally
            {
                MessageBox.Show("Informações registradas com sucesso.");
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tutu.Consultar();
            dataGridView1.Columns["nomeComum"].HeaderText = "Nome";
            dataGridView1.Columns["nomeCientifico"].HeaderText = "Nome Científico";
            dataGridView1.Columns["familia"].HeaderText = "Família";
            dataGridView1.Columns["sexo"].HeaderText = "Sexo";
            dataGridView1.Columns["comprimento"].HeaderText = "Comprimento";
            dataGridView1.Columns["peso"].HeaderText = "Peso";
            dataGridView1.Columns["corPele"].HeaderText = "Cor de Pele";
            dataGridView1.Columns["id"].HeaderText = "ID";
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                tutu.setId(txt_id.Text);
                tutu.excluir();
                dataGridView1.DataSource = tutu.Consultar();
                dataGridView1.Columns["nomeComum"].HeaderText = "Nome";
                dataGridView1.Columns["nomeCientifico"].HeaderText = "Nome Científico";
                dataGridView1.Columns["familia"].HeaderText = "Família";
                dataGridView1.Columns["sexo"].HeaderText = "Sexo";
                dataGridView1.Columns["comprimento"].HeaderText = "Comprimento";
                dataGridView1.Columns["peso"].HeaderText = "Peso";
                dataGridView1.Columns["corPele"].HeaderText = "Cor de Pele";
                dataGridView1.Columns["id"].HeaderText = "ID";
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
                tutu.setNomeComum(txt_nome_comum.Text);
                tutu.setNomeCientifico(txt_nome_cientifico.Text);
                tutu.setFamilia(txt_familia.Text);
                tutu.setSexo(txt_sexo.Text);
                tutu.setComprimento(Convert.ToDouble(txt_comprimento.Text));
                tutu.setPeso(Convert.ToDouble(txt_peso.Text));
                tutu.setCorPele(txt_cor_pele.Text);
                tutu.setId(txt_id.Text);
                tutu.alterar();
                dataGridView1.DataSource = tutu.Consultar();
                dataGridView1.Columns["nomeComum"].HeaderText = "Nome";
                dataGridView1.Columns["nomeCientifico"].HeaderText = "Nome Científico";
                dataGridView1.Columns["familia"].HeaderText = "Família";
                dataGridView1.Columns["sexo"].HeaderText = "Sexo";
                dataGridView1.Columns["comprimento"].HeaderText = "Comprimento";
                dataGridView1.Columns["peso"].HeaderText = "Peso";
                dataGridView1.Columns["corPele"].HeaderText = "Cor de Pele";
                dataGridView1.Columns["id"].HeaderText = "ID";
            }
            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            exibirRegistro(dataGridView1.CurrentRow.Index);
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome_comum.Text = "";
            txt_nome_cientifico.Text = "";
            txt_familia.Text = "";
            txt_sexo.Text = "";
            txt_comprimento.Text = "";
            txt_peso.Text = "";
            txt_cor_pele.Text = "";
            txt_id.Text = "";
        }
    }
}
