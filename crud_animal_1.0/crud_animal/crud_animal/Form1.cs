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
            }
            finally
            {
                MessageBox.Show("Informações registradas com sucesso.");
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tutu.Consultar();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                tutu.setId(txt_id.Text);
                tutu.excluir();
                dataGridView1.DataSource = tutu.Consultar();
            }
            finally
            {
                MessageBox.Show("Informações excluídas com sucesso");
            }
        }
    }
}
