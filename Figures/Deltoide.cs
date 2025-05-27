using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    internal class Deltoide
    {
        private float mLado1;   
        private float mLado2;    
        private float mAngulo;  
        private float mArea;
        private float mPerimetro;

        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20; 

        public Deltoide()
        {
            mLado1 = 0.0f;
            mLado2 = 0.0f;
            mAngulo = 0.0f;
            mArea = 0.0f;
            mPerimetro = 0.0f;
        }

        
        public void ReadData(TextBox txtLado1, TextBox txtLado2, TextBox txtAngulo)
        {
            try
            {
                mLado1 = float.Parse(txtLado1.Text);
                mLado2 = float.Parse(txtLado2.Text);
                mAngulo = float.Parse(txtAngulo.Text);

                if (mLado1 <= 0 || mLado2 <= 0 || mAngulo <= 0 || mAngulo >= 180)
                {
                    MessageBox.Show("Por favor, ingrese valores positivos para los lados y un ángulo entre 0° y 180°.", "Error de entrada");
                    ResetData();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Por favor, ingrese números válidos.", "Error de entrada");
                ResetData();
            }
        }

        public void PerimeterDeltoide()
        {
            mPerimetro = 2 * (mLado1 + mLado2);  
        }

        public void AreaDeltoide()
        {
            
            float d1 = 2 * mLado1 * (float)Math.Sin(mAngulo * Math.PI / 180 / 2);
            float d2 = 2 * mLado2 * (float)Math.Cos(mAngulo * Math.PI / 180 / 2);

            mArea = (d1 * d2) / 2;
        }

        public void PrintData(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimetro.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtLado1, TextBox txtLado2, TextBox txtAngulo,
                                   TextBox txtPerimetro, TextBox txtArea, PictureBox picCanvas)
        {
            ResetData();

            txtLado1.Text = "";
            txtLado2.Text = "";
            txtAngulo.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";
            txtLado1.Focus();
            picCanvas.Refresh();
        }

        private void ResetData()
        {
            mLado1 = mLado2 = mAngulo = 0.0f;
            mArea = mPerimetro = 0.0f;
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Purple, 3);

            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;

            float anguloRad = mAngulo * (float)Math.PI / 180;

            PointF[] points = new PointF[4];


            points[0] = new PointF(
                centerX,
                centerY - mLado1 * SF);


            points[1] = new PointF(
                centerX + mLado2 * SF * (float)Math.Sin(anguloRad / 2),
                centerY + mLado2 * SF * (float)Math.Cos(anguloRad / 2) - mLado1 * SF);

            points[2] = new PointF(
                centerX,
                centerY + mLado1 * SF - mLado1 * SF);

            points[3] = new PointF(
                centerX - mLado2 * SF * (float)Math.Sin(anguloRad / 2),
                centerY + mLado2 * SF * (float)Math.Cos(anguloRad / 2) - mLado1 * SF);

            mGraph.DrawPolygon(mPen, points);
        }

        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}