using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppComputacionGrafica
{
    internal class Curva
    {
        Vector V;

        public Curva(Color color0, Bitmap lienzo, PictureBox pbxVentana)
        {
            V = new Vector(0, 0, color0, lienzo, pbxVentana);
        }
        public void encender()
        {
            double x = -7.14;
            double dx = 0.005;

            do
            {
                V.x0 = x;
                V.y0 = 3 * Math.Sin(x / 2);
                V.encender();
                x = x + dx;
            } while (x <= 7.14);
            /*
           
            //DE ORO
            double a = ((1 + Math.Sqrt(5)) / 2);
            
            x = 0;
            do
            {
                //V.x0 = x0 + radio * ((Math.Pow(a, x) - Math.Pow((1 - a), x)) / (Math.Sqrt(5)));
                V.x0 = (Math.Pow(a, x) - Math.Pow((1 - a), x)) / (Math.Sqrt(5));
                V.y0 = x;
                rotar2D(V.x0, V.y0, angulo, out V.x0, out V.y0);
                V.encender();
                x = x + 0.1;
            } while (x <= 200);

            if (Tipo == 15)
            {
                x = 4.5 * Math.PI;
                dx = 0.00055;
                do
                {

                    //C.X0 = X0 + Radio * (((36 + 5) * (Math.Cos(x))) - (6 * (Math.Sin(x * (1 + (7.2 * x))))));
                    //C.Y0 = Y0 + Radio * (((36 + 5) * (Math.Sin(x))) - (6 * (Math.Cos(x * (1 + (7.2 * x))))));
                    //C.X0 = X0 + Radio * (((36 + 5) * (Math.Cos(x))) - (6 * (Math.Sin(x * (1 + (7.2 * x))))));
                    //C.Y0 = Y0 + Radio * (((36 + 5) * (Math.Pow(x,0.03))) - (6 * (Math.Cos(x * (1 + (7.2 * x))))));
                    V.X0 = X0 + Radio * (((36 + 5) * (Math.Cos(x * Math.PI / 0.1))) - (6 * (Math.Sin(x * (1 + (7.2 * x / 0.4))))));
                    V.Y0 = Y0 + Radio * (((36 + 5) * (Math.Sin(x * Math.PI / 0.1))) - (6 * (Math.Cos(x * (1 + (7.2 * x / 0.4))))));
                    rotar1(V.X0, V.Y0, angulo, out V.X0, out V.Y0);
                    V.Encender();
                    Radio = Radio - 0.00001;
                    x = x + dx;
                    //} while (x <= 7.9 * Math.PI);
                } while (x <= 5.9 * Math.PI);
            }
           */
        }

    }
}
