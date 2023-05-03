using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Windows.Input;

namespace ThePaint
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Bitmap bitmap = new Bitmap(10, 10);
        public Form1()
        {
            InitializeComponent();
            SetSize();
            Sheet.MouseUp += Sheet_MouseUp;
            Sheet.MouseDown += Sheet_MouseDown;
            Sheet.MouseMove += Sheet_MouseMove;

        }
        private bool pressed = false;
        private bool isShiftPressed;
        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            bitmap = new Bitmap(rectangle.Width, rectangle.Height);
            g = Graphics.FromImage(bitmap);
        }

        //Взаимодействие с Холстом

        private void Sheet_MouseDown(object sender, MouseEventArgs e)
        {
            pressed = true;

            Palette.FixCurrentPen(e);
            Drawer.startPoint = e.Location;
            if (Drawer.CurrentFigure == Drawer.Figures.FillingInstrument)
            {
                Drawer.FillingInstrument(bitmap);
            }
        }
        private void Sheet_MouseUp(object sender, MouseEventArgs e)
        {
            Drawer.endPoint = e.Location;
            if (Drawer.CurrentFigure != Drawer.Figures.Pen)
            {
                Drawer.DrawFigure(g, isShiftPressed);
            }
            Drawer.arrayPoints.ResetPoints();

            pressed = false;
        }
        private void Sheet_MouseMove(object sender, MouseEventArgs e)
        {
            ;
            if (!pressed) return;//Проверка на "нажатость".

            if (Drawer.CurrentFigure == Drawer.Figures.Pen)
            {
                Drawer.DrawWithPen(g, e.Location);
            }

            Drawer.endPoint = e.Location;
            Sheet.Image = bitmap;
            Sheet.Invalidate();
        }
        private void Sheet_Paint(object sender, PaintEventArgs e)
        {
            if (!pressed) return;
            Drawer.DrawFigure(e.Graphics, isShiftPressed);
        }


        //Цвета и Толщина
        private void ColorPick(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            Color color = button.BackColor;

            switch (Palette.CurrentColor)
            {
                case Palette.ColorOption.Main:
                    MainColorButton.BackColor = color;
                    Palette.CurrentMainColor = color;
                    break;
                case Palette.ColorOption.Additional:
                    AddictionalColorButton.BackColor = color;
                    Palette.CurrentAdditionalColor = color;
                    break;
            }
            Palette.FixCurrentPen(e);
        }
        private void ChooseThickNess(object sender, EventArgs e)
        {
            if (sender == toolStripMenuItem1)
            {
                Palette.thickness = 2;
                return;
            }
            else if (sender == toolStripMenuItem2)
            {
                Palette.thickness = 4;
                return;
            }
            else if (sender == toolStripMenuItem3)
            {
                Palette.thickness = 6;
                return;
            }
            else if (sender == toolStripMenuItem4)
            {
                Palette.thickness = 8;
                return;
            }
            else return;
        }
        private void ChooseColor(object sender, EventArgs e)
        {
            if (sender == MainColorPanel || sender == MainColorButton || sender == label1)
            {
                Palette.CurrentColor = Palette.ColorOption.Main;
                MainColorPanel.BackColor = Color.SteelBlue;
                AddictionalColorPanel.BackColor = SystemColors.Control;
            }
            if (sender == AddictionalColorPanel || sender == AddictionalColorButton || sender == label2)
            {
                Palette.CurrentColor = Palette.ColorOption.Additional;
                AddictionalColorPanel.BackColor = Color.SteelBlue;
                MainColorPanel.BackColor = SystemColors.Control;
            }
        }

        //Выбор метода для Рисования 
        private void ChooseDrawingMethod(object sender, EventArgs e)
        {
            if (sender.Equals(LineDrawer)) Drawer.CurrentFigure = Drawer.Figures.Line;
            if (sender.Equals(PenDrawer)) Drawer.CurrentFigure = Drawer.Figures.Pen;
            if (sender.Equals(RectangleDrawer)) Drawer.CurrentFigure = Drawer.Figures.Rectangle;
            if (sender.Equals(EllipsDrawer)) Drawer.CurrentFigure = Drawer.Figures.Ellipse;
            if (sender.Equals(isoscelesTriangleDrawer)) Drawer.CurrentFigure = Drawer.Figures.isoscelesTriangle;
            if (sender.Equals(rightTriangleDrawer)) Drawer.CurrentFigure = Drawer.Figures.rectangularthTriangle;
            if (sender.Equals(rhombusDrawer)) Drawer.CurrentFigure = Drawer.Figures.rhombus;
            if (sender.Equals(pentaGon)) Drawer.CurrentFigure = Drawer.Figures.pentagon;
            if (sender.Equals(hexagonDrawer)) Drawer.CurrentFigure = Drawer.Figures.hexagon;
            if (sender.Equals(FillingInstrument)) Drawer.CurrentFigure = Drawer.Figures.FillingInstrument;

        }

        private void ParamsOfFillingAndContour(object sender, EventArgs e)
        {
            if (sender.Equals(SolidColorFilling)) Drawer.Filling = Drawer.fillingOption.SolidColor;
            if (sender.Equals(NoFilling)) Drawer.Filling = Drawer.fillingOption.NO;

            if (sender.Equals(SolidColorContour)) Drawer.Contour = Drawer.fillingOption.SolidColor;
            if (sender.Equals(NOcontour)) Drawer.Contour = Drawer.fillingOption.NO;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                isShiftPressed = true;
                e.Handled = true;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                isShiftPressed = false;
                e.Handled = true;
            }
        }
    }
}