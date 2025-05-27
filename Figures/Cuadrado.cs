using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    internal class Cuadrado
    {
        private float mLado;
        private float mArea;
        private float mPerimetro;
        private Graphics mGraph;
        private const float SF = 20; 
        private Pen mPen;

        public Cuadrado()
        {
            mLado = 0.0f;
            mArea = 0.0f;
            mPerimetro = 0.0f;
        }

        public void ReadData(TextBox txtLado)
        {
            try
            {
                mLado = float.Parse(txtLado.Text);
                if (mLado <= 0)
                {
                    MessageBox.Show("El lado debe ser mayor a 0.", "Mensaje de error");
                    mLado = 0.0f;
                }
            }
            catch
            {
                MessageBox.Show("Entrada no válida. Ingrese un número válido.", "Mensaje de error");
            }
        }

       
        public void AreaCuadrado()
        {
            mArea = mLado * mLado;
        }

        public void PerimeterCuadrado()
        {
            mPerimetro = 4 * mLado;
        }

        
        public void PrintData(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimetro.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtLado, TextBox txtPerimetro,
                                   TextBox txtArea, PictureBox picCanvas)
        {
            mLado = 0.0f;
            mPerimetro = 0.0f;
            mArea = 0.0f;

            txtLado.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";
            txtLado.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.DarkGreen, 3);

            float size = mLado * SF;
            float x = (picCanvas.Width - size) / 2;
            float y = (picCanvas.Height - size) / 2;

            mGraph.DrawRectangle(mPen, x, y, size, size);
        }

        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}
