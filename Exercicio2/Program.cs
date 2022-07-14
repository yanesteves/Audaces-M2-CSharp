using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Produto> produtos = criarBase();
            while (true)
            {                
                Console.WriteLine("\n\n--- Loja X --- \n\n\n1 - Vender produtos\n2 - Cadastrar Produtos\n3 - Listar Produtos\n4 - Sair\n\n");
                var key = Console.ReadKey();
                // Console.Clear();
                if (key.Key == ConsoleKey.D1)
                {
                    venderProduto();
                    continue;
                } 
                
                if (key.Key == ConsoleKey.D2)
                {
                    cadastrarProduto();
                    continue;
                }
                
                if (key.Key == ConsoleKey.D3)
                {
                    listarItens(produtos);
                    continue;
                }

                break;

            }

            Console.Read();
        }

        static void venderProduto()
        {
            Console.WriteLine("Informe o ID");
            var key = Console.ReadKey();

        }

        static void cadastrarProduto()
        {

        }

        static void listarItens(IList<Produto> produtos)
        {
            Console.WriteLine("======= Lista de Produtos =======");
            foreach (var item in produtos)
            {
                Console.WriteLine(item);
            }
        }

        static IList<Produto> criarBase()
        {
            return new List<Produto> 
            {
                new Produto(0, "Smartphone A", 2700.0, 15, Tipo.Eletronico),
                new Produto(1, "Smartphone B", 4500.0, 10, Tipo.Eletronico),
                new Produto(2, "Air Force 1", 749.0, 27, Tipo.Calcado),
                new Produto(3, "Perfume A", 249.0, 10, Tipo.Perfumaria),
                new Produto(4, "Perfume B", 649.0, 12, Tipo.Perfumaria),
            };
        }
        
        class Produto
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public double Preco { get; set; }
            public int Quantidade { get; set; }
            public double Faturamento { get; set; }
            public Tipo Tipo { get; set; }
            public Produto(int id, string nome, double preco, int quantidade, Tipo tipo)
            {                
                Id = new Random().Next();
                Nome = nome;
                Preco = preco;
                Quantidade = quantidade;
                Tipo = tipo;
                Faturamento = 0;
            }

            public void Vender(int qtdVendidos = 1)
            {
                Faturamento = Faturamento + qtdVendidos * Preco;
                Quantidade -= qtdVendidos;
            }

            public override string ToString()
            {
                return $"ID: {Id} - {Nome} - {Quantidade} - R${Preco}";
            }
        }

        enum Tipo
        {
            Calcado,            
            Eletronico,
            Eletrodomestico,
            Perfumaria
        }      
    }
}
