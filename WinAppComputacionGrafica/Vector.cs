using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace WinAppComputacionGrafica
{
    class Vector:Pantalla
    {
        public double x0;
        public double y0;
        public Color color0;
        public Bitmap lienzo;
        public PictureBox pbxVentana;
        public Vector() { }
        public Vector(double x0, double y0, Color color0, Bitmap lienzo, PictureBox pbxVentana)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.color0 = color0;
            this.lienzo = lienzo;
            this.pbxVentana = pbxVentana;

        }
        
        public virtual void Encender()
        {
            Pantalla.Pantalla19(this.x0, this.y0, out int Sx, out int Sy);
            if (Sx > 0 && Sx < 560 && Sy > 0 && Sy < 400)
            {
                lienzo.SetPixel(Sx, Sy, color0);
                pbxVentana.Image = lienzo;
            }
        }
        public virtual void Apagar()
        {
            color0 = Color.White;
            Encender();
        }
        ~Vector()
        {
        }
    }
}
