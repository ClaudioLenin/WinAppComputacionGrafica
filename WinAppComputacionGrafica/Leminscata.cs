using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppComputacionGrafica
{
    internal class Leminscata
    {
       
        public double x0;
        public double y0;
        public double angulo;
        public Color color0;
        public Bitmap lienzo;
        public PictureBox pbxVentana;

        public Leminscata(double x0, double y0, double angulo, Color color0, Bitmap lienzo, PictureBox pbxVentana)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.angulo = angulo;
            this.color0 = color0;
            this.lienzo = lienzo;
            this.pbxVentana = pbxVentana;
        }
        public void encender()
        {
            Vector V = new Vector(0, 0, color0, lienzo, pbxVentana);
            double t = 0;
            double dt = 0.001;
            do
            {
                V.x0 = x0 + ((6 * Math.Cos(t) - Math.Cos(6 * t)) / 4);
                V.y0 = y0 + ((6 * Math.Sin(t) - Math.Sin(6 * t)) / 4);
                rotar2D(V.x0, V.y0, angulo, out V.x0, out V.y0);
                V.color0 = color0;
                V.encender();
                t = t + dt;
            } while (t <= (2 * Math.PI));
        }
        public void rotar2D(double vx, double vy, double gama, out double rx, out double ry)
        {
            rx = (vx - x0) * Math.Cos(gama) - (vy - y0) * Math.Sin(gama) + x0;
            ry = (vx - x0) * Math.Sin(gama) + (vy - y0) * Math.Cos(gama) + y0;
        }

    }
}
