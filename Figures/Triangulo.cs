using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    internal class Triangulo
    {
        private float mBase;
        private float mAltura;
        private float mPerimetro;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public Triangulo()
        {
            mBase = 0.0f;
            mAltura = 0.0f;
            mPerimetro = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtBase, TextBox txtAltura)
        {
            try
            {
                mBase = float.Parse(txtBase.Text);
                mAltura = float.Parse(txtAltura.Text);

                if (mBase <= 0 || mAltura <= 0)
                {
                    MessageBox.Show("Los valores de base y altura deben ser mayores a 0.", "Mensaje de error");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido. Por favor, ingrese números válidos.", "Mensaje de error");
            }
        }

        public void AreaTriangulo()
        {
            mArea = (mBase * mAltura) / 2;
        }

        public void PerimeterTriangulo()
        {
            // Asumimos triángulo rectángulo para estimar el perímetro:
            float hipotenusa = (float)Math.Sqrt(Math.Pow(mBase, 2) + Math.Pow(mAltura, 2));
            mPerimetro = mBase + mAltura + hipotenusa;
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
            mPerimetro = 0.0f;
            mArea = 0.0f;

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

            PointF[] points = new PointF[3];
            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;

            float halfBase = mBase * SF / 2;
            float height = mAltura * SF;

            // Puntos: inferior izquierda, inferior derecha, superior centro
            points[0] = new PointF(centerX - halfBase, centerY + height / 2); // Izquierda
            points[1] = new PointF(centerX + halfBase, centerY + height / 2); // Derecha
            points[2] = new PointF(centerX, centerY - height / 2);            // Arriba

            mGraph.DrawPolygon(mPen, points);
        }

        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}
