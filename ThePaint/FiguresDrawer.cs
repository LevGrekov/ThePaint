using System.Drawing;

namespace ThePaint
{
    public static class Drawer
    {

        //Работа с Точками
        public class ArrayPoints
        {
            private int index = 0;
            private Point[] points;

            public ArrayPoints(int size)
            {
                if (size <= 0) size = 2;
                points = new Point[size];
            }
            public void SetPoint(Point point)
            {
                if (index >= points.Length) index = 0;
                points[index] = point;
                index++;
            }

            public void ResetPoints()
            {
                index = 0;
            }

            public int Count => index;
            public Point[] Points => points;

            public Point this[int index]
            {

                get
                {
                    if (index < 0 && index > points.Length) throw new IndexOutOfRangeException();
                    return points[index];
                }
                set
                {
                    if (index < 0 && index > points.Length) throw new IndexOutOfRangeException();
                    points[index] = value;
                }
            }
        }
        public static ArrayPoints arrayPoints = new ArrayPoints(2);

        public static Point startPoint
        {
            get => arrayPoints[0];
            set => arrayPoints[0] = value;
        }
        public static Point endPoint
        {
            get => arrayPoints[1];
            set => arrayPoints[1] = value;
        }

        public enum fillingOption
        {
            NO,
            SolidColor,
        }

        private static fillingOption filling = fillingOption.NO;
        public static fillingOption Filling
        {
            get => filling;
            set => filling = value;
        }

        private static fillingOption contour = fillingOption.SolidColor;
        public static fillingOption Contour
        {
            get => contour;
            set => contour = value;
        }

        public enum Figures
        {
            Pen,
            FillingInstrument,

            Line,
            Rectangle,
            Ellipse,
            isoscelesTriangle,
            rectangularthTriangle,
            pentagon,
            hexagon,
            rhombus,

        }

        public static Figures CurrentFigure = Figures.Pen;

        public static void DrawWithPen(Graphics g, Point point)
        {
            arrayPoints.SetPoint(point);
            if (arrayPoints.Count >= 2)
            {
                g.DrawLines(Palette.LastUsedPen, arrayPoints.Points);
                arrayPoints.SetPoint(point);
            }
        }

        private static Rectangle CountRectangle()
        {
            int x1 = Math.Min(startPoint.X, endPoint.X);
            int y1 = Math.Min(startPoint.Y, endPoint.Y);

            int x2 = Math.Max(startPoint.X, endPoint.X);
            int y2 = Math.Max(startPoint.Y, endPoint.Y);

            int width = x2 - x1;
            int height = y2 - y1;

            return new Rectangle(x1, y1, width, height);
        }

        private static Rectangle CountSquare()
        {

            int deltaX = endPoint.X - startPoint.X;
            int deltaY = endPoint.Y - startPoint.Y;

            int absDeltaX = Math.Abs(deltaX);
            int absDeltaY = Math.Abs(deltaY);
            int endPointX = endPoint.X;
            int endPointY = endPoint.Y;

            if (absDeltaX > absDeltaY)
            {
                endPointY = startPoint.Y + Math.Sign(deltaY) * absDeltaX;
            }
            else
            {
                endPointX = startPoint.X + Math.Sign(deltaX) * absDeltaY;
            }


            int x1 = Math.Min(startPoint.X, endPointX);
            int y1 = Math.Min(startPoint.Y, endPointY);

            int x2 = Math.Max(startPoint.X, endPointX);
            int y2 = Math.Max(startPoint.Y, endPointY);

            int width = x2 - x1;
            int height = y2 - y1;


            return new Rectangle(x1, y1, width, width);
        }


