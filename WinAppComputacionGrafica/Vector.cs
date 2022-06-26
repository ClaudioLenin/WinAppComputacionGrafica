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
        public double X0;
        public double Y0;
        public Color Color0;
        public Bitmap Lienzo;
        public PictureBox PbxVentana;
        public Vector(double x0, double y0, Color color0, Bitmap lienzo, PictureBox pbxVentana)
        {
            X0 = x0;
            Y0 = y0;
            Color0 = color0;
            Lienzo = lienzo;
            PbxVentana = pbxVentana;

        }
        public Vector(Color color0, Bitmap lienzo, PictureBox pbxVentana)
        {
            Color0 = color0;
            Lienzo = lienzo;
            PbxVentana = pbxVentana;
        }
        public Vector() { }
        public virtual void Encender()
        {
            Pantalla.Pantalla19(this.X0, this.Y0, out int Sx, out int Sy);
            if (Sx > 0 && Sx < 560 && Sy > 0 && Sy < 400)
            {
                Lienzo.SetPixel(Sx, Sy, Color0);
                PbxVentana.Image = Lienzo;
            }
        }
        public virtual void Encender2(Bitmap pixel)
        {
            //// este el metodo encender pantalla para vectores
            int Sx0, Sy0;

            Pantalla.Pantalla19(this.X0, this.Y0, out Sx0, out Sy0);
            if (Sx0 >= 0 && Sx0 < 560 && Sy0 >= 0 && Sy0 < 400)
            {
                //aqui recuerda cambiar a las dimensiones a las q estas trabajando
                pixel.SetPixel(Sx0, Sy0, Color0);
            }
        }
        public virtual void Apagar()
        {
            Color0 = Color.White;
            Encender();
        }
        ~Vector()
        {
        }
    }
}
