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
            labelTitle = new Label();
            buttonClose = new Button();
            dgBookingChange = new DataGridView();
            btnStart = new Button();
            title = new Label();
            ((System.ComponentModel.ISupportInitialize)dgBookingChange).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Orange Kid", 25F);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(41, 98);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(264, 50);
            labelTitle.TabIndex = 3;
            labelTitle.Text = "CHANGE BOOKING";
            // 
            // buttonClose
            // 
            buttonClose.BackgroundImage = (Image)resources.GetObject("buttonClose.BackgroundImage");
            buttonClose.BackgroundImageLayout = ImageLayout.Stretch;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Location = new Point(916, 14);
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
            dgBookingChange.Location = new Point(41, 98);
            dgBookingChange.Name = "dgBookingChange";
            dgBookingChange.RightToLeft = RightToLeft.No;
            dgBookingChange.RowHeadersWidth = 51;
            dgBookingChange.ScrollBars = ScrollBars.Vertical;
            dgBookingChange.Size = new Size(902, 493);
            dgBookingChange.TabIndex = 7;
            // 
            // btnStart
            // 
            btnStart.BackgroundImage = (Image)resources.GetObject("btnStart.BackgroundImage");
            btnStart.BackgroundImageLayout = ImageLayout.Stretch;
            btnStart.Font = new Font("Orange Kid", 15F);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(287, 634);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(400, 40);
            btnStart.TabIndex = 8;
            btnStart.Text = "SAVE";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
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
            // fChangeBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 682);
            ControlBox = false;
            Controls.Add(title);
            Controls.Add(btnStart);
            Controls.Add(dgBookingChange);
            Controls.Add(labelTitle);
            Controls.Add(buttonClose);
            DoubleBuffered = true;
            MaximumSize = new Size(1000, 700);
            MinimumSize = new Size(1000, 700);
            Name = "fChangeBooking";
            StartPosition = FormStartPosition.CenterScreen;
            Load += fChangeBooking_Load;
            ((System.ComponentModel.ISupportInitialize)dgBookingChange).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Button buttonClose;
        private DataGridView dgBookingChange;
        private Button btnStart;
        private Label title;
    }
}