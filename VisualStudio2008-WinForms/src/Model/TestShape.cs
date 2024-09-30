using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model
{
    public class TestShape : Shape
    {
        public TestShape() { }

        public TestShape(RectangleF baseShape, LineShape[] lines)
        {
            _base = baseShape;
            _lines = lines;

            Location = baseShape.Location;
            Width = baseShape.Width;
            Height = baseShape.Height;
        }

        private LineShape[] _lines;

        public LineShape[] Lines { get { return _lines; } set { _lines = value; } }

        private RectangleF _base;
        public RectangleF BaseShape { get { return _base; } set { _base = value; } }


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
            grfx.FillRectangle(new SolidBrush(Color.FromArgb(Opacity, FillColor)), BaseShape.X, BaseShape.Y, BaseShape.Width, BaseShape.Height);
            grfx.DrawRectangle(new Pen(Color.Black, Thickness), BaseShape.X, BaseShape.Y, BaseShape.Width, BaseShape.Height);

            foreach (var line in Lines)
            {
                grfx.DrawLine(new Pen(Color.Black, Thickness), line.StartCoordinates, line.EndCoordinates);
            }

        }
    }
}
