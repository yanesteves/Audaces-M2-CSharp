using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // var numeros = new List<int> { 1, 2, 3, 4 };
            var alunos = criarDados();
            var filtrado = alunos.Where(item => item.Nome.Contains("J"));
            foreach (var aluno in filtrado)
            {
                Console.WriteLine(aluno);
            }

            Console.Read();
        }        

         static IList<Aluno> criarDados()
         {
            return new List<Aluno>
            {
                new Aluno("Yan", 28),
                new Aluno("Renan", 29),
                new Aluno("Maicon", 36),
                new Aluno("Júlia", 22),
            };
         }
    }

    class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Aluno(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} | Idade: {Idade}";
        }
    }
}
 