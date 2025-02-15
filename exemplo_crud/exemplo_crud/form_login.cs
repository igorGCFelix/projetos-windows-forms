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
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja mesmo sair?","Exemplo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_acessar_Click(object sender, EventArgs e)
        {
            string usuario = "admin";
            string senha = "123";

            if(txt_usuario.Text == usuario && txt_senha.Text == senha)
            {
                form_principal formulario = new form_principal();
                formulario.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }
        }
    }
}
