using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using GeometryHelper;

namespace Draw.src.Model
{
    public class TriangleShape:Shape
    {
        #region Constructor

        public TriangleShape()
        {
        }
        public TriangleShape(Rectangle rect) : base(rect)
        {
        }

        public TriangleShape(LineShape[] TriagnleLines)
        {
            _triagnleLines = TriagnleLines;
            _points = new PointF[3];


            for (int i = 0; i < TriagnleLines.Length; i++)
            {
                _points[i] = TriagnleLines[i].StartCoordinates;
            }
            

            Type = typeof(TriangleShape);

        }

        #endregion

        #region Properties

        /// <summary>
        /// Линии за обозначаване на триъгълника
        /// </summary>
        
        private LineShape[] _triagnleLines;
        public LineShape[] TriagnleLines { get { return _triagnleLines; } set { _triagnleLines = value; } }
        /// <summary>
        /// Точките за обозначаване на триъгълника
        /// </summary>
        private PointF[] _points;

        public override PointF[] Points
        {
            get { return _points; }
                set {
                        _points = value;
                    }
        }


        #endregion

        /// <summary>
        /// Проверка за принадлежност на точка point към правоъгълника.
        /// В случая на правоъгълник този метод може да не бъде пренаписван, защото
        /// Реализацията съвпада с тази на абстрактния клас Shape, който проверява
        /// дали точката е в обхващащия правоъгълник на елемента (а той съвпада с
        /// елемента в този случай).
        /// </summary>
        public override bool Contains(PointF point)
        {

            //Изчисление на всяко едно лице
            float[] Areas = { MathExtender.TriangleArea(point, Points[1], Points[2]),
                              MathExtender.TriangleArea(Points[0], point, Points[2]),
                              MathExtender.TriangleArea(Points[0], Points[1], point)};

            float CalculateArea = 0;

            foreach(float area in Areas)
            {
                CalculateArea += area;
            }

            //Проверка дали координатите на курсора са вътре в триъгълника.
            if (CalculateArea == MathExtender.TriangleArea(Points[0], Points[1], Points[2]))
            {
                Console.WriteLine("It's true" + Location);
                return true;
            }
            else
            {
                Console.WriteLine($"CalculateArea: {CalculateArea} ; \n Total Area: {MathExtender.TriangleArea(Points[0], Points[1], Points[2])}");
                return false;
            }
        }

        /// <summary>
        /// Частта, визуализираща конкретния примитив.
        /// </summary>
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            if(Points is null)
            {
                for (int i = 0; i < TriagnleLines.Length; i++)
                {
                    TriagnleLines[i].DrawSelf(grfx);
                }   
            }
            grfx.DrawPolygon(new Pen(Color.Black, Thickness), this.Points);
            grfx.FillPolygon(new SolidBrush(Color.FromArgb(Opacity, FillColor)), this.Points);
        }

    }
}
