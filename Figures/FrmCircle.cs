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
    public partial class FrmCircle : Form
    {
        private Circle ObjCircle = new Circle(); // Objeto de la clase Circle
        public FrmCircle()
        {
            InitializeComponent();
            btnCalcular.ForeColor = Color.Green;
            btnResetear.ForeColor = Color.DarkRed;

        }

        private void FrmCircle_Load(object sender, EventArgs e)
        {
            ObjCircle.InitializeData(txtRadio, txtArea, txtPerimetro, picCanvas);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjCircle.ReadData(txtRadio);
            ObjCircle.PerimeterCircle();
            ObjCircle.AreaCircle();
            ObjCircle.PrintData(txtPerimetro, txtArea);
            ObjCircle.PlotShape(picCanvas);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjCircle.InitializeData(txtRadio, txtArea, txtPerimetro, picCanvas);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ObjCircle.CloseForm(this);
        }
    }
}