        public static void DrawFigure(Graphics g, bool shift)
        {
            

            if (CurrentFigure == Figures.Pen) return;

            Pen currentPen = Palette.LastUsedPen;
            Brush currentBrush = Palette.SolidBrush;
            Point[] points;
            Rectangle rect;
            double angle;

            switch (shift)
            {
                case false:
                    {
                        rect = CountRectangle();
                    }
                    break;
                case true:
                    {
                        rect = CountSquare();
                    }
                    break;
            }
            switch (filling)
            {
                case fillingOption.SolidColor:
                    currentBrush = Palette.SolidBrush;
                    break;
                case fillingOption.NO:
                    currentBrush = null;
                    break;
            }

            //Выбор Фигуры
            switch (CurrentFigure)
            {
                case Figures.Line:
                    if (contour != fillingOption.NO)
                    {
                        if (shift)
                        {
                            int deltaX = endPoint.X - startPoint.X;
                            int deltaY = endPoint.Y - startPoint.Y;
                            int endPointX;
                            int endPointY;

                            // Вычисляем значение угла между прямой и осью X в радианах
                            angle = Math.Atan2(deltaY, deltaX);

                            // Округляем угол до ближайшего значения, кратного 45 градусам
                            angle = Math.Round(angle / (Math.PI / 4)) * (Math.PI / 4);

                            // Вычисляем новые координаты endPoint на основе угла и расстояния между точками
                            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
                            endPointX = startPoint.X + (int)Math.Round(distance * Math.Cos(angle));
                            endPointY = startPoint.Y + (int)Math.Round(distance * Math.Sin(angle));
                            g.DrawLine(currentPen, startPoint, new Point(endPointX, endPointY));
                        }
                        if (!shift)
                        {
                            g.DrawLine(currentPen, startPoint, endPoint);
                        }
                    }
                    break;



                case Figures.Rectangle:
                    if (filling != fillingOption.NO)
                    {
                        g.FillRectangle(currentBrush, rect);
                    }
                    if (contour != fillingOption.NO)
                    {
                        g.DrawRectangle(currentPen, rect);
                    }
                    break;



                case Figures.Ellipse:
                    if (filling != fillingOption.NO)
                    {
                        g.FillEllipse(currentBrush, rect);
                    }
                    if (contour != fillingOption.NO)
                    {
                        g.DrawEllipse(currentPen, rect);
                    }
                    break;



                case Figures.isoscelesTriangle:

                    points = new Point[3];
                    points[0] = new Point(rect.X + rect.Width / 2, rect.Y); // верхняя точка
                    points[1] = new Point(rect.X, rect.Y + rect.Height); // левая точка
                    points[2] = new Point(rect.X + rect.Width, rect.Y + rect.Height);

                    DrawPolygon(g, points);
                    break;



                case Figures.rectangularthTriangle:
                    points = new Point[3];
                    points[0] = new Point(rect.X, rect.Y); // верхняя левая точка
                    points[1] = new Point(rect.X, rect.Y + rect.Height); // нижняя левая точка
                    points[2] = new Point(rect.X + rect.Width, rect.Y + rect.Height);
                    DrawPolygon(g, points);
                    break;



                case Figures.rhombus:
                    points = new Point[4];
                    points[0] = new Point(rect.X + rect.Width / 2, rect.Y); // верхняя точка
                    points[1] = new Point(rect.X, rect.Y + rect.Height / 2); // левая точка
                    points[2] = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height); // нижняя точка
                    points[3] = new Point(rect.X + rect.Width, rect.Y + rect.Height / 2); // правая точка

                    DrawPolygon(g, points);
                    break;

                    int cx;
                    int cy;
                    int r;

                case Figures.pentagon:
                    points = new Point[5];

                    double goldenRatio = (1 + Math.Sqrt(5)) / 2;

                    points[0] = new Point(rect.Left + rect.Width/2, rect.Top);
                    points[1] = new Point(rect.Right, rect.Top + rect.Height/(3*(int)goldenRatio));
                    points[2] = new Point(rect.Left + rect.Width/4 * 3 , rect.Bottom);
                    points[3] = new Point(rect.Left + rect.Width/4, rect.Bottom);
                    points[4] = new Point(rect.Left, rect.Top + rect.Height/(3 *(int)goldenRatio) );

                    DrawPolygon(g, points);
                    break;



                case Figures.hexagon:
                    points = new Point[6];

                    points[0] = new Point(rect.Left + rect.Width / 2, rect.Top);
                    points[1] = new Point(rect.Right, rect.Top + rect.Height/4);
                    points[2] = new Point(rect.Right, rect.Top + (rect.Height / 4) * 3);
                    points[3] = new Point(rect.Left + rect.Width / 2, rect.Bottom);
                    points[5] = new Point(rect.Left, rect.Top + rect.Height / 4);
                    points[4] = new Point(rect.Left, rect.Top + (rect.Height / 4) * 3);
                    DrawPolygon(g, points);
                    break;
                default: break;
            }
        }
        private static void DrawPolygon(Graphics g, Point[] points)
        {
            if (filling != fillingOption.NO)
            {
                g.FillPolygon(Palette.SolidBrush, points);
            }
            if (contour != fillingOption.NO)
            {
                g.DrawPolygon(Palette.LastUsedPen, points);
            }
        }

        public static void FillingInstrument(Bitmap bmp)
        {
            Color theColor = bmp.GetPixel(startPoint.X, startPoint.Y);

            Stack<Point> stack = new Stack<Point>();
            stack.Push(startPoint);
            var temp = startPoint;

            while(stack.Count > 0 )
            {
                if (stack.Count > 0)
                {
                    temp = stack.Pop();
                    bmp.SetPixel(temp.X, temp.Y, Palette.CurrentMainColor);
                }


                var x1 = new Point(temp.X + 1, temp.Y);
                var x2 = new Point(temp.X - 1, temp.Y);
                var x3 = new Point(temp.X, temp.Y + 1);
                var x4 = new Point(temp.X, temp.Y - 1);

                if (bmp.GetPixel(x1.X, x1.Y) != theColor)
                {
                    stack.Push(x1);
                }
                if (bmp.GetPixel(x2.X, x2.Y) != theColor)
                {
                    stack.Push(x2);
                }
                if (bmp.GetPixel(x3.X, x3.Y) != theColor)
                {
                    stack.Push(x3);
                }
                if (bmp.GetPixel(x4.X, x4.Y) != theColor)
                {
                    stack.Push(x4);
                }
            }
        }

    }
}
