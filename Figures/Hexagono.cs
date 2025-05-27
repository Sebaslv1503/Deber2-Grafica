using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    internal class Hexagono
    {
        private float mRadio;
        private float mPerimetro;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20; 
        private Pen mPen;

        public Hexagono()
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

        public void PerimeterHexagono()
        {
            float lado = 2 * mRadio * (float)Math.Sin(Math.PI / 6);
            mPerimetro = 6 * lado;
        }

        public void AreaHexagono()
        {
            mArea = (3 * (float)Math.Sqrt(3) / 2) * mRadio * mRadio;
        }
        
        public void GenerarPanal(PictureBox picCanvas)
        {
            if (mRadio <= 0) return;

            picCanvas.Refresh();
            mGraph = picCanvas.CreateGraphics();

            float radio = mRadio * SF;
            float lado = radio;

            float dx = lado * 3f; 
            float dy = (float)(Math.Sqrt(3) * lado);

            int cols = (int)(picCanvas.Width / (1.5f * lado)) + 2;
            int rows = (int)(picCanvas.Height / dy) + 2;

            SolidBrush brush = new SolidBrush(Color.Yellow);
            Pen pen = new Pen(Color.OrangeRed, 2);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    float offsetX = (col * 1.5f * lado);
                    float offsetY = row * dy + ((col % 2 == 1) ? dy / 2 : 0);

                    PointF[] hexPoints = new PointF[6];
                    for (int i = 0; i < 6; i++)
                    {
                        float angle = (float)(Math.PI / 3 * i); 
                        float x = offsetX + radio * (float)Math.Cos(angle);
                        float y = offsetY + radio * (float)Math.Sin(angle);
                        hexPoints[i] = new PointF(x, y);
                    }

                    mGraph.FillPolygon(brush, hexPoints);
                    mGraph.DrawPolygon(pen, hexPoints);
                }
            }

            brush.Dispose();
            pen.Dispose();
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
            mPen = new Pen(Color.Purple, 3);

            PointF[] points = new PointF[6];
            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;

            for (int i = 0; i < 6; i++)
            {
                float angle = (float)(2 * Math.PI * i / 6 - Math.PI / 2); // inicia arriba
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
