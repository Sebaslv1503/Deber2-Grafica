using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    public partial class FrmIndex : Form
    {

        public FrmIndex()
        {
            InitializeComponent();
        }

        private void OpenForm(Form formulario)
        {
            panelContenedor.Controls.Clear();     // Limpiar contenido anterior
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void FrmIndex_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void romboToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmRombo());
            this.Text = "Rombo";
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmCircle());
            this.Text = "Circulo";
        }

        private void pentagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmPentagono());
            this.Text = "Pentágono";
        }

        private void octagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmOctagono());
            this.Text = "Octágono";
        }

        private void hexagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmHexagono());
            this.Text = "Hexágono";
        }

        private void heptagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmHeptagono());
            this.Text = "Heptágono";
        }

        private void eneagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmEneagono());
            this.Text = "Eneágono";
        }

        private void decagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmDecagono());
            this.Text = "Decágono";
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmTriangulo());
            this.Text = "Triángulo";
        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmElipse());
            this.Text = "Elipse";
        }

        private void ovaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmOvalo());
            this.Text = "Óvalo";
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmCuadrado());
            this.Text = "Cuadrado";
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmRectangulo());
            this.Text = "Rectángulo";
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmRomboide());
            this.Text = "Romboide";
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmTrapecio());
            this.Text = "Trapecio";
        }

        private void trapecioisocelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmTrapecioIso());
            this.Text = "Trapecio";
        }

        private void trapezoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmTrapezoide());
            this.Text = "Trapezoide";
        }

        private void deltoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmDeltoide());
            this.Text = "Deltoide";
        }

        private void romboToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            OpenForm(new FrmRombo());
            this.Text = "Rombo";
        }

        private void pentagonoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenForm(new FrmPentagono());
            this.Text = "Pentágono";
        }

        private void romboideToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenForm(new FrmRomboide());
            this.Text = "Romboide";
        }

        private void trapezoideToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenForm(new FrmTrapezoide());
            this.Text = "Trapezoide";
        }

        private void panalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmHexagono());
            this.Text = "Hexágono";
        }
    }
}
 