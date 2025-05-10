namespace CurseWork
{
    partial class fEndOfSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEndOfSetup));
            buttonClose = new Button();
            labelTitle = new Label();
            btnStart = new Button();
            dgTableEndSetInfo = new DataGridView();
            labelNameTitle = new Label();
            btnRandom = new Button();
            toolStrip = new ToolStrip();
            ts_btnAdd = new ToolStripButton();
            ts_btnDelete = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dgTableEndSetInfo).BeginInit();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.BackgroundImage = (Image)resources.GetObject("buttonClose.BackgroundImage");
            buttonClose.BackgroundImageLayout = ImageLayout.Stretch;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Location = new Point(1123, 15);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(40, 40);
            buttonClose.TabIndex = 0;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Orange Kid", 25F);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(17, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(182, 50);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "END SET UP";
            // 
            // btnStart
            // 
            btnStart.BackgroundImage = (Image)resources.GetObject("btnStart.BackgroundImage");
            btnStart.BackgroundImageLayout = ImageLayout.Stretch;
            btnStart.Font = new Font("Orange Kid", 20F);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(751, 598);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(400, 50);
            btnStart.TabIndex = 5;
            btnStart.Text = "NEXT";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += buttonStart_Click;
            // 
            // dgTableEndSetInfo
            // 
            dgTableEndSetInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgTableEndSetInfo.BackgroundColor = Color.FromArgb(255, 192, 192);
            dgTableEndSetInfo.BorderStyle = BorderStyle.None;
            dgTableEndSetInfo.ColumnHeadersHeight = 29;
            dgTableEndSetInfo.Cursor = Cursors.Hand;
            dgTableEndSetInfo.EnableHeadersVisualStyles = false;
            dgTableEndSetInfo.GridColor = Color.FromArgb(3, 37, 140);
            dgTableEndSetInfo.Location = new Point(51, 280);
            dgTableEndSetInfo.Name = "dgTableEndSetInfo";
            dgTableEndSetInfo.RightToLeft = RightToLeft.No;
            dgTableEndSetInfo.RowHeadersWidth = 51;
            dgTableEndSetInfo.ScrollBars = ScrollBars.Vertical;
            dgTableEndSetInfo.Size = new Size(1100, 300);
            dgTableEndSetInfo.TabIndex = 6;
            // 
            // labelNameTitle
            // 
            labelNameTitle.AutoSize = true;
            labelNameTitle.BackColor = Color.Transparent;
            labelNameTitle.Font = new Font("Orange Kid", 60F);
            labelNameTitle.Location = new Point(51, 97);
            labelNameTitle.Name = "labelNameTitle";
            labelNameTitle.Size = new Size(393, 120);
            labelNameTitle.TabIndex = 7;
            labelNameTitle.Text = "WELCOME!";
            // 
            // btnRandom
            // 
            btnRandom.BackgroundImage = (Image)resources.GetObject("btnRandom.BackgroundImage");
            btnRandom.BackgroundImageLayout = ImageLayout.Stretch;
            btnRandom.Font = new Font("Orange Kid", 20F);
            btnRandom.ForeColor = Color.White;
            btnRandom.Location = new Point(51, 598);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(400, 50);
            btnRandom.TabIndex = 8;
            btnRandom.Text = "RANDOM";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;
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
            toolStrip.Items.AddRange(new ToolStripItem[] { ts_btnAdd, ts_btnDelete });
            toolStrip.Location = new Point(51, 215);
            toolStrip.Name = "toolStrip";
            toolStrip.Padding = new Padding(40, 0, 40, 0);
            toolStrip.Size = new Size(1100, 62);
            toolStrip.TabIndex = 13;
            toolStrip.Text = "toolStrip";
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
            // fEndOfSetup
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1200, 700);
            ControlBox = false;
            Controls.Add(toolStrip);
            Controls.Add(btnRandom);
            Controls.Add(labelNameTitle);
            Controls.Add(dgTableEndSetInfo);
            Controls.Add(btnStart);
            Controls.Add(labelTitle);
            Controls.Add(buttonClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1200, 700);
            Name = "fEndOfSetup";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += fEndOfSetup_Load;
            ((System.ComponentModel.ISupportInitialize)dgTableEndSetInfo).EndInit();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose;
        private Label labelTitle;
        private Button btnStart;
        private DataGridView dgTableEndSetInfo;
        private Label labelNameTitle;
        private Button btnRandom;
        private ToolStrip toolStrip;
        private ToolStripButton ts_btnAdd;
        private ToolStripButton ts_btnDelete;
    }
}