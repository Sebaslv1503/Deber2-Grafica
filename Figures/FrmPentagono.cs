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
    public partial class FrmPentagono : Form
    {
        private Pentagono ObjPentagono = new Pentagono();
        public FrmPentagono()
        {
            InitializeComponent();
            btnCalcular.ForeColor = Color.Green;
            btnResetear.ForeColor = Color.DarkRed;
        }

        private void FrmPentagono_Load(object sender, EventArgs e)
        {
            ObjPentagono.InitializeData(txtRadio, txtPerimetro, txtArea, picCanvas);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjPentagono.ReadData(txtRadio);
            ObjPentagono.PerimeterPentagono();
            ObjPentagono.AreaPentagono();
            ObjPentagono.PrintData(txtPerimetro, txtArea);
            ObjPentagono.PlotShape(picCanvas);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                case Keys.Down:
                case Keys.Left:
                case Keys.Right:
                    ObjPentagono.MoveShape(keyData, picCanvas); // Usa tu instancia
                    return true;

                case Keys.Q:
                    ObjPentagono.Rotar("antihorario", picCanvas);
                    return true;

                case Keys.E:
                    ObjPentagono.Rotar("horario", picCanvas);
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjPentagono.InitializeData(txtRadio, txtPerimetro, txtArea, picCanvas);
        }

        private void trackZoom_Scroll(object sender, EventArgs e)
        {
            ObjPentagono.SetZoom(trackZoom.Value, picCanvas);

        }
    }
}
