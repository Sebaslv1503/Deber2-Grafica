using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    internal class Octagono
    {
        private float mRadio;
        private float mPerimetro;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20; // Factor de escala
        private Pen mPen;

        public Octagono()
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

        public void PerimeterOctagono()
        {
            float lado = 2 * mRadio * (float)Math.Sin(Math.PI / 8); // Lado del octágono regular
            mPerimetro = 8 * lado;
        }

        public void AreaOctagono()
        {
            // Área con radio (R) circunscrito
            mArea = 4 * mRadio * mRadio * (float)Math.Sin(Math.PI / 4); // Fórmula equivalente a: (n/2)*R^2*sin(2pi/n)
        }

        public void PrintData(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimetro.ToString();
            txtArea.Text = mArea.ToString();
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
            mPen = new Pen(Color.DarkOrange, 3);

            PointF[] points = new PointF[8];
            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;

            for (int i = 0; i < 8; i++)
            {
                float angle = (float)(2 * Math.PI * i / 8 - Math.PI / 2); // inicio hacia arriba
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
