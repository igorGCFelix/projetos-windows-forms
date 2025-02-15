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
    public partial class login_funcionario : Form
    {
        public login_funcionario()
        {
            InitializeComponent();
        }

        private void login_funcionario_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            operacao_realizada op_realizada = new operacao_realizada();
            op_realizada.Show();
            this.Hide();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            login_cadastro log_cadastro = new login_cadastro();
            log_cadastro.Show();
            this.Hide();

        }
    }
}
