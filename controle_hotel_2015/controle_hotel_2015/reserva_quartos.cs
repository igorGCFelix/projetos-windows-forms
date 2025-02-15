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
    public partial class reserva_quartos : Form
    {
        public reserva_quartos()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            if (cbk_contaSim.Checked)
            {
                operacao_realizada op_realizada = new operacao_realizada();
                op_realizada.Show();
                this.Hide();
            }
            else if (cbk_contaNao.Checked)
            {
                cadastrar_clientes cad_cliente = new cadastrar_clientes();
                cad_cliente.Show();
                this.Hide();
            }
            else
            {
                lbl_selectConta.Visible = true;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            home principal = new home();
            principal.Show();
            this.Hide();

        }

        private void reserva_quartos_Load(object sender, EventArgs e)
        {

        }
    }
}
