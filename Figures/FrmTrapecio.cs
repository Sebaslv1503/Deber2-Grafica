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
    public partial class FrmTrapecio : Form
    {
        private Trapecio ObjTrapecio = new Trapecio();
        public FrmTrapecio()
        {
            InitializeComponent();
            btnCalcular.ForeColor = Color.Green;
            btnResetear.ForeColor = Color.DarkRed;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjTrapecio.ReadData(txtBaseMayor, txtBaseMenor, txtAltura, txtLadoIzquierdo,txtLadoDerecho);
            ObjTrapecio.PerimeterTrapecio();
            ObjTrapecio.AreaTrapecio();
            ObjTrapecio.PrintData(txtPerimetro, txtArea);
            ObjTrapecio.PlotShape(picCanvas);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjTrapecio.InitializeData(txtBaseMayor, txtBaseMenor, txtAltura, txtLadoIzquierdo, txtLadoDerecho, txtPerimetro, txtArea, picCanvas);
        }

        private void FrmTrapecio_Load(object sender, EventArgs e)
        {
            ObjTrapecio.InitializeData(txtBaseMayor, txtBaseMenor, txtAltura, txtLadoIzquierdo, txtLadoDerecho, txtPerimetro, txtArea, picCanvas);
        }
    }
}
