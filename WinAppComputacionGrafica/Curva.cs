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
            //LAZO
            if (Tipo == 0)
            {
                do
                {
                    V.X0 = X0 + Radio * Math.Sin(2 * x);
                    V.Y0 = Y0 + Radio * Math.Cos(3 * x);
                    //rotar1(V.X0,V.Y0,angulo,out V.Y0,out V.Y0);
                    rotar1(V.X0, V.Y0, angulo, out V.X0, out V.Y0);
                    V.Encender();
                    x = x + dx;
                } while (x <= 2 * Math.PI);
            }
            //HIPOCICLO
            if (Tipo == 1)
            {
                do
                {
                    V.X0 = X0 + Radio * Math.Pow(Math.Sin(x), 3);
                    V.Y0 = Y0 + Radio * Math.Pow(Math.Cos(x), 3);
                    rotar1(V.X0, V.Y0, angulo, out V.X0, out V.Y0);
                    V.Encender();
                    x = x + dx;
                } while (x <= 2 * Math.PI);
            }
            //MARGARITA
            if (Tipo == 2)
            {
                do
                {
                    V.X0 = X0 + Radio * ((Math.Cos(4 * x) * Math.Cos(x)) / 2);
                    V.Y0 = Y0 + Radio * ((Math.Cos(4 * x) * Math.Sin(x)) / 2);
                    rotar1(V.X0, V.Y0, angulo, out V.X0, out V.Y0);
                    V.Encender();
                    x = x + dx;
                } while (x <= 2 * Math.PI);
            }
            //INFINITO
            if (Tipo == 3)
            {
                do
                {
                    V.X0 = X0 + Radio * Math.Sin(2 * x);
                    V.Y0 = Y0 + Radio * Math.Cos(x);
                    rotar1(V.X0, V.Y0, angulo, out V.X0, out V.Y0);
                    V.Encender();
                    x = x + dx;
                } while (x <= 2 * Math.PI);
            }
            //OVALO
            if (Tipo == 4)
            {
                do
                {
                    V.X0 = X0 + Radio * Math.Cos(x) * 3;
                    V.Y0 = Y0 + Radio * Math.Sin(x);
                    rotar1(V.X0, V.Y0, angulo, out V.X0, out V.Y0);
                    V.Encender();
                    x = x + dx;
                } while (x <= 2 * Math.PI);
            }
            //CORAZON
            if (Tipo == 5)
            {
                do
                {
                    V.X0 = X0 + (Radio / 10) * (12 * Math.Sin(x) - 4 * Math.Sin(3 * x));
                    V.Y0 = Y0 + (Radio / 10) * (13 * Math.Cos(x) - 5 * Math.Cos(2 * x) - 2 * Math.Cos(3 * x) - Math.Cos(4 * x));
                    rotar1(V.X0, V.Y0, angulo, out V.X0, out V.Y0);
                    V.Encender();
                    x = x + dx;
                } while (x <= 2 * Math.PI);
            }
            //MEDIA CIRCUNFERENCIA
            if (Tipo == 6)
            {
                x = 3 * (Math.PI / 2);
                do
                {
                    V.X0 = X0 + Radio * Math.Cos(x);
                    V.Y0 = Y0 + Radio * Math.Sin(x);
                    rotar1(V.X0, V.Y0, angulo, out V.X0, out V.Y0);
                    V.Encender();
                    x = x + dx;
                } while (x <= ((2 * Math.PI) + Math.PI / 2));
            }
            //MEDIA CIRCUNFERENCIA AL OTRO LADO
            if (Tipo == 7)
            {
                x = Math.PI / 3;
                do
                {
                    V.X0 = X0 + Radio * Math.Cos(x);
                    V.Y0 = Y0 + Radio * Math.Sin(x);
                    rotar1(V.X0, V.Y0, angulo, out V.X0, out V.Y0);
                    V.Encender();
                    x = x + dx;
                } while (x <= 5 * (Math.PI / 3));
            }
            //OTRO OVALO
            if (Tipo == 8)
            {
                do
                {
                    V.X0 = X0 + Radio * Math.Cos(x);
                    V.Y0 = Y0 + Radio * Math.Sin(x) * 3;
                    rotar1(V.X0, V.Y0, angulo, out V.X0, out V.Y0);
                    V.Encender();
                    x = x + dx;
                } while (x <= 2 * Math.PI);
            }
            //ESPIRAL LOGARITMICA
            if (Tipo == 9)
            {
                double a = 5.9, b = 0.2;
                do
                {
                    V.X0 = X0 + Radio * (Math.Pow((a * b), x)) * Math.Cos(x);
                    V.Y0 = Y0 + Radio * (Math.Pow((a * b), x)) * Math.Sin(x);
                    rotar1(V.X0, V.Y0, angulo, out V.X0, out V.Y0);
                    V.Encender();
                    x = x + 0.01;
                } while (x <= 7 * Math.PI);
            }
            //DE ORO
            if (Tipo == 10)
            {

                double a = ((1 + Math.Sqrt(5)) / 2);
                Vector v = new Vector(0, 0, Color.Red, Lienzo, VentanaP);
                x = 0;
                do
                {
                    // v.X0 = X0 + Radio * ((Math.Pow(a, x) - Math.Pow((1 - a), x)) / (Math.Sqrt(5)));
                    v.X0 = (Math.Pow(a, x) - Math.Pow((1 - a), x)) / (Math.Sqrt(5));
                    v.Y0 = x;
                    rotar1(V.X0, V.Y0, angulo, out V.X0, out V.Y0);
                    v.Encender();
                    x = x + 1;
                } while (x <= 90);
            }
            //MI CURVA PERSONAL
            if (Tipo == 11)
            {
                double t = 0;
                double dt = 0.005;
                do
                {
                    V.X0 = X0 + Radio * ((10 - 6) * (Math.Cos(t)) + 6 * (Math.Cos(t * (10 / 6) * t)));
                    V.Y0 = Y0 + Radio * ((10 - 6) * (Math.Sin(t)) - 6 * (Math.Sin(t * (10 / 6) * t)));
                    rotar1(V.X0, V.Y0, angulo, out V.X0, out V.Y0);
                    V.Encender();
                    t = t + dt;
                } while (t <= (6 * 3.14));
            }
            //ASTROIDE
            if (Tipo == 13)
            {
                double t = 0;
                double dt = 0.001;
                do
                {
                    V.X0 = Radio * (Math.Pow(Math.Sin(t), 3)) + X0;
                    V.Y0 = Radio * (Math.Pow(Math.Cos(t), 3)) + Y0;
                    rotar1(V.X0, V.Y0, angulo, out V.X0, out V.Y0);
                    V.Color0 = Color0;
                    V.Encender();
                    t = t + dt;
                } while (t <= 2 * Math.PI);
            }
            //TETA
            if (Tipo == 14)
            {
                double t = 0;
                double dt = 0.001;
                do
                {
                    V.X0 = X0 + Radio * Math.Cos(t);
                    V.Y0 = Y0 + Radio * (Math.Sin(t)) * 1.3;
                    rotar1(V.X0, V.Y0, angulo, out V.X0, out V.Y0);
                    V.Color0 = Color0;
                    V.Encender();
                    t += dt;
                } while (t <= (2 * Math.PI));

                t = 0; dt = 0.001;
                do
                {
                    V.X0 = (X0 - Radio) * (1 - t) + (X0 + Radio) * (t);
                    rotar1(V.X0, V.Y0, angulo, out V.Y0, out V.Y0);
                    V.Encender();
                    V.Color0 = Color0;
                    t = t + dt;
                } while (t <= 1);
            }


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
            if (Tipo == 16)
            {
                x = (Math.PI);
                do
                {
                    V.X0 = X0 + Radio * Math.Cos(x);
                    V.Y0 = Y0 + Radio * Math.Sin(x);
                    rotar1(V.X0, V.Y0, angulo, out V.X0, out V.Y0);
                    V.Encender();
                    x = x + dx;
                } while (x <= ((2 * Math.PI)));
            }
           */
        }

    }
}
