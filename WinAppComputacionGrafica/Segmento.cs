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
        public double Xf;
        public double Yf;
        public double x0;
        public double y0;
        public double xf;
        public double yf;

        public Segmento(double x0, double y0, double xf, double yf, Color color0, Bitmap lienzo, PictureBox ventanaP)
            : base(x0, y0, color0, lienzo, ventanaP)

        {
            Xf = xf;
            Yf = yf;
            this.x0 = x0;
            this.y0 = y0;
            this.xf = xf;
            this.yf = yf;
        }
        public Segmento() { }
        public override void Encender()
        {
            double t = 0;
            double dt = 0.0013;
            Vector V = new Vector(0, 0, Color0, Lienzo, PbxVentana);
            do
            {
                V.X0 = X0 * (1 - t) + Xf * t;
                V.Y0 = Y0 * (1 - t) + Yf * t;
                V.Encender();
                t = t + dt;

            } while (t <= 1);
        }

        public override void Encender2(Bitmap pixel)
        {
            double t, dt;
            Vector vec = new Vector();
            t = 0;
            dt = 0.001;
            do
            {
                vec.X0 = X0 * (1 - t) + (Xf * t);
                vec.Y0 = Y0 * (1 - t) + (Yf * t);
                vec.Color0 = Color0;
                vec.Encender2(pixel);
                t = t + dt;
            }
            while (t <= 1);
        }
        public void EncenderInterpolacion(int ri, int rf, int gi, int gf, int bi, int bf, Bitmap pixel)
        {
            double t = 0;
            Vector vec = new Vector();
            double d = Math.Abs(x0 - xf) + Math.Abs(y0 - yf);
            double dt = 1 / (100 * (d + 1));
            do
            {
                vec.X0 = x0 * (1 - t) + (xf * t);
                vec.Y0 = y0 * (1 - t) + (yf * t);
                vec.Color0 = Color.FromArgb((int)Interpolacion.Segmento(ri, rf, t), (int)Interpolacion.Segmento(gi, gf, t), (int)Interpolacion.Segmento(bi, bf, t));
                vec.Encender2(pixel);
                t = t + dt;
            }
            while (t <= 1);
        }
        public override void Apagar()
        {
            Color0 = Color.White;
            Encender();
        }
        ~Segmento()
        {
        }
    }
}
