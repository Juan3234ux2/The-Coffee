using System;
using System.Drawing;
using System.Windows.Forms;
namespace TheCoffe.CPresentacion.Components
{
    public class CustomComboBox : ComboBox
    {
        private Color _borderColor = Color.Transparent;
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        public CustomComboBox()
        {
            FlatStyle = FlatStyle.Flat;
            DrawMode = DrawMode.Normal;
            DropDownStyle = ComboBoxStyle.DropDownList;
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
            using (var pen = new Pen(BorderColor))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
            }

            TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
        }
        protected override void OnDropDown(EventArgs e)
        {
            base.OnDropDown(e);
        }
    }

}
