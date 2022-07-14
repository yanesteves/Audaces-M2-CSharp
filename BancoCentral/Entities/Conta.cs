using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCentral.Entities
{
    public class Conta
    {
        public string Agencia { get; set; }
        public string NumConta { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public List<Pix> Chaves { get; set; }
        public bool Status { get; set; }

        public Conta(string nome, string numConta, double saldo, List<Pix> chaves, bool status = true)
        {
            Agencia = "3891";            
            Nome = nome;
            Saldo = saldo;
            Chaves = chaves;
            Status = status;
            NumConta = numConta;
        }
    }
}
