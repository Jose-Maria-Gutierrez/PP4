using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP4
{
    internal class Rectangulo : Forma
    {
        public double _lado1 { get; set; }
        public double _lado2 { get; set; }
        public Ubicacion c { get; set; }

        public Rectangulo(double lado1,double lado2)
        {
            this._lado1 = lado1;
            this._lado2 = lado2;
            this.c = new Ubicacion(0, 0);
        }
        public Rectangulo(double lado1, double lado2,double x,double y)
        {
            this._lado1 = lado1;
            this._lado2 = lado2;
            this.c = new Ubicacion(x, y);
        }

        public double area()
        {
            return _lado1 * _lado2;
        }

        public double perimetro()
        {
            return _lado1 * 2 + _lado2 * 2;
        }

        public override string ToString()
        {
            return "rectangulo: \nlado 1: " + this._lado1 + " lado 2: " + this._lado2 + "\nla ubicacion es: " + c.ToString();
        }
    }
}
