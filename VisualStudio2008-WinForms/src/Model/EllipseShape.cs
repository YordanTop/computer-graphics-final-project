using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    public class EllipseShape : Shape
    {
        #region Constructor

        public EllipseShape() { }
        public EllipseShape(RectangleF rect) : base(rect)
        {
            Type = typeof(EllipseShape);
        }

        public EllipseShape(RectangleShape rectangle) : base(rectangle)
        {
        }

        #endregion

        /// <summary>
        /// Проверка за принадлежност на точка point към елипса.
        /// </summary>
		    public override bool Contains(PointF point)
            {
                if ((Math.Pow(point.X - (Rectangle.X + (Rectangle.Width / 2)), 2) / Math.Pow((Rectangle.Width / 2), 2)) +
                    Math.Pow(point.Y - (Rectangle.Y + (Rectangle.Height / 2)), 2) / Math.Pow((Rectangle.Height / 2), 2) <= 1)
                    return true;
                else
                    return false;
            }

        /// <summary>
        /// Частта, визуализираща конкретния примитив.
        /// </summary>
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            grfx.FillEllipse(new SolidBrush(Color.FromArgb(Opacity,FillColor)), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawEllipse(new Pen(Color.Black, Thickness), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
        }

    }
}
