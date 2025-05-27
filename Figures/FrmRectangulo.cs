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
    public partial class FrmRectangulo : Form
    {
        private Rectangulo ObjRectangulo = new Rectangulo();
        public FrmRectangulo()
        {
            InitializeComponent();
            btnCalcular.ForeColor = Color.Green;
            btnResetear.ForeColor = Color.DarkRed;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjRectangulo.ReadData(txtBase, txtAltura);
            ObjRectangulo.PerimeterRectangulo();
            ObjRectangulo.AreaRectangulo();
            ObjRectangulo.PrintData(txtPerimetro, txtArea);
            ObjRectangulo.PlotShape(picCanvas);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjRectangulo.InitializeData(txtBase, txtAltura, txtPerimetro, txtArea, picCanvas);
        }

        private void FrmRectangulo_Load(object sender, EventArgs e)
        {
            ObjRectangulo.InitializeData(txtBase, txtAltura, txtPerimetro, txtArea, picCanvas);
        }
    }
}
