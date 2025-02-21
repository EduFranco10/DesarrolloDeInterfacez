using System.Drawing;
using System.Windows.Forms;

public class Bar : Control
{
    private int value = 0;
    private int min = 0;
    private int max = 100;
    private bool isDragging = false;
    private int sliderWidth = 18;

    public int Value
    {
        get { return value; }
        set
        {
            if (value < min) value = min;
            if (value > max) value = max;
            this.value = value;
            Invalidate();
        }
    }

    public int Minimum
    {
        get { return min; }
        set { min = value; Invalidate(); }
    }

    public int Maximum
    {
        get { return max; }
        set { max = value; Invalidate(); }
    }

    public Bar()
    {
        this.DoubleBuffered = true;
        this.Height = 40;
        this.Width = 260;
    }


    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // Suaviza los bordes

        // Dibujar la línea negra
        int lineY = Height / 2;
        g.DrawLine(new Pen(Color.Black, 2), 1, lineY, Width, lineY);


        // Calcular la posición correcta del botón
        float percentage = (float)(value - min) / (max - min);
        int sliderX = (int)(percentage * (Width - sliderWidth)) + (sliderWidth / 2);

        // Dibujar el botón redondo correctamente centrado
        int circleSize = 18;  // Tamaño del círculo
        int circleX = sliderX - (circleSize / 2); // Centrar en X
        int circleY = lineY - (circleSize / 2);   // Centrar en Y
        g.FillEllipse(new SolidBrush(Color.Brown), circleX, circleY, circleSize, circleSize);
    }



    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        isDragging = true;
        UpdateValueFromMouse(e.X);
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        base.OnMouseMove(e);
        if (isDragging)
        {
            UpdateValueFromMouse(e.X);
        }
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        isDragging = false;
    }

    private void UpdateValueFromMouse(int mouseX)
    {
        float percentage = (float)(mouseX - (sliderWidth / 2)) / (Width - sliderWidth);
        Value = (int)(min + percentage * (max - min));
        Invalidate();
    }

}