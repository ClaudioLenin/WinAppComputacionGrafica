using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppComputacionGrafica
{
    internal class Lazo
    {
        public double x0;
        public double y0;
        public double radio;
        public double angulo;
        public Color color0;
        public Bitmap lienzo;
        public PictureBox pbxVentana;

        public Lazo(double x0, double y0, double radio, double angulo, Color color0, Bitmap lienzo, PictureBox pbxVentana)
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
            double x = -7.14;
            double dx = 0.005;
            Vector V = new Vector(0, 0, color0, lienzo, pbxVentana);

            do
            {
                V.x0 = x0 + radio * Math.Sin(2 * x);
                V.y0 = y0 + radio * Math.Cos(3 * x);
                rotar2D(V.x0, V.y0, angulo, out V.x0, out V.y0);
                V.encender();
                x = x + dx;
            } while (x <= 2 * Math.PI);

        }
        public void rotar2D(double vx, double vy, double gama, out double rx, out double ry)
        {
            rx = (vx - x0) * Math.Cos(gama) - (vy - y0) * Math.Sin(gama) + x0;
            ry = (vx - x0) * Math.Sin(gama) + (vy - y0) * Math.Cos(gama) + y0;
        }
    }
}
