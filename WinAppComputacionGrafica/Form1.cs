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
            Segmento s = new Segmento(0, 0, 10, 0, Color.Green, lienzo, pbxVentana);
            s.Encender();
            s.x0 = 0;
            s.y0 = 0;
            s.Xf = 0;
            s.Yf = 7;
            s.Encender();
        }
        #endregion
        #region EJERCICIO 3: CIRCUNFERENCIA
        private void btnCircunferencia_Click(object sender, EventArgs e)
        {
            Circunferencia c = new Circunferencia(0, 0, 5, Color.Green, lienzo, pbxVentana);
            c.Encender();
        }
        #endregion
    }
}
