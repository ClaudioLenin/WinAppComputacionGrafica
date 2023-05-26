using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;


namespace WinAppComputacionGrafica
{
    public partial class Form1 : Form
    {
        Bitmap lienzo = new Bitmap(560, 400);
        Color[] Paleta0 = new Color[16];
        Color[] Paleta1 = new Color[16];
        Color[] Paleta2 = new Color[20];//JEAN
        Color[] Paleta3 = new Color[20];//PIEDRA
        Color[] Paleta4 = new Color[31];//CESPED
        public Form1()
        {
            InitializeComponent();
            #region "INICIAR PALETA 0"
            Paleta0[0] = Color.Black;
            Paleta0[1] = Color.Navy;
            Paleta0[2] = Color.Green;
            Paleta0[3] = Color.Aqua;
            Paleta0[4] = Color.Red;
            Paleta0[5] = Color.Purple;
            Paleta0[6] = Color.Maroon;
            Paleta0[7] = Color.LightGray;
            Paleta0[8] = Color.DarkGray;
            Paleta0[9] = Color.Blue;
            Paleta0[10] = Color.Linen;
            Paleta0[11] = Color.Silver;
            Paleta0[12] = Color.Teal;
            Paleta0[13] = Color.Fuchsia;
            Paleta0[14] = Color.Yellow;
            Paleta0[15] = Color.White;
            #endregion
            #region "INICIAR PALETA 1"
            for (int i = 0; i < 16; i++)
            {
                Paleta1[i] = Color.FromArgb((int)((-9.67 * i) + 255), (int)((-14.34 * i) + 255), (int)((-6 * i) + 120));
            }
            #endregion
            #region "INICIAR PALETA 2"
            for (int i = 0; i < 16; i++)
            {
                Paleta2[i] = Color.FromArgb(5 * i, 6 * i, 17 * i);
            }
            #endregion
            #region "INICIAR PALETA 3"
            for (int i = 0; i < 18; i++)
            {
                Paleta3[i] = Color.FromArgb((-15 * i + 255), (-15 * i + 255), (-15 * i + 255));
            }
            #endregion
            #region "INICIAR PALETA 4"
            Paleta4[0] = Color.FromArgb(6, 90, 15);
            Paleta4[1] = Color.FromArgb(17, 173, 33);
            Paleta4[2] = Color.FromArgb(14, 52, 18);
            Paleta4[3] = Color.FromArgb(6, 90, 15);
            Paleta4[4] = Color.FromArgb(17, 173, 33);
            Paleta4[5] = Color.FromArgb(14, 52, 18);
            Paleta4[6] = Color.FromArgb(6, 90, 15);
            Paleta4[7] = Color.FromArgb(17, 173, 33);
            Paleta4[8] = Color.FromArgb(14, 52, 18);
            Paleta4[9] = Color.FromArgb(6, 90, 15);
            Paleta4[10] = Color.FromArgb(17, 173, 33);
            Paleta4[11] = Color.FromArgb(14, 52, 18);
            Paleta4[12] = Color.FromArgb(6, 90, 15);
            Paleta4[13] = Color.FromArgb(12, 65, 187);
            Paleta4[14] = Color.FromArgb(17, 173, 33);
            Paleta4[15] = Color.FromArgb(6, 90, 15);
            Paleta4[16] = Color.FromArgb(17, 173, 33);
            Paleta4[17] = Color.FromArgb(14, 52, 18);
            Paleta4[18] = Color.FromArgb(6, 90, 15);
            Paleta4[19] = Color.FromArgb(17, 173, 33);
            Paleta4[20] = Color.FromArgb(14, 52, 18);
            Paleta4[21] = Color.FromArgb(6, 90, 15);
            Paleta4[22] = Color.FromArgb(17, 173, 33);
            Paleta4[23] = Color.FromArgb(14, 52, 18);
            Paleta4[24] = Color.FromArgb(6, 90, 15);
            Paleta4[25] = Color.FromArgb(17, 173, 33);
            Paleta4[26] = Color.FromArgb(14, 52, 18);
            Paleta4[27] = Color.FromArgb(6, 90, 15);
            Paleta4[28] = Color.FromArgb(12, 65, 187);
            Paleta4[29] = Color.FromArgb(17, 173, 33);
            Paleta4[30] = Color.FromArgb(12, 65, 187);
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region AJUSTES
        #region EJERCICIO 1: LIMPIAR PANTALLA
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 560; i++)
                for (int j = 0; j < 400; j++)
                {
                    lienzo.SetPixel(i, j, Color.White);
                }
            pbxVentana.Image = lienzo;
        }
        #endregion

        #endregion

        #region FIGURAS 2D
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
            Leminscata L = new Leminscata(0, 0, 0, Color.Red, lienzo, pbxVentana);
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
        #region EJERCICIO 21: CUADRICULAS
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
        #endregion
        #endregion

