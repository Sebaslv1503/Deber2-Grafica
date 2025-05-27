using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    internal class TrapecioIso
    {
        private float mBaseMayor;
        private float mBaseMenor;
        private float mAltura;
        private float mArea;
        private float mPerimetro;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public TrapecioIso()
        {
            mBaseMayor = 0.0f;
            mBaseMenor = 0.0f;
            mAltura = 0.0f;
            mArea = 0.0f;
            mPerimetro = 0.0f;
        }

        public void ReadData(TextBox txtBaseMayor, TextBox txtBaseMenor, TextBox txtAltura)
        {
            try
            {
                mBaseMayor = float.Parse(txtBaseMayor.Text);
                mBaseMenor = float.Parse(txtBaseMenor.Text);
                mAltura = float.Parse(txtAltura.Text);

                if (mBaseMayor <= 0 || mBaseMenor <= 0 || mAltura <= 0)
                {
                    MessageBox.Show("Todos los valores deben ser mayores a 0.", "Error de validación");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Mensaje de error");
            }
        }

        public void AreaTrapecio()
        {
            mArea = ((mBaseMayor + mBaseMenor) * mAltura) / 2;
        }

        public void PerimeterTrapecio()
        {
            // Suponiendo trapecio isósceles para calcular los lados inclinados
            float ladoInclinado = (float)Math.Sqrt(Math.Pow((mBaseMayor - mBaseMenor) / 2, 2) + Math.Pow(mAltura, 2));
            mPerimetro = mBaseMayor + mBaseMenor + 2 * ladoInclinado;
        }

        public void PrintData(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimetro.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtBaseMayor, TextBox txtBaseMenor, TextBox txtAltura,
                                   TextBox txtPerimetro, TextBox txtArea, PictureBox picCanvas)
        {
            mBaseMayor = 0.0f;
            mBaseMenor = 0.0f;
            mAltura = 0.0f;
            mArea = 0.0f;
            mPerimetro = 0.0f;

            txtBaseMayor.Text = "";
            txtBaseMenor.Text = "";
            txtAltura.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";
            txtBaseMayor.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.DarkSlateBlue, 3);

            float baseMayor = mBaseMayor * SF;
            float baseMenor = mBaseMenor * SF;
            float altura = mAltura * SF;

            float x = (picCanvas.Width - baseMayor) / 2;
            float y = (picCanvas.Height - altura) / 2;

            float offset = (baseMayor - baseMenor) / 2;

            PointF[] points = new PointF[4];
            points[0] = new PointF(x, y); // izquierda base mayor
            points[1] = new PointF(x + baseMayor, y); // derecha base mayor
            points[2] = new PointF(x + baseMayor - offset, y + altura); // derecha base menor
            points[3] = new PointF(x + offset, y + altura); // izquierda base menor

            mGraph.DrawPolygon(mPen, points);
        }

        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}
