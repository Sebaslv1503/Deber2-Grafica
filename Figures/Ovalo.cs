using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    internal class Ovalo
    {
        private float mAncho;      // Ancho total
        private float mAlto;       // Alto total
        private float mArea;
        private float mPerimetro;
        private Graphics mGraph;
        private const float SF = 20; // Factor de escala
        private Pen mPen;

        public Ovalo()
        {
            mAncho = 0.0f;
            mAlto = 0.0f;
            mArea = 0.0f;
            mPerimetro = 0.0f;
        }

        public void ReadData(TextBox txtAncho, TextBox txtAlto)
        {
            try
            {
                mAncho = float.Parse(txtAncho.Text);
                mAlto = float.Parse(txtAlto.Text);

                if (mAncho <= 0 || mAlto <= 0)
                {
                    MessageBox.Show("El ancho y el alto deben ser mayores a 0.", "Mensaje de error");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido. Por favor, ingrese números válidos.", "Mensaje de error");
            }
        }

        public void AreaOvalo()
        {
            float a = mAncho / 2;
            float b = mAlto / 2;
            mArea = (float)(Math.PI * a * b);
        }

        public void PerimeterOvalo()
        {
            float a = mAncho / 2;
            float b = mAlto / 2;
            mPerimetro = (float)(Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b))));
        }

        public void PrintData(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimetro.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtAncho, TextBox txtAlto,
                                   TextBox txtPerimetro, TextBox txtArea,
                                   PictureBox picCanvas)
        {
            mAncho = 0.0f;
            mAlto = 0.0f;
            mArea = 0.0f;
            mPerimetro = 0.0f;

            txtAncho.Text = "";
            txtAlto.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";
            txtAncho.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.DarkCyan, 3);

            float width = mAncho * SF;
            float height = mAlto * SF;

            float x = (picCanvas.Width - width) / 2;
            float y = (picCanvas.Height - height) / 2;

            mGraph.DrawEllipse(mPen, x, y, width, height);
        }

        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}
