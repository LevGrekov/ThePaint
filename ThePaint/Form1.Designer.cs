namespace ThePaint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Sheet = new PictureBox();
            ControlPanel = new Panel();
            panel7 = new Panel();
            label4 = new Label();
            PenDrawer = new Button();
            panel5 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            button26 = new Button();
            button25 = new Button();
            hexagonDrawer = new Button();
            rhombusDrawer = new Button();
            pentaGon = new Button();
            rightTriangleDrawer = new Button();
            isoscelesTriangleDrawer = new Button();
            panel6 = new Panel();
            menuStrip2 = new MenuStrip();
            контурToolStripMenuItem = new ToolStripMenuItem();
            NOcontour = new ToolStripMenuItem();
            SolidColorContour = new ToolStripMenuItem();
            заливкаToolStripMenuItem1 = new ToolStripMenuItem();
            NoFilling = new ToolStripMenuItem();
            SolidColorFilling = new ToolStripMenuItem();
            EllipsDrawer = new Button();
            RectangleDrawer = new Button();
            LineDrawer = new Button();
            FiguresLabel = new Label();
            panel2 = new Panel();
            ColorsLabel = new Label();
            panel3 = new Panel();
            MainColorPanel = new Panel();
            MainColorButton = new PictureBox();
            label1 = new Label();
            AddictionalColorPanel = new Panel();
            AddictionalColorButton = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            толщинаToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            button19 = new Button();
            button18 = new Button();
            button17 = new Button();
            button16 = new Button();
            button1 = new Button();
            button7 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button9 = new Button();
            button8 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            толщинаToolStripMenuItem = new ToolStripMenuItem();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)Sheet).BeginInit();
            ControlPanel.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            menuStrip2.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            MainColorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainColorButton).BeginInit();
            AddictionalColorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddictionalColorButton).BeginInit();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Sheet
            // 
            Sheet.BackColor = Color.White;
            Sheet.Dock = DockStyle.Fill;
            Sheet.Location = new Point(0, 0);
            Sheet.Name = "Sheet";
            Sheet.Size = new Size(1293, 605);
            Sheet.TabIndex = 0;
            Sheet.TabStop = false;
            Sheet.Paint += Sheet_Paint;
            // 
            // ControlPanel
            // 
            ControlPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ControlPanel.Controls.Add(panel7);
            ControlPanel.Controls.Add(panel5);
            ControlPanel.Controls.Add(panel4);
            ControlPanel.Controls.Add(panel2);
            ControlPanel.Location = new Point(0, 0);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(1292, 110);
            ControlPanel.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(label4);
            panel7.Controls.Add(PenDrawer);
            panel7.Location = new Point(329, 6);
            panel7.Name = "panel7";
            panel7.Size = new Size(56, 93);
            panel7.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(4, 71);
            label4.Name = "label4";
            label4.Size = new Size(44, 19);
            label4.TabIndex = 22;
            label4.Text = "Кисть";
            // 
            // PenDrawer
            // 
            PenDrawer.Location = new Point(4, 3);
            PenDrawer.Name = "PenDrawer";
            PenDrawer.Size = new Size(48, 48);
            PenDrawer.TabIndex = 23;
            PenDrawer.Text = "button20";
            PenDrawer.UseVisualStyleBackColor = true;
            PenDrawer.Click += ChooseDrawingMethod;
            // 
            // panel5
            // 
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(150, 110);
            panel5.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 89);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 24;
            label3.Text = "Инструменты";
            // 
            // panel4
            // 
            panel4.Controls.Add(button26);
            panel4.Controls.Add(button25);
            panel4.Controls.Add(hexagonDrawer);
            panel4.Controls.Add(rhombusDrawer);
            panel4.Controls.Add(pentaGon);
            panel4.Controls.Add(rightTriangleDrawer);
            panel4.Controls.Add(isoscelesTriangleDrawer);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(EllipsDrawer);
            panel4.Controls.Add(RectangleDrawer);
            panel4.Controls.Add(LineDrawer);
            panel4.Controls.Add(FiguresLabel);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(418, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(284, 110);
            panel4.TabIndex = 2;
            // 
            // button26
            // 
            button26.Location = new Point(147, 39);
            button26.Name = "button26";
            button26.Size = new Size(30, 30);
            button26.TabIndex = 34;
            button26.Text = "button22";
            button26.UseVisualStyleBackColor = true;
            button26.Click += ChooseDrawingMethod;
            // 
            // button25
            // 
            button25.Location = new Point(147, 6);
            button25.Name = "button25";
            button25.Size = new Size(30, 30);
            button25.TabIndex = 33;
            button25.Text = "button22";
            button25.UseVisualStyleBackColor = true;
            button25.Click += ChooseDrawingMethod;
            // 
            // hexagonDrawer
            // 
            hexagonDrawer.Location = new Point(111, 39);
            hexagonDrawer.Name = "hexagonDrawer";
            hexagonDrawer.Size = new Size(30, 30);
            hexagonDrawer.TabIndex = 32;
            hexagonDrawer.Text = "button22";
            hexagonDrawer.UseVisualStyleBackColor = true;
            hexagonDrawer.Click += ChooseDrawingMethod;
            // 
            // rhombusDrawer
            // 
            rhombusDrawer.Location = new Point(111, 6);
            rhombusDrawer.Name = "rhombusDrawer";
            rhombusDrawer.Size = new Size(30, 30);
            rhombusDrawer.TabIndex = 31;
            rhombusDrawer.Text = "button22";
            rhombusDrawer.UseVisualStyleBackColor = true;
            rhombusDrawer.Click += ChooseDrawingMethod;
            // 
            // pentaGon
            // 
            pentaGon.Location = new Point(75, 39);
            pentaGon.Name = "pentaGon";
            pentaGon.Size = new Size(30, 30);
            pentaGon.TabIndex = 30;
            pentaGon.Text = "button22";
            pentaGon.UseVisualStyleBackColor = true;
            pentaGon.Click += ChooseDrawingMethod;
            // 
            // rightTriangleDrawer
            // 
            rightTriangleDrawer.Location = new Point(39, 39);
            rightTriangleDrawer.Name = "rightTriangleDrawer";
            rightTriangleDrawer.Size = new Size(30, 30);
            rightTriangleDrawer.TabIndex = 29;
            rightTriangleDrawer.Text = "button22";
            rightTriangleDrawer.UseVisualStyleBackColor = true;
            rightTriangleDrawer.Click += ChooseDrawingMethod;
            // 
            // isoscelesTriangleDrawer
            // 
            isoscelesTriangleDrawer.Location = new Point(3, 39);
            isoscelesTriangleDrawer.Name = "isoscelesTriangleDrawer";
            isoscelesTriangleDrawer.Size = new Size(30, 30);
            isoscelesTriangleDrawer.TabIndex = 28;
            isoscelesTriangleDrawer.Text = "button21";
            isoscelesTriangleDrawer.UseVisualStyleBackColor = true;
            isoscelesTriangleDrawer.Click += ChooseDrawingMethod;
            // 
            // panel6
            // 
            panel6.Controls.Add(menuStrip2);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(179, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(105, 110);
            panel6.TabIndex = 27;
            // 
            // menuStrip2
            // 
            menuStrip2.AutoSize = false;
            menuStrip2.Dock = DockStyle.Bottom;
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { контурToolStripMenuItem, заливкаToolStripMenuItem1 });
            menuStrip2.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(105, 110);
            menuStrip2.TabIndex = 0;
            menuStrip2.Text = "menuStrip2";
            // 
            // контурToolStripMenuItem
            // 
            контурToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NOcontour, SolidColorContour });
            контурToolStripMenuItem.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            контурToolStripMenuItem.Image = Properties.Resources.PencilContur;
            контурToolStripMenuItem.Name = "контурToolStripMenuItem";
            контурToolStripMenuItem.Size = new Size(98, 28);
            контурToolStripMenuItem.Text = "Контур";
            // 
            // NOcontour
            // 
            NOcontour.Image = Properties.Resources.без_заливки;
            NOcontour.Name = "NOcontour";
            NOcontour.Size = new Size(223, 34);
            NOcontour.Text = "Без Контура";
            NOcontour.Click += ParamsOfFillingAndContour;
            // 
            // SolidColorContour
            // 
            SolidColorContour.Image = Properties.Resources.Сплошной_цвет;
            SolidColorContour.Name = "SolidColorContour";
            SolidColorContour.Size = new Size(223, 34);
            SolidColorContour.Text = "Сплошной цвет";
            SolidColorContour.Click += ParamsOfFillingAndContour;
            // 
            // заливкаToolStripMenuItem1
            // 
            заливкаToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { NoFilling, SolidColorFilling });
            заливкаToolStripMenuItem1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            заливкаToolStripMenuItem1.Image = Properties.Resources.заливка;
            заливкаToolStripMenuItem1.Name = "заливкаToolStripMenuItem1";
            заливкаToolStripMenuItem1.Size = new Size(98, 28);
            заливкаToolStripMenuItem1.Text = "Заливка";
            // 
            // NoFilling
            // 
            NoFilling.Image = Properties.Resources.без_заливки;
            NoFilling.Name = "NoFilling";
            NoFilling.Size = new Size(229, 34);
            NoFilling.Text = "Без Заливки";
            NoFilling.Click += ParamsOfFillingAndContour;
            // 
            // SolidColorFilling
            // 
            SolidColorFilling.Image = Properties.Resources.Сплошной_цвет;
            SolidColorFilling.Name = "SolidColorFilling";
            SolidColorFilling.Size = new Size(229, 34);
            SolidColorFilling.Text = "Сплошной Цвет ";
            SolidColorFilling.Click += ParamsOfFillingAndContour;
            // 
            // EllipsDrawer
            // 
            EllipsDrawer.Location = new Point(39, 6);
            EllipsDrawer.Name = "EllipsDrawer";
            EllipsDrawer.Size = new Size(30, 30);
            EllipsDrawer.TabIndex = 26;
            EllipsDrawer.Text = "button22";
            EllipsDrawer.UseVisualStyleBackColor = true;
            EllipsDrawer.Click += ChooseDrawingMethod;
            // 
            // RectangleDrawer
            // 
            RectangleDrawer.Location = new Point(75, 6);
            RectangleDrawer.Name = "RectangleDrawer";
            RectangleDrawer.Size = new Size(30, 30);
            RectangleDrawer.TabIndex = 25;
            RectangleDrawer.Text = "button22";
            RectangleDrawer.UseVisualStyleBackColor = true;
            RectangleDrawer.Click += ChooseDrawingMethod;
            // 
            // LineDrawer
            // 
            LineDrawer.Location = new Point(3, 6);
            LineDrawer.Name = "LineDrawer";
            LineDrawer.Size = new Size(30, 30);
            LineDrawer.TabIndex = 24;
            LineDrawer.Text = "button21";
            LineDrawer.UseVisualStyleBackColor = true;
            LineDrawer.Click += ChooseDrawingMethod;
            // 
            // FiguresLabel
            // 
            FiguresLabel.AutoSize = true;
            FiguresLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            FiguresLabel.Location = new Point(93, 89);
            FiguresLabel.Name = "FiguresLabel";
            FiguresLabel.Size = new Size(65, 21);
            FiguresLabel.TabIndex = 22;
            FiguresLabel.Text = "Фигуры";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(ColorsLabel);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(button19);
            panel2.Controls.Add(button18);
            panel2.Controls.Add(button17);
            panel2.Controls.Add(button16);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button11);
            panel2.Controls.Add(button12);
            panel2.Controls.Add(button13);
            panel2.Controls.Add(button14);
            panel2.Controls.Add(button15);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(702, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(590, 110);
            panel2.TabIndex = 1;
            // 
            // ColorsLabel
            // 
            ColorsLabel.AutoSize = true;
            ColorsLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            ColorsLabel.Location = new Point(348, 89);
            ColorsLabel.Name = "ColorsLabel";
            ColorsLabel.Size = new Size(53, 21);
            ColorsLabel.TabIndex = 21;
            ColorsLabel.Text = "Цвета";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel3.Controls.Add(MainColorPanel);
            panel3.Controls.Add(AddictionalColorPanel);
            panel3.Location = new Point(104, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(110, 93);
            panel3.TabIndex = 2;
            // 
            // MainColorPanel
            // 
            MainColorPanel.BackColor = Color.SteelBlue;
            MainColorPanel.Controls.Add(MainColorButton);
            MainColorPanel.Controls.Add(label1);
            MainColorPanel.Dock = DockStyle.Left;
            MainColorPanel.Location = new Point(0, 0);
            MainColorPanel.Name = "MainColorPanel";
            MainColorPanel.Size = new Size(56, 93);
            MainColorPanel.TabIndex = 2;
            MainColorPanel.Click += ChooseColor;
            // 
            // MainColorButton
            // 
            MainColorButton.BackColor = Color.Black;
            MainColorButton.BorderStyle = BorderStyle.FixedSingle;
            MainColorButton.Location = new Point(4, 3);
            MainColorButton.Name = "MainColorButton";
            MainColorButton.Size = new Size(48, 48);
            MainColorButton.TabIndex = 23;
            MainColorButton.TabStop = false;
            MainColorButton.Click += ChooseColor;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(2, 74);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 22;
            label1.Text = "Цвет 1";
            label1.Click += ChooseColor;
            // 
            // AddictionalColorPanel
            // 
            AddictionalColorPanel.Controls.Add(AddictionalColorButton);
            AddictionalColorPanel.Controls.Add(label2);
            AddictionalColorPanel.Dock = DockStyle.Right;
            AddictionalColorPanel.Location = new Point(54, 0);
            AddictionalColorPanel.Name = "AddictionalColorPanel";
            AddictionalColorPanel.Size = new Size(56, 93);
            AddictionalColorPanel.TabIndex = 22;
            AddictionalColorPanel.Click += ChooseColor;
            // 
            // AddictionalColorButton
            // 
            AddictionalColorButton.BackColor = Color.White;
            AddictionalColorButton.BorderStyle = BorderStyle.FixedSingle;
            AddictionalColorButton.Location = new Point(8, 9);
            AddictionalColorButton.Name = "AddictionalColorButton";
            AddictionalColorButton.Size = new Size(40, 40);
            AddictionalColorButton.TabIndex = 24;
            AddictionalColorButton.TabStop = false;
            AddictionalColorButton.Click += ChooseColor;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 74);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 23;
            label2.Text = "Цвет 2";
            label2.Click += ChooseColor;
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(102, 110);
            panel1.TabIndex = 20;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(70, 80);
            menuStrip1.Items.AddRange(new ToolStripItem[] { толщинаToolStripMenuItem1, toolStripMenuItem5, toolStripMenuItem6, toolStripMenuItem7, toolStripMenuItem8 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(102, 96);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // толщинаToolStripMenuItem1
            // 
            толщинаToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4 });
            толщинаToolStripMenuItem1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            толщинаToolStripMenuItem1.Image = Properties.Resources.line_width;
            толщинаToolStripMenuItem1.Name = "толщинаToolStripMenuItem1";
            толщинаToolStripMenuItem1.Size = new Size(86, 92);
            толщинаToolStripMenuItem1.Text = "Толщина";
            толщинаToolStripMenuItem1.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.AutoSize = false;
            toolStripMenuItem1.BackgroundImage = Properties.Resources.Без_имени_1_копия;
            toolStripMenuItem1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(150, 60);
            toolStripMenuItem1.Click += ChooseThickNess;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.AutoSize = false;
            toolStripMenuItem2.BackgroundImage = Properties.Resources._21;
            toolStripMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(150, 60);
            toolStripMenuItem2.Click += ChooseThickNess;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.AutoSize = false;
            toolStripMenuItem3.BackgroundImage = Properties.Resources._31;
            toolStripMenuItem3.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(150, 60);
            toolStripMenuItem3.Click += ChooseThickNess;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.AutoSize = false;
            toolStripMenuItem4.BackgroundImage = Properties.Resources._41;
            toolStripMenuItem4.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(150, 60);
            toolStripMenuItem4.Click += ChooseThickNess;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(16, 92);
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(16, 92);
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(16, 92);
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(16, 92);
            // 
            // button19
            // 
            button19.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button19.BackColor = Color.White;
            button19.Cursor = Cursors.Hand;
            button19.Location = new Point(214, 39);
            button19.Name = "button19";
            button19.Size = new Size(30, 30);
            button19.TabIndex = 18;
            button19.UseVisualStyleBackColor = false;
            button19.MouseClick += ColorPick;
            // 
            // button18
            // 
            button18.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button18.BackColor = Color.Black;
            button18.Cursor = Cursors.Hand;
            button18.Location = new Point(214, 3);
            button18.Name = "button18";
            button18.Size = new Size(30, 30);
            button18.TabIndex = 17;
            button18.UseVisualStyleBackColor = false;
            button18.MouseClick += ColorPick;
            // 
            // button17
            // 
            button17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button17.BackColor = Color.Gray;
            button17.Cursor = Cursors.Hand;
            button17.Location = new Point(250, 39);
            button17.Name = "button17";
            button17.Size = new Size(30, 30);
            button17.TabIndex = 16;
            button17.UseVisualStyleBackColor = false;
            button17.MouseClick += ColorPick;
            // 
            // button16
            // 
            button16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button16.BackColor = Color.FromArgb(100, 64, 15);
            button16.Cursor = Cursors.Hand;
            button16.Location = new Point(250, 3);
            button16.Name = "button16";
            button16.Size = new Size(30, 30);
            button16.TabIndex = 15;
            button16.UseVisualStyleBackColor = false;
            button16.MouseClick += ColorPick;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(255, 36, 0);
            button1.Location = new Point(538, 3);
            button1.Name = "button1";
            button1.Size = new Size(49, 66);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button7.BackColor = Color.FromArgb(183, 132, 168);
            button7.Cursor = Cursors.Hand;
            button7.Location = new Point(502, 39);
            button7.Name = "button7";
            button7.Size = new Size(30, 30);
            button7.TabIndex = 13;
            button7.UseVisualStyleBackColor = false;
            button7.MouseClick += ColorPick;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button10.BackColor = Color.DarkBlue;
            button10.Cursor = Cursors.Hand;
            button10.Location = new Point(466, 39);
            button10.Name = "button10";
            button10.Size = new Size(30, 30);
            button10.TabIndex = 12;
            button10.UseVisualStyleBackColor = false;
            button10.MouseClick += ColorPick;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button11.BackColor = Color.SkyBlue;
            button11.Cursor = Cursors.Hand;
            button11.Location = new Point(430, 39);
            button11.Name = "button11";
            button11.Size = new Size(30, 30);
            button11.TabIndex = 11;
            button11.UseVisualStyleBackColor = false;
            button11.MouseClick += ColorPick;
            // 
            // button12
            // 
            button12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button12.BackColor = Color.FromArgb(91, 163, 48);
            button12.Cursor = Cursors.Hand;
            button12.Location = new Point(394, 39);
            button12.Name = "button12";
            button12.Size = new Size(30, 30);
            button12.TabIndex = 10;
            button12.UseVisualStyleBackColor = false;
            button12.MouseClick += ColorPick;
            // 
            // button13
            // 
            button13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button13.BackColor = Color.FromArgb(252, 211, 118);
            button13.Cursor = Cursors.Hand;
            button13.Location = new Point(358, 39);
            button13.Name = "button13";
            button13.Size = new Size(30, 30);
            button13.TabIndex = 9;
            button13.UseVisualStyleBackColor = false;
            button13.MouseClick += ColorPick;
            // 
            // button14
            // 
            button14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button14.BackColor = Color.FromArgb(250, 215, 0);
            button14.Cursor = Cursors.Hand;
            button14.Location = new Point(322, 39);
            button14.Name = "button14";
            button14.Size = new Size(30, 30);
            button14.TabIndex = 8;
            button14.UseVisualStyleBackColor = false;
            button14.MouseClick += ColorPick;
            // 
            // button15
            // 
            button15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button15.BackColor = Color.FromArgb(252, 116, 253);
            button15.Cursor = Cursors.Hand;
            button15.Location = new Point(286, 39);
            button15.Name = "button15";
            button15.Size = new Size(30, 30);
            button15.TabIndex = 7;
            button15.UseVisualStyleBackColor = false;
            button15.MouseClick += ColorPick;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button9.BackColor = Color.DarkViolet;
            button9.Cursor = Cursors.Hand;
            button9.Location = new Point(502, 3);
            button9.Name = "button9";
            button9.Size = new Size(30, 30);
            button9.TabIndex = 6;
            button9.UseVisualStyleBackColor = false;
            button9.MouseClick += ColorPick;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button8.BackColor = Color.FromArgb(0, 71, 171);
            button8.Cursor = Cursors.Hand;
            button8.Location = new Point(466, 3);
            button8.Name = "button8";
            button8.Size = new Size(30, 30);
            button8.TabIndex = 5;
            button8.UseVisualStyleBackColor = false;
            button8.MouseClick += ColorPick;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button6.BackColor = Color.FromArgb(66, 170, 255);
            button6.Cursor = Cursors.Hand;
            button6.Location = new Point(430, 3);
            button6.Name = "button6";
            button6.Size = new Size(30, 30);
            button6.TabIndex = 4;
            button6.UseVisualStyleBackColor = false;
            button6.MouseClick += ColorPick;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button5.BackColor = Color.Green;
            button5.Cursor = Cursors.Hand;
            button5.Location = new Point(394, 3);
            button5.Name = "button5";
            button5.Size = new Size(30, 30);
            button5.TabIndex = 3;
            button5.UseVisualStyleBackColor = false;
            button5.MouseClick += ColorPick;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button4.BackColor = Color.Yellow;
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(358, 3);
            button4.Name = "button4";
            button4.Size = new Size(30, 30);
            button4.TabIndex = 2;
            button4.UseVisualStyleBackColor = false;
            button4.MouseClick += ColorPick;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(236, 124, 38);
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(322, 3);
            button3.Name = "button3";
            button3.Size = new Size(30, 30);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = false;
            button3.MouseClick += ColorPick;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(255, 36, 0);
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(286, 3);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = false;
            button2.MouseClick += ColorPick;
            // 
            // толщинаToolStripMenuItem
            // 
            толщинаToolStripMenuItem.DropDownDirection = ToolStripDropDownDirection.BelowRight;
            толщинаToolStripMenuItem.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            толщинаToolStripMenuItem.Image = Properties.Resources.line_width1;
            толщинаToolStripMenuItem.Name = "толщинаToolStripMenuItem";
            толщинаToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            толщинаToolStripMenuItem.Size = new Size(90, 106);
            толщинаToolStripMenuItem.Text = "Толщина";
            толщинаToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 605);
            Controls.Add(ControlPanel);
            Controls.Add(Sheet);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)Sheet).EndInit();
            ControlPanel.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            MainColorPanel.ResumeLayout(false);
            MainColorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MainColorButton).EndInit();
            AddictionalColorPanel.ResumeLayout(false);
            AddictionalColorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AddictionalColorButton).EndInit();
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Sheet;
        private Panel ControlPanel;
        private Panel panel2;
        private Button button9;
        private Button button8;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button7;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button19;
        private Button button18;
        private Button button17;
        private Button button16;
        private ToolStripMenuItem толщинаToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem толщинаToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private Panel panel1;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private Panel AddictionalColorPanel;
        private Panel MainColorPanel;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private PictureBox MainColorButton;
        private PictureBox AddictionalColorButton;
        private Panel panel4;
        private Button PenDrawer;
        private Label FiguresLabel;
        private Label ColorsLabel;
        private Panel panel5;
        private Label label3;
        private Button RectangleDrawer;
        private Button LineDrawer;
        private ColorDialog colorDialog1;
        private Button EllipsDrawer;
        private Panel panel6;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem контурToolStripMenuItem;
        private ToolStripMenuItem заливкаToolStripMenuItem1;
        private ToolStripMenuItem NoFilling;
        private ToolStripMenuItem SolidColorFilling;
        private ToolStripMenuItem NOcontour;
        private ToolStripMenuItem SolidColorContour;
        private Panel panel7;
        private Label label4;
        private Button button26;
        private Button button25;
        private Button hexagonDrawer;
        private Button rhombusDrawer;
        private Button pentaGon;
        private Button rightTriangleDrawer;
        private Button isoscelesTriangleDrawer;
    }
}