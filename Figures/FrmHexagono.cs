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
    public partial class FrmHexagono : Form
    {
        private Hexagono ObjHexagono = new Hexagono();
        public FrmHexagono()
        {
            InitializeComponent();
            btnCalcular.ForeColor = Color.Green;
            btnResetear.ForeColor = Color.DarkRed;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjHexagono.ReadData(txtRadio);
            ObjHexagono.PerimeterHexagono();
            ObjHexagono.AreaHexagono();
            ObjHexagono.PrintData(txtPerimetro, txtArea);
            ObjHexagono.PlotShape(picCanvas);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjHexagono.InitializeData(txtRadio, txtPerimetro, txtArea, picCanvas);
        }

        private void FrmHexagono_Load(object sender, EventArgs e)
        {
            ObjHexagono.InitializeData(txtRadio, txtPerimetro, txtArea, picCanvas);
        }
    }
}
