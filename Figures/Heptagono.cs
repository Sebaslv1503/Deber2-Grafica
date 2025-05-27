using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    internal class Heptagono
    {
        private float mRadio;
        private float mPerimetro;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20; // Factor de escala
        private Pen mPen;

        public Heptagono()
        {
            mRadio = 0.0f;
            mPerimetro = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtRadio)
        {
            try
            {
                mRadio = float.Parse(txtRadio.Text);
                if (mRadio <= 0)
                {
                    MessageBox.Show("El radio debe ser un número positivo.", "Error de validación");
                    mRadio = 0.0f;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido. Ingrese un número válido.", "Mensaje de error");
            }
        }

        public void PerimeterHeptagono()
        {
            float lado = 2 * mRadio * (float)Math.Sin(Math.PI / 7);
            mPerimetro = 7 * lado;
        }

        public void AreaHeptagono()
        {
            // Área de un heptágono regular con radio R circunscrito
            mArea = (7f / 2f) * mRadio * mRadio * (float)Math.Sin(2 * Math.PI / 7);
        }

        public void PrintData(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimetro.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtRadio, TextBox txtPerimetro,
                                   TextBox txtArea, PictureBox picCanvas)
        {
            mRadio = 0.0f;
            mPerimetro = 0.0f;
            mArea = 0.0f;

            txtRadio.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";
            txtRadio.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.MediumPurple, 3);

            PointF[] points = new PointF[7];
            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;

            for (int i = 0; i < 7; i++)
            {
                float angle = (float)(2 * Math.PI * i / 7 - Math.PI / 2);
                float x = centerX + mRadio * SF * (float)Math.Cos(angle);
                float y = centerY + mRadio * SF * (float)Math.Sin(angle);
                points[i] = new PointF(x, y);
            }

            mGraph.DrawPolygon(mPen, points);
        }

        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}
