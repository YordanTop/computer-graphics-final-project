using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    internal class Polygon:Shape
    {

        public override bool Contains(PointF point)
        {

            if (base.Contains(point))
                // Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
                // В случая на правоъгълник - директно връщаме true
                return true;
            else
                // Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
                return false;
        }

        /// <summary>
        /// Частта, визуализираща конкретния примитив.
        /// </summary>
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            Color c = Color.FromArgb(FillColorOpacity, FillColor);
            Color c2 = Color.FromArgb(StrockColorOpacity, StrockColor);

            grfx.FillRectangle(new SolidBrush(c), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawRectangle(new Pen(c2, StrokeWidth), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

        }
    }
}
