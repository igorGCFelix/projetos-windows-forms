using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_operacao_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            //Declaração de Variavel
            double n1, n2,n3, soma;
            n1 = double.Parse(txt_numero1.Text);
            n2 = double.Parse(txt_numero2.Text);
            n3 = double.Parse(txt_numero3.Text);
            soma = n1 + n2 + n3;
            //Exibição do resultado na caixa de texto
            txt_resultado.Text = soma.ToString();
            //ToString converte o valor de variavel para texto
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, subt;
            n1 = double.Parse(txt_numero1.Text);
            n2 = double.Parse(txt_numero2.Text);
            n3 = double.Parse(txt_numero3.Text);
            subt = n1 - n2 - n3;
            txt_resultado.Text = subt.ToString();
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            double n1, n2,n3, mult;
            n1 = double.Parse(txt_numero1.Text);
            n2 = double.Parse(txt_numero2.Text);
            n3 = double.Parse(txt_numero3.Text);
            mult = n1 * n2 * n3;
            txt_resultado.Text = mult.ToString();
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            double n1, n2,n3, divisao;
            n1 = double.Parse(txt_numero1.Text);
            n2 = double.Parse(txt_numero2.Text);
            n3 = double.Parse(txt_numero3.Text);
            divisao = n1 / n2 / n3;
            txt_resultado.Text = divisao.ToString();
        }
    }
}
