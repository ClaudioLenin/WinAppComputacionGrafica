using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppComputacionGrafica
{
    internal class Flor
    {
        public double x0;
        public double y0;
        public double radio;
        public double angulo;
        public Color color0;
        public Bitmap lienzo;
        public PictureBox pbxVentana;

        public Flor(double x0, double y0, double radio, double angulo, Color color0, Bitmap lienzo, PictureBox pbxVentana)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.radio = radio;
            this.angulo = angulo;
            this.color0 = color0;
            this.lienzo = lienzo;
            this.pbxVentana = pbxVentana;
        }
        public void encender()
        {
            double x = 4.5 * Math.PI;
            double dx = 0.00055;
            Vector V = new Vector(0, 0, color0, lienzo, pbxVentana);

            do
            {

                //C.X0 = X0 + Radio * (((36 + 5) * (Math.Cos(x))) - (6 * (Math.Sin(x * (1 + (7.2 * x))))));
                //C.Y0 = Y0 + Radio * (((36 + 5) * (Math.Sin(x))) - (6 * (Math.Cos(x * (1 + (7.2 * x))))));
                //C.X0 = X0 + Radio * (((36 + 5) * (Math.Cos(x))) - (6 * (Math.Sin(x * (1 + (7.2 * x))))));
                //C.Y0 = Y0 + Radio * (((36 + 5) * (Math.Pow(x,0.03))) - (6 * (Math.Cos(x * (1 + (7.2 * x))))));
                V.x0 = x0 + radio * (((36 + 5) * (Math.Cos(x * Math.PI / 0.1))) - (6 * (Math.Sin(x * (1 + (7.2 * x / 0.4))))));
                V.y0 = y0 + radio * (((36 + 5) * (Math.Sin(x * Math.PI / 0.1))) - (6 * (Math.Cos(x * (1 + (7.2 * x / 0.4))))));
                rotar2D(V.x0, V.y0, angulo, out V.x0, out V.y0);
                V.encender();
                radio = radio - 0.00001;
                x = x + dx;
                //} while (x <= 7.9 * Math.PI);
            } while (x <= 5.9 * Math.PI);
        }
        public void rotar2D(double vx, double vy, double gama, out double rx, out double ry)
        {
            rx = (vx - x0) * Math.Cos(gama) - (vy - y0) * Math.Sin(gama) + x0;
            ry = (vx - x0) * Math.Sin(gama) + (vy - y0) * Math.Cos(gama) + y0;
        }
    }
}
