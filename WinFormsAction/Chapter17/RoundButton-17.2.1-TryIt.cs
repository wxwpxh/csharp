using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Manning.MyPhotoControls
{
  public class RoundButton : Control
  {
    private Pen _pen;
    private int _penWidth = 2;
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

      _pen = new Pen(ControlPaint.DarkDark(BackColor), _penWidth);
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
        format.FormatFlags |= StringFormatFlags.NoWrap;

        // Draw a focus rectangle if appropriate
        DrawFocus(g);

        RectangleF textRectF = new RectangleF(0, 0, ClientSize.Width, ClientSize.Height);
        if (Enabled)
        {
          g.DrawString(Text, Font,
            _foreBrush,
            textRectF,
            format);
        }
        else
        {
          ControlPaint.DrawStringDisabled(g, Text,
            Font, BackColor,
            textRectF,
            format);
        }

      }
    }

    private void DrawFocus(Graphics g)
    {
      if (Text.Length == 0)
        return;

      SizeF size = g.MeasureString(Text, Font);
      int x = (int)((ClientSize.Width - size.Width) / 2);
      int y = (int)((ClientSize.Height - size.Height) / 2);
      Rectangle textRect = new Rectangle(
        Math.Max(x, 0),
        Math.Max(y, 0),
        Math.Min((int)size.Width + 1, ClientSize.Width - 2),
        Math.Min((int)size.Height + 1, ClientSize.Height - 2));

      if (Focused)
      {
        ControlPaint.DrawFocusRectangle(g,
          textRect,
          ForeColor,
          BackColor);
      }
      else
      {
        // The below code fails when the text wraps
        Pen p = new Pen(BackColor, 2);
        g.DrawRectangle(p, textRect);
      }

    }

    protected override void OnGotFocus(EventArgs e)
    {
      DrawFocus(Graphics.FromHwnd(Handle));
      
      base.OnGotFocus(e);
    }

    protected override void OnLostFocus(EventArgs e)
    {
      DrawFocus(Graphics.FromHwnd(Handle));

      base.OnLostFocus(e);
    }

    protected override void OnMouseHover(EventArgs e)
    {
      _penWidth = 5;
      InitColorObjects();
      Invalidate();

      base.OnMouseHover(e);
    }

    protected override void OnMouseLeave(EventArgs e)
    {
      if (_penWidth != 2)
      {
        _penWidth = 2;
        InitColorObjects();
        Invalidate();
      }
      
      base.OnMouseLeave(e);
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

    /// <summary>
    /// Dispose of the control
    /// </summary>
    /// <param name="disposing">indicates whether already disposing</param>
    /// <remarks>The TRY IT! extercise says to implement Dispose, and you
    /// can do this. However, control classes implement dispose automatically,
    /// so it is more appropriate to override the inherited Dispose(bool)
    /// method that is called for all components during Dispose.</remarks>
    protected override void Dispose(bool disposing)
    {
      if (!disposing)
      {
        if (_pen != null)
        {
          _pen.Dispose();
          _pen = null;
        }

        if (_foreBrush != null)
        {
          _foreBrush.Dispose();
          _foreBrush = null;
        }
      }

      base.Dispose(disposing);
    }

  }
}