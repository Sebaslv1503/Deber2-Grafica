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
    public partial class FrmTriangulo : Form
    {
        private Triangulo ObjTriangulo = new Triangulo();
        public FrmTriangulo()
        {
            InitializeComponent();
            btnCalcular.ForeColor = Color.Green;
            btnResetear.ForeColor = Color.DarkRed;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjTriangulo.ReadData(txtBase, txtAltura); // Leer datos del TextBox
            ObjTriangulo.PerimeterTriangulo(); // Calcular perímetro
            ObjTriangulo.AreaTriangulo(); // Calcular área
            ObjTriangulo.PrintData(txtPerimetro, txtArea); // Imprimir resultados en los TextBox
            ObjTriangulo.PlotShape(picCanvas); // Dibujar la figura en el PictureBox
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjTriangulo.InitializeData(txtBase, txtAltura, txtPerimetro, txtArea, picCanvas); // Inicializar datos
        }

        private void FrmTriangulo_Load(object sender, EventArgs e)
        {
            ObjTriangulo.InitializeData(txtBase, txtAltura, txtPerimetro, txtArea, picCanvas); // Inicializar datos al cargar el formulario
        }
    }
}
