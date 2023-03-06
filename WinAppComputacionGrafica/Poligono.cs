using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppComputacionGrafica
{
    internal class Poligono : Circunferencia
    {
        public int nl = 0;
        public double angulo = 0;
        public Poligono(double x0, double y0, double radio, int nl, Color color0, Bitmap lienzo, PictureBox pbxVentana)
            : base(x0, y0, radio, color0, lienzo, pbxVentana)
        {
            this.nl = nl;
        }
        public override void encender()
        {
            double t = Math.PI / 2;
            double dt = (2 * Math.PI) / nl;
            Segmento S = new Segmento(0, 0, 0, 0, color0, lienzo, pbxVentana);
            do
            {
                S.x0 = x0 + radio * Math.Cos(t);
                S.y0 = y0 + radio * Math.Sin(t);
                S.xf = x0 + radio * Math.Cos(t + dt);
                S.yf = y0 + radio * Math.Sin(t + dt);
                rotar2D(S.x0, S.y0, angulo, out S.x0, out S.y0); //quitar esto para poligono normal
                rotar2D(S.xf, S.yf, angulo, out S.xf, out S.yf); //quitar esto para poligono normal
                S.encender();
                t = t + dt;
            } while (t <= 2.5 * Math.PI);

        }
        public void rotar2D(double vx, double vy, double gama, out double rx, out double ry)
        {
            rx = (vx - x0) * Math.Cos(gama) - (vy - y0) * Math.Sin(gama) + x0;
            ry = (vx - x0) * Math.Sin(gama) + (vy - y0) * Math.Cos(gama) + y0;
        }
    }
}
