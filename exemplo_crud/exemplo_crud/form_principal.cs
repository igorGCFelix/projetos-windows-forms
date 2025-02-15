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
    public partial class form_principal : Form
    {
        public form_principal()
        {
            InitializeComponent();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_crud formulario = new form_crud();
            formulario.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            form_crud formulario = new form_crud();
            formulario.Show();
            this.Hide();
        }

        private void voltarÀPáginaAnteriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_login formulario = new form_login();
            formulario.Show();
            this.Hide();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja mesmo sair?","Exemplo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void gestãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja mesmo sair?", "Exemplo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
