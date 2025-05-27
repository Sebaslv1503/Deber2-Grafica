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
    public partial class FrmEneagono : Form
    {
        private Eneagono ObjEneagono = new Eneagono();
        public FrmEneagono()
        {
            InitializeComponent();
            btnCalcular.ForeColor = Color.Green;
            btnResetear.ForeColor = Color.DarkRed;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjEneagono.ReadData(txtRadio);
            ObjEneagono.PerimeterEneagono();
            ObjEneagono.AreaEneagono();
            ObjEneagono.PrintData(txtPerimetro, txtArea);
            ObjEneagono.PlotShape(picCanvas);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjEneagono.InitializeData(txtRadio, txtPerimetro, txtArea, picCanvas);
        }

        private void FrmEneagono_Load(object sender, EventArgs e)
        {
            ObjEneagono.InitializeData(txtRadio, txtPerimetro, txtArea, picCanvas);
        }
    }
}
