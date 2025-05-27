using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    internal class Trapecio
    {
        private float mBaseMayor;
        private float mBaseMenor;
        private float mAltura;
        private float mLadoIzquierdo;
        private float mLadoDerecho;
        private float mPerimetro;
        private float mArea;

        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20; // Escala de dibujo

        public Trapecio()
        {
            mBaseMayor = mBaseMenor = mAltura = mLadoIzquierdo = mLadoDerecho = 0.0f;
            mPerimetro = mArea = 0.0f;
        }

        public void ReadData(TextBox txtBaseMayor, TextBox txtBaseMenor, TextBox txtAltura,
                             TextBox txtLadoIzquierdo, TextBox txtLadoDerecho)
        {
            try
            {
                mBaseMayor = float.Parse(txtBaseMayor.Text);
                mBaseMenor = float.Parse(txtBaseMenor.Text);
                mAltura = float.Parse(txtAltura.Text);
                mLadoIzquierdo = float.Parse(txtLadoIzquierdo.Text);
                mLadoDerecho = float.Parse(txtLadoDerecho.Text);

                if (mBaseMayor <= 0 || mBaseMenor <= 0 || mAltura <= 0 || mLadoIzquierdo <= 0 || mLadoDerecho <= 0)
                {
                    MessageBox.Show("Todos los valores deben ser positivos.", "Error de entrada");
                    ResetData();
                    return;
                }

                if (!ValidateGeometry())
                {
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

        private bool ValidateGeometry()
        {
            if (mLadoIzquierdo < mAltura || mLadoDerecho < mAltura)
            {
                MessageBox.Show("Los lados inclinados deben ser al menos tan largos como la altura.", "Error geométrico");
                return false;
            }

            float dxIzq = (float)Math.Sqrt(mLadoIzquierdo * mLadoIzquierdo - mAltura * mAltura);
            float dxDer = (float)Math.Sqrt(mLadoDerecho * mLadoDerecho - mAltura * mAltura);
            float diferenciaBases = Math.Abs(mBaseMayor - mBaseMenor);

            if ((dxIzq + dxDer) < diferenciaBases)
            {
                MessageBox.Show("Los lados inclinados no permiten cerrar el trapecio con esas bases.", "Error geométrico");
                return false;
            }

            return true;
        }

        public void PerimeterTrapecio()
        {
            mPerimetro = mBaseMayor + mBaseMenor + mLadoIzquierdo + mLadoDerecho;
        }

        public void AreaTrapecio()
        {
            mArea = ((mBaseMayor + mBaseMenor) / 2) * mAltura;
        }

        public void PrintData(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimetro.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtBaseMayor, TextBox txtBaseMenor,
                                   TextBox txtAltura, TextBox txtLadoIzquierdo,
                                   TextBox txtLadoDerecho, TextBox txtPerimetro,
                                   TextBox txtArea, PictureBox picCanvas)
        {
            ResetData();

            txtBaseMayor.Text = "";
            txtBaseMenor.Text = "";
            txtAltura.Text = "";
            txtLadoIzquierdo.Text = "";
            txtLadoDerecho.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";
            txtBaseMayor.Focus();
            picCanvas.Refresh();
        }

        private void ResetData()
        {
            mBaseMayor = mBaseMenor = mAltura = mLadoIzquierdo = mLadoDerecho = 0.0f;
            mPerimetro = mArea = 0.0f;
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.DarkGreen, 3);

            float baseMayor = mBaseMayor * SF;
            float baseMenor = mBaseMenor * SF;
            float altura = mAltura * SF;
            float dxIzq = (float)Math.Sqrt(mLadoIzquierdo * mLadoIzquierdo - mAltura * mAltura) * SF;
            float dxDer = (float)Math.Sqrt(mLadoDerecho * mLadoDerecho - mAltura * mAltura) * SF;

            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;

            float y1 = centerY - altura / 2;
            float y2 = centerY + altura / 2;

            // Vértices del trapecio escaleno
            PointF[] points = new PointF[4];
            points[0] = new PointF(centerX - baseMayor / 2, y1);                   // Base mayor izquierda
            points[1] = new PointF(centerX + baseMayor / 2, y1);                   // Base mayor derecha
            points[2] = new PointF(centerX + baseMenor / 2 - dxDer, y2);           // Base menor derecha
            points[3] = new PointF(centerX - baseMenor / 2 + dxIzq, y2);           // Base menor izquierda

            mGraph.DrawPolygon(mPen, points);
        }

        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}
