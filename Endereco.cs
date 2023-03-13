using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvOO13032023
{
    internal class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }

        public override string ToString()
        {
            return "Id: " + Id +
                    "\nLogradouro: " + Logradouro +
                    "\nBairro: " + Bairro +
                    "\nNumero: " + Numero +
                    "\nCep: " + Cep;
                    
        }


    }
}
