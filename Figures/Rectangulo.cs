using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    internal class Rectangulo
    {
        private float mBase;
        private float mAltura;
        private float mArea;
        private float mPerimetro;
        private Graphics mGraph;
        private const float SF = 20; // Factor de escala
        private Pen mPen;

        public Rectangulo()
        {
            mBase = 0.0f;
            mAltura = 0.0f;
            mArea = 0.0f;
            mPerimetro = 0.0f;
        }

        // Leer datos desde los TextBox
        public void ReadData(TextBox txtBase, TextBox txtAltura)
        {
            try
            {
                mBase = float.Parse(txtBase.Text);
                mAltura = float.Parse(txtAltura.Text);

                if (mBase <= 0 || mAltura <= 0)
                {
                    MessageBox.Show("La base y la altura deben ser mayores a 0.", "Mensaje de error");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido. Por favor, ingrese números válidos.", "Mensaje de error");
            }
        }

        public void AreaRectangulo()
        {
            mArea = mBase * mAltura;
        }

        public void PerimeterRectangulo()
        {
            mPerimetro = 2 * (mBase + mAltura);
        }

        public void PrintData(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimetro.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtBase, TextBox txtAltura,
                                   TextBox txtPerimetro, TextBox txtArea,
                                   PictureBox picCanvas)
        {
            mBase = 0.0f;
            mAltura = 0.0f;
            mArea = 0.0f;
            mPerimetro = 0.0f;

            txtBase.Text = "";
            txtAltura.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";
            txtBase.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.DarkRed, 3);

            float width = mBase * SF;
            float height = mAltura * SF;

            float x = (picCanvas.Width - width) / 2;
            float y = (picCanvas.Height - height) / 2;

            mGraph.DrawRectangle(mPen, x, y, width, height);
        }

        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}
