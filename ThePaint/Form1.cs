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

        private Graphics g;
        private Bitmap bitmap = new Bitmap(10, 10);
        private Pen pen = new Pen(Color.Black, 4);
        private Color QuarentColor = Color.Black;
        private int thickness = 4;

        private void ReloadPen() => pen = new Pen(QuarentColor, thickness);

        private bool pressed = false;
        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            bitmap = new Bitmap(rectangle.Width, rectangle.Height);
            g = Graphics.FromImage(bitmap);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


        }
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

        }
        private ArrayPoints arrayPoints = new ArrayPoints(2);
        private void Sheet_MouseDown(object sender, MouseEventArgs e)
        {
            pressed = true;
        }
        private void Sheet_MouseUp(object sender, MouseEventArgs e)
        {
            pressed = false;
            arrayPoints.ResetPoints();
        }
        private void Sheet_MouseMove(object sender, MouseEventArgs e)
        {
            if (!pressed) return;
            arrayPoints.SetPoint(e.X, e.Y);
            if (arrayPoints.Count >= 2)
            {
                g.DrawLines(pen, arrayPoints.Points);
                Sheet.Image = bitmap;
                arrayPoints.SetPoint(e.X, e.Y);
            }
        }
        private void ColorPick(object sender, EventArgs e)
        {
            // Определяем, какую кнопку нажали
            Button button = (Button)sender;
            Color color = button.BackColor;

            // Присваиваем цвет картинке
            QuarentColorPanel.BackColor = color;
            QuarentColor = color;
            ReloadPen();
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}