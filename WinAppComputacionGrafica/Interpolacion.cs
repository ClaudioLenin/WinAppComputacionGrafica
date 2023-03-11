using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppComputacionGrafica
{
    class Interpolacion
    {
        public Interpolacion()
        {

        }
        public int colores(double x0, double x1, double y0, double y1, double i)
        {
            int cl = (int)((y0 * ((i - x1) / (x0 - x1))) + (y1 * ((i - x0) / (x1 - x0))));
            if (cl >= 256)
                return 255;
            else
                if (cl <= 0)
                return 0;
            else
                return cl;

        }
        /*
        public static double segmento(double Y0, double Y1, double t)
        {
            return (-(Y0 * (t - 1)) + (Y1 * t));
        }
        public double camino(double X0, double X1, double Y0, double Y1, double i)
        {
            return (double)((Y0 * ((i - X1) / (X0 - X1))) + (Y1 * ((i - X0) / (X1 - X0))));
        }*/
    }
}
