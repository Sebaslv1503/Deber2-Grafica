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
    public partial class FrmCuadrado : Form
    {
        private Cuadrado ObjCuadrado = new Cuadrado();
        public FrmCuadrado()
        {
            InitializeComponent();
            btnCalcular.ForeColor = Color.Green;
            btnResetear.ForeColor = Color.DarkRed;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjCuadrado.ReadData(txtLado);
            ObjCuadrado.PerimeterCuadrado();
            ObjCuadrado.AreaCuadrado();
            ObjCuadrado.PrintData(txtPerimetro, txtArea);
            ObjCuadrado.PlotShape(picCanvas);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjCuadrado.InitializeData(txtLado, txtPerimetro, txtArea, picCanvas);
        }

        private void FrmCuadrado_Load(object sender, EventArgs e)
        {
            ObjCuadrado.InitializeData(txtLado, txtPerimetro, txtArea, picCanvas);
        }
    }
}
