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

        private Pen FirstPen = new Pen(Color.Black, 4);
        private Pen SecondPen = new Pen(Color.White, 4);

        private Color CurrentMainColor = Color.Black;
        private Color CurrentAdditionalColor = Color.White;

        enum ColorOption
        {
            Main,
            Addictional
        }
        private ColorOption CurrentColor = ColorOption.Main;


        private int thickness = 4;


        private void ReloadPen()
        {
            FirstPen = new Pen(CurrentMainColor, thickness);
            FirstPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            FirstPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            SecondPen = new Pen(CurrentAdditionalColor, thickness);
            SecondPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            SecondPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

        }

        private bool pressed = false;
        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            bitmap = new Bitmap(rectangle.Width, rectangle.Height);
            g = Graphics.FromImage(bitmap);
            ReloadPen();
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
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        g.DrawLines(FirstPen, arrayPoints.Points);
                        break;
                    case MouseButtons.Right:
                        g.DrawLines(SecondPen, arrayPoints.Points);
                        break;
                }
                Sheet.Image = bitmap;
                arrayPoints.SetPoint(e.X, e.Y);
            }
        }
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sheet_Click(object sender, EventArgs e)
        {

        }
    }
}