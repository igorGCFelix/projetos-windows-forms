using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciamento_veiculos
{
    class carro : veiculo
    {
        private int numeroPortas;

        public void setNumeroPortas (int numeroPortas)
        {
            this.numeroPortas = numeroPortas;
        }
        public int getNumeroPortas()
        {
            return this.numeroPortas;
        }
    }
}
