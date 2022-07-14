using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public abstract class Forma
    {
        private double _area;
        private double _cor;
        private double _perimetro;

        public double Cor
        {
            get { return _cor; }
            set { _cor = value; }
        }

        public double Area
        {
            get { return _area; }
            set { _cor = value; }
        }

        public double Perimetro
        {
            get { return _perimetro; }
            set { _cor = value; }
        }
    }

    public class Quadrado : Forma
    {
        private double lado;

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }
       
        public void CalcularPerimetro()
        {
            this.Perimetro = 4 * lado;
        }

        public void CalcularArea()
        {
            this.Area = lado * lado;
        }
    }

}
