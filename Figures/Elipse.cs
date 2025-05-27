using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    internal class Elipse
    {
        private float mEjeMayor;    
        private float mEjeMenor;   
        private float mPerimetro;   
        private float mArea;        
        private Graphics mGraph;
        private const float SF = 20; 
        private Pen mPen;

        public Elipse()
        {
            mEjeMayor = 0.0f;
            mEjeMenor = 0.0f;
            mPerimetro = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtEjeMayor, TextBox txtEjeMenor)
        {
            try
            {
                mEjeMayor = float.Parse(txtEjeMayor.Text);
                mEjeMenor = float.Parse(txtEjeMenor.Text);

                if (mEjeMayor <= 0 || mEjeMenor <= 0)
                {
                    MessageBox.Show("Los ejes deben ser mayores a 0.", "Mensaje de error");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido. Por favor, ingrese números válidos.", "Mensaje de error");
            }
        }

        public void AreaElipse()
        {
            mArea = (float)Math.PI * mEjeMayor * mEjeMenor;
        }

        public void PerimeterElipse()
        {

            float a = mEjeMayor;
            float b = mEjeMenor;
            mPerimetro = (float)(Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b))));
        }

        public void PrintData(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimetro.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtEjeMayor, TextBox txtEjeMenor,
                                   TextBox txtPerimetro, TextBox txtArea,
                                   PictureBox picCanvas)
        {
            mEjeMayor = 0.0f;
            mEjeMenor = 0.0f;
            mPerimetro = 0.0f;
            mArea = 0.0f;

            txtEjeMayor.Text = "";
            txtEjeMenor.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";
            txtEjeMayor.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.MediumVioletRed, 3);

            float width = mEjeMayor * 2 * SF;
            float height = mEjeMenor * 2 * SF;

            float x = (picCanvas.Width - width) / 2;
            float y = (picCanvas.Height - height) / 2;

            mGraph.DrawEllipse(mPen, x, y, width, height);
        }

        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}
