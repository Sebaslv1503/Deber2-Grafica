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
    public partial class FrmDecagono : Form
    {
        private Decagono ObjDecagono = new Decagono(); // Instancia de la clase Decagono    
        public FrmDecagono()
        {
            InitializeComponent();
            btnCalcular.ForeColor = Color.Green;
            btnResetear.ForeColor = Color.DarkRed;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjDecagono.ReadData(txtRadio); // Leer datos del TextBox
            ObjDecagono.PerimeterDecagono(); // Calcular perímetro
            ObjDecagono.AreaDecagono(); // Calcular área
            ObjDecagono.PrintData(txtPerimetro, txtArea); // Imprimir resultados en los TextBox
            ObjDecagono.PlotShape(picCanvas); // Dibujar la figura en el PictureBox
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjDecagono.InitializeData(txtRadio, txtPerimetro, txtArea, picCanvas); // Inicializar datos
        }

        private void FrmDecagono_Load(object sender, EventArgs e)
        {
            ObjDecagono.InitializeData(txtRadio, txtPerimetro, txtArea, picCanvas); // Inicializar datos al cargar el formulario
        }
    }
}
