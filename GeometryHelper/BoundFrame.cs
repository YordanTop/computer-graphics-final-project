using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace GeometryHelper
{
    public class BoundFrame
    {
        public static RectangleF GetBoundingRectangle(PointF[] points)
        {
            float minX = points[0].X, minY = points[0].Y;
            float maxX = points[0].X, maxY = points[0].Y;

            foreach (PointF point in points)
            {
                if (point.X < minX) minX = point.X;
                if (point.X > maxX) maxX = point.X;
                if (point.Y < minY) minY = point.Y;
                if (point.Y > maxY) maxY = point.Y;
            }

            return new RectangleF(minX, minY, maxX - minX, maxY - minY);
        }
    }
}
