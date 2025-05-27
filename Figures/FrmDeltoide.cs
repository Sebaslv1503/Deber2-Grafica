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
    public partial class FrmDeltoide : Form
    {
        private Deltoide ObjDeltoide = new Deltoide();
        public FrmDeltoide()
        {
            InitializeComponent();
            btnCalcular.ForeColor = Color.Green;
            btnResetear.ForeColor = Color.DarkRed;
            lblAnguloMessage.Visible = false;
        }

        private void txtAngulo_Enter(object sender, EventArgs e)
        {
            lblAnguloMessage.Visible = true;  // Hacer visible el mensaje
        }

        private void txtAngulo_Leave(object sender, EventArgs e)
        {
            lblAnguloMessage.Visible = false; // Ocultar el mensaje cuando sale del campo
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjDeltoide.ReadData(txtLado1, txtLado2, txtAngulo);
            ObjDeltoide.PerimeterDeltoide();
            ObjDeltoide.AreaDeltoide();
            ObjDeltoide.PrintData(txtPerimetro, txtArea);
            ObjDeltoide.PlotShape(picCanvas);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjDeltoide.InitializeData(txtLado1, txtLado2, txtAngulo, txtPerimetro, txtArea, picCanvas);
        }

        private void FrmDeltoide_Load(object sender, EventArgs e)
        {
            ObjDeltoide.InitializeData(txtLado1, txtLado2, txtAngulo, txtPerimetro, txtArea, picCanvas);
        }
    }
}
