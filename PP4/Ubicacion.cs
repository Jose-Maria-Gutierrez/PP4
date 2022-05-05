using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP4
{
    internal class Ubicacion
    {
        private double _x;
        private double _y;

        public double X
        {
            get { return _x; }
        }
        public double Y
        {
            get { return _y; }
        }

        public Ubicacion(double x,double y)
        {
            this._x = x;
            this._y = y;   
        }

        public override string ToString()
        {
            return "x: " + this.X + " y: " + this.Y;
        }


    }
}
