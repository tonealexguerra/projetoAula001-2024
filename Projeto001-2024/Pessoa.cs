using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Projeto001_2024
{
    internal class Pessoa
    {
        public string nome;
        private int idade;
        private int anoNascimento;

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }

        public int getIdade()
        {
            return this.idade;
        }
        public void setIdade(int idade)
        {
            this.idade = idade;
            this.anoNascimento = 2024 - idade;
        }

        public int getAnoNascimento()
        {
            return this.anoNascimento;
        }

        public ArrayList getDados()
        {
            ArrayList dados = new ArrayList();
            dados.Add(this.nome);
            dados.Add(this.idade);
            dados.Add(this.anoNascimento);

            return dados;
        }
    }
}
