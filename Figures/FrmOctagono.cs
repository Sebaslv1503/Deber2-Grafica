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
    public partial class FrmOctagono : Form
    {
        private Octagono ObjOctagono = new Octagono();
        public FrmOctagono()
        {
            InitializeComponent();
            btnCalcular.ForeColor = Color.Green;
            btnResetear.ForeColor = Color.DarkRed;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjOctagono.ReadData(txtRadio);
            ObjOctagono.PerimeterOctagono();
            ObjOctagono.AreaOctagono();
            ObjOctagono.PrintData(txtPerimetro, txtArea);
            ObjOctagono.PlotShape(picCanvas);

        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjOctagono.InitializeData(txtRadio, txtPerimetro, txtArea, picCanvas);
        }

        private void FrmOctagono_Load(object sender, EventArgs e)
        {
            ObjOctagono.InitializeData(txtRadio, txtPerimetro, txtArea, picCanvas);
        }
    }
}
