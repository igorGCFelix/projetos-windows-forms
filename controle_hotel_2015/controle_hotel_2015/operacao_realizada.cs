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
    public partial class operacao_realizada : Form
    {
        public operacao_realizada()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            home principal = new home();
            principal.Show();
            this.Hide();
        }
    }
}
