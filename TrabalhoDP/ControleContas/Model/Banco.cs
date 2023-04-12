using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Model
{
    public class Banco
    {
        public string Nome { get; set; }
        public int Numero { get; set; }

        public Banco(string nome, int numero)
        {
            Nome = nome;
            Numero = numero;
        }
    }
}
