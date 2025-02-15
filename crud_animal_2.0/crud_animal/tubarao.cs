using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace crud_animal
{
    internal class tubarao : conexao
    {
        private string nomeComum;
        private string nomeCientifico;
        private string familia;
        private string sexo;
        private double comprimento;
        private double peso;
        private string corPele;
        private string id;

        // ID
        public void setId(string id)
        {
            this.id = id;
        }
        public string getId()
        {
            return this.id;
        }

        // Nome Comum
        public void setNomeComum(string nomeComum)
        {
            this.nomeComum = nomeComum;
        }
        public string getNomeComum()
        {
            return this.nomeComum;
        }

        // Nome Científico
        public void setNomeCientifico(string nomeCientifico)
        {
            this.nomeCientifico = nomeCientifico;
        }
        public string getNomeCientifico()
        {
            return this.nomeCientifico;
        }

        // Família
        public void setFamilia(string familia)
        {
            this.familia = familia;
        }
        public string getFamilia()
        {
            return this.familia;
        }

        // Sexo
        public void setSexo(string sexo)
        {
            this.sexo = sexo;
        }
        public string getSexo()
        {
            return this.sexo;
        }

        // Comprimento
        public void setComprimento(double comprimento)
        {
            this.comprimento = comprimento;
        }
        public double getComprimento()
        {
            return this.comprimento;
        }

        // Peso
        public void setPeso(double peso)
        {
            this.peso = peso;
        }
        public double getPeso()
        {
            return this.peso;
        }

        // Cor da Pele
        public void setCorPele(string corPele)
        {
            this.corPele = corPele;
        }
        public string getCorPele()
        {
            return this.corPele;
        }

        // Método inserir()
        public void inserir()
        {
            string query = "INSERT INTO tubarao (nomeComum, nomeCientifico, familia, sexo, comprimento, peso, corPele) " +
                           "VALUES (@nomeComum, @nomeCientifico, @familia, @sexo, @comprimento, @peso, @corPele)";

            if (this.abrirconexao())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conectar))
                {
                    cmd.Parameters.AddWithValue("@nomeComum", getNomeComum());
                    cmd.Parameters.AddWithValue("@nomeCientifico", getNomeCientifico());
                    cmd.Parameters.AddWithValue("@familia", getFamilia());
                    cmd.Parameters.AddWithValue("@sexo", getSexo());
                    cmd.Parameters.AddWithValue("@comprimento", getComprimento());
                    cmd.Parameters.AddWithValue("@peso", getPeso());
                    cmd.Parameters.AddWithValue("@corPele", getCorPele());

                    cmd.ExecuteNonQuery();
                }
                this.fecharconexao();
            }
        }

        // Método excluir()
        public void excluir()
        {
            string query = "DELETE FROM tubarao WHERE id = @id";
            if (this.abrirconexao())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conectar))
                {
                    cmd.Parameters.AddWithValue("@id", getId());
                    cmd.ExecuteNonQuery();
                }
                this.fecharconexao();
            }
        }

        // Método para visualizar os dados
        public DataTable Consultar()
        {
            DataTable dt = new DataTable();
            string mSQL = "SELECT * FROM tubarao";

            if (this.abrirconexao())
            {
                using (MySqlCommand cmd = new MySqlCommand(mSQL, conectar))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                this.fecharconexao();
            }

            return dt;
        }

        public void alterar()
        {
            string query = "update tubarao set nomeComum = '" + getNomeComum() + "', nomeCientifico = '" + getNomeCientifico() + "', familia = '" + getFamilia() + "', sexo = '" + getSexo() + "', comprimento = '" + getComprimento() + "', peso = '" + getPeso() + "', corPele = '" + getCorPele() + "' where id = '" + getId() + "'";
            if(this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
    }
}

