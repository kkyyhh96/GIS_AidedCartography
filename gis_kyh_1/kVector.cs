using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gis_kyh_1
{
    public class kVector
    {
        public double x1 { set; get; }
        public double y1 { set; get; }
        public double x2 { set; get; }
        public double y2 { set; get; }

        public double X { set; get; }
        public double Y { set; get; }

        public double Module { get { return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2)); } }

        public kVector(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public kVector(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.X = x2 - x1;
            this.Y = y2 - y1;
        }

        public kVector eVector()
        {
            return new gis_kyh_1.kVector(X / Module, Y / Module);
        }
    }
}
