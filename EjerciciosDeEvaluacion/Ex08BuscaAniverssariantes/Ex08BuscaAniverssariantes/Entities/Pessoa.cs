using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08BuscaAniverssariantes.Entities
{
    internal class Pessoa
    {
        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }

        public Pessoa(string nome, DateTime dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        public override string ToString() => $"{Nome} - {DataNascimento.ToShortDateString()}";
    }
}
