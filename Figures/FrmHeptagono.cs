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
    public partial class FrmHeptagono : Form
    {
        private Heptagono ObjHeptagono = new Heptagono();
        public FrmHeptagono()
        {
            InitializeComponent();
            btnCalcular.ForeColor = Color.Green;
            btnResetear.ForeColor = Color.DarkRed;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjHeptagono.ReadData(txtRadio);
            ObjHeptagono.PerimeterHeptagono();
            ObjHeptagono.AreaHeptagono();
            ObjHeptagono.PrintData(txtPerimetro, txtArea);
            ObjHeptagono.PlotShape(picCanvas);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjHeptagono.InitializeData(txtRadio, txtPerimetro, txtArea, picCanvas);
        }

        private void FrmHeptagono_Load(object sender, EventArgs e)
        {
            ObjHeptagono.InitializeData(txtRadio, txtPerimetro, txtArea, picCanvas);
        }
    }
}
