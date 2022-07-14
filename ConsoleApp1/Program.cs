using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    #region herança
    class Veiculo
    {
        public string Modelo { get; set; }
        public string Cor { get; set; }

        public virtual void Mover()
        {
            Console.WriteLine("O veículo está se movendo");
        }
    }

    class Carro : Veiculo
    {
        public string chassi { get; set; }
        public string proprietario { get; set; }
        public override void Mover()
        {
            Console.WriteLine("Acelerando");
        }
    }

    #endregion

    #region composição
    public class Quarto
    {
        public string Descricao()
        {
            return "Quarto";
        }
    }

    public class Cozinha
    {
        public string Descricao()
        {
            return "Cozinha";
        }
    }
    public class Casa
    {
        public Quarto quarto;
        public Cozinha cozinha;

        public string proprietario { get; set; }

        public Casa(Quarto _quarto, Cozinha _cozinha)
        {
            quarto = _quarto;
            cozinha = _cozinha;
        }
    }

    #endregion


    class Tanque
    {
        double t_radius;
        double t_height;
        public Tank(double r, double h)
        {
            Radius = r;
            Height = h;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo composição
            /*
            var quarto1 = new Quarto();
            var cozinha1 = new Cozinha();
            Casa casa1 = new Casa(quarto1, cozinha1);
            casa1.quarto.Descricao();
             */

            // Exemplo herança
            Carro vw = new Carro();
            vw.Cor = "Azul";
            vw.Modelo = "Fusca";
            vw.chassi = "ABC123";
            vw.proprietario = "Yan";
            vw.Mover();
            Console.ReadKey();
        }
    }
}
