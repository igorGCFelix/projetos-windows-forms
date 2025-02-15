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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void btn_cadastrarQuarto_Click(object sender, EventArgs e)
        {
            cadastro_quartos cad_quarto = new cadastro_quartos();
            cad_quarto.Show();
            this.Hide();
        }

        private void btn_reservaQuartos_Click(object sender, EventArgs e)
        {
            reserva_quartos res_quarto = new reserva_quartos();
            res_quarto.Show();
        }

        private void btn_cadastroCliente_Click(object sender, EventArgs e)
        {
            cadastrar_clientes cad_cliente = new cadastrar_clientes();
            cad_cliente.Show();
            this.Hide();
        }

        private void btn_controleQuarto_Click(object sender, EventArgs e)
        {
            controle_quartos contr_quarto = new controle_quartos();
            contr_quarto.Show();
            this.Hide();
        }

        private void arrow_voltar_Click(object sender, EventArgs e)
        {
            login_cadastro log_cadastro = new login_cadastro();
            log_cadastro.Show();
            this.Hide();
        }
    }
}
