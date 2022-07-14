using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCentral.Entities
{
    public enum TiposChave
    {
        email,
        cpf,
        telefone,
        aleatoria
    }

    public class Pix
    {
        public TiposChave Tipo { get; set; }
        public string Chave { get; set; }
        public Pix(string chave, TiposChave tipo = TiposChave.aleatoria)
        {
            Tipo = tipo;
            Chave = chave;
        }
    }
}
