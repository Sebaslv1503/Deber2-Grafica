using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    internal class Trapezoide
    {
        private float mLado1, mLado2, mLado3, mLado4, mAltura;
        private float mPerimetro, mArea;

        private Graphics mGraph;
        private Pen mPen;
        private float SF = 20f;
        private float offsetX = 0;
        private float offsetY = 0;
        private float angulo = 0; // Ángulo de rotación

        public Trapezoide()
        {
            ResetData();
        }

        public void ReadData(TextBox txtLado1, TextBox txtLado2, TextBox txtLado3,
                             TextBox txtLado4, TextBox txtAltura)
        {
            try
            {
                mLado1 = float.Parse(txtLado1.Text);
                mLado2 = float.Parse(txtLado2.Text);
                mLado3 = float.Parse(txtLado3.Text);
                mLado4 = float.Parse(txtLado4.Text);
                mAltura = float.Parse(txtAltura.Text);

                if (mLado1 <= 0 || mLado2 <= 0 || mLado3 <= 0 || mLado4 <= 0 || mAltura <= 0)
                {
                    MessageBox.Show("Todos los valores deben ser positivos.", "Error de entrada");
                    ResetData();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Por favor, ingrese solo números válidos.", "Error de entrada");
                ResetData();
            }
        }
        public void SetZoom(int zoomLevel, PictureBox picCanvas)
        {
            SF = zoomLevel * 4f; 
            PlotShape(picCanvas);
        }

        public void PerimeterTrapezoide()
        {
            mPerimetro = mLado1 + mLado2 + mLado3 + mLado4;
        }

        public void AreaTrapezoide()
        {
            mArea = ((mLado1 + mLado3) / 2) * mAltura;
        }

        public void PrintData(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimetro.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtLado1, TextBox txtLado2, TextBox txtLado3,
                                   TextBox txtLado4, TextBox txtAltura, TextBox txtPerimetro,
                                   TextBox txtArea, PictureBox picCanvas)
        {
            ResetData();

            txtLado1.Text = "";
            txtLado2.Text = "";
            txtLado3.Text = "";
            txtLado4.Text = "";
            txtAltura.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";
            txtLado1.Focus();
            picCanvas.Refresh();
        }

        private void ResetData()
        {
            mLado1 = mLado2 = mLado3 = mLado4 = mAltura = 0.0f;
            mPerimetro = mArea = 0.0f;
            offsetX = offsetY = angulo = 0.0f;
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.DarkRed, 3);

            float lado1 = mLado1 * SF;
            float lado3 = mLado3 * SF;
            float altura = mAltura * SF;

            float cx = picCanvas.Width / 2 + offsetX;
            float cy = picCanvas.Height / 2 + offsetY;

            float y1 = -altura / 2;
            float y2 = altura / 2;

            // Coordenadas relativas al centro
            PointF[] points = new PointF[4];
            points[0] = new PointF(-lado1 / 2, y1);    // Punto A
            points[1] = new PointF(lado1 / 2, y1);     // Punto B
            points[2] = new PointF(lado3 / 2, y2);     // Punto C
            points[3] = new PointF(-lado3 / 2, y2);    // Punto D

            // Rotación
            float rad = angulo * (float)Math.PI / 180f;

            for (int i = 0; i < points.Length; i++)
            {
                float x = points[i].X;
                float y = points[i].Y;

                float xRot = x * (float)Math.Cos(rad) - y * (float)Math.Sin(rad);
                float yRot = x * (float)Math.Sin(rad) + y * (float)Math.Cos(rad);

                points[i] = new PointF(cx + xRot, cy + yRot);
            }

            picCanvas.Refresh();
            mGraph.DrawPolygon(mPen, points);
        }

        public void MoveShape(Keys key, PictureBox picCanvas)
        {
            const float step = 10f;

            switch (key)
            {
                case Keys.Left:
                    offsetX -= step;
                    break;
                case Keys.Right:
                    offsetX += step;
                    break;
                case Keys.Up:
                    offsetY -= step;
                    break;
                case Keys.Down:
                    offsetY += step;
                    break;
            }

            PlotShape(picCanvas);
        }

        public void Rotar(string sentido, PictureBox picCanvas)
        {
            float paso = 10f;
            if (sentido == "horario")
                angulo += paso;
            else if (sentido == "antihorario")
                angulo -= paso;

            PlotShape(picCanvas);
        }

        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}
