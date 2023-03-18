using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace ThePaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetSize();
            Sheet.MouseUp += Sheet_MouseUp;
            Sheet.MouseDown += Sheet_MouseDown;
            Sheet.MouseMove += Sheet_MouseMove;

        }
        private bool pressed = false;

        private Graphics g;
        private Bitmap bitmap = new Bitmap(10, 10);

        private Pen FirstPen = new Pen(Color.Black, 4);
        private Pen SecondPen = new Pen(Color.White, 4);
        private Pen LastUsedPen = new Pen(Color.Black, 4);

        private Color CurrentMainColor = Color.Black;
        private Color CurrentAdditionalColor = Color.White;
        private int thickness = 4;

        private enum ColorOption
        {
            Main,
            Addictional
        }
        private ColorOption CurrentColor = ColorOption.Main;

        private enum DrawOption
        {
            Pencil,
            Pen,
            Line,
            Rectangle,
            Circle,
            Triangle,
        }
        private DrawOption drawOption = DrawOption.Pen;


        // Вспомогательные методы 
        private void ReloadPen()
        {
            FirstPen = new Pen(CurrentMainColor, thickness);
            FirstPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            FirstPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            SecondPen = new Pen(CurrentAdditionalColor, thickness);
            SecondPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            SecondPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            bitmap = new Bitmap(rectangle.Width, rectangle.Height);
            g = Graphics.FromImage(bitmap);
            ReloadPen();
        }

        //Работа с Точками
        private class ArrayPoints
        {
            private int index = 0;
            private Point[] points;

            public ArrayPoints(int size)
            {
                if (size <= 0) size = 2;
                points = new Point[size];
            }
            public void SetPoint(int x, int y)
            {
                if (index >= points.Length) index = 0;
                points[index] = new Point(x, y);
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
        private ArrayPoints arrayPoints = new ArrayPoints(2);

        public Point startPoint
        {
            get => arrayPoints[0];
            set => arrayPoints[0] = value;
        }
        public Point endPoint
        {
            get => arrayPoints[1];
            set => arrayPoints[1] = value;
        }

        //Взаимодействие с Холстом

        private void Sheet_MouseDown(object sender, MouseEventArgs e)
        {
            pressed = true;

            //Фиксирование рабочего Карандаша 
            switch (e.Button)
            {
                case MouseButtons.Left:
                    LastUsedPen = FirstPen;
                    break;
                case MouseButtons.Right:
                    LastUsedPen = SecondPen;
                    break;
            }

            startPoint = e.Location;
        }
        private void Sheet_MouseUp(object sender, MouseEventArgs e)
        {
            endPoint = e.Location;
            switch (drawOption)
            {
                case DrawOption.Line:
                    g.DrawLine(LastUsedPen, arrayPoints[0], arrayPoints[1]);
                    break;
                case DrawOption.Rectangle:
                    g.DrawRectangle(LastUsedPen, CountRectangle());
                    break;
                case DrawOption.Circle:
                    g.DrawEllipse(LastUsedPen, CountRectangle());
                    break;
            }

            arrayPoints.ResetPoints();
            pressed = false;
        }
        private void Sheet_MouseMove(object sender, MouseEventArgs e)
        {

            if (!pressed) return;//Проверка на "нажатость".
            switch (drawOption)
            {
                case DrawOption.Pen:
                    arrayPoints.SetPoint(e.X, e.Y);
                    if (arrayPoints.Count >= 2)
                    {
                        g.DrawLines(LastUsedPen, arrayPoints.Points);
                        Sheet.Image = bitmap;
                        arrayPoints.SetPoint(e.X, e.Y);
                    }
                    break;
                default:
                    arrayPoints[1] = e.Location;
                    Sheet.Image = bitmap;
                    Sheet.Invalidate();
                    break;
            }
        }

        private void Sheet_Paint(object sender, PaintEventArgs e)
        {
            if (!pressed) return;
            switch (drawOption)
            {
                case DrawOption.Rectangle:
                    e.Graphics.DrawRectangle(LastUsedPen, CountRectangle());
                    break;

                case DrawOption.Line:
                    e.Graphics.DrawLine(LastUsedPen, arrayPoints[0], arrayPoints[1]);
                    break;
                case DrawOption.Circle:
                    e.Graphics.DrawEllipse(LastUsedPen, CountRectangle());
                    break;
            }

        }

        private Rectangle CountRectangle()
        {
            int x1 = Math.Min(startPoint.X, endPoint.X);
            int y1 = Math.Min(startPoint.Y, endPoint.Y);
            int x2 = Math.Max(startPoint.X, endPoint.X);
            int y2 = Math.Max(startPoint.Y, endPoint.Y);

            int width = x2 - x1;
            int height = y2 - y1;

            return new Rectangle(x1, y1, width, height);
        }

        //Цвета и Толщина
        private void ColorPick(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            Color color = button.BackColor;

            switch (CurrentColor)
            {
                case ColorOption.Main:
                    MainColorButton.BackColor = color;
                    CurrentMainColor = color;
                    break;
                case ColorOption.Addictional:
                    AddictionalColorButton.BackColor = color;
                    CurrentAdditionalColor = color;
                    break;
            }
            ReloadPen();
        }
        private void ChooseThickNess(object sender, EventArgs e)
        {
            if (sender == toolStripMenuItem1)
            {
                thickness = 2;
                ReloadPen();
                return;
            }
            else if (sender == toolStripMenuItem2)
            {
                thickness = 4;
                ReloadPen();
                return;
            }
            else if (sender == toolStripMenuItem3)
            {
                thickness = 6;
                ReloadPen();
                return;
            }
            else if (sender == toolStripMenuItem4)
            {
                thickness = 8;
                ReloadPen();
                return;
            }
            else return;
        }
        private void ChooseColor(object sender, EventArgs e)
        {
            if (sender == MainColorPanel || sender == MainColorButton || sender == label1)
            {
                CurrentColor = ColorOption.Main;
                MainColorPanel.BackColor = Color.SteelBlue;
                AddictionalColorPanel.BackColor = SystemColors.Control;
            }
            if (sender == AddictionalColorPanel || sender == AddictionalColorButton || sender == label2)
            {
                CurrentColor = ColorOption.Addictional;
                AddictionalColorPanel.BackColor = Color.SteelBlue;
                MainColorPanel.BackColor = SystemColors.Control;
            }
        }

        //Выбор метода для Рисования 
        private void ChooseDrawingMethod(object sender, EventArgs e)
        {
            if (sender.Equals(LineDrawer)) drawOption = DrawOption.Line;
            if (sender.Equals(PenDrawer)) drawOption = DrawOption.Pen;
            if (sender.Equals(RectangleDrawer)) drawOption = DrawOption.Rectangle;
            if (sender.Equals(EllipsDrawer)) drawOption = DrawOption.Circle;
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}