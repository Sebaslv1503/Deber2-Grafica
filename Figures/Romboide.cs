using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    internal class Romboide
    {
        private float mBase;
        private float mAltura;
        private float mArea;
        private float mPerimetro;
        private Graphics mGraph;
        private float SF = 20f;
        private Pen mPen;
        private float offsetX = 0;
        private float offsetY = 0;
        private float angulo = 0; // Ángulo de rotación

        public Romboide()
        {
            mBase = 0.0f;
            mAltura = 0.0f;
            mArea = 0.0f;
            mPerimetro = 0.0f;
        }
        public void SetZoom(int zoomLevel, PictureBox picCanvas)
        {
            SF = zoomLevel * 4f; // Ajusta el factor de escala (puedes calibrar este número)
            PlotShape(picCanvas);
        }

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
                MessageBox.Show("Ingreso no válido. Ingrese valores numéricos.", "Mensaje de error");
            }
        }

        public void AreaRomboide()
        {
            mArea = mBase * mAltura;
        }

        public void PerimeterRomboide()
        {
            mPerimetro = 2 * (mBase + mBase);
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
            angulo = 0;
            offsetX = 0;
            offsetY = 0;

            txtBase.Text = "";
            txtAltura.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";
            txtBase.Focus();
            picCanvas.Refresh();
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

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Purple, 3);

            float baseLength = mBase * SF;
            float height = mAltura * SF;
            float skewOffset = baseLength / 3;

            float cx = picCanvas.Width / 2 + offsetX;
            float cy = picCanvas.Height / 2 + offsetY;

            float x = -baseLength / 2;
            float y = -height / 2;

            PointF[] points = new PointF[4];
            points[0] = new PointF(x + skewOffset, y);
            points[1] = new PointF(x + skewOffset + baseLength, y);
            points[2] = new PointF(x + baseLength, y + height);
            points[3] = new PointF(x, y + height);

            // Convertir ángulo a radianes
            float rad = angulo * (float)Math.PI / 180f;

            // Aplicar rotación y traslación
            for (int i = 0; i < points.Length; i++)
            {
                float px = points[i].X;
                float py = points[i].Y;

                float xRot = px * (float)Math.Cos(rad) - py * (float)Math.Sin(rad);
                float yRot = px * (float)Math.Sin(rad) + py * (float)Math.Cos(rad);

                points[i] = new PointF(cx + xRot, cy + yRot);
            }

            picCanvas.Refresh();
            mGraph.DrawPolygon(mPen, points);
        }

        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}
