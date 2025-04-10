namespace CurseWork
{
    partial class fAdministration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdministration));
            btnSearchBooking = new Button();
            lbCurrentFreeRooms = new Label();
            pictureBox1 = new PictureBox();
            labelTitle = new Label();
            title = new Label();
            btnClose = new Button();
            lbCurrentOccupiedRooms = new Label();
            btnHotelInfo = new Button();
            btnAddBooking = new Button();
            btnChangeBooking = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSearchBooking
            // 
            btnSearchBooking.BackgroundImage = (Image)resources.GetObject("btnSearchBooking.BackgroundImage");
            btnSearchBooking.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearchBooking.FlatStyle = FlatStyle.Flat;
            btnSearchBooking.Font = new Font("Orange Kid", 15F);
            btnSearchBooking.ForeColor = SystemColors.ButtonHighlight;
            btnSearchBooking.Location = new Point(445, 729);
            btnSearchBooking.Name = "btnSearchBooking";
            btnSearchBooking.Size = new Size(300, 40);
            btnSearchBooking.TabIndex = 3;
            btnSearchBooking.Text = "SEARCH BOOKING";
            btnSearchBooking.UseVisualStyleBackColor = true;
            btnSearchBooking.Click += btnSearchBooking_Click;
            // 
            // lbCurrentFreeRooms
            // 
            lbCurrentFreeRooms.AutoSize = true;
            lbCurrentFreeRooms.BackColor = Color.Transparent;
            lbCurrentFreeRooms.Font = new Font("Orange Kid", 25F);
            lbCurrentFreeRooms.Location = new Point(81, 224);
            lbCurrentFreeRooms.Name = "lbCurrentFreeRooms";
            lbCurrentFreeRooms.Size = new Size(289, 50);
            lbCurrentFreeRooms.TabIndex = 6;
            lbCurrentFreeRooms.Text = "Current free rooms:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(667, 180);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(409, 426);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Orange Kid", 60F);
            labelTitle.Location = new Point(40, 95);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(393, 120);
            labelTitle.TabIndex = 11;
            labelTitle.Text = "WELCOME!";
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Orange Kid", 25F);
            title.ForeColor = Color.White;
            title.Location = new Point(15, 13);
            title.Name = "title";
            title.Size = new Size(257, 50);
            title.TabIndex = 10;
            title.Text = "ADMINISTRATION";
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(1118, 19);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 5;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbCurrentOccupiedRooms
            // 
            lbCurrentOccupiedRooms.AutoSize = true;
            lbCurrentOccupiedRooms.BackColor = Color.Transparent;
            lbCurrentOccupiedRooms.Font = new Font("Orange Kid", 25F);
            lbCurrentOccupiedRooms.Location = new Point(81, 274);
            lbCurrentOccupiedRooms.Name = "lbCurrentOccupiedRooms";
            lbCurrentOccupiedRooms.Size = new Size(352, 50);
            lbCurrentOccupiedRooms.TabIndex = 12;
            lbCurrentOccupiedRooms.Text = "Current occupied rooms:";
            // 
            // btnHotelInfo
            // 
            btnHotelInfo.BackgroundImage = (Image)resources.GetObject("btnHotelInfo.BackgroundImage");
            btnHotelInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnHotelInfo.FlatStyle = FlatStyle.Flat;
            btnHotelInfo.Font = new Font("Orange Kid", 15F, FontStyle.Bold);
            btnHotelInfo.ForeColor = SystemColors.ButtonHighlight;
            btnHotelInfo.Location = new Point(822, 729);
            btnHotelInfo.Name = "btnHotelInfo";
            btnHotelInfo.Size = new Size(300, 40);
            btnHotelInfo.TabIndex = 4;
            btnHotelInfo.Text = "HOTEL INFORMATION";
            btnHotelInfo.UseVisualStyleBackColor = true;
            btnHotelInfo.Click += btnHotelInfo_Click;
            // 
            // btnAddBooking
            // 
            btnAddBooking.BackgroundImage = (Image)resources.GetObject("btnAddBooking.BackgroundImage");
            btnAddBooking.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddBooking.FlatStyle = FlatStyle.Flat;
            btnAddBooking.Font = new Font("Orange Kid", 20F);
            btnAddBooking.ForeColor = SystemColors.ButtonHighlight;
            btnAddBooking.Location = new Point(64, 346);
            btnAddBooking.Name = "btnAddBooking";
            btnAddBooking.Size = new Size(400, 50);
            btnAddBooking.TabIndex = 1;
            btnAddBooking.Text = "ADD BOOKING";
            btnAddBooking.UseVisualStyleBackColor = true;
            btnAddBooking.Click += btnAddBooking_Click;
            // 
            // btnChangeBooking
            // 
            btnChangeBooking.BackgroundImage = (Image)resources.GetObject("btnChangeBooking.BackgroundImage");
            btnChangeBooking.BackgroundImageLayout = ImageLayout.Stretch;
            btnChangeBooking.FlatStyle = FlatStyle.Flat;
            btnChangeBooking.Font = new Font("Orange Kid", 15F, FontStyle.Bold);
            btnChangeBooking.ForeColor = SystemColors.ButtonHighlight;
            btnChangeBooking.Location = new Point(64, 729);
            btnChangeBooking.Name = "btnChangeBooking";
            btnChangeBooking.Size = new Size(300, 40);
            btnChangeBooking.TabIndex = 2;
            btnChangeBooking.Text = "CHANGE BOOKING";
            btnChangeBooking.UseVisualStyleBackColor = true;
            btnChangeBooking.Click += btnChangeBooking_Click;
            // 
            // fAdministration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 782);
            ControlBox = false;
            Controls.Add(btnChangeBooking);
            Controls.Add(btnAddBooking);
            Controls.Add(btnHotelInfo);
            Controls.Add(lbCurrentOccupiedRooms);
            Controls.Add(labelTitle);
            Controls.Add(title);
            Controls.Add(btnClose);
            Controls.Add(pictureBox1);
            Controls.Add(lbCurrentFreeRooms);
            Controls.Add(btnSearchBooking);
            DoubleBuffered = true;
            MaximumSize = new Size(1200, 800);
            MinimumSize = new Size(1200, 800);
            Name = "fAdministration";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSearchBooking;
        private Label lbCurrentFreeRooms;
        private PictureBox pictureBox1;
        private Label labelTitle;
        private Label title;
        private Button btnClose;
        private Label lbCurrentOccupiedRooms;
        private Button btnHotelInfo;
        private Button btnAddBooking;
        private Button btnChangeBooking;
    }
}