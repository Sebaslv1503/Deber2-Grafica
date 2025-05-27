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
    public partial class FrmRomboide : Form
    {
        private Romboide ObjRomboide = new Romboide();
        public FrmRomboide()
        {
            InitializeComponent();
            btnCalcular.ForeColor = Color.Green;
            btnResetear.ForeColor = Color.DarkRed;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjRomboide.ReadData(txtBase, txtAltura);
            ObjRomboide.PerimeterRomboide();
            ObjRomboide.AreaRomboide();
            ObjRomboide.PrintData(txtPerimetro, txtArea);
            ObjRomboide.PlotShape(picCanvas);

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                case Keys.Down:
                case Keys.Left:
                case Keys.Right:
                    ObjRomboide.MoveShape(keyData, picCanvas);
                    return true;
                case Keys.Q:
                    ObjRomboide.Rotar("antihorario", picCanvas);
                    return true;

                case Keys.E:
                    ObjRomboide.Rotar("horario", picCanvas);
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjRomboide.InitializeData(txtBase, txtAltura, txtPerimetro, txtArea, picCanvas);
        }

        private void FrmRomboide_Load(object sender, EventArgs e)
        {
            ObjRomboide.InitializeData(txtBase, txtAltura, txtPerimetro, txtArea, picCanvas);
        }

        private void trackZoom_Scroll(object sender, EventArgs e)
        {
            ObjRomboide.SetZoom(trackZoom.Value, picCanvas);

        }
    }
}
