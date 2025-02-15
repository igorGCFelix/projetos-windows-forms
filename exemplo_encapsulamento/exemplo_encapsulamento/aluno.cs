using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_encapsulamento
{
    class aluno
    {
        //Criar Atributo
        private string nome;
        private string cpf;
        //A cada atributo é necessário criar dois métodos (get e set)

        //Método sem retorno possui a palavra void e não possui a palavra return
        //O nome do método deve ser set + o nome do atributo com a primeira palavra em maísculo (setNome)
        //O método set serve para receber valores digitados pelo usuário.
        //Os valores digitados pelo usuário é armazenado no parâmetro (string nome) e repassado ao atributo.
        public void setNome(string nome) {
            this.nome = nome;
        }

        //2° Método
        //Método com retorno, o tipo do método deve ser do mesmo tipo do atributo aque ele está ligado.
        //O nome do método deverá ser get + o nome do atributo com a 1° letra em maíuscula (getNome)
        //Método get serve para mostrar valores ao usuário armazenado dentro do método set. 
        public string getNome() {
            return this.nome;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string getCpf() {
            return this.cpf;
        }
            
    }
}