        #region COLORES
        #region EJERCICIO 1: INTERPOLACIÓN
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
        #endregion
        #region EJERCICIO 2: INTERPOLACIÓN AMARILLO-AZUL
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
        #endregion
        #region EJERCICIO 3: INTERPOLACIÓN AZUL-AZUL
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
        #endregion
        #region EJERCICIO 4: INTERPOLACIÓN VERDE-AZUL
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
        #endregion
        #region EJERCICIO 5: INTERPOLACIÓN AMARILLO-AMARILLO
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
        #endregion
        #region EJERCICIO 6: BANDERA ECUADOR
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
        #endregion
        #region EJERCICIO 7: INTERPOLACIÓN 4 COLORES
        private void btn4Colores_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 400; i++)
                for (int j = 0; j < 400; j++)
                {
                    lienzo.SetPixel(i, j, Color.FromArgb((int)(0.6375 * j - 0.00159375 * j * i), (int)(255 - 0.6375 * j), (int)(0.6375 * i)));
                    pbxVentana.Image = lienzo;
                }
        }
        #endregion
        #region EJERCICIO 8: INTERPOLACIÓN LUNA
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
        #endregion
        #endregion

        #region TAPETES
        #region TAPETE 1
        private void btnTapete1_Click(object sender, EventArgs e)
        {
            Double colorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    //colorT = (i + j) % 16;
                    colorT = (Math.Pow(i, 2) + Math.Pow(j, 2)) % 15;
                    lienzo.SetPixel(i, j, Paleta0[(int)colorT]);
                }
            }
            pbxVentana.Image = lienzo;
        }
        #endregion
        #region TAPETE 2
        private void btnPaleta2_Click(object sender, EventArgs e)
        {
            Double colorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    colorT = (Math.Pow(i, 2) + Math.Pow(j, 2)) % 15;
                    lienzo.SetPixel(i, j, Paleta1[(int)colorT]);
                }
            }
            pbxVentana.Image = lienzo;
        }
        #endregion
        #region TAPETE 3
        private void btnTapete3_Click(object sender, EventArgs e)
        {
            Double colorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    colorT = (Math.Pow(2, j) * j * i / 2 % 15);
                    lienzo.SetPixel(i, j, Paleta1[(int)colorT]);
                }
            }
            pbxVentana.Image = lienzo;
        }
        #endregion
        #region TAPETE 4
        private void btnTapete4_Click(object sender, EventArgs e)
        {
            Double colorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    colorT = ((int)Math.Pow((i + j), 2) * j) / 5 % 16;
                    lienzo.SetPixel(i, j, Paleta0[(int)colorT]); //pinta el pixel en el lienzo

                }
            }
            pbxVentana.Image = lienzo;
        }
        #endregion
        #region TAPETE 5
        private void btnTapete5_Click(object sender, EventArgs e)
        {
            Double colorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    colorT = ((int)(i + i) * j / 5 % 16);
                    lienzo.SetPixel(i, j, Paleta0[(int)colorT]); //pinta el pixel en el lienzo

                }
            }
            pbxVentana.Image = lienzo;
        }
        #endregion
        #region TAPETE 6
        private void btnTapete6_Click(object sender, EventArgs e)
        {
            //Utilizar una función senoidal: Puedes utilizar funciones trigonométricas, como el seno o el coseno, para generar variaciones suaves de colores en el tapete. 
            Double colorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    colorT = (int)(Math.Sin(i) * Math.Cos(j) * 8 + 8);
                    lienzo.SetPixel(i, j, Paleta0[(int)colorT]); //pinta el pixel en el lienzo

                }
            }
            pbxVentana.Image = lienzo;
        }
        #endregion
        #region TAPETE 7
        private void btnTapete7_Click(object sender, EventArgs e)
        {
            //Utilizar una función seno en una dimensión: Puedes usar solo una dimensión (por ejemplo, i) y aplicar la función seno para obtener variaciones de colores en una dirección.
            Double colorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    colorT = (int)(Math.Sin(i / 20.0) * 8 + 8);
                    lienzo.SetPixel(i, j, Paleta0[(int)colorT]); //pinta el pixel en el lienzo

                }
            }
            pbxVentana.Image = lienzo;
        }
        #endregion
        #region TAPETE 8
        private void btnTapete8_Click(object sender, EventArgs e)
        {
            //Combinar dos funciones senoidales: Puedes combinar dos funciones senoidales en diferentes dimensiones (i y j) para generar patrones más complejos. 
            Double colorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    colorT = (int)((Math.Sin(i / 20.0) + Math.Sin(j / 10.0)) * 4 + 8);
                    lienzo.SetPixel(i, j, Paleta0[(int)colorT]); //pinta el pixel en el lienzo

                }
            }
            pbxVentana.Image = lienzo;
        }
        #endregion
        #region TAPETE 9
        private void btnTapete9_Click(object sender, EventArgs e)
        {
            //Utilizar diferentes funciones trigonométricas: Además de la función seno, también puedes experimentar con otras funciones trigonométricas, como el coseno o la tangente, para generar patrones diferentes.
            //colorT = (int)((Math.Cos(i / 20.0) * Math.Tan(j / 10.0)) * 8 + 8);

            //Utilizar una función exponencial: Puedes aplicar una función exponencial para obtener variaciones más rápidas o más lentas en los colores.
            Double colorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    colorT = (int)(Math.Pow(i, 2) % 16);
                    lienzo.SetPixel(i, j, Paleta1[(int)colorT]); //pinta el pixel en el lienzo

                }
            }
            pbxVentana.Image = lienzo;
        }
        #endregion
        #region TAPETE 10
        private void btnTapete10_Click(object sender, EventArgs e)
        {
            //Emplear una función polinómica: Puedes utilizar una función polinómica de grado superior para obtener patrones más complejos. 
            Double colorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    colorT = (int)((Math.Pow(i, 3) + Math.Pow(j, 2)) % 16);
                    lienzo.SetPixel(i, j, Paleta1[(int)colorT]); //pinta el pixel en el lienzo

                }
            }
            pbxVentana.Image = lienzo;
        }
        #endregion
        #region TAPETE 11
        private void btnTapete11_Click(object sender, EventArgs e)
        {
            //Función escalonada: Puedes utilizar una función escalonada para generar bloques de colores en el tapete. 
            Double colorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    colorT = i % 16 < 8 ? 0 : 15;
                    lienzo.SetPixel(i, j, Paleta1[(int)colorT]); //pinta el pixel en el lienzo

                }
            }
            pbxVentana.Image = lienzo;
        }
        #endregion
        #region TAPETE 12
        private void btnTapete12_Click(object sender, EventArgs e)
        {
            //Función de onda cuadrada: Puedes emplear una función de onda cuadrada para generar cambios bruscos entre dos valores. 
            Double colorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    colorT = i % 32 < 16 ? 0 : 15;
                    lienzo.SetPixel(i, j, Paleta0[(int)colorT]); //pinta el pixel en el lienzo

                }
            }
            pbxVentana.Image = lienzo;
        }
        #endregion
        #region TAPETE 13
        private void btnTapete13_Click(object sender, EventArgs e)
        {
            //Función aleatoria uniforme: Puedes utilizar una función de generación de números aleatorios uniformemente distribuidos para asignar valores aleatorios a colorT. 
            Double colorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    Random rnd = new Random();
                    colorT = rnd.Next(16);
                    lienzo.SetPixel(i, j, Paleta0[(int)colorT]); //pinta el pixel en el lienzo

                }
            }
            pbxVentana.Image = lienzo;
        }
        #endregion
        #region TAPETE 14
        private void btnTapete14_Click(object sender, EventArgs e)
        {
            int maxIterations = 100;
            double escapeRadius = 2.0;

            // Definir las coordenadas y escala del Conjunto de Mandelbrot
            double xMin = -2.5;
            double xMax = 1.0;
            double yMin = -1.5;
            double yMax = 1.5;
            double scaleX = (xMax - xMin) / 560.0;
            double scaleY = (yMax - yMin) / 400.0;
            Double colorT;

            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    // Mapear las coordenadas del píxel al plano complejo
                    double cx = xMin + i * scaleX;
                    double cy = yMin + j * scaleY;

                    // Aplicar el algoritmo del Conjunto de Mandelbrot
                    double zx = 0;
                    double zy = 0;
                    int iteration = 0;
                    while (zx * zx + zy * zy < escapeRadius * escapeRadius && iteration < maxIterations)
                    {
                        double xtemp = zx * zx - zy * zy + cx;
                        zy = 2 * zx * zy + cy;
                        zx = xtemp;
                        iteration++;
                    }

                    // Asignar el valor de colorT basado en el número de iteraciones
                    colorT = (int)((iteration % 16) * 15.0 / maxIterations);

                    // Pintar el píxel en el lienzo
                    lienzo.SetPixel(i, j, Paleta1[(int)colorT]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        #endregion

        #endregion

        private void btnTapete15_Click(object sender, EventArgs e)
        {
            Double colorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    colorT = (int)(Math.Pow(j, 2) * Math.Sqrt(Math.PI * 2) + Math.Sqrt(i * 2)) % 16;

                    int x = ((int)(Math.Pow(j, 2) * Math.Sqrt(Math.PI * 2) + Math.Sqrt(i * 2)) % 15);
                    int y = ((int)(Math.Pow(i, 2) * Math.Sqrt(Math.PI * 2) + Math.Sqrt(j * 2)) % 15);
                    colorT = (int)(Math.Sqrt(x) + Math.Sqrt(Math.PI * y) % 15);

                    colorT = (int)((Math.Sqrt(i * Math.PI) + Math.Sqrt(Math.Pow(j, Math.PI)))) % 15;


                    lienzo.SetPixel(i, j, Paleta0[(int)colorT]); //pinta el pixel en el lienzo

                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete16_Click(object sender, EventArgs e)
        {
            int ColorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    ColorT = (int)((i + j * (j)) / 10) % 3;//colores llamativos//con %3 escamas de lagarto
                    lienzo.SetPixel(i, j, Paleta1[ColorT]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete17_Click(object sender, EventArgs e)
        {
            int ColorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    ColorT = (int)(((Math.Pow(i, 4) + Math.Pow(j, 4)) % 100 + 4) % 15);
                    lienzo.SetPixel(i, j, Paleta1[ColorT]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete18_Click(object sender, EventArgs e)
        {
            int ColorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    ColorT = (int)((i + j * (j)) / 10) % 16;
                    lienzo.SetPixel(i, j, Paleta1[ColorT]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete19_Click(object sender, EventArgs e)
        {
            int ColorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    ColorT = (int)((i * i + j * (j * Math.PI / 2)) / 2) % 15;
                    lienzo.SetPixel(i, j, Paleta1[ColorT]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete20_Click(object sender, EventArgs e)
        {
            int ColorT;
            for (int i = 0; i < 280; i++)
            {
                for (int j = 0; j < 200; j++)
                {
                    ColorT = (int)(((Math.Pow(i, 4) + Math.Pow(j, 4)) % 100 + 4) % 15);
                    lienzo.SetPixel(i, j, Paleta1[ColorT]);
                }
            }
            for (int i = 0; i < 280; i++)
            {
                for (int j = 200; j < 400; j++)
                {
                    ColorT = ((int)(Math.Pow(i, 2)) + (int)(Math.Pow(j, 2))) / 30 % 16;
                    lienzo.SetPixel(i, j, Paleta1[ColorT]);
                }
            }
            for (int i = 280; i < 560; i++)
            {
                for (int j = 0; j < 200; j++)
                {
                    ColorT = (int)((i * i + j * (j * Math.PI / 2)) / 2) % 15;
                    lienzo.SetPixel(i, j, Paleta1[ColorT]);
                }
            }
            for (int i = 280; i < 560; i++)
            {
                for (int j = 200; j < 400; j++)
                {
                    ColorT = (int)((i / 0.8 + j / 0.8 * (j / 0.8 * 2)) / 65) % 15;
                    lienzo.SetPixel(i, j, Paleta1[ColorT]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete21_Click(object sender, EventArgs e)
        {
            int ColorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    ColorT = (int)((i + 5 * Math.Pow((Math.Sin(i) + 1) * 3, 3)) + (j + 5 * Math.Pow((Math.Cos(j) + 1) * 5, 3))) % 15;
                    lienzo.SetPixel(i, j, Paleta0[ColorT]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete22_Click(object sender, EventArgs e)
        {
            int ColorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    ColorT = (int)((i + j * (j)) / 10) % 16;
                    //ColorT = (int)((i + j * (j * 2)) / 65) % 15;
                    lienzo.SetPixel(i, j, Paleta1[ColorT]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete23_Click(object sender, EventArgs e)
        {
            int ColorP;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    ColorP = ((int)Math.Abs(Math.Sin(i) * j)) % 5;
                    lienzo.SetPixel(i, j, this.Paleta0[ColorP]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete24_Click(object sender, EventArgs e)
        {
            int ColorP;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    ColorP = (int)(i*j) % 16;
                    lienzo.SetPixel(i, j, this.Paleta1[ColorP]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete25_Click(object sender, EventArgs e)
        {
            int ColorP;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    ColorP = (int)((Math.Atan(Math.Pow(i,2)))+ Math.Acos(Math.Pow(j, 3))) % 16;
                    lienzo.SetPixel(i, j, this.Paleta1[ColorP]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete26_Click(object sender, EventArgs e)
        {
            int ColorP;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    ColorP = (int)Math.Abs(Math.Sin(i)+Math.Cos(j)) % 16; 
                    lienzo.SetPixel(i, j, this.Paleta1[ColorP]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete27_Click(object sender, EventArgs e)
        {
            int ColorP;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    ColorP = (int)Math.Abs(Math.Cos(i) + j) % 10;
                    lienzo.SetPixel(i, j, this.Paleta1[ColorP]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete28_Click(object sender, EventArgs e)
        {
            int i, j;
            int colorT = 0;
            for (i = 0; i < 560; i++)
                for (j = 0; j < 400; j++)
                {
                    colorT = (int)((i * 0.7 * Math.Tanh(0.3) * j) * 0.1 + j) % 16;
                    lienzo.SetPixel(i, j, Paleta0[colorT]);
                    pbxVentana.Image = lienzo;
                }
        }

        private void btnTapete29_Click(object sender, EventArgs e)
        {
            int i, j;
            int colorT = 0;
            for (i = 0; i < 560; i++)
                for (j = 0; j < 400; j++)
                {
                    colorT = ((int)(Math.Abs(Math.Pow(Math.PI, 15) + (i * j)) % 16));
                    lienzo.SetPixel(i, j, Paleta0[colorT]);
                    pbxVentana.Image = lienzo;
                }
        }

        private void btnTapete30_Click(object sender, EventArgs e)
        {
            int sx, sy;
            int colorT = 0;
            for (sx = 0; sx < 560; sx++)
                for (sy = 0; sy < 400; sy++)
                {
                    colorT = (int)(Math.Sqrt(Math.Pow(sx, 3) + Math.Pow(sy, 3)) % 15);
                    lienzo.SetPixel(sx, sy, Paleta0[colorT]);
                    pbxVentana.Image = lienzo;
                }
        }

        private void btnTapete31_Click(object sender, EventArgs e)
        {
            //Fórmula exponencial:
            int sx, sy;
            int colorT = 0;
            for (sx = 0; sx < 560; sx++)
                for (sy = 0; sy < 400; sy++)
                {
                    colorT = (int)(Math.Exp(Math.Cos(sx / 50.0) + Math.Sin(sy / 50.0)) % 16);
                    lienzo.SetPixel(sx, sy, Paleta0[colorT]);
                    pbxVentana.Image = lienzo;
                }
        }

        private void btnTapete32_Click(object sender, EventArgs e)
        {
            int sx, sy;
            int colorT = 0;
            for (sx = 0; sx < 560; sx++)
                for (sy = 0; sy < 400; sy++)
                {
                    colorT = ((((int)Math.Pow(sx, 2)) * (sy))) % 16;
                    lienzo.SetPixel(sx, sy, Paleta0[colorT]);
                    pbxVentana.Image = lienzo;
                }
        }

        private void btnTapete33_Click(object sender, EventArgs e)
        {
            int sx, sy;
            int colorT = 0;
            for (sx = 0; sx < 560; sx++)
                for (sy = 0; sy < 400; sy++)
                {
                    colorT = (sx * sy) % 16;
                    lienzo.SetPixel(sx, sy, Paleta0[colorT]);
                    pbxVentana.Image = lienzo;
                }
        }

        private void btnTapete34_Click(object sender, EventArgs e)
        {
            int ColorT;
            for (int i = 0; i < 560; i++)
                for (int j = 0; j < 400; j++)
                {
                    ColorT = (i * i * 3 + j * j * 3) % 5;
                    lienzo.SetPixel(i, j, Paleta1[ColorT]);
                }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete35_Click(object sender, EventArgs e)
        {
            int ColorT;
            for (int i = 0; i < 560; i++)
                for (int j = 0; j < 400; j++)
                {
                    ColorT = (int)(Math.Sqrt((Math.Pow(i, 4)) * 2 * (Math.Sqrt(Math.Pow(j, 5)))) % 14) - (int)Math.Tan(5);
                    lienzo.SetPixel(i, j, Paleta3[ColorT]);
                }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete36_Click(object sender, EventArgs e)
        {
            int ColorT;

            Random rnd = new Random();
            int cl = 0;
            for (int i = 0; i < 560; i++)
                for (int j = 0; j < 400; j++)
                {
                    cl = rnd.Next(0, 3);
                    ColorT = (int)(Math.Pow(cl, 1.5));
                    lienzo.SetPixel(i, j, Paleta4[ColorT]);

                }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete37_Click(object sender, EventArgs e)
        {
            int ColorT;
            for (int i = 0; i < 560; i++)
                for (int j = 0; j < 400; j++)
                {
                    Random rnd = new Random();
                    ColorT = rnd.Next(15);
                    lienzo.SetPixel(i, j, Paleta3[ColorT]);
                }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete38_Click(object sender, EventArgs e)
        {
            int ColorT;
            for (int i = 0; i < 560; i++)
                for (int j = 0; j < 400; j++)
                {
                    ColorT = (i / 40 + j / 40) % 16;
                    lienzo.SetPixel(i, j, Paleta4[ColorT]);
                }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete39_Click(object sender, EventArgs e)
        {
            //Fórmula con patrón de ondas:
            int ColorT;

            Random rnd = new Random();
            int cl = 0;
            for (int i = 0; i < 560; i++)
                for (int j = 0; j < 400; j++)
                {
                    double waveValue = Math.Abs(Math.Sin(i * 0.05f) + Math.Sin(j * 0.05f));
                    ColorT = (int)(waveValue * 15);
                    lienzo.SetPixel(i, j, Paleta4[ColorT]);

                }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete40_Click(object sender, EventArgs e)
        {
            //Fórmula basada en valor promedio de coordenadas:
            int ColorT;

            Random rnd = new Random();
            int cl = 0;
            for (int i = 0; i < 560; i++)
                for (int j = 0; j < 400; j++)
                {
                    int averageValue = (i + j) / 2;
                    ColorT = averageValue % 16;
                    lienzo.SetPixel(i, j, Paleta4[ColorT]);

                }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete41_Click(object sender, EventArgs e)
        {
            int ColorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    ColorT = (int)((i + j * (i * 1.2)) / 50) % 15;//estrellas final
                    lienzo.SetPixel(i, j, Paleta4[ColorT]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete42_Click(object sender, EventArgs e)
        {
            int ColorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    ColorT = (int)((i + j * (j)) / 10) % 21;//colores llamativos//con %3 escamas de lagarto
                    lienzo.SetPixel(i, j, Paleta4[ColorT]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete43_Click(object sender, EventArgs e)
        {
            int colorP;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    colorP = (int)Math.Abs((Math.Log(i) + Math.Cos(8 * j))) % 16;
                    lienzo.SetPixel(i, j, Paleta0[colorP]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete44_Click(object sender, EventArgs e)
        {
            //Fórmula basada en funciones exponenciales y trigonométricas:
            int ColorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    double expValue = Math.Exp(Math.Sin(i * 0.05) + Math.Cos(j * 0.05));
                    ColorT = (int)(expValue % 16);
                    lienzo.SetPixel(i, j, Paleta4[ColorT]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete45_Click(object sender, EventArgs e)
        {
            //Fórmula con patrón en zigzag:
            int ColorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    int zigzagValue = i % 40;
                    if (j / 50 % 2 == 1)
                        zigzagValue = 39 - zigzagValue;
                    ColorT = zigzagValue % 16;
                    lienzo.SetPixel(i, j, Paleta2[ColorT]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete46_Click(object sender, EventArgs e)
        {
            //Fórmula basada en fractales de Mandelbrot:
            int ColorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    int maxIterations = 100;
                    double zx = 0, zy = 0;
                    double cx = (i - 400) / 200.0;
                    double cy = (j - 280) / 200.0;
                    int iterations = 0;

                    while (iterations < maxIterations && zx * zx + zy * zy < 4)
                    {
                        double tmp = zx * zx - zy * zy + cx;
                        zy = 2 * zx * zy + cy;
                        zx = tmp;
                        iterations++;
                    }

                    ColorT = iterations % 16;
                    lienzo.SetPixel(i, j, Paleta4[ColorT]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete47_Click(object sender, EventArgs e)
        {
            //Fórmula de rombos concéntricos:
            int ColorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    int size = 40;
                    int halfSize = size / 2;
                    int offsetX = i % size - halfSize;
                    int offsetY = j % size - halfSize;
                    ColorT = Math.Abs(offsetX) % size == halfSize || Math.Abs(offsetY) % size == halfSize ? 1 : 0;
                    lienzo.SetPixel(i, j, Paleta4[ColorT]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete48_Click(object sender, EventArgs e)
        {
            //Fórmula de ajedrez:
            int ColorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    int tileSize = 40;
                    int chessX = i / tileSize;
                    int chessY = j / tileSize;
                    ColorT = (chessX + chessY) % 2 == 0 ? 1 : 0;
                    lienzo.SetPixel(i, j, Paleta4[ColorT]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete49_Click(object sender, EventArgs e)
        {
            //Fórmula de círculos concéntricos:
            int ColorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    int centerX = 280;
                    int centerY = 200;
                    int radius = 40;
                    double distance = Math.Sqrt(Math.Pow(i - centerX, 2) + Math.Pow(j - centerY, 2));
                    ColorT = (int)(distance / radius) % 2 == 0 ? 1 : 0;
                    lienzo.SetPixel(i, j, Paleta4[ColorT]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete50_Click(object sender, EventArgs e)
        {
            //Fórmula de líneas diagonales:
            int ColorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    int lineWidth = 20;
                    int diagonalIndex = i + j;

                    ColorT = diagonalIndex % lineWidth == 0 ? 1 : 0;
                    lienzo.SetPixel(i, j, Paleta3[ColorT]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete51_Click(object sender, EventArgs e)
        {
            //Fórmula de círculos concéntricos con ruido:
            int ColorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    int centerX = 280;
                    int centerY = 200;
                    int radius = 40;
                    int noiseRange = 5;
                    double distance = Math.Sqrt(Math.Pow(i - centerX, 2) + Math.Pow(j - centerY, 2));
                    Random rnd = new Random();
                    int randomValue = rnd.Next(0, noiseRange);

                    ColorT = (int)(distance / radius) + randomValue;
                    lienzo.SetPixel(i, j, Paleta3[ColorT]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete52_Click(object sender, EventArgs e)
        {
            int ColorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    ColorT = (int)((i + 5 * Math.Pow((Math.Sin(i) + 1) * 3, 3)) + (j + 5 * Math.Pow((Math.Cos(j) + 1) * 5, 3))) % 15;
                    lienzo.SetPixel(i, j, Paleta3[ColorT]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete53_Click(object sender, EventArgs e)
        {
            int ColorT;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    ColorT = (int)((Math.Sin(i + j) + 1) * (7.5));
                    lienzo.SetPixel(i, j, Paleta4[ColorT]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete54_Click(object sender, EventArgs e)
        {
            int colorP;
            for (int i = 0; i < 560; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    colorP = (int)Math.Abs((Math.Cos(i) / Math.Sin(j) + Math.Cos(i) * Math.Sin(j))) % 16;
                    lienzo.SetPixel(i, j, Paleta0[colorP]);
                }
            }
            pbxVentana.Image = lienzo;
        }

        private void btnTapete55_Click(object sender, EventArgs e)
        {
            int width = 560;  // Ancho del lienzo
            int height = 400; // Alto del lienzo

            Random rnd = new Random();

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    int red = rnd.Next(256);
                    int green = rnd.Next(256);
                    int blue = rnd.Next(256);

                    Color color = Color.FromArgb(red, green, blue);
                    lienzo.SetPixel(i, j, color);
                }
            }

            pbxVentana.Image = lienzo;
        }

        private void btnTapete56_Click(object sender, EventArgs e)
        {
            int width = 560;  // Ancho del lienzo
            int height = 400; // Alto del lienzo

            int centerX = width / 2;   // Coordenada X del centro del círculo
            int centerY = height / 2;  // Coordenada Y del centro del círculo
            int radius = Math.Min(width, height) / 4;  // Radio del círculo

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    int distanceX = Math.Abs(i - centerX);
                    int distanceY = Math.Abs(j - centerY);
                    double distance = Math.Sqrt(Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2));

                    if (distance <= radius)
                    {
                        Color color = Color.Black;
                        lienzo.SetPixel(i, j, color);
                    }
                }
            }

            pbxVentana.Image = lienzo;
        }

        private void btnTapete57_Click(object sender, EventArgs e)
        {
            int width = 560;  // Ancho del lienzo
            int height = 400; // Alto del lienzo
            

            Random rnd = new Random();

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    int shape = rnd.Next(3);  // Genera un número aleatorio entre 0 y 2

                    if (shape == 0)  // Dibuja un círculo
                    {
                        int radius = rnd.Next(10, 50);
                        Color color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                        DrawCircle(lienzo, x, y, radius, color);
                    }
                    else if (shape == 1)  // Dibuja un rectángulo
                    {
                        int size = rnd.Next(10, 50);
                        Color color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                        DrawRectangle(lienzo, x, y, size, size, color);
                    }
                    else  // Dibuja una línea
                    {
                        int length = rnd.Next(10, 50);
                        int angle = rnd.Next(360);
                        Color color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                        DrawLine(lienzo, x, y, length, angle, color);
                    }
                }
            }

            pbxVentana.Image = lienzo;
        }

        private void DrawCircle(Bitmap image, int centerX, int centerY, int radius, Color color)
        {
            Graphics graphics = Graphics.FromImage(image);
            Pen pen = new Pen(color);
            graphics.DrawEllipse(pen, centerX - radius, centerY - radius, 2 * radius, 2 * radius);
        }

        private void DrawRectangle(Bitmap image, int centerX, int centerY, int width, int height, Color color)
        {
            Graphics graphics = Graphics.FromImage(image);
            Pen pen = new Pen(color);
            graphics.DrawRectangle(pen, centerX - width / 2, centerY - height / 2, width, height);
        }

        private void DrawLine(Bitmap image, int startX, int startY, int length, int angle, Color color)
        {
            double radians = angle * Math.PI / 180.0;
            int endX = startX + (int)(length * Math.Cos(radians));
            int endY = startY + (int)(length * Math.Sin(radians));

            Graphics graphics = Graphics.FromImage(image);
            Pen pen = new Pen(color);
            graphics.DrawLine(pen, startX, startY, endX, endY);
        }

        private void btnTapete58_Click(object sender, EventArgs e)
        {
            //JULIA
            int width = 560;  // Ancho del lienzo
            int height = 400; // Alto del lienzo


            double zoom = 1.5;
            double offsetX = -0.5;
            double offsetY = 0.0;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    double zx = 1.5 * (x - width / 2) / (0.5 * zoom * width) + offsetX;
                    double zy = (y - height / 2) / (0.5 * zoom * height) + offsetY;

                    int maxIterations = 100;
                    int iteration = 0;

                    while (zx * zx + zy * zy < 4 && iteration < maxIterations)
                    {
                        double xtemp = zx * zx - zy * zy + 0.355;
                        zy = 2.0 * zx * zy + 0.355;
                        zx = xtemp;
                        iteration++;
                    }

                    Color color = Color.FromArgb(iteration % 16, iteration % 8 * 16, iteration % 4 * 64);
                    lienzo.SetPixel(x, y, color);
                }
            }

            pbxVentana.Image = lienzo;
        }

        private void btnTapete59_Click(object sender, EventArgs e)
        {
            //NOCHE ESTRELLA
            int width = 560;  // Ancho del lienzo
            int height = 400; // Alto del lienzo

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    // Fondo azul oscuro
                    Color color = Color.FromArgb(29, 41, 81);
                    lienzo.SetPixel(x, y, color);
                }
            }

            // Dibujar estrellas
            Random rnd = new Random();
            int numStars = 200;

            for (int i = 0; i < numStars; i++)
            {
                int x = rnd.Next(width);
                int y = rnd.Next(height);

                // Brillo aleatorio para las estrellas
                int brightness = rnd.Next(128, 256);
                Color starColor = Color.FromArgb(brightness, brightness, brightness);

                lienzo.SetPixel(x, y, starColor);
            }

            pbxVentana.Image = lienzo;
        }

        private void btnTapete60_Click(object sender, EventArgs e)
        {
            int width = 560;  // Ancho del lienzo
            int height = 400; // Alto del lienzo

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    // Fondo azul oscuro
                    Color color = Color.FromArgb(0, 0, 51);
                    lienzo.SetPixel(x, y, color);
                }
            }

            // Dibujar las estrellas
            int numStars = 200;
            Random rnd = new Random();

            for (int i = 0; i < numStars; i++)
            {
                int x = rnd.Next(width);
                int y = rnd.Next(height);

                // Color blanco para las estrellas
                Color starColor = Color.White;
                lienzo.SetPixel(x, y, starColor);
            }

            // Dibujar la luna
            int moonRadius = 50;
            int moonCenterX = width / 2;
            int moonCenterY = height / 2;

            for (int x = moonCenterX - moonRadius; x <= moonCenterX + moonRadius; x++)
            {
                for (int y = moonCenterY - moonRadius; y <= moonCenterY + moonRadius; y++)
                {
                    if (Math.Pow(x - moonCenterX, 2) + Math.Pow(y - moonCenterY, 2) <= Math.Pow(moonRadius, 2))
                    {
                        // Color amarillo claro para la luna
                        Color moonColor = Color.FromArgb(255, 255, 204);
                        lienzo.SetPixel(x, y, moonColor);
                    }
                }
            }

            pbxVentana.Image = lienzo;
        }

        private void btnTapete61_Click(object sender, EventArgs e)
        {
            int width = 560;  // Ancho del lienzo
            int height = 400; // Alto del lienzo

            Random rnd = new Random();

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    int pattern = rnd.Next(4);  // Genera un número aleatorio entre 0 y 3

                    if (pattern == 0)  // Dibuja una espiral
                    {
                        double angle = Math.Atan2(y - height / 2, x - width / 2);
                        int radius = (int)(Math.Sqrt(x * x + y * y) / 2);
                        Color color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                        DrawSpiral(lienzo, x, y, angle, radius, color);
                    }
                    else if (pattern == 1)  // Dibuja un patrón de líneas diagonales
                    {
                        int lineSize = rnd.Next(10, 30);
                        int lineWidth = rnd.Next(2, 5);
                        Color color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                        DrawDiagonalLines(lienzo, x, y, lineSize, lineWidth, color);
                    }
                    else if (pattern == 2)  // Dibuja un patrón de círculos concéntricos
                    {
                        int centerX = width / 2;
                        int centerY = height / 2;
                        int distance = (int)Math.Sqrt(Math.Pow(x - centerX, 2) + Math.Pow(y - centerY, 2));
                        int radius = rnd.Next(50, 150);
                        Color color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                        if (distance % radius < 10)
                            DrawCircle(lienzo, x, y, radius, color);
                    }
                    else  // Dibuja un patrón de rectángulos
                    {
                        int rectSize = rnd.Next(20, 50);
                        int rectWidth = rnd.Next(5, 15);
                        int rectHeight = rnd.Next(10, 30);
                        Color color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                        DrawRectanglePattern(lienzo, x, y, rectSize, rectWidth, rectHeight, color);
                    }
                }
            }

            pbxVentana.Image = lienzo;
        }

        private void DrawSpiral(Bitmap image, int centerX, int centerY, double angle, int radius, Color color)
        {
            Graphics graphics = Graphics.FromImage(image);
            Pen pen = new Pen(color);

            int x = centerX + (int)(radius * Math.Cos(angle));
            int y = centerY + (int)(radius * Math.Sin(angle));

            graphics.DrawEllipse(pen, x, y, 2, 2);
        }

        private void DrawDiagonalLines(Bitmap image, int x, int y, int lineSize, int lineWidth, Color color)
        {
            Graphics graphics = Graphics.FromImage(image);
            Pen pen = new Pen(color, lineWidth);

            graphics.DrawLine(pen, x, y, x + lineSize, y + lineSize);
        }

        private void DrawRectanglePattern(Bitmap image, int x, int y, int rectSize, int rectWidth, int rectHeight, Color color)
        {
            Graphics graphics = Graphics.FromImage(image);
            Pen pen = new Pen(color);

            int startX = x - rectSize / 2;
            int startY = y - rectSize / 2;

            for (int i = 0; i < rectSize; i++)
            {
                graphics.DrawRectangle(pen, startX, startY, rectWidth, rectHeight);
                startX += rectWidth;
                startY += rectHeight;
            }
        }

        private void btnPaisaje1_Click(object sender, EventArgs e)
        {
            int width = 560;  // Ancho del lienzo
            int height = 400; // Alto del lienzo
            Graphics graphics = Graphics.FromImage(lienzo);

            // Fondo del cielo
            Brush cieloBrush = new LinearGradientBrush(new Point(0, 0), new Point(0, height), Color.LightBlue, Color.DeepSkyBlue);
            graphics.FillRectangle(cieloBrush, 0, 0, width, height);

            // Sol
            Brush solBrush = new SolidBrush(Color.Yellow);
            graphics.FillEllipse(solBrush, width / 2 - 40, 50, 80, 80);

            // Montañas
            Brush montanasBrush = new SolidBrush(Color.DarkGreen);
            Point[] montanasPoints = { new Point(0, 400), new Point(width / 2, 200), new Point(width, 400) };
            graphics.FillPolygon(montanasBrush, montanasPoints);

            // Campo
            Brush campoBrush = new SolidBrush(Color.LightGreen);
            graphics.FillRectangle(campoBrush, 0, 400, width, height - 400);

            // Árboles
            Pen arbolPen = new Pen(Color.DarkGreen, 10);
            graphics.DrawRectangle(arbolPen, 100, 350, 20, 50);
            graphics.DrawLine(arbolPen, 90, 375, 130, 375);
            graphics.DrawLine(arbolPen, 80, 400, 140, 400);

            graphics.DrawRectangle(arbolPen, 700, 350, 20, 50);
            graphics.DrawLine(arbolPen, 690, 375, 730, 375);
            graphics.DrawLine(arbolPen, 680, 400, 740, 400);

            // Casa
            Pen casaPen = new Pen(Color.Brown, 5);
            Brush casaBrush = new SolidBrush(Color.SaddleBrown);
            graphics.DrawRectangle(casaPen, 300, 350, 200, 150);
            graphics.FillRectangle(casaBrush, 300, 350, 200, 150);
            graphics.DrawPolygon(casaPen, new Point[] { new Point(250, 350), new Point(400, 250), new Point(550, 350) });
            graphics.FillPolygon(casaBrush, new Point[] { new Point(250, 350), new Point(400, 250), new Point(550, 350) });

            pbxVentana.Image = lienzo;
        }

        private void btnPaisaje2_Click(object sender, EventArgs e)
        {
            int width = 560;  // Ancho del lienzo
            int height = 400; // Alto del lienzo

            Graphics graphics = Graphics.FromImage(lienzo);

            // Cielo de fondo
            Brush cieloBrush = new LinearGradientBrush(new Point(0, 0), new Point(0, height), Color.LightBlue, Color.DeepSkyBlue);
            graphics.FillRectangle(cieloBrush, 0, 0, width, height);

            // Cuerpo del águila
            Brush cuerpoBrush = new SolidBrush(Color.Brown);
            graphics.DrawEllipse(Pens.Black, 300, 250, 200, 100);
            graphics.FillEllipse(cuerpoBrush, 300, 250, 200, 100);

            // Cabeza del águila
            Brush cabezaBrush = new SolidBrush(Color.White);
            graphics.DrawEllipse(Pens.Black, 500, 200, 80, 80);
            graphics.FillEllipse(cabezaBrush, 500, 200, 80, 80);

            // Ojo del águila
            Brush ojoBrush = new SolidBrush(Color.Yellow);
            graphics.FillEllipse(ojoBrush, 520, 220, 20, 20);

            // Pico del águila
            Brush picoBrush = new SolidBrush(Color.Yellow);
            Point[] picoPoints = { new Point(580, 240), new Point(540, 240), new Point(560, 270) };
            graphics.FillPolygon(picoBrush, picoPoints);

            // Alas del águila
            Brush alasBrush = new SolidBrush(Color.Brown);
            Point[] alaSuperiorPoints = { new Point(300, 250), new Point(330, 200), new Point(400, 180), new Point(400, 210) };
            Point[] alaInferiorPoints = { new Point(300, 350), new Point(330, 400), new Point(400, 420), new Point(400, 390) };
            graphics.FillPolygon(alasBrush, alaSuperiorPoints);
            graphics.FillPolygon(alasBrush, alaInferiorPoints);

            pbxVentana.Image = lienzo;
        }

        private void btnPaisaje3_Click(object sender, EventArgs e)
        {
            int width = 560;  // Ancho del lienzo
            int height = 400; // Alto del lienzo
            Graphics graphics = Graphics.FromImage(lienzo);

            // Cabeza del robot
            Brush cabezaBrush = new SolidBrush(Color.Gray);
            graphics.FillRectangle(cabezaBrush, 350, 100, 100, 100);

            // Ojos del robot
            Brush ojoBrush = new SolidBrush(Color.Red);
            graphics.FillEllipse(ojoBrush, 370, 130, 20, 20);
            graphics.FillEllipse(ojoBrush, 410, 130, 20, 20);

            // Cuerpo del robot
            Brush cuerpoBrush = new SolidBrush(Color.Blue);
            graphics.FillRectangle(cuerpoBrush, 325, 200, 150, 200);

            // Brazos del robot
            Brush brazoBrush = new SolidBrush(Color.Yellow);
            graphics.FillRectangle(brazoBrush, 225, 200, 100, 30);
            graphics.FillRectangle(brazoBrush, 475, 200, 100, 30);

            // Piernas del robot
            Brush piernaBrush = new SolidBrush(Color.Green);
            graphics.FillRectangle(piernaBrush, 325, 400, 50, 100);
            graphics.FillRectangle(piernaBrush, 425, 400, 50, 100);

            pbxVentana.Image = lienzo;
        }

        private void btnTapete62_Click(object sender, EventArgs e)
        {
            int width = 560;  // Ancho del lienzo
            int height = 400; // Alto del lienzo
            int hexagonSize = 40; // Tamaño de los hexágonos
            int padding = 5; // Espacio entre los hexágonos

            Graphics graphics = Graphics.FromImage(lienzo);

            // Colores para los hexágonos
            Color color1 = Color.Gold;
            Color color2 = Color.Black;

            for (int row = 0; row < height / (hexagonSize + padding); row++)
            {
                for (int col = 0; col < width / (hexagonSize + padding); col++)
                {
                    int x = col * (hexagonSize + padding);
                    int y = row * (hexagonSize + padding);

                    if (row % 2 == 0)
                        x += hexagonSize / 2;

                    Point[] points = GetHexagonPoints(x, y, hexagonSize);
                    Brush brush = (row % 2 == 0 && col % 2 == 0) || (row % 2 != 0 && col % 2 != 0)
                        ? new SolidBrush(color1) : new SolidBrush(color2);

                    graphics.FillPolygon(brush, points);
                }
            }

            pbxVentana.Image = lienzo;
        }
        private Point[] GetHexagonPoints(int x, int y, int size)
        {
            Point[] points = new Point[6];

            points[0] = new Point(x + size / 2, y);
            points[1] = new Point(x + size, y + size / 4);
            points[2] = new Point(x + size, y + 3 * size / 4);
            points[3] = new Point(x + size / 2, y + size);
            points[4] = new Point(x, y + 3 * size / 4);
            points[5] = new Point(x, y + size / 4);

            return points;
        }

        private void btnTapete63_Click(object sender, EventArgs e)
        {
            int width = 560;  // Ancho del lienzo
            int height = 400; // Alto del lienzo
            int leafSize = 30; // Tamaño de las hojas
            int padding = 10; // Espacio entre las hojas

            Bitmap lienzo = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(lienzo);

            // Colores para las hojas
            Color color1 = Color.DarkGreen;
            Color color2 = Color.Green;

            for (int row = 0; row < height / (leafSize + padding); row++)
            {
                for (int col = 0; col < width / (leafSize + padding); col++)
                {
                    int x = col * (leafSize + padding);
                    int y = row * (leafSize + padding);

                    Point[] points = GetLeafPoints(x, y, leafSize);
                    Brush brush = (row % 2 == 0 && col % 2 == 0) || (row % 2 != 0 && col % 2 != 0)
                        ? new SolidBrush(color1) : new SolidBrush(color2);

                    graphics.FillPolygon(brush, points);
                }
            }

            pbxVentana.Image = lienzo;
        }
        private Point[] GetLeafPoints(int x, int y, int size)
        {
            Point[] points = new Point[7];

            points[0] = new Point(x + size / 2, y);
            points[1] = new Point(x + size, y + size / 4);
            points[2] = new Point(x + size * 3 / 4, y + size);
            points[3] = new Point(x + size / 2, y + size * 3 / 4);
            points[4] = new Point(x + size / 4, y + size);
            points[5] = new Point(x, y + size / 4);
            points[6] = new Point(x + size / 4, y + size / 2);

            return points;
        }

        private void btnTapete64_Click(object sender, EventArgs e)
        {
            int width = 560;  // Ancho del lienzo
            int height = 400; // Alto del lienzo
            int butterflySize = 60; // Tamaño de las mariposas
            int padding = 20; // Espacio entre las mariposas

            Graphics graphics = Graphics.FromImage(lienzo);

            // Colores para las mariposas
            Color color1 = Color.Purple;
            Color color2 = Color.Pink;

            for (int row = 0; row < height / (butterflySize + padding); row++)
            {
                for (int col = 0; col < width / (butterflySize + padding); col++)
                {
                    int x = col * (butterflySize + padding);
                    int y = row * (butterflySize + padding);

                    Point[] points = GetButterflyPoints(x, y, butterflySize);
                    Brush brush = (row % 2 == 0 && col % 2 == 0) || (row % 2 != 0 && col % 2 != 0)
                        ? new SolidBrush(color1) : new SolidBrush(color2);

                    graphics.FillPolygon(brush, points);
                }
            }

            pbxVentana.Image = lienzo;
        }
        private Point[] GetButterflyPoints(int x, int y, int size)
        {
            Point[] points = new Point[10];

            points[0] = new Point(x + size / 2, y);
            points[1] = new Point(x + size * 3 / 4, y + size / 3);
            points[2] = new Point(x + size, y + size / 4);
            points[3] = new Point(x + size * 3 / 4, y + size / 2);
            points[4] = new Point(x + size, y + size * 3 / 4);
            points[5] = new Point(x + size * 3 / 4, y + size * 2 / 3);
            points[6] = new Point(x + size / 2, y + size);
            points[7] = new Point(x + size / 4, y + size * 2 / 3);
            points[8] = new Point(x, y + size * 3 / 4);
            points[9] = new Point(x + size / 4, y + size / 3);

            return points;
        }

        private void btnSlither_Click(object sender, EventArgs e)
        {
            Form slither = new WinAppComputacionGrafica.Slither();
            //F1.MdiParent = this;
            //F1.Text = "Formq" + childFormNumber++;
            slither.Show();
        }
    }
}
