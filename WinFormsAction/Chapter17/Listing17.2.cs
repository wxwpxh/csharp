using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Manning.MyPhotoControls
{
  public class RoundButton : Control
  {
    private Pen _pen;
    private Brush _foreBrush;

    public RoundButton()
    {
      InitColorObjects();
    }

    private void InitColorObjects()
    {
      if (_pen != null)
        _pen.Dispose();
      if (_foreBrush != null)
        _foreBrush.Dispose();

      _pen = new Pen(ControlPaint.DarkDark(BackColor), 2);
      _foreBrush = new SolidBrush(ForeColor);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      using (GraphicsPath path = new GraphicsPath())
      {
        path.AddEllipse(ClientRectangle);
        Region = new Region(path);
      }

      Graphics g = e.Graphics;
      g.DrawEllipse(_pen, ClientRectangle);
      if (Text.Length > 0)
      {
        StringFormat format = new StringFormat();
        format.Alignment = StringAlignment.Center;
        format.LineAlignment = StringAlignment.Center;
        if (Enabled)
        {
          g.DrawString(Text, Font,
            _foreBrush,
            new RectangleF(0, 0, ClientSize.Width, ClientSize.Height),
            format);
        }
        else
        {
          ControlPaint.DrawStringDisabled(g, Text,
            Font, BackColor,
            new RectangleF(0, 0, ClientSize.Width, ClientSize.Height),
            format);
        }
      }
    }

    protected override void OnBackColorChanged(EventArgs e)
    {
      base.OnBackColorChanged(e);
      InitColorObjects();
    }

    protected override void OnForeColorChanged(EventArgs e)
    {
      base.OnForeColorChanged(e);
      InitColorObjects();
    }

    protected override void OnTextChanged(EventArgs e)
    {
      base.OnTextChanged(e);
      Invalidate();
    }
  }
}