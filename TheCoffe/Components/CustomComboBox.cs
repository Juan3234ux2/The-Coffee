using System;
using System.Drawing;
using System.Windows.Forms;

public class CustomComboBox : ComboBox
{
    private Color _borderColor = Color.Transparent; // Color del borde por defecto

    // Propiedad para establecer el color del borde
    public Color BorderColor
    {
        get { return _borderColor; }
        set
        {
            _borderColor = value;
            Invalidate(); // Redibuja el ComboBox para aplicar el nuevo color de borde
        }
    }

    // Constructor
    public CustomComboBox()
    {
        // Configuración inicial
        FlatStyle = FlatStyle.Flat;
        DrawMode = DrawMode.Normal;
        DropDownStyle = ComboBoxStyle.DropDownList;
        SetStyle(ControlStyles.UserPaint, true); // Permite el dibujo personalizado
        SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
    }

    // Sobrescribir el método OnPaint para personalizar el dibujo del ComboBox
    protected override void OnPaint(PaintEventArgs e)
    {
        // No dibujar el borde por defecto
        e.Graphics.Clear(BackColor);

        // Dibuja el borde personalizado
        using (var pen = new Pen(BorderColor))
        {
            e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
        }

        // Dibuja el texto del ComboBox
        TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
    }

    // Sobrescribir el método OnDropDown para ajustar la apariencia cuando se despliega
    protected override void OnDropDown(EventArgs e)
    {
        base.OnDropDown(e);

        // Puedes ajustar el aspecto del ComboBox cuando se despliega si es necesario
    }
}
