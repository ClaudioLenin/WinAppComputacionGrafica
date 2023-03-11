using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppComputacionGrafica
{
    public partial class Form1 : Form
    {
        Bitmap lienzo = new Bitmap(560, 400);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region EJERCICIO 1: PIXEL
        private void btnPixel_Click(object sender, EventArgs e)
        {
            lienzo.SetPixel(100, 100, Color.Green);
            pbxVentana.Image = lienzo;
        }
        #endregion
        #region EJERCICIO 2: SEGMENTO
        private void btnSegmento_Click(object sender, EventArgs e)
        {
            Segmento s1 = new Segmento(0, 0, 10, 0, Color.Green, lienzo, pbxVentana);
            s1.encender();
            Segmento s2 = new Segmento(0, 0, 0, 7, Color.Green, lienzo, pbxVentana);
            s2.encender();
        }
        #endregion
        #region EJERCICIO 3: CIRCUNFERENCIA
        private void btnCircunferencia_Click(object sender, EventArgs e)
        {
            Circunferencia c = new Circunferencia(0, 0, 5, Color.Green, lienzo, pbxVentana);
            c.encender();
        }
        #endregion
        #region EJERCICIO 4: POLIGONO
        private void btnPoligono_Click(object sender, EventArgs e)
        {
            Poligono p = new Poligono(0, 0, 3, 5, Color.Blue, lienzo, pbxVentana);
            p.encender();
        }
        #endregion
        #region EJERCICIO 5: CURVA
        private void btnCurva_Click(object sender, EventArgs e)
        {
            Curva C = new Curva(Color.Red, lienzo, pbxVentana);
            C.encender();
        }
        #endregion
        #region EJERCICIO 6: LEMINSCATA
        private void btnLeminscata_Click(object sender, EventArgs e)
        {
            Leminscata L = new Leminscata(0,0,0, Color.Red,lienzo,pbxVentana);
            L.encender();
        }
        #endregion
        #region EJERCICIO 7: HIPOCICLO
        private void btnHipociclo_Click(object sender, EventArgs e)
        {
            Hipociclo H = new Hipociclo(0, 0, 5, 90, Color.Red, lienzo, pbxVentana);
            H.encender();
        }
        #endregion
        #region EJERCICIO 8: LAZO
        private void btnLazo_Click(object sender, EventArgs e)
        {
            Lazo L = new Lazo(0, 0, 3, 0, Color.Red, lienzo, pbxVentana);
            L.encender();
        }
        #endregion
        #region EJERCICIO 9: INFINITO
        private void btnInfinito_Click(object sender, EventArgs e)
        {
            Infinito I = new Infinito(0, 0, 3, 0, Color.Red, lienzo, pbxVentana);
            I.encender();

        }
        #endregion
        #region EJERCICIO 10: MARGARITA
        private void btnMargarita_Click(object sender, EventArgs e)
        {
            Margarita M = new Margarita(0, 0, 5, 0, Color.Red, lienzo, pbxVentana);
            M.encender();
        }
        #endregion
        #region EJERCICIO 11: ESPIRAL LOGARITMICA
        private void btnEspiralLogaritmica_Click(object sender, EventArgs e)
        {
            EspiralLogaritmica E = new EspiralLogaritmica(0, 0, 1, 0, Color.Red, lienzo, pbxVentana);
            double dx = 0.01;
            double x = 2;
            do
            {
                E.radio = x;
                E.encender();
                x = x + dx;
            } while (x <= 2.1);
        }
        #endregion
        #region EJERCICIO 12: TETA
        private void btnTeta_Click(object sender, EventArgs e)
        {
            Teta T = new Teta(0, 0, 2, 0, Color.Red, lienzo, pbxVentana);
            T.encender();
        }
        #endregion
        #region EJERCICIO 13: ASTROIDE
        private void btnAstroide_Click(object sender, EventArgs e)
        {
            Astroide A = new Astroide(0, 0, 2, 0, Color.Red, lienzo, pbxVentana);
            A.encender();

        }
        #endregion
        #region EJERCICIO 14: CORAZON
        private void btnCorazon_Click(object sender, EventArgs e)
        {
            Corazon C = new Corazon(0, 0, 2, 0, Color.Red, lienzo, pbxVentana);
            double dx = 0.01;
            double x = 2;
            do
            {
                C.radio = x;
                C.encender();
                x = x + dx;
            } while (x <= 2.1);
        }
        #endregion
        #region EJERCICIO 15: OVALO
        private void btnOvalo_Click(object sender, EventArgs e)
        {
            Ovalo O = new Ovalo(0, 0, 2, 0, Color.Red, lienzo, pbxVentana);
            O.encender();
        }
        #endregion
        #region EJERCICIO 16: MEDIA CIRCUNFERENCIA
        private void btnMediaCircunferencia_Click(object sender, EventArgs e)
        {
            MediaCircunferencia M = new MediaCircunferencia(0, 0, 1, 0, Color.Red, lienzo, pbxVentana);
            M.encender();
        }
        #endregion
        #region EJERCICIO 17: DONA
        private void btnDona_Click(object sender, EventArgs e)
        {
            Dona D = new Dona(0, 0, 0.5, 0, Color.Red, lienzo, pbxVentana);
            D.encender();
        }
        #endregion
        #region EJERCICIO 18: FLOR
        private void btnFlor_Click(object sender, EventArgs e)
        {
            Flor F = new Flor(0, 0, 0.08, 0, Color.Red, lienzo, pbxVentana);
            F.encender();
        }
        #endregion
        #region EJERCICIO 19: TAYLOR
        private void btnTaylor_Click(object sender, EventArgs e)
        {
            Vector F = new Vector(0, 0, Color.Blue, lienzo, pbxVentana);
            double t = -10;
            double dt = 0.005;
            do
            {
                F.color0 = Color.Blue;
                F.x0 = t;
                F.y0 = 2 * Math.Sin(t / 1.5);
                F.encender();
                F.color0 = Color.Green;
                F.y0 = 0 + (1.33 * t) + 0 + (-0.098 * Math.Pow(t, 3));//este es el polinomio de Taylor osea la derivada
                t = t + dt;
                F.encender();
            } while (t <= 10);
        }
        #endregion
        #region EJERCICIO 20: ARCTG
        private void btnArcTg_Click(object sender, EventArgs e)
        {
            Vector F = new Vector(0, 0, Color.Blue, lienzo, pbxVentana);
            double t = -10;
            double dt = 0.005;
            do
            {
                F.color0 = Color.Blue;
                F.x0 = t;
                F.y0 = 2 * Math.Atan(t);
                F.encender();
                F.color0 = Color.Green;
                F.y0 = 1.57 + (t - 1) - 0.5 * (Math.Pow((t - 1), 2));//este es el polinomio de Taylor osea la derivada
                t = t + dt;
                F.encender();
            } while (t <= 10);
        }
        #endregion

        private void btnInterpolacion_Click(object sender, EventArgs e)
        {
            Color cl;
            Interpolacion objInter = new Interpolacion();
            for (int i = 0; i < 400; i++)
                for (int j = 0; j < 560; j++)
                {
                    cl = Color.FromArgb(objInter.colores(0, 400, 255, 57, i), objInter.colores(0, 400, 127, 255, i), objInter.colores(0, 400, 0, 20, i));
                    lienzo.SetPixel(j, i, cl);
                }
            pbxVentana.Image = lienzo;
        }

        private void btnAmarilloAzul_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 560; i++)
                for (int j = 1; j < 200; j++)
                {
                    if (j < 100)
                    {
                        lienzo.SetPixel(i, j, Color.Yellow);
                        pbxVentana.Image = lienzo;
                    }
                    else
                    {
                        lienzo.SetPixel(i, j, Color.Blue);
                        pbxVentana.Image = lienzo;
                    }
                }
        }

        private void btnAzulAzul_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 560; i++)
                for (int j = 0; j <= 200; j++)
                {
                    lienzo.SetPixel(i, j, Color.FromArgb((int)(1.275 * j), (int)(1.275 * j), 255));
                    pbxVentana.Image = lienzo;
                }
            for (int i = 0; i < 560; i++)
                for (int j = 201; j < 400; j++)
                {
                    lienzo.SetPixel(i, j, Color.FromArgb((int)(-1.27 * j + 510), (int)(-1.27 * j + 510), 255));
                    pbxVentana.Image = lienzo;
                }
        }

        private void btnVerdeVerde_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 560; i++)
                for (int j = 0; j <= 200; j++)
                {
                    lienzo.SetPixel(i, j, Color.FromArgb((int)(1.275 * j), 255, (int)(1.275 * j)));
                    pbxVentana.Image = lienzo;
                }
            for (int i = 0; i < 560; i++)
                for (int j = 201; j < 400; j++)
                {
                    lienzo.SetPixel(i, j, Color.FromArgb((int)(-1.27 * j + 510), 255, (int)(-1.27 * j + 510)));
                    pbxVentana.Image = lienzo;
                }
        }

        private void btnAmarilloAmarillo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 560; i++)
                for (int j = 0; j <= 200; j++)
                {
                    lienzo.SetPixel(i, j, Color.FromArgb(255, 255, (int)(1.275 * j)));
                    pbxVentana.Image = lienzo;
                }
            for (int i = 0; i < 560; i++)
                for (int j = 201; j < 400; j++)
                {
                    lienzo.SetPixel(i, j, Color.FromArgb(255, 255, (int)(-1.27 * j + 510)));
                    pbxVentana.Image = lienzo;
                }
        }

        private void btnEcuador_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 560; i++)
                for (int j = 0; j <= 200; j++)
                {
                    lienzo.SetPixel(i, j, Color.FromArgb((int)(-1.275 * j + 255), (int)(-1.275 * j + 255), (int)(1.275 * j)));
                    pbxVentana.Image = lienzo;
                }
            for (int i = 0; i < 560; i++)
                for (int j = 201; j < 400; j++)
                {
                    lienzo.SetPixel(i, j, Color.FromArgb((int)(1.27 * j - 255), 0, (int)(-1.27 * j + 510)));
                    pbxVentana.Image = lienzo;
                }
        }

        private void btn4Colores_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 400; i++)
                for (int j = 0; j < 400; j++)
                {
                    lienzo.SetPixel(i, j, Color.FromArgb((int)(0.6375 * j - 0.00159375 * j * i), (int)(255 - 0.6375 * j), (int)(0.6375 * i)));
                    pbxVentana.Image = lienzo;
                }
        }

        private void btnLuna_Click(object sender, EventArgs e)
        {
            Color cl;
            Interpolacion objInter = new Interpolacion();
            Circunferencia c = new Circunferencia(0, 0, 0, Color.Red, lienzo, pbxVentana);
            double j = 0;
            do
            {
                cl = Color.FromArgb(objInter.colores(0, 3, 0, 145, j), objInter.colores(0, 3, 0, 255, j), objInter.colores(0, 3, 0, 255, j));
                c.color0 = cl;
                c.encender();
                j = j + 0.02;
                c.radio = j;
            } while (j <= 3);
            pbxVentana.Image = lienzo;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 560; i++)
                for (int j = 0; j < 400; j++)
                {
                    lienzo.SetPixel(i, j, Color.White);
                }
            pbxVentana.Image = lienzo;
        }

        private void btnCuadriculas_Click(object sender, EventArgs e)
        {
            double vertical = 10;
            double horizontal = -10;
            do
            {
                Cuadriculas c1 = new Cuadriculas(-10, vertical, 10, vertical, Color.Blue, lienzo, pbxVentana);
                c1.encender();
                vertical -= 0.5;
            } while (vertical >= -10);
              
            do
            {
                Cuadriculas c2 = new Cuadriculas(horizontal, -7, horizontal, 7, Color.Blue, lienzo, pbxVentana);
                c2.encender();
                horizontal += 0.5;
            } while (horizontal <= 10);
        }
    }
}
