namespace CurseWork
{
    partial class fChangeBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChangeBooking));
            buttonClose = new Button();
            dgBookingChange = new DataGridView();
            title = new Label();
            toolStrip = new ToolStrip();
            ts_cbSort = new ToolStripComboBox();
            ts_tbSearch = new ToolStripTextBox();
            toolStripButton2 = new ToolStripButton();
            ts_btnBack = new ToolStripButton();
            ts_btnDelete = new ToolStripButton();
            ts_btnAdd = new ToolStripButton();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgBookingChange).BeginInit();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.BackgroundImage = (Image)resources.GetObject("buttonClose.BackgroundImage");
            buttonClose.BackgroundImageLayout = ImageLayout.Stretch;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Location = new Point(1115, 20);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(40, 40);
            buttonClose.TabIndex = 2;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // dgBookingChange
            // 
            dgBookingChange.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgBookingChange.BackgroundColor = Color.FromArgb(255, 192, 192);
            dgBookingChange.BorderStyle = BorderStyle.None;
            dgBookingChange.ColumnHeadersHeight = 29;
            dgBookingChange.Cursor = Cursors.Hand;
            dgBookingChange.EnableHeadersVisualStyles = false;
            dgBookingChange.GridColor = Color.FromArgb(3, 37, 140);
            dgBookingChange.Location = new Point(57, 181);
            dgBookingChange.Name = "dgBookingChange";
            dgBookingChange.RightToLeft = RightToLeft.No;
            dgBookingChange.RowHeadersWidth = 51;
            dgBookingChange.ScrollBars = ScrollBars.Vertical;
            dgBookingChange.Size = new Size(1094, 512);
            dgBookingChange.TabIndex = 7;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Orange Kid", 25F);
            title.ForeColor = Color.White;
            title.Location = new Point(23, 10);
            title.Name = "title";
            title.Size = new Size(457, 50);
            title.TabIndex = 11;
            title.Text = "CHANGE BOOKING INFORMATION";
            // 
            // toolStrip
            // 
            toolStrip.AllowDrop = true;
            toolStrip.Anchor = AnchorStyles.None;
            toolStrip.AutoSize = false;
            toolStrip.BackColor = Color.FromArgb(13, 139, 217);
            toolStrip.Dock = DockStyle.None;
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.ImageScalingSize = new Size(40, 40);
            toolStrip.Items.AddRange(new ToolStripItem[] { ts_btnAdd, ts_btnDelete, ts_cbSort, ts_btnBack, toolStripButton2, ts_tbSearch });
            toolStrip.Location = new Point(57, 122);
            toolStrip.Name = "toolStrip";
            toolStrip.Padding = new Padding(40, 0, 40, 0);
            toolStrip.Size = new Size(1094, 62);
            toolStrip.TabIndex = 12;
            toolStrip.Text = "toolStrip";
            // 
            // ts_cbSort
            // 
            ts_cbSort.Font = new Font("Orange Kid", 15F);
            ts_cbSort.Margin = new Padding(20, 0, 0, 0);
            ts_cbSort.Name = "ts_cbSort";
            ts_cbSort.Size = new Size(200, 62);
            // 
            // ts_tbSearch
            // 
            ts_tbSearch.Alignment = ToolStripItemAlignment.Right;
            ts_tbSearch.Font = new Font("Orange Kid", 15F);
            ts_tbSearch.Margin = new Padding(0, 0, 20, 0);
            ts_tbSearch.MaxLength = 300;
            ts_tbSearch.Name = "ts_tbSearch";
            ts_tbSearch.Size = new Size(200, 62);
            // 
            // toolStripButton2
            // 
            toolStripButton2.Alignment = ToolStripItemAlignment.Right;
            toolStripButton2.AutoSize = false;
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Margin = new Padding(5, 0, 0, 0);
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(40, 40);
            toolStripButton2.Text = "ts_btnSearch";
            toolStripButton2.Click += ts_btnSearch_Click;
            // 
            // ts_btnBack
            // 
            ts_btnBack.Alignment = ToolStripItemAlignment.Right;
            ts_btnBack.AutoSize = false;
            ts_btnBack.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ts_btnBack.Image = (Image)resources.GetObject("ts_btnBack.Image");
            ts_btnBack.ImageTransparentColor = Color.Magenta;
            ts_btnBack.Margin = new Padding(0);
            ts_btnBack.Name = "ts_btnBack";
            ts_btnBack.Size = new Size(40, 40);
            ts_btnBack.Text = "ts_btnBack";
            ts_btnBack.Click += ts_btnBack_Click;
            // 
            // ts_btnDelete
            // 
            ts_btnDelete.AutoSize = false;
            ts_btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ts_btnDelete.Image = (Image)resources.GetObject("ts_btnDelete.Image");
            ts_btnDelete.ImageTransparentColor = Color.Magenta;
            ts_btnDelete.Margin = new Padding(0);
            ts_btnDelete.Name = "ts_btnDelete";
            ts_btnDelete.Size = new Size(40, 40);
            ts_btnDelete.Click += ts_btnDelete_Click;
            // 
            // ts_btnAdd
            // 
            ts_btnAdd.AutoSize = false;
            ts_btnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ts_btnAdd.Image = (Image)resources.GetObject("ts_btnAdd.Image");
            ts_btnAdd.ImageTransparentColor = Color.Magenta;
            ts_btnAdd.Margin = new Padding(0);
            ts_btnAdd.MergeIndex = 0;
            ts_btnAdd.Name = "ts_btnAdd";
            ts_btnAdd.Size = new Size(40, 40);
            ts_btnAdd.Click += ts_btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(80, 75, 56);
            btnSave.BackgroundImage = (Image)resources.GetObject("btnSave.BackgroundImage");
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Orange Kid", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSave.ForeColor = Color.WhiteSmoke;
            btnSave.Location = new Point(410, 744);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(400, 45);
            btnSave.TabIndex = 13;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // fChangeBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1200, 800);
            ControlBox = false;
            Controls.Add(btnSave);
            Controls.Add(toolStrip);
            Controls.Add(title);
            Controls.Add(dgBookingChange);
            Controls.Add(buttonClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1200, 800);
            MinimumSize = new Size(1200, 800);
            Name = "fChangeBooking";
            StartPosition = FormStartPosition.CenterScreen;
            Load += fChangeBooking_Load;
            ((System.ComponentModel.ISupportInitialize)dgBookingChange).EndInit();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonClose;
        private DataGridView dgBookingChange;
        private Label title;
        private ToolStrip toolStrip;
        private ToolStripButton ts_btnAdd;
        private ToolStripButton ts_btnDelete;
        private ToolStripComboBox ts_cbSort;
        private ToolStripTextBox ts_tbSearch;
        private ToolStripButton ts_btnBack;
        private Button btnSave;
        private ToolStripButton toolStripButton2;
    }
}