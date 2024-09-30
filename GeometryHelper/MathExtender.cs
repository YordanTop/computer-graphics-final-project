using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace GeometryHelper
{
    public class MathExtender
    {
        /// <summary>
        /// Изчисляване на дължината между две точки върхи координатна системал
        /// </summary>
        /// <param name="startPoint">Стартова точка</param>
        /// <param name="endPoint">Крайна точка</param>
        /// <returns>Дължината на двете точки</returns>
        public static int CalcSlope(PointF startPoint, PointF endPoint)
        {

            Convert.ToInt32(endPoint.X);
            Convert.ToInt32(endPoint.Y);   

            Convert.ToInt32(startPoint.X);
            Convert.ToInt32(startPoint.Y);

            return (int) Math.Sqrt(
                                    Math.Pow((endPoint.X - startPoint.X), 2) +
                                    Math.Pow((endPoint.Y - startPoint.Y), 2));
        }


        /// <summary>
        /// Изчисляването на лицено на триъгълник чрез вектори
        /// </summary>
        /// <param name="vect1" name="vect2" name="vect3">Вектори</param>
        /// <returns>Лицето на триъгълник.</returns>
        public static float TriangleArea(PointF vect1, PointF vect2, PointF vect3)
        {
            if(vect1 == null || vect2 == null || vect3 == null) return 0;

            return Math.Abs((vect1.X * (vect2.Y - vect3.Y) +
                             vect2.X * (vect3.Y - vect1.Y) +
                             vect3.X * (vect1.Y - vect2.Y))/2);
        }

        public static float EcllipseArea()
        {
            return 0f;
        }
    }
}
