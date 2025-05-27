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
    public partial class FrmRombo : Form
    {
        private Rombo ObjRombo = new Rombo(); 

        public FrmRombo()
        {
            InitializeComponent();
            btnCalcular.ForeColor = Color.Green;
            btnResetear.ForeColor = Color.DarkRed;

            
        }


        

        private void FrnRombo_Load(object sender, EventArgs e)
        {
            
            ObjRombo.InitializeData(txtLado, txtAltura, txtArea, txtPerimetro, picCanvas);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjRombo.ReadData(txtLado, txtAltura);
            ObjRombo.PerimeterRombo();
            ObjRombo.AreaRombo();
            ObjRombo.PrintData(txtPerimetro, txtArea);
            ObjRombo.PlotShape(picCanvas);

            
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                case Keys.Down:
                case Keys.Left:
                case Keys.Right:
                    ObjRombo.MoveShape(keyData, picCanvas);
                    return true;

                case Keys.Q:
                    ObjRombo.Rotar("antihorario", picCanvas);
                    return true;

                case Keys.E:
                    ObjRombo.Rotar("horario", picCanvas);
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }



        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjRombo.InitializeData(txtLado, txtAltura, txtArea, txtPerimetro, picCanvas);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ObjRombo.CloseForm(this);
        }

        private void trackZoom_Scroll(object sender, EventArgs e)
        {
            ObjRombo.SetZoom(trackZoom.Value, picCanvas);
            
        }
    }
}