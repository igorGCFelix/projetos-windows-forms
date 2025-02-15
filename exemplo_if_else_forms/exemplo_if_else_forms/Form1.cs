using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_if_else_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_escolha_Click(object sender, EventArgs e)
        {
            if (rdb_manha.Checked == true)
            {
                MessageBox.Show("Você escolheu manhã");
            }
            else if (rdb_tarde.Checked == true)
            {
                MessageBox.Show("Você escolheu tarde");
            }
            else if (rdb_noite.Checked == true)
            {
                MessageBox.Show("Você escolheu noite");
            }
            else
            {
                MessageBox.Show("Escolha um dos periodos");
            }
        }

        private void btn_conferir_Click(object sender, EventArgs e)
        {
            int numero;
            numero = int.Parse(txt_numero.Text);
            if (numero >= 10)
            {
                lbl_resultado.Text = "Número maior ou igual a 10.";
                lbl_resultado.ForeColor = Color.Blue;
            }
            else
            {
                lbl_resultado.Text = "Número menor que 10";
                lbl_resultado.ForeColor = Color.Red;
            }

        }
    }
}
