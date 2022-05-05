using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP4
{
    internal class Circulo : Forma
    {
        public double radio { get; set; }
        public Ubicacion c { get; set; }

        public Circulo(double radio)
        {
            this.radio = radio;
            this.c = new Ubicacion(0,0);
        }

        public Circulo(double radio,double x,double y)
        {
            this.radio = radio;
            this.c = new Ubicacion(x,y);
        }

        public double area()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public double perimetro()
        {
            return 2 * Math.PI * this.radio;
        }

        public override string ToString()
        {
            return "circulo: \nel radio es: " + this.radio + "\nla ubicacion es: " + c.ToString();
        }

    }
}
