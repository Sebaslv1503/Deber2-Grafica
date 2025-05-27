using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    internal class Rombo
    {
        // Datos del miembro
        private float mLado;        // Lado del rombo
        private float mAltura;      // Altura del rombo
        private float mPerimeter;   // Perímetro del rombo
        private float mArea;       // Área del rombo
        private Graphics mGraph;    // Objeto para modo gráfico
        private float SF = 20f; // Factor de escala (zoom in/zoom out)
        private Pen mPen;           // Bolígrafo para dibujar
        private float offsetX = 0;
        private float offsetY = 0;
        private float angulo = 0;

        // Constructor sin parámetros
        public Rombo()
        {
            mLado = 0.0f;
            mAltura = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        // Función que lee los datos de entrada del rombo (lado y altura)
        public void ReadData(TextBox txtLado, TextBox txtAltura)
        {
            try
            {
                mLado = float.Parse(txtLado.Text);
                mAltura = float.Parse(txtAltura.Text);

                if (mLado <= 0 || mAltura <= 0)
                {
                    MessageBox.Show("Los valores de lado y altura deben ser mayores a 0.", "Mensaje de error");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido. Por favor, ingrese números válidos.", "Mensaje de error");
            }
        }

        // Función que calcula el perímetro del rombo
        public void PerimeterRombo()
        {
            mPerimeter = 4 * mLado; // Todos los lados son iguales en un rombo
        }

        // Función que calcula el área del rombo
        public void AreaRombo()
        {
            mArea = mLado * mAltura; // Área = lado * altura
        }
        public void SetZoom(int zoomLevel, PictureBox picCanvas)
        {
            SF = zoomLevel * 4f; // Ajusta el factor de escala (puedes calibrar este número)
            PlotShape(picCanvas);
        }

        // Función que imprime el perímetro y el área del rombo
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        // Función que inicializa los datos y controles del rombo
        public void InitializeData(TextBox txtLado, TextBox txtAltura,
                                 TextBox txtPerimeter, TextBox txtArea,
                                 PictureBox picCanvas)
        {
            mLado = 0.0f;
            mAltura = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;

            txtLado.Text = "";
            txtAltura.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtLado.Focus();
            picCanvas.Refresh();
        }

        // Función que grafica un rombo
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            picCanvas.Refresh();

            float centerX = picCanvas.Width / 2 + offsetX;
            float centerY = picCanvas.Height / 2 + offsetY;

            float halfAltura = mAltura * SF / 2;
            float halfLado = mLado * SF / 2;

            // Puntos base sin rotación (rombo vertical)
            PointF[] points = new PointF[]
            {
            new PointF(0, -halfAltura), // arriba
            new PointF(halfLado, 0),    // derecha
            new PointF(0, halfAltura),  // abajo
            new PointF(-halfLado, 0)    // izquierda
            };

            float rad = angulo * (float)Math.PI / 180f;
            for (int i = 0; i < points.Length; i++)
            {
                float x = points[i].X;
                float y = points[i].Y;

                float xRot = x * (float)Math.Cos(rad) - y * (float)Math.Sin(rad);
                float yRot = x * (float)Math.Sin(rad) + y * (float)Math.Cos(rad);

                points[i] = new PointF(centerX + xRot, centerY + yRot);
            }

            mGraph.DrawPolygon(mPen, points);
        }
        public void MoveShape(Keys key, PictureBox picCanvas)
        {
            const float step = 10f; // desplazamiento por tecla

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
            if (sentido == "horario") angulo += paso;
            else if (sentido == "antihorario") angulo -= paso;

            PlotShape(picCanvas);
        }

        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}