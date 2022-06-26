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
        Bitmap Lienzo = new Bitmap(560, 400);
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
            Lienzo.SetPixel(100, 100, Color.Green);
            pbxVentana.Image = Lienzo;
        }
        #endregion

        private void btnSegmento_Click(object sender, EventArgs e)
        {
            Segmento s = new Segmento(0, 0, 10, 0, Color.Green, Lienzo, pbxVentana);
            s.Encender();
            s.X0 = 0;
            s.Y0 = 0;
            s.Xf = 0;
            s.Yf = 7;
            s.Encender();
        }
    }
}
