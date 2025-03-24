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
            btnBookingInfo = new Button();
            lbCurrentOccupiedRooms = new Label();
            pictureBox1 = new PictureBox();
            labelNameTitle = new Label();
            labelTitle = new Label();
            buttonClose = new Button();
            label1 = new Label();
            btnHotelInfo = new Button();
            btnAddBooking = new Button();
            btnRoomInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBookingInfo
            // 
            btnBookingInfo.BackgroundImage = (Image)resources.GetObject("btnBookingInfo.BackgroundImage");
            btnBookingInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnBookingInfo.FlatStyle = FlatStyle.Flat;
            btnBookingInfo.Font = new Font("Orange Kid", 15F, FontStyle.Bold);
            btnBookingInfo.ForeColor = SystemColors.ButtonHighlight;
            btnBookingInfo.Location = new Point(64, 730);
            btnBookingInfo.Name = "btnBookingInfo";
            btnBookingInfo.Size = new Size(300, 40);
            btnBookingInfo.TabIndex = 2;
            btnBookingInfo.Text = "BOOKING INFORMATION";
            btnBookingInfo.UseVisualStyleBackColor = true;
            btnBookingInfo.Click += btnBookingInfo_Click;
            // 
            // lbCurrentOccupiedRooms
            // 
            lbCurrentOccupiedRooms.AutoSize = true;
            lbCurrentOccupiedRooms.BackColor = Color.Transparent;
            lbCurrentOccupiedRooms.Font = new Font("Orange Kid", 25F);
            lbCurrentOccupiedRooms.Location = new Point(81, 224);
            lbCurrentOccupiedRooms.Name = "lbCurrentOccupiedRooms";
            lbCurrentOccupiedRooms.Size = new Size(352, 50);
            lbCurrentOccupiedRooms.TabIndex = 6;
            lbCurrentOccupiedRooms.Text = "Current occupied rooms:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(667, 180);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(409, 426);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // labelNameTitle
            // 
            labelNameTitle.AutoSize = true;
            labelNameTitle.BackColor = Color.Transparent;
            labelNameTitle.Font = new Font("Orange Kid", 60F);
            labelNameTitle.Location = new Point(40, 95);
            labelNameTitle.Name = "labelNameTitle";
            labelNameTitle.Size = new Size(393, 120);
            labelNameTitle.TabIndex = 11;
            labelNameTitle.Text = "WELCOME!";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Orange Kid", 25F);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(16, 13);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(182, 50);
            labelTitle.TabIndex = 10;
            labelTitle.Text = "END SET UP";
            // 
            // buttonClose
            // 
            buttonClose.BackgroundImage = (Image)resources.GetObject("buttonClose.BackgroundImage");
            buttonClose.BackgroundImageLayout = ImageLayout.Stretch;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Location = new Point(1118, 19);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(40, 40);
            buttonClose.TabIndex = 9;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Orange Kid", 25F);
            label1.Location = new Point(81, 274);
            label1.Name = "label1";
            label1.Size = new Size(352, 50);
            label1.TabIndex = 12;
            label1.Text = "Current occupied rooms:";
            // 
            // btnHotelInfo
            // 
            btnHotelInfo.BackgroundImage = (Image)resources.GetObject("btnHotelInfo.BackgroundImage");
            btnHotelInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnHotelInfo.FlatStyle = FlatStyle.Flat;
            btnHotelInfo.Font = new Font("Orange Kid", 15F, FontStyle.Bold);
            btnHotelInfo.ForeColor = SystemColors.ButtonHighlight;
            btnHotelInfo.Location = new Point(831, 730);
            btnHotelInfo.Name = "btnHotelInfo";
            btnHotelInfo.Size = new Size(300, 40);
            btnHotelInfo.TabIndex = 13;
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
            btnAddBooking.TabIndex = 15;
            btnAddBooking.Text = "ADD BOOKING";
            btnAddBooking.UseVisualStyleBackColor = true;
            btnAddBooking.Click += btnAddBooking_Click;
            // 
            // btnRoomInfo
            // 
            btnRoomInfo.BackgroundImage = (Image)resources.GetObject("btnRoomInfo.BackgroundImage");
            btnRoomInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnRoomInfo.FlatStyle = FlatStyle.Flat;
            btnRoomInfo.Font = new Font("Orange Kid", 15F, FontStyle.Bold);
            btnRoomInfo.ForeColor = SystemColors.ButtonHighlight;
            btnRoomInfo.Location = new Point(454, 730);
            btnRoomInfo.Name = "btnRoomInfo";
            btnRoomInfo.Size = new Size(300, 40);
            btnRoomInfo.TabIndex = 16;
            btnRoomInfo.Text = "ROOM INFORMATION";
            btnRoomInfo.UseVisualStyleBackColor = true;
            btnRoomInfo.Click += btnRoomInfo_Click;
            // 
            // fAdministration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 782);
            ControlBox = false;
            Controls.Add(btnRoomInfo);
            Controls.Add(btnAddBooking);
            Controls.Add(btnHotelInfo);
            Controls.Add(label1);
            Controls.Add(labelNameTitle);
            Controls.Add(labelTitle);
            Controls.Add(buttonClose);
            Controls.Add(pictureBox1);
            Controls.Add(lbCurrentOccupiedRooms);
            Controls.Add(btnBookingInfo);
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
        private Button btnBookingInfo;
        private Label lbCurrentOccupiedRooms;
        private PictureBox pictureBox1;
        private Label labelNameTitle;
        private Label labelTitle;
        private Button buttonClose;
        private Label label1;
        private Button btnHotelInfo;
        private Button btnAddBooking;
        private Button btnRoomInfo;
    }
}