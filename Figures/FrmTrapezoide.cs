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
    public partial class FrmTrapezoide : Form
    {
        private Trapezoide ObjTrapezoide = new Trapezoide();
        public FrmTrapezoide()
        {
            InitializeComponent();
            btnCalcular.ForeColor = Color.Green;
            btnResetear.ForeColor = Color.DarkRed;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjTrapezoide.ReadData(txtLado1, txtLado2, txtLado3, txtLado4, txtAltura);
            ObjTrapezoide.PerimeterTrapezoide();
            ObjTrapezoide.AreaTrapezoide();
            ObjTrapezoide.PrintData(txtPerimetro, txtArea);
            ObjTrapezoide.PlotShape(picCanvas);

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                case Keys.Down:
                case Keys.Left:
                case Keys.Right:
                    ObjTrapezoide.MoveShape(keyData, picCanvas);
                    return true;
                case Keys.Q:
                    ObjTrapezoide.Rotar("antihorario", picCanvas);
                    return true;

                case Keys.E:
                    ObjTrapezoide.Rotar("horario", picCanvas);
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjTrapezoide.InitializeData(txtLado1, txtLado2, txtLado3, txtLado4, txtAltura, txtPerimetro, txtArea, picCanvas);
        }

        private void FrmTrapezoide_Load(object sender, EventArgs e)
        {
            ObjTrapezoide.InitializeData(txtLado1, txtLado2, txtLado3, txtLado4, txtAltura, txtPerimetro, txtArea, picCanvas);
        }

        private void trackZoom_Scroll(object sender, EventArgs e)
        {
            ObjTrapezoide.SetZoom(trackZoom.Value, picCanvas);

        }
    }
}
