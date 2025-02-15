using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_hotel
{
    public partial class login_cadastro : Form
    {
        public login_cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login_funcionario log_funcionario = new login_funcionario();
            log_funcionario.Show();
            this.Hide();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            cadastrar_funcionario cad_funcionario = new cadastrar_funcionario();
            cad_funcionario.Show();
            this.Hide();
        }
    }
}
