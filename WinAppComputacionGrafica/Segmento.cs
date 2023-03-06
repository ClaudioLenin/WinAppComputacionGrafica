using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppComputacionGrafica
{
    class Segmento : Vector
    {
        public double x0;
        public double y0;
        public double xf;
        public double yf;

        public Segmento(double x0, double y0, double xf, double yf, Color color0, Bitmap lienzo, PictureBox pbxVentana) : base(x0, y0, color0, lienzo, pbxVentana)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.xf = xf;
            this.yf = yf;
        }
        public override void encender()
        {
            double t = 0;
            double dt = 0.0013;
            Vector v = new Vector(0, 0, color0, lienzo, pbxVentana);
            do
            {
                v.x0 = x0 * (1 - t) + xf * t;
                v.y0 = y0 * (1 - t) + yf * t;
                v.encender();
                t = t + dt;

            } while (t <= 1);
        }
        public override void apagar()
        {
            this.color0 = Color.White;
            encender();
        }
        ~Segmento()
        {
        }
    }
}
