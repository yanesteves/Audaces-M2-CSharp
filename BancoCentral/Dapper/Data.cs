using BancoCentral.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCentral.Dapper
{
    public static class Data
    {
        public static List<Conta> contas = new List<Conta>
        {
            new Conta("Yan Esteves", "0000", 4600.90, new List<Pix>{ new Pix("yan.m.esteves@gmail.com", TiposChave.email) }   ),
            new Conta("Júlia Esteves", "0001", 1449.90, new List<Pix>{ new Pix("julia.esteves@gmail.com", TiposChave.email) }   ),
            new Conta("Igor Esteves", "0002", 650.50, new List<Pix>{ new Pix("igor.esteves@gmail.com", TiposChave.email) }   ),
            new Conta("Davi Esteves", "0003", 40.00, new List<Pix>{ new Pix("davi.esteves@gmail.com", TiposChave.email) }   ),
        };
    }
}
