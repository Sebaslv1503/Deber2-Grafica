using System.Drawing;
using System.Windows.Forms;
using System;

internal class Pentagono
{
    private float mRadio;
    private float mPerimetro;
    private float mArea;
    private Graphics mGraph;
    private float SF = 20f;
    private Pen mPen;
    private float offsetX = 0;
    private float offsetY = 0;
    private float angulo = 0; // ➕ Ángulo de rotación en grados

    public Pentagono()
    {
        mRadio = 0.0f;
        mPerimetro = 0.0f;
        mArea = 0.0f;
    }
    public void SetZoom(int zoomLevel, PictureBox picCanvas)
    {
        SF = zoomLevel * 4f; // Ajusta el factor de escala (puedes calibrar este número)
        PlotShape(picCanvas);
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

    public void PerimeterPentagono()
    {
        float lado = 2 * mRadio * (float)Math.Sin(Math.PI / 5);
        mPerimetro = 5 * lado;
    }

    public void AreaPentagono()
    {
        mArea = (5 / 2.0f) * mRadio * mRadio * (float)Math.Sin(2 * Math.PI / 5);
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
        offsetX = 0;
        offsetY = 0;
        angulo = 0;

        txtRadio.Text = "";
        txtPerimetro.Text = "";
        txtArea.Text = "";
        txtRadio.Focus();
        picCanvas.Refresh();
    }

    public void MoveShape(Keys key, PictureBox picCanvas)
    {
        const float step = 10f;

        switch (key)
        {
            case Keys.Left: offsetX -= step; break;
            case Keys.Right: offsetX += step; break;
            case Keys.Up: offsetY -= step; break;
            case Keys.Down: offsetY += step; break;
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

    public void PlotShape(PictureBox picCanvas)
    {
        picCanvas.Refresh();
        mGraph = picCanvas.CreateGraphics();
        mPen = new Pen(Color.Green, 3);

        PointF[] points = new PointF[5];
        float centerX = picCanvas.Width / 2 + offsetX;
        float centerY = picCanvas.Height / 2 + offsetY;

        float anguloRad = angulo * (float)Math.PI / 180f;

        for (int i = 0; i < 5; i++)
        {
            float baseAngle = (float)(2 * Math.PI * i / 5 - Math.PI / 2); // base sin rotar
            float angle = baseAngle + anguloRad; // aplicar rotación

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
