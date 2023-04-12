using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Model
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public int AnoNascimento { get; private set; }

        public Cliente(string nome, string cpf, int ano)
        {
            Nome = nome;
            if ((2022 - ano) >= 18)
                AnoNascimento = ano;
            else
                throw new ArgumentOutOfRangeException("Cliente deve ter no mínimo mais de 18 anos");
        
            if (cpf.Length == 11)
                Cpf = cpf;
            else
                throw new ArgumentOutOfRangeException("CPF deve ter no máximo 11 dígitos");
        }

    }
}
