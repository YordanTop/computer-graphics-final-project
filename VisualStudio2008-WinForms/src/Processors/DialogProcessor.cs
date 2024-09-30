using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Draw
{
	/// <summary>
	/// Класът, който ще бъде използван при управляване на диалога.
	/// </summary>
	public class DialogProcessor : DisplayProcessor
	{
		#region Constructor
		
		public DialogProcessor()
		{
		}
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Избран елемент.
		/// </summary>
		private Shape selection;
		public Shape Selection {
			get { return selection; }
			set { selection = value; }
		}
		/// <summary>
		/// Избрана група от елементи.
		/// </summary>
		private GroupModel groupSelection;

        public GroupModel GroupSelection 
		{
			get { return groupSelection; } 
			set { groupSelection = value; } 
		}

		public List<Shape> Shapes = new List<Shape>();

        /// <summary>
        /// Лист от различни групи.
        /// </summary>
        private List<GroupModel> listOfGroups = new List<GroupModel>();

        public List<GroupModel> ListOfGroups 
		{
			get { return listOfGroups; }
			set { listOfGroups = value; }
		}	

        /// <summary>
        /// Дали в момента диалога е в състояние на "влачене" на избрания елемент.
        /// </summary>
        private bool isDragging;
		public bool IsDragging {
			get { return isDragging; }
			set { isDragging = value; }
		}
        /// <summary>
        /// Дали в момента диалога е в състояние на "Въртене" на избрания елемент.
        /// </summary>
        private bool isRotating;
        public bool IsRotating
        {
            get { return isRotating; }
            set { isRotating = value; }
        }
        /// <summary>
        /// Последна позиция на мишката при "влачене".
        /// Използва се за определяне на вектора на транслация.
        /// </summary>
        private PointF lastLocation;
		public PointF LastLocation {
			get { return lastLocation; }
			set { lastLocation = value; }
		}
		
		#endregion
		

        public void AddRandomTestShape()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 500);
            int y = rnd.Next(100, 500);
            float width = 200;
            float height = 100;

            /*
                                          new LineShape(new PointF(y+(height/2), x+(width/2)),new PointF(x, y+height)),

                                          new LineShape(new PointF((height/2), (width/2)),new PointF(x, y+height))*/


            LineShape[] Lines = { new LineShape(new PointF(x, y), new PointF(x+(width/2),y+(height/2))),
                                new LineShape(new PointF(x, y+height), new PointF(x+(width/2),y+(height/2))),
                                 };

            TestShape TestShape = new TestShape(new RectangleF(x, y, width, height), Lines);

            ShapeList.Add(TestShape);
        }

		/// <summary>
		/// Добавя примитив - правоъгълник на произволно място върху клиентската област.
		/// </summary>
		public void AddRandomRectangle()
		{
            Random rnd = new Random();
            int x = rnd.Next(100, 500);
            int y = rnd.Next(100, 500);

            RectangleShape rect = new RectangleShape(new RectangleF(x, y, 100, 200));

            ShapeList.Add(rect);
        }

        /// <summary>
        /// Добавя примитив - елипса на произволно място върху клиентската област.
        /// </summary>
        public void AddRandomEllipse()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 500);
            int y = rnd.Next(100, 500);

            EllipseShape ellipse = new EllipseShape(new RectangleF(x, y, 100, 200));

            ShapeList.Add(ellipse);
        }
        /// <summary>
        /// Добавя примитив - линия на произволно място върху клиентската област.
        /// </summary>
        public void AddRandomLine()
		{
            Random rnd = new Random();

			PointF startPoint = new PointF(rnd.Next(100, 500), rnd.Next(100, 500));
            PointF endPoint = new PointF(rnd.Next(100, 500), rnd.Next(100, 500));

            LineShape line = new LineShape(startPoint,endPoint);
            ShapeList.Add(line);
        }
        /// <summary>
        /// Добавя примитив - триъгълник на произволно място върху клиентската област.
        /// </summary>
        public void AddRandomTriangle()
        {
            Random rnd = new Random();


            PointF startPoint = new PointF(rnd.Next(100, 500), rnd.Next(100, 500));
            PointF followPoint = new PointF(rnd.Next(100, 500), rnd.Next(100, 500));
			PointF closingPoint = new PointF(followPoint.X + rnd.Next(100, 500), followPoint.Y + rnd.Next(100, 500));



            LineShape[] trianlePoints = { new LineShape(startPoint, followPoint),

										  new LineShape(followPoint,closingPoint),

                                          new LineShape(closingPoint,startPoint)};

            TriangleShape triangle = new TriangleShape(trianlePoints);
            ShapeList.Add(triangle);
        }

        /// <summary>
        /// Проверява дали дадена точка е в елемента.
        /// Обхожда в ред обратен на визуализацията с цел намиране на
        /// "най-горния" елемент т.е. този който виждаме под мишката.
        /// </summary>
        /// <param name="point">Указана точка</param>
        /// <returns>Елемента на изображението, на който принадлежи дадената точка.</returns>
        public Shape ContainsPoint(PointF point)
		{
			Shapes.Clear();
			for(int i = ShapeList.Count - 1; i >= 0; i--){
				if (ShapeList[i].Contains(point)){
					Shapes.Add(ShapeList[i]);
                    return ShapeList[i];
				}	
			}
			return null;
		}
		
		public void GroupTranslateTo(PointF p, List<Shape> groupSelection)
		{
			if(groupSelection != null)
			{
				foreach(Shape shape in groupSelection)
				{
					TranslateTo(p, shape);
				}
				lastLocation = p;
			}

		}
		/// <summary>
		/// Транслация на избраният елемент на вектор определен от <paramref name="p">p</paramref>
		/// </summary>
		/// <param name="p">Вектор на транслация.</param>
		public void TranslateTo(PointF p)
		{
			if(selection is LineShape || selection is TriangleShape)
			{
				for(int i = 0; i< Selection.Points.Length; i++)
				{
					Selection.Points[i] = new PointF(Selection.Points[i].X + p.X - lastLocation.X, Selection.Points[i].Y + p.Y - lastLocation.Y);
				}
				lastLocation = p;
			}


			else if (selection != null) 
			{
				selection.Location = new PointF(selection.Location.X + p.X - lastLocation.X, selection.Location.Y + p.Y - lastLocation.Y);
                lastLocation = p;
			}
		}
        /// <summary>
        /// Overloaded метод на TranslateTo.
        /// </summary>
		/// <param name="p">Вектор на транслация.</param>
        /// <param name="selection">Селектиран примитив.</param>
        public void TranslateTo(PointF p, Shape selection)
        {
            if (selection is LineShape || selection is TriangleShape)
            {
                for (int i = 0; i < selection.Points.Length; i++)
                {
                    selection.Points[i] = new PointF(selection.Points[i].X + p.X - lastLocation.X, selection.Points[i].Y + p.Y - lastLocation.Y);
                }
                
            }


            else if (selection != null)
            {
                selection.Location = new PointF(selection.Location.X + p.X - lastLocation.X, selection.Location.Y + p.Y - lastLocation.Y);      
            }
        }


        /// <summary>
        /// Ротация на определен елемент избран от потребителя.
        /// </summary>
        /// <param name="p">Вектор на ротацията.</param>
        public void RotateTo(PointF p)
		{
            if (selection != null)
            {
				float radian = (float)Math.Atan2(Selection.Location.Y - p.Y, Selection.Location.X-p.X);	

				Selection.Rotate = (float)(radian * (180/Math.PI));

            }
        }

		public void GroupColorIt(Color color,List<Shape> groupSelection)
		{
            if (groupSelection != null)
            {
                foreach (Shape shape in groupSelection)
                {
                    ColorIt(color, shape);
                }
            }
        }

		/// <summary>
		/// Оцветяване на примитив.
		/// </summary>
		/// <param name="color">Цвят на примитива.</param>
		public void ColorIt(Color color)
		{
            selection.FillColor = color;
        }

        public void ColorIt(Color color,Shape selection)
        {
            selection.FillColor = color;
        }

        public void GroupChangeOpacity(int opacity, List<Shape> groupSelection)
        {
            if (groupSelection != null)
            {
                foreach (Shape shape in groupSelection)
                {
                    ChangeOpacity(opacity, shape);
                }
            }
        }

        public void ChangeOpacity(int opacity)
        {
            selection.Opacity = opacity;
        }

        public void ChangeOpacity(int opacity, Shape selection)
        {
            selection.Opacity = opacity;
        }

        public void GroupChangeThickness(float thickness, List<Shape> groupSelection)
        {
            if (groupSelection != null)
            {
                foreach (Shape shape in groupSelection)
                {
                    ChangeThickness(thickness, shape);
                }
            }
        }

        public void ChangeThickness(float thickness)
        {
            selection.Thickness = thickness;
        }

        public void ChangeThickness(float thickness, Shape selection)
        {
            selection.Thickness = thickness;
        }

        /// <summary>
        /// Премахване на всички фигури
        /// </summary>
		public void RemoveAllShapes()
		{
            Shapes.Clear();
            listOfGroups.Clear();
            ShapeList.Clear();
        }
        /// <summary>
        /// Добавяне на всички фигури
        /// </summary>
        public void AddAllShapes(List<Shape> shape)
        {
            foreach(Shape s in shape)
            {
                Shapes.Add(s);
                ShapeList.Add(s);
            }
        }
    }
}
