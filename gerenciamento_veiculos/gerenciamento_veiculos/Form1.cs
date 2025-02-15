using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerenciamento_veiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        carro cr = new carro();
        private void btn_enviar_Click(object sender, EventArgs e)
        {
            //Pegando as informações
            cr.setModelo(txt_modelo.Text);
            cr.setCor(txt_cor.Text);
            cr.setAnoFabricacao(txt_ano_fabricacao.Text);
            cr.setNumeroPortas(int.Parse(txt_numero_portas.Text));
            
            //Mostrando as informações
            res_modelo.Text = cr.getModelo();
            res_cor.Text = cr.getCor();
            res_ano_fabricacao.Text = cr.getAnoFabricacao();
            res_numero_portas.Text = cr.getNumeroPortas().ToString();
        }
    }
}
