using GeometryHelper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Draw.src.Model
{
    public class LineShape:Shape
    {
        #region Constructor

        public LineShape() { }

        public LineShape(Rectangle rect) : base(rect)
        {
        }

        public LineShape(PointF startCoord, PointF endCoord)
        {
            _startCoord = startCoord;
            _endCoord = endCoord;

            Points = new PointF[2];

            Points[0] = _startCoord;
            Points[1] = _endCoord;

            FillColor = Color.Black;
            Type = typeof(LineShape);
        }

        #endregion

        #region Properties
        /// <summary>
        /// Точки за обозначаване на дължината на линията
        /// </summary>
        /// 

        private PointF _startCoord;

        public PointF StartCoordinates
        {
            get { return _startCoord; }
            set { _startCoord = value; } 
        }


        private PointF _endCoord;

        public PointF EndCoordinates
        {
            get { return _endCoord; }
            set { _endCoord = value; }
        }

        #endregion

        /// <summary>
        /// Проверка за принадлежност на точка point към отсечка.
        /// </summary>
        public override bool Contains(PointF point)
        {
            //Актуализиране на двете точки
            StartCoordinates = Points[0];
            EndCoordinates = Points[1];

            //Изчислява дължината между стартовата и крайната точка,
            //и двете дължини, по които се разделят.
            int firstSlope = MathExtender.CalcSlope(StartCoordinates, point);
            int secondSlope = MathExtender.CalcSlope(EndCoordinates, point);
            int slope = MathExtender.CalcSlope(StartCoordinates, EndCoordinates);

            if (firstSlope <= (firstSlope + secondSlope) && (firstSlope + secondSlope) <= slope)
            {
                return true;
             }
            else
            {
                return false;
            }
                
        }

        /// <summary>
        /// Частта, визуализираща конкретния примитив.
        /// </summary>
        public override void DrawSelf(Graphics grfx)
        {

            base.DrawSelf(grfx);
            Pen pen = new Pen(Color.FromArgb(Opacity, FillColor), Thickness);

            grfx.DrawLine(pen, Points[0].X, Points[0].Y, Points[1].X, Points[1].Y);
        }
    }
}
