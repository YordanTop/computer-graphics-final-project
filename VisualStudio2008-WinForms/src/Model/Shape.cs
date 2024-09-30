using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw
{
	/// <summary>
	/// Базовия клас на примитивите, който съдържа общите характеристики на примитивите.
	/// </summary>
	public abstract class Shape
	{
		#region Constructors
		
		public Shape()
		{
		}
		
		public Shape(RectangleF rect)
		{
			rectangle = rect;
		}
		
		public Shape(Shape shape)
		{
			this.Height = shape.Height;
			this.Width = shape.Width;
			this.Location = shape.Location;
			this.rectangle = shape.rectangle;
			
			this.FillColor =  shape.FillColor;
		}
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Обхващащ правоъгълник на елемента.
		/// </summary>
		private RectangleF rectangle;		
		public virtual RectangleF Rectangle {
			get { return rectangle; }
			set { rectangle = value; }
		}
        /// <summary>
        /// Широчина на елемента.
        /// </summary>
        public virtual float Width {
			get { return Rectangle.Width; }
			set { rectangle.Width = value; }
		}
		
		/// <summary>
		/// Височина на елемента.
		/// </summary>
		public virtual float Height {
			get { return Rectangle.Height; }
			set { rectangle.Height = value; }
		}
		
		/// <summary>
		/// Горен ляв ъгъл на елемента.
		/// </summary>
		public virtual PointF Location {
			get { return Rectangle.Location; }
			set { rectangle.Location = value; }
		}
		/// <summary>
		/// Цвят на елемента.
		/// </summary>
		private Color fillColor = Color.White;		
		public virtual Color FillColor {
			get { return fillColor; }
			set { fillColor = value; }
		}

		/// <summary>
		/// Градуси на ротация.
		/// </summary>
		private float rotate;

		public virtual float Rotate 
		{
			get { return rotate; }
			set { rotate = value; }
		}

        /// <summary>
        /// Гранични точки за разчартаване на примитив.
        /// </summary>
        private PointF[] _points;

        public virtual PointF[] Points
        {
            get { return _points; }
            set { _points = value; }
        }

		///Проверка дали даден примитив е в група.
        private bool isGrouped;

        public virtual bool IsGrouped
        {
            get { return isGrouped; }
            set { isGrouped = value; }
        }

        ///Промяна на прозрачноста
        private int opacity = 255;

        public virtual int Opacity
        {
            get { return opacity; }
            set { opacity = value; }
        }

		/// <summary>
		/// Дебелина на линийте на примитива. 
		/// </summary>
		public float thickness;

		public float Thickness
		{
			get { return thickness; }
			set { thickness = value; }
		}

        private Matrix matrix;

		public Matrix MatrixShape { get { return matrix; } set { matrix = value; } }

		/// <summary>
		/// Вида на примитива
		/// </summary>
		private object type;
		public object Type
		{
			get { return type; }
			set { type = value; }
		}

        #endregion


        /// <summary>
        /// Проверка дали точка point принадлежи на елемента.
        /// </summary>
        /// <param name="point">Точка</param>
        /// <returns>Връща true, ако точката принадлежи на елемента и
        /// false, ако не пренадлежи</returns>
        public virtual bool Contains(PointF point)
		{
			return Rectangle.Contains(point.X, point.Y);
		}
		
		/// <summary>
		/// Визуализира елемента.
		/// </summary>
		/// <param name="grfx">Къде да бъде визуализиран елемента.</param>
		public virtual void DrawSelf(Graphics grfx)
		{
			// shape.Rectangle.Inflate(shape.BorderWidth, shape.BorderWidth);
		}
	}
}
