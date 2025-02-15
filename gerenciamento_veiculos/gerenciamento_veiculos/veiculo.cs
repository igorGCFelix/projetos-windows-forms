using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciamento_veiculos
{
    class veiculo
    {
        private string modelo;
        private string cor;
        private string anoFabricacao;

        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string getModelo()
        {
            return this.modelo;
        }
        //----
        public void setCor(string cor)
        {
            this.cor = cor;
        }
        public string getCor()
        {
            return this.cor;
        }
        //----
        public void setAnoFabricacao(string anoFabricacao)
        {
            this.anoFabricacao = anoFabricacao;
        }
        public string getAnoFabricacao()
        {
            return this.anoFabricacao;
        }

    }
}
