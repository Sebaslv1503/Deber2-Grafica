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
    public partial class FrmOvalo : Form
    {
        private Ovalo ObjOvalo = new Ovalo();
        public FrmOvalo()
        {
            InitializeComponent();
            btnCalcular.ForeColor = Color.Green;
            btnResetear.ForeColor = Color.DarkRed;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjOvalo.ReadData(txtAncho, txtAlto);
            ObjOvalo.PerimeterOvalo();
            ObjOvalo.AreaOvalo();
            ObjOvalo.PrintData(txtPerimetro, txtArea);
            ObjOvalo.PlotShape(picCanvas);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjOvalo.InitializeData(txtAncho, txtAlto, txtPerimetro, txtArea, picCanvas);
        }

        private void FrmOvalo_Load(object sender, EventArgs e)
        {
            ObjOvalo.InitializeData(txtAncho, txtAlto, txtPerimetro, txtArea, picCanvas);
        }
    }
}
