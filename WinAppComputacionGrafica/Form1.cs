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

        private void btnHipociclo_Click(object sender, EventArgs e)
        {
            Hipociclo H = new Hipociclo(0, 0, 90, 90, Color.Red, lienzo, pbxVentana);
            H.encender();
        }
    }
}
