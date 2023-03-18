using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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



        public static void DrawFigure(Graphics g, bool shift)
        {
            if (CurrentFigure == Figures.Pen) return;

            Pen currentPen = Palette.LastUsedPen;
            Brush currentBrush = Palette.SolidBrush;
            Point[] points;
            var rect = CountRectangle();

            //Если заливка выбрана
            if (filling != fillingOption.NO)
            {
                //Выбор способа заливки
                switch (filling)
                {
                    case fillingOption.SolidColor:
                        currentBrush = Palette.SolidBrush;
                        break;
                }

                //Выбор Фигуры
                switch (CurrentFigure)
                {
                    case Figures.Rectangle:
                        g.FillRectangle(currentBrush, rect);
                        break;
                    case Figures.Ellipse:
                        g.FillEllipse(currentBrush, rect);
                        break;
                    case Figures.isoscelesTriangle:
                        points = new Point[3];
                        points[0] = new Point(rect.X + rect.Width / 2, rect.Y); // верхняя точка
                        points[1] = new Point(rect.X, rect.Y + rect.Height); // левая точка
                        points[2] = new Point(rect.X + rect.Width, rect.Y + rect.Height);
                        g.FillPolygon(currentBrush, points);
                        break;
                    case Figures.rectangularthTriangle:
                        points = new Point[3];
                        points[0] = new Point(rect.X, rect.Y); // верхняя левая точка
                        points[1] = new Point(rect.X, rect.Y + rect.Height); // нижняя левая точка
                        points[2] = new Point(rect.X + rect.Width, rect.Y + rect.Height);
                        g.FillPolygon(currentBrush, points);
                        break;
                    case Figures.rhombus:
                        points = new Point[4];
                        points[0] = new Point(rect.X + rect.Width / 2, rect.Y); // верхняя точка
                        points[1] = new Point(rect.X, rect.Y + rect.Height / 2); // левая точка
                        points[2] = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height); // нижняя точка
                        points[3] = new Point(rect.X + rect.Width, rect.Y + rect.Height / 2); // правая точка
                        g.FillPolygon(currentBrush, points);
                        break;

                        int cx;
                        int cy;
                        int r;

                    case Figures.pentagon:
                        // Вычисляем координаты центра прямоугольника
                        int centerX = rect.X + rect.Width / 2;
                        int centerY = rect.Y + rect.Height / 2;

                        // Вычисляем радиус вписанной окружности
                        int radius = Math.Min(rect.Width, rect.Height) / 2;

                        // Вычисляем координаты вершин пятиугольника
                        points = new Point[5];
                        for (int i = 0; i < 5; i++)
                        {
                            double angle = 72 * i - 90;
                            double x = centerX + radius * Math.Cos(angle * Math.PI / 180);
                            double y = centerY + radius * Math.Sin(angle * Math.PI / 180);

                            points[i] = new Point((int)x, (int)y);
                        }
                        g.FillPolygon(currentBrush, points);
                        break;
                    case Figures.hexagon:
                        points = new Point[6];
                        cx = rect.X + rect.Width / 2; // координаты центра окружности
                        cy = rect.Y + rect.Height / 2;
                        r = Math.Min(rect.Width, rect.Height) / 2; // радиус окружности

                        for (int i = 0; i < 6; i++)
                        {
                            double angle = Math.PI / 6 + 2 * Math.PI * i / 6; // угол между вершинами
                            int x = (int)(cx + r * Math.Cos(angle)); // координаты вершины
                            int y = (int)(cy + r * Math.Sin(angle));
                            points[i] = new Point(x, y);
                        }
                        g.FillPolygon(currentBrush, points);
                        break;

                }
            }
            //Если выбран контур 
            if (contour != fillingOption.NO)
            {
                switch (CurrentFigure)
                {
                    case Figures.Line:
                        g.DrawLine(currentPen, startPoint, endPoint);
                        break;
                    case Figures.Rectangle:
                        g.DrawRectangle(currentPen, rect);
                        break;
                    case Figures.Ellipse:
                        g.DrawEllipse(currentPen, rect);
                        break;
                    case Figures.isoscelesTriangle:
                        points = new Point[3];
                        points[0] = new Point(rect.X + rect.Width / 2, rect.Y); // верхняя точка
                        points[1] = new Point(rect.X, rect.Y + rect.Height); // левая точка
                        points[2] = new Point(rect.X + rect.Width, rect.Y + rect.Height);
                        g.DrawPolygon(Palette.LastUsedPen, points);
                        break;
                    case Figures.rectangularthTriangle:
                        points = new Point[3];
                        points[0] = new Point(rect.X, rect.Y); // верхняя левая точка
                        points[1] = new Point(rect.X, rect.Y + rect.Height); // нижняя левая точка
                        points[2] = new Point(rect.X + rect.Width, rect.Y + rect.Height);
                        g.DrawPolygon(currentPen, points);
                        break;
                    case Figures.rhombus:
                        points = new Point[4];
                        points[0] = new Point(rect.X + rect.Width / 2, rect.Y); // верхняя точка
                        points[1] = new Point(rect.X, rect.Y + rect.Height / 2); // левая точка
                        points[2] = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height); // нижняя точка
                        points[3] = new Point(rect.X + rect.Width, rect.Y + rect.Height / 2); // правая точка
                        g.DrawPolygon(currentPen, points);
                        break;

                        int cx;
                        int cy;
                        int r;

                    case Figures.pentagon:
                        // Вычисляем координаты центра прямоугольника
                        int centerX = rect.X + rect.Width / 2;
                        int centerY = rect.Y + rect.Height / 2;

                        // Вычисляем радиус вписанной окружности
                        int radius = Math.Min(rect.Width, rect.Height) / 2;

                        // Вычисляем координаты вершин пятиугольника
                        points = new Point[5];
                        for (int i = 0; i < 5; i++)
                        {
                            double angle = 72 * i - 90;
                            double x = centerX + radius * Math.Cos(angle * Math.PI / 180);
                            double y = centerY + radius * Math.Sin(angle * Math.PI / 180);

                            points[i] = new Point((int)x, (int)y);
                        }
                        g.DrawPolygon(currentPen, points);
                        break;
                    case Figures.hexagon:
                        points = new Point[6];
                        cx = rect.X + rect.Width / 2; // координаты центра окружности
                        cy = rect.Y + rect.Height / 2;
                        r = Math.Min(rect.Width, rect.Height) / 2; // радиус окружности

                        for (int i = 0; i < 6; i++)
                        {
                            double angle = Math.PI / 6 + 2 * Math.PI * i / 6; // угол между вершинами
                            int x = (int)(cx + r * Math.Cos(angle)); // координаты вершины
                            int y = (int)(cy + r * Math.Sin(angle));
                            points[i] = new Point(x, y);
                        }
                        g.DrawPolygon(currentPen, points);
                        break;

                }
            }
        }
    }
}
