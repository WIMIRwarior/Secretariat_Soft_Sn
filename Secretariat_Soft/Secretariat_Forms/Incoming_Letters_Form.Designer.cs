namespace Secretariat_Soft.Secretariat_Forms
{
    partial class Incoming_Letters_Form
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            Top_toolStrip = new ToolStrip();
            Bottom_toolStrip = new ToolStrip();
            First_Button = new ToolStripButton();
            Previous_Button = new ToolStripButton();
            SelectedRowPosition_TextBox = new ToolStripTextBox();
            RecordsTotalNumber_TextBox = new ToolStripTextBox();
            Next_Button = new ToolStripButton();
            Last_Button = new ToolStripButton();
            dataGridView1 = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subjectDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            letterNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            letterTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateReceivedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            letterTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            senderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            recipientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            receiveMethodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priorityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pageCountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            responseDeadlineDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            relatedtoDocDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            docSummaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            systemDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            systemTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Incoming_Letters_bindingSource = new BindingSource(components);
            letters1 = new Secretariat_Soft.DataSet.Letters();
            incoming_LettersTableAdapter1 = new Secretariat_Soft.DataSet.LettersTableAdapters.Incoming_LettersTableAdapter();
            Print_Button = new ToolStripButton();
            AddEditDoc_Button = new ToolStripButton();
            Search_Button = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripSeparator4 = new ToolStripSeparator();
            Top_toolStrip.SuspendLayout();
            Bottom_toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Incoming_Letters_bindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)letters1).BeginInit();
            SuspendLayout();
            // 
            // Top_toolStrip
            // 
            Top_toolStrip.AutoSize = false;
            Top_toolStrip.Items.AddRange(new ToolStripItem[] { AddEditDoc_Button, toolStripSeparator2, toolStripSeparator1, Print_Button, toolStripSeparator4, Search_Button, toolStripSeparator3 });
            Top_toolStrip.Location = new Point(0, 0);
            Top_toolStrip.Name = "Top_toolStrip";
            Top_toolStrip.Size = new Size(1026, 54);
            Top_toolStrip.TabIndex = 0;
            Top_toolStrip.Text = "toolStrip1";
            // 
            // Bottom_toolStrip
            // 
            Bottom_toolStrip.AutoSize = false;
            Bottom_toolStrip.Dock = DockStyle.Bottom;
            Bottom_toolStrip.Items.AddRange(new ToolStripItem[] { First_Button, Previous_Button, SelectedRowPosition_TextBox, RecordsTotalNumber_TextBox, Next_Button, Last_Button });
            Bottom_toolStrip.Location = new Point(0, 539);
            Bottom_toolStrip.Name = "Bottom_toolStrip";
            Bottom_toolStrip.Size = new Size(1026, 57);
            Bottom_toolStrip.TabIndex = 1;
            Bottom_toolStrip.Text = "toolStrip2";
            // 
            // First_Button
            // 
            First_Button.AutoSize = false;
            First_Button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            First_Button.Image = Properties.Resources.nav_first;
            First_Button.ImageScaling = ToolStripItemImageScaling.None;
            First_Button.ImageTransparentColor = Color.Magenta;
            First_Button.Name = "First_Button";
            First_Button.Size = new Size(30, 30);
            First_Button.Text = "toolStripButton1";
            First_Button.Click += First_Button_Click;
            // 
            // Previous_Button
            // 
            Previous_Button.AutoSize = false;
            Previous_Button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Previous_Button.Image = Properties.Resources.nav_previous;
            Previous_Button.ImageScaling = ToolStripItemImageScaling.None;
            Previous_Button.ImageTransparentColor = Color.Magenta;
            Previous_Button.Name = "Previous_Button";
            Previous_Button.Size = new Size(30, 30);
            Previous_Button.Text = "toolStripButton1";
            Previous_Button.Click += Previous_Button_Click;
            // 
            // SelectedRowPosition_TextBox
            // 
            SelectedRowPosition_TextBox.AutoSize = false;
            SelectedRowPosition_TextBox.Name = "SelectedRowPosition_TextBox";
            SelectedRowPosition_TextBox.Size = new Size(40, 40);
            SelectedRowPosition_TextBox.TextBoxTextAlign = HorizontalAlignment.Center;
            // 
            // RecordsTotalNumber_TextBox
            // 
            RecordsTotalNumber_TextBox.AutoSize = false;
            RecordsTotalNumber_TextBox.Name = "RecordsTotalNumber_TextBox";
            RecordsTotalNumber_TextBox.Size = new Size(40, 40);
            RecordsTotalNumber_TextBox.TextBoxTextAlign = HorizontalAlignment.Center;
            // 
            // Next_Button
            // 
            Next_Button.AutoSize = false;
            Next_Button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Next_Button.Image = Properties.Resources.nav_next;
            Next_Button.ImageScaling = ToolStripItemImageScaling.None;
            Next_Button.ImageTransparentColor = Color.Magenta;
            Next_Button.Name = "Next_Button";
            Next_Button.Size = new Size(30, 30);
            Next_Button.Text = "toolStripButton1";
            Next_Button.Click += Next_Button_Click;
            // 
            // Last_Button
            // 
            Last_Button.AutoSize = false;
            Last_Button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Last_Button.Image = Properties.Resources.nav_last;
            Last_Button.ImageScaling = ToolStripItemImageScaling.None;
            Last_Button.ImageTransparentColor = Color.Magenta;
            Last_Button.Name = "Last_Button";
            Last_Button.Size = new Size(30, 30);
            Last_Button.Text = "toolStripButton1";
            Last_Button.Click += Last_Button_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = Color.DeepSkyBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.SkyBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, subjectDataGridViewTextBoxColumn, regDateDataGridViewTextBoxColumn, letterNumberDataGridViewTextBoxColumn, letterTimeDataGridViewTextBoxColumn, dateReceivedDataGridViewTextBoxColumn, letterTypeDataGridViewTextBoxColumn, senderDataGridViewTextBoxColumn, recipientDataGridViewTextBoxColumn, receiveMethodDataGridViewTextBoxColumn, groupNameDataGridViewTextBoxColumn, priorityDataGridViewTextBoxColumn, pageCountDataGridViewTextBoxColumn, responseDeadlineDataGridViewTextBoxColumn, relatedtoDocDataGridViewTextBoxColumn, docSummaryDataGridViewTextBoxColumn, userNameDataGridViewTextBoxColumn, userIDDataGridViewTextBoxColumn, systemDateDataGridViewTextBoxColumn, systemTimeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = Incoming_Letters_bindingSource;
            dataGridView1.Location = new Point(12, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 25;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.Size = new Size(1002, 479);
            dataGridView1.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            iDDataGridViewTextBoxColumn.Width = 80;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            subjectDataGridViewTextBoxColumn.ReadOnly = true;
            subjectDataGridViewTextBoxColumn.Width = 250;
            // 
            // regDateDataGridViewTextBoxColumn
            // 
            regDateDataGridViewTextBoxColumn.DataPropertyName = "Reg_Date";
            regDateDataGridViewTextBoxColumn.HeaderText = "Reg Date";
            regDateDataGridViewTextBoxColumn.Name = "regDateDataGridViewTextBoxColumn";
            regDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // letterNumberDataGridViewTextBoxColumn
            // 
            letterNumberDataGridViewTextBoxColumn.DataPropertyName = "Letter_Number";
            letterNumberDataGridViewTextBoxColumn.HeaderText = "Letter Number";
            letterNumberDataGridViewTextBoxColumn.Name = "letterNumberDataGridViewTextBoxColumn";
            letterNumberDataGridViewTextBoxColumn.ReadOnly = true;
            letterNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // letterTimeDataGridViewTextBoxColumn
            // 
            letterTimeDataGridViewTextBoxColumn.DataPropertyName = "Letter_Time";
            letterTimeDataGridViewTextBoxColumn.HeaderText = "Letter Time";
            letterTimeDataGridViewTextBoxColumn.Name = "letterTimeDataGridViewTextBoxColumn";
            letterTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateReceivedDataGridViewTextBoxColumn
            // 
            dateReceivedDataGridViewTextBoxColumn.DataPropertyName = "Date_Received";
            dateReceivedDataGridViewTextBoxColumn.HeaderText = "Date Received";
            dateReceivedDataGridViewTextBoxColumn.Name = "dateReceivedDataGridViewTextBoxColumn";
            dateReceivedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // letterTypeDataGridViewTextBoxColumn
            // 
            letterTypeDataGridViewTextBoxColumn.DataPropertyName = "Letter_Type";
            letterTypeDataGridViewTextBoxColumn.HeaderText = "Letter Type";
            letterTypeDataGridViewTextBoxColumn.Name = "letterTypeDataGridViewTextBoxColumn";
            letterTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // senderDataGridViewTextBoxColumn
            // 
            senderDataGridViewTextBoxColumn.DataPropertyName = "Sender";
            senderDataGridViewTextBoxColumn.HeaderText = "Sender";
            senderDataGridViewTextBoxColumn.Name = "senderDataGridViewTextBoxColumn";
            senderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recipientDataGridViewTextBoxColumn
            // 
            recipientDataGridViewTextBoxColumn.DataPropertyName = "Recipient";
            recipientDataGridViewTextBoxColumn.HeaderText = "Recipient";
            recipientDataGridViewTextBoxColumn.Name = "recipientDataGridViewTextBoxColumn";
            recipientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receiveMethodDataGridViewTextBoxColumn
            // 
            receiveMethodDataGridViewTextBoxColumn.DataPropertyName = "Receive_Method";
            receiveMethodDataGridViewTextBoxColumn.HeaderText = "Receive Method";
            receiveMethodDataGridViewTextBoxColumn.Name = "receiveMethodDataGridViewTextBoxColumn";
            receiveMethodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupNameDataGridViewTextBoxColumn
            // 
            groupNameDataGridViewTextBoxColumn.DataPropertyName = "Group_Name";
            groupNameDataGridViewTextBoxColumn.HeaderText = "Group Name";
            groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
            groupNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
            priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            priorityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pageCountDataGridViewTextBoxColumn
            // 
            pageCountDataGridViewTextBoxColumn.DataPropertyName = "Page_Count";
            pageCountDataGridViewTextBoxColumn.HeaderText = "Page Count";
            pageCountDataGridViewTextBoxColumn.Name = "pageCountDataGridViewTextBoxColumn";
            pageCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // responseDeadlineDataGridViewTextBoxColumn
            // 
            responseDeadlineDataGridViewTextBoxColumn.DataPropertyName = "Response_Deadline";
            responseDeadlineDataGridViewTextBoxColumn.HeaderText = "Response Deadline";
            responseDeadlineDataGridViewTextBoxColumn.Name = "responseDeadlineDataGridViewTextBoxColumn";
            responseDeadlineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // relatedtoDocDataGridViewTextBoxColumn
            // 
            relatedtoDocDataGridViewTextBoxColumn.DataPropertyName = "Related_to_Doc";
            relatedtoDocDataGridViewTextBoxColumn.HeaderText = "Related to Doc";
            relatedtoDocDataGridViewTextBoxColumn.Name = "relatedtoDocDataGridViewTextBoxColumn";
            relatedtoDocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // docSummaryDataGridViewTextBoxColumn
            // 
            docSummaryDataGridViewTextBoxColumn.DataPropertyName = "Doc_Summary";
            docSummaryDataGridViewTextBoxColumn.HeaderText = "Doc Summary";
            docSummaryDataGridViewTextBoxColumn.Name = "docSummaryDataGridViewTextBoxColumn";
            docSummaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.DataPropertyName = "User_Name";
            userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            userIDDataGridViewTextBoxColumn.DataPropertyName = "User_ID";
            userIDDataGridViewTextBoxColumn.HeaderText = "User ID";
            userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // systemDateDataGridViewTextBoxColumn
            // 
            systemDateDataGridViewTextBoxColumn.DataPropertyName = "System_Date";
            systemDateDataGridViewTextBoxColumn.HeaderText = "System Date";
            systemDateDataGridViewTextBoxColumn.Name = "systemDateDataGridViewTextBoxColumn";
            systemDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // systemTimeDataGridViewTextBoxColumn
            // 
            systemTimeDataGridViewTextBoxColumn.DataPropertyName = "System_Time";
            systemTimeDataGridViewTextBoxColumn.HeaderText = "System Time";
            systemTimeDataGridViewTextBoxColumn.Name = "systemTimeDataGridViewTextBoxColumn";
            systemTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Incoming_Letters_bindingSource
            // 
            Incoming_Letters_bindingSource.DataMember = "Incoming_Letters";
            Incoming_Letters_bindingSource.DataSource = letters1;
            // 
            // letters1
            // 
            letters1.DataSetName = "Letters";
            letters1.Namespace = "http://tempuri.org/Letters.xsd";
            letters1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incoming_LettersTableAdapter1
            // 
            incoming_LettersTableAdapter1.ClearBeforeFill = true;
            // 
            // Print_Button
            // 
            Print_Button.Alignment = ToolStripItemAlignment.Right;
            Print_Button.BackgroundImage = Properties.Resources.butt_background;
            Print_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Print_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Print_Button.Image = Properties.Resources.butt_print_32;
            Print_Button.ImageScaling = ToolStripItemImageScaling.None;
            Print_Button.ImageTransparentColor = Color.Magenta;
            Print_Button.Name = "Print_Button";
            Print_Button.Size = new Size(54, 51);
            Print_Button.Text = "Print F4";
            Print_Button.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // AddEditDoc_Button
            // 
            AddEditDoc_Button.BackgroundImage = Properties.Resources.butt_background;
            AddEditDoc_Button.BackgroundImageLayout = ImageLayout.Stretch;
            AddEditDoc_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            AddEditDoc_Button.Image = Properties.Resources.top_input_butt;
            AddEditDoc_Button.ImageScaling = ToolStripItemImageScaling.None;
            AddEditDoc_Button.ImageTransparentColor = Color.Magenta;
            AddEditDoc_Button.Name = "AddEditDoc_Button";
            AddEditDoc_Button.Size = new Size(140, 51);
            AddEditDoc_Button.Text = "Add | Edit document F2";
            AddEditDoc_Button.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // Search_Button
            // 
            Search_Button.Alignment = ToolStripItemAlignment.Right;
            Search_Button.BackgroundImage = Properties.Resources.butt_background;
            Search_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Search_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Search_Button.Image = Properties.Resources.butt_search2_32;
            Search_Button.ImageScaling = ToolStripItemImageScaling.None;
            Search_Button.ImageTransparentColor = Color.Magenta;
            Search_Button.Name = "Search_Button";
            Search_Button.Size = new Size(65, 51);
            Search_Button.Text = "Search F3";
            Search_Button.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 54);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 54);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 54);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 54);
            // 
            // Incoming_Letters_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1026, 596);
            Controls.Add(dataGridView1);
            Controls.Add(Bottom_toolStrip);
            Controls.Add(Top_toolStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Incoming_Letters_Form";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Incoming Letters List";
            Load += Incoming_Letters_Form_Load;
            Top_toolStrip.ResumeLayout(false);
            Top_toolStrip.PerformLayout();
            Bottom_toolStrip.ResumeLayout(false);
            Bottom_toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Incoming_Letters_bindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)letters1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip Top_toolStrip;
        private ToolStrip Bottom_toolStrip;
        private DataGridView dataGridView1;
        private DataSet.Letters letters1;
        private BindingSource Incoming_Letters_bindingSource;
        private DataSet.LettersTableAdapters.Incoming_LettersTableAdapter incoming_LettersTableAdapter1;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn letterNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn letterTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateReceivedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn letterTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn senderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn recipientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn receiveMethodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pageCountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn responseDeadlineDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn relatedtoDocDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn docSummaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn systemDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn systemTimeDataGridViewTextBoxColumn;
        private ToolStripButton Last_Button;
        private ToolStripButton First_Button;
        private ToolStripButton Previous_Button;
        private ToolStripButton Next_Button;
        private ToolStripTextBox SelectedRowPosition_TextBox;
        private ToolStripTextBox RecordsTotalNumber_TextBox;
        private ToolStripButton Print_Button;
        private ToolStripButton AddEditDoc_Button;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton Search_Button;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
    }
}