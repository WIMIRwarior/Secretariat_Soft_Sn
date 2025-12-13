namespace Secretariat_Soft
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Top_Panel = new Panel();
            Help_Button = new Button();
            Tools_Button = new Button();
            Report_Button = new Button();
            Data_Entry_Button = new Button();
            Minimize_Button = new Button();
            Close_Button = new Button();
            Side_Panel = new Panel();
            Calendar_Panel = new Panel();
            Day_Name_Label = new Label();
            Day_Num_Label = new Label();
            Month_Name_Label = new Label();
            Year_Num_Label = new Label();
            Bottom_Panel = new Panel();
            Calculator_Button = new Button();
            Background_Button = new Button();
            Digital_Clock_Label = new Label();
            Top_Panel.SuspendLayout();
            Side_Panel.SuspendLayout();
            Calendar_Panel.SuspendLayout();
            Bottom_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // Top_Panel
            // 
            Top_Panel.BackColor = Color.Silver;
            Top_Panel.Controls.Add(Help_Button);
            Top_Panel.Controls.Add(Tools_Button);
            Top_Panel.Controls.Add(Report_Button);
            Top_Panel.Controls.Add(Data_Entry_Button);
            Top_Panel.Controls.Add(Minimize_Button);
            Top_Panel.Controls.Add(Close_Button);
            Top_Panel.Dock = DockStyle.Top;
            Top_Panel.Location = new Point(170, 0);
            Top_Panel.MinimumSize = new Size(0, 60);
            Top_Panel.Name = "Top_Panel";
            Top_Panel.Size = new Size(854, 60);
            Top_Panel.TabIndex = 0;
            // 
            // Help_Button
            // 
            Help_Button.BackgroundImage = Properties.Resources.butt_background;
            Help_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Help_Button.Cursor = Cursors.Help;
            Help_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Help_Button.ForeColor = Color.Black;
            Help_Button.Image = Properties.Resources.top_Help_butt;
            Help_Button.ImageAlign = ContentAlignment.TopCenter;
            Help_Button.Location = new Point(297, 3);
            Help_Button.Name = "Help_Button";
            Help_Button.Size = new Size(91, 57);
            Help_Button.TabIndex = 10;
            Help_Button.Text = "Help F5";
            Help_Button.TextAlign = ContentAlignment.BottomCenter;
            Help_Button.TextImageRelation = TextImageRelation.ImageAboveText;
            Help_Button.UseVisualStyleBackColor = true;
            // 
            // Tools_Button
            // 
            Tools_Button.BackgroundImage = Properties.Resources.butt_background;
            Tools_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Tools_Button.Cursor = Cursors.Hand;
            Tools_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Tools_Button.ForeColor = Color.Black;
            Tools_Button.Image = Properties.Resources.top_Tools_butt;
            Tools_Button.ImageAlign = ContentAlignment.TopCenter;
            Tools_Button.Location = new Point(200, 3);
            Tools_Button.Name = "Tools_Button";
            Tools_Button.Size = new Size(91, 57);
            Tools_Button.TabIndex = 9;
            Tools_Button.Text = "Tools F4";
            Tools_Button.TextAlign = ContentAlignment.BottomCenter;
            Tools_Button.TextImageRelation = TextImageRelation.ImageAboveText;
            Tools_Button.UseVisualStyleBackColor = true;
            // 
            // Report_Button
            // 
            Report_Button.BackgroundImage = Properties.Resources.butt_background;
            Report_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Report_Button.Cursor = Cursors.Hand;
            Report_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Report_Button.ForeColor = Color.Black;
            Report_Button.Image = Properties.Resources.top_report_butt;
            Report_Button.ImageAlign = ContentAlignment.TopCenter;
            Report_Button.Location = new Point(103, 3);
            Report_Button.Name = "Report_Button";
            Report_Button.Size = new Size(91, 57);
            Report_Button.TabIndex = 8;
            Report_Button.Text = "Report F3";
            Report_Button.TextAlign = ContentAlignment.BottomCenter;
            Report_Button.TextImageRelation = TextImageRelation.ImageAboveText;
            Report_Button.UseVisualStyleBackColor = true;
            // 
            // Data_Entry_Button
            // 
            Data_Entry_Button.BackgroundImage = Properties.Resources.butt_background;
            Data_Entry_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Data_Entry_Button.Cursor = Cursors.Hand;
            Data_Entry_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Data_Entry_Button.ForeColor = Color.Black;
            Data_Entry_Button.Image = Properties.Resources.top_input_butt;
            Data_Entry_Button.ImageAlign = ContentAlignment.TopCenter;
            Data_Entry_Button.Location = new Point(6, 3);
            Data_Entry_Button.Name = "Data_Entry_Button";
            Data_Entry_Button.Size = new Size(91, 57);
            Data_Entry_Button.TabIndex = 7;
            Data_Entry_Button.Text = "Data Entry F2";
            Data_Entry_Button.TextAlign = ContentAlignment.BottomCenter;
            Data_Entry_Button.TextImageRelation = TextImageRelation.ImageAboveText;
            Data_Entry_Button.UseVisualStyleBackColor = true;
            // 
            // Minimize_Button
            // 
            Minimize_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Minimize_Button.BackgroundImage = Properties.Resources.min_butt;
            Minimize_Button.BackgroundImageLayout = ImageLayout.Zoom;
            Minimize_Button.Cursor = Cursors.Hand;
            Minimize_Button.Location = new Point(776, 3);
            Minimize_Button.Name = "Minimize_Button";
            Minimize_Button.Size = new Size(30, 30);
            Minimize_Button.TabIndex = 6;
            Minimize_Button.UseVisualStyleBackColor = true;
            Minimize_Button.Click += Minimize_Button_Click;
            // 
            // Close_Button
            // 
            Close_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Close_Button.BackgroundImage = Properties.Resources.Close_butt;
            Close_Button.BackgroundImageLayout = ImageLayout.Zoom;
            Close_Button.Cursor = Cursors.Hand;
            Close_Button.Location = new Point(812, 3);
            Close_Button.Name = "Close_Button";
            Close_Button.Size = new Size(30, 30);
            Close_Button.TabIndex = 5;
            Close_Button.UseVisualStyleBackColor = true;
            Close_Button.Click += Close_Button_Click;
            // 
            // Side_Panel
            // 
            Side_Panel.BackColor = Color.Silver;
            Side_Panel.Controls.Add(Digital_Clock_Label);
            Side_Panel.Controls.Add(Calendar_Panel);
            Side_Panel.Dock = DockStyle.Left;
            Side_Panel.Location = new Point(0, 0);
            Side_Panel.MinimumSize = new Size(170, 0);
            Side_Panel.Name = "Side_Panel";
            Side_Panel.Size = new Size(170, 768);
            Side_Panel.TabIndex = 2;
            // 
            // Calendar_Panel
            // 
            Calendar_Panel.BackgroundImage = Properties.Resources.calendar;
            Calendar_Panel.BackgroundImageLayout = ImageLayout.Stretch;
            Calendar_Panel.Controls.Add(Day_Name_Label);
            Calendar_Panel.Controls.Add(Day_Num_Label);
            Calendar_Panel.Controls.Add(Month_Name_Label);
            Calendar_Panel.Controls.Add(Year_Num_Label);
            Calendar_Panel.Location = new Point(3, 64);
            Calendar_Panel.Name = "Calendar_Panel";
            Calendar_Panel.Size = new Size(164, 176);
            Calendar_Panel.TabIndex = 0;
            // 
            // Day_Name_Label
            // 
            Day_Name_Label.BackColor = Color.Transparent;
            Day_Name_Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Day_Name_Label.ForeColor = Color.Black;
            Day_Name_Label.Location = new Point(9, 128);
            Day_Name_Label.Name = "Day_Name_Label";
            Day_Name_Label.Size = new Size(151, 21);
            Day_Name_Label.TabIndex = 3;
            Day_Name_Label.Text = "Poniedziałek";
            Day_Name_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Day_Num_Label
            // 
            Day_Num_Label.BackColor = Color.Transparent;
            Day_Num_Label.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Day_Num_Label.ForeColor = Color.Black;
            Day_Num_Label.Location = new Point(9, 76);
            Day_Num_Label.Name = "Day_Num_Label";
            Day_Num_Label.Size = new Size(151, 43);
            Day_Num_Label.TabIndex = 2;
            Day_Num_Label.Text = "25";
            Day_Num_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Month_Name_Label
            // 
            Month_Name_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Month_Name_Label.BackColor = Color.Transparent;
            Month_Name_Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Month_Name_Label.ForeColor = Color.White;
            Month_Name_Label.Location = new Point(54, 42);
            Month_Name_Label.Name = "Month_Name_Label";
            Month_Name_Label.Size = new Size(106, 21);
            Month_Name_Label.TabIndex = 1;
            Month_Name_Label.Text = "Październik";
            Month_Name_Label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Year_Num_Label
            // 
            Year_Num_Label.BackColor = Color.Transparent;
            Year_Num_Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Year_Num_Label.ForeColor = Color.White;
            Year_Num_Label.Location = new Point(9, 42);
            Year_Num_Label.Name = "Year_Num_Label";
            Year_Num_Label.Size = new Size(55, 21);
            Year_Num_Label.TabIndex = 0;
            Year_Num_Label.Text = "2025";
            Year_Num_Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Bottom_Panel
            // 
            Bottom_Panel.Controls.Add(Calculator_Button);
            Bottom_Panel.Controls.Add(Background_Button);
            Bottom_Panel.Dock = DockStyle.Bottom;
            Bottom_Panel.Location = new Point(170, 728);
            Bottom_Panel.MinimumSize = new Size(0, 40);
            Bottom_Panel.Name = "Bottom_Panel";
            Bottom_Panel.Size = new Size(854, 40);
            Bottom_Panel.TabIndex = 4;
            // 
            // Calculator_Button
            // 
            Calculator_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Calculator_Button.BackgroundImage = Properties.Resources.butt_background;
            Calculator_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Calculator_Button.Cursor = Cursors.Hand;
            Calculator_Button.Image = Properties.Resources.calc_butt;
            Calculator_Button.Location = new Point(706, 3);
            Calculator_Button.Name = "Calculator_Button";
            Calculator_Button.Size = new Size(28, 34);
            Calculator_Button.TabIndex = 1;
            Calculator_Button.TextImageRelation = TextImageRelation.ImageBeforeText;
            Calculator_Button.UseVisualStyleBackColor = true;
            // 
            // Background_Button
            // 
            Background_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Background_Button.BackgroundImage = Properties.Resources.butt_background;
            Background_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Background_Button.Cursor = Cursors.Hand;
            Background_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Background_Button.Image = Properties.Resources.background;
            Background_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Background_Button.Location = new Point(740, 3);
            Background_Button.Name = "Background_Button";
            Background_Button.Size = new Size(102, 34);
            Background_Button.TabIndex = 0;
            Background_Button.Text = "Background";
            Background_Button.TextImageRelation = TextImageRelation.ImageBeforeText;
            Background_Button.UseVisualStyleBackColor = true;
            // 
            // Digital_Clock_Label
            // 
            Digital_Clock_Label.BackColor = Color.Black;
            Digital_Clock_Label.BorderStyle = BorderStyle.Fixed3D;
            Digital_Clock_Label.Font = new Font("Typo Digit Demo", 40F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Digital_Clock_Label.ForeColor = Color.White;
            Digital_Clock_Label.Location = new Point(13, 5);
            Digital_Clock_Label.Name = "Digital_Clock_Label";
            Digital_Clock_Label.Size = new Size(151, 56);
            Digital_Clock_Label.TabIndex = 1;
            Digital_Clock_Label.Text = "12:20";
            Digital_Clock_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 768);
            Controls.Add(Bottom_Panel);
            Controls.Add(Top_Panel);
            Controls.Add(Side_Panel);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MinimumSize = new Size(1024, 768);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            Top_Panel.ResumeLayout(false);
            Side_Panel.ResumeLayout(false);
            Calendar_Panel.ResumeLayout(false);
            Bottom_Panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Top_Panel;
        private Panel Side_Panel;
        private Panel Bottom_Panel;
        private Button Minimize_Button;
        private Button Close_Button;
        private Button Data_Entry_Button;
        private Button Tools_Button;
        private Button Report_Button;
        private Button Help_Button;
        private Button Background_Button;
        private Button Calculator_Button;
        private Panel Calendar_Panel;
        private Label Year_Num_Label;
        private Label Month_Name_Label;
        private Label Day_Name_Label;
        private Label Day_Num_Label;
        private Label Digital_Clock_Label;
    }
}