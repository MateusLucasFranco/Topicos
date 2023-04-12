using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Model
{
    public class Agencia
    {
        public int Numero { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public Banco Banco { get; set; }

        public Agencia(string cep, int numero, Banco banco)
        {
            Cep = cep;
            Numero = numero;
            Banco = banco;
        }
    }
}
