using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public string seq_pix { get; set; }
    }
}
