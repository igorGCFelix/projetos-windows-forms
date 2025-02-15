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
    public partial class cadastrar_funcionario : Form
    {
        public cadastrar_funcionario()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
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
