using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppComputacionGrafica
{
    internal class Circunferencia :Vector
    {
        public double radio;

        public Circunferencia(double x0,double y0,Double radio,Color color0,Bitmap lienzo, PictureBox pbxVentana) : base(x0, y0, color0, lienzo, pbxVentana)
        {
            this.radio = radio;
        }
        public override void encender()
        {
            double t = 0;
            double dt = 0.005;
            Vector v = new Vector(0,0,color0,lienzo,pbxVentana);
            do
            {
                v.x0 = x0 + radio * Math.Cos(t);
                v.y0 = y0 + radio * Math.Sin(t);
                v.encender();
                t += dt;
            } while (t <= 2 * Math.PI);
        }

    }
}
