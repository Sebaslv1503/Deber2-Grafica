using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    internal class Circle
    {
        
        private float mRadius;       
        private float mPerimeter;   
        private float mArea;        
        private Graphics mGraph;    
        private const float SF = 20; 
        private Pen mPen;            

       
        public Circle()
        {
            mRadius = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        
        public void ReadData(TextBox txtRadius)
        {
            try
            {
                mRadius = float.Parse(txtRadius.Text);
                if (mRadius <= 0)
                {
                    MessageBox.Show("El radio debe ser un número positivo.", "Error de validación");
                    mRadius = 0.0f;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        
        public void PerimeterCircle()
        {
            mPerimeter = 2 * (float)Math.PI * mRadius;
        }

        
        public void AreaCircle()
        {
            mArea = (float)Math.PI * mRadius * mRadius;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void InitializeData(TextBox txtRadius, TextBox txtPerimeter,
                                 TextBox txtArea, PictureBox picCanvas)
        {
            mRadius = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;

            txtRadius.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtRadius.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Violet, 3);

           
            float diameter = mRadius * 2 * SF;
            mGraph.DrawEllipse(mPen, 0, 0, diameter, diameter);
        }

        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}