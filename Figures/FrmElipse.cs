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
    public partial class FrmElipse : Form
    {
        private Elipse ObjElipse = new Elipse();
        public FrmElipse()
        {
            InitializeComponent();
            btnCalcular.ForeColor = Color.Green;
            btnResetear.ForeColor = Color.DarkRed;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjElipse.ReadData(txtEjeMayor, txtEjeMenor);
            ObjElipse.PerimeterElipse();
            ObjElipse.AreaElipse();
            ObjElipse.PrintData(txtPerimetro, txtArea);
            ObjElipse.PlotShape(picCanvas);

        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjElipse.InitializeData(txtEjeMayor, txtEjeMenor, txtPerimetro, txtArea, picCanvas);
        }

        private void FrmElipse_Load(object sender, EventArgs e)
        {
            ObjElipse.InitializeData(txtEjeMayor, txtEjeMenor, txtPerimetro, txtArea, picCanvas);
        }
    }
}
