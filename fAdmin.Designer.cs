namespace CurseWork
{
    partial class fAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdmin));
            btnChangeBooking = new Button();
            btnHotelInfo = new Button();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            buttonClose = new Button();
            panel1 = new Panel();
            labelTitle = new Label();
            btnSearchBooking = new Button();
            btnAddBooking = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnChangeBooking
            // 
            btnChangeBooking.BackgroundImage = (Image)resources.GetObject("btnChangeBooking.BackgroundImage");
            btnChangeBooking.BackgroundImageLayout = ImageLayout.Stretch;
            btnChangeBooking.FlatStyle = FlatStyle.Flat;
            btnChangeBooking.Font = new Font("Orange Kid", 15F);
            btnChangeBooking.ForeColor = SystemColors.ButtonHighlight;
            btnChangeBooking.Location = new Point(55, 198);
            btnChangeBooking.Name = "btnChangeBooking";
            btnChangeBooking.Size = new Size(300, 40);
            btnChangeBooking.TabIndex = 14;
            btnChangeBooking.Text = "CLIENT INFORMATION";
            btnChangeBooking.UseVisualStyleBackColor = true;
            btnChangeBooking.Click += btnChangeBooking_Click;
            // 
            // btnHotelInfo
            // 
            btnHotelInfo.BackgroundImage = (Image)resources.GetObject("btnHotelInfo.BackgroundImage");
            btnHotelInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnHotelInfo.FlatStyle = FlatStyle.Flat;
            btnHotelInfo.Font = new Font("Orange Kid", 15F);
            btnHotelInfo.ForeColor = SystemColors.ButtonHighlight;
            btnHotelInfo.Location = new Point(55, 311);
            btnHotelInfo.Name = "btnHotelInfo";
            btnHotelInfo.Size = new Size(300, 40);
            btnHotelInfo.TabIndex = 16;
            btnHotelInfo.Text = "HOTEL INFORMATION";
            btnHotelInfo.UseVisualStyleBackColor = true;
            btnHotelInfo.Click += btnHotelInfo_Click;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(1133, 21);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 17;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(17, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(969, 699);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // buttonClose
            // 
            buttonClose.BackgroundImage = (Image)resources.GetObject("buttonClose.BackgroundImage");
            buttonClose.BackgroundImageLayout = ImageLayout.Stretch;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Jersey 10", 1F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonClose.ForeColor = Color.FromArgb(3, 37, 140);
            buttonClose.Location = new Point(931, 19);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(40, 40);
            buttonClose.TabIndex = 24;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 219, 226);
            panel1.Controls.Add(labelTitle);
            panel1.Controls.Add(btnSearchBooking);
            panel1.Controls.Add(btnAddBooking);
            panel1.Controls.Add(btnHotelInfo);
            panel1.Controls.Add(btnChangeBooking);
            panel1.Location = new Point(305, 243);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 400);
            panel1.TabIndex = 25;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Orange Kid", 35F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(3, 37, 140);
            labelTitle.Location = new Point(37, 47);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(382, 71);
            labelTitle.TabIndex = 24;
            labelTitle.Text = "ADMINISTRATION";
            // 
            // btnSearchBooking
            // 
            btnSearchBooking.BackgroundImage = (Image)resources.GetObject("btnSearchBooking.BackgroundImage");
            btnSearchBooking.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearchBooking.FlatStyle = FlatStyle.Flat;
            btnSearchBooking.Font = new Font("Orange Kid", 15F);
            btnSearchBooking.ForeColor = SystemColors.ButtonHighlight;
            btnSearchBooking.Location = new Point(55, 256);
            btnSearchBooking.Name = "btnSearchBooking";
            btnSearchBooking.Size = new Size(300, 40);
            btnSearchBooking.TabIndex = 23;
            btnSearchBooking.Text = "SEARCH BOOKING";
            btnSearchBooking.UseVisualStyleBackColor = true;
            btnSearchBooking.Click += btnSearchBooking_Click;
            // 
            // btnAddBooking
            // 
            btnAddBooking.BackgroundImage = (Image)resources.GetObject("btnAddBooking.BackgroundImage");
            btnAddBooking.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddBooking.FlatStyle = FlatStyle.Flat;
            btnAddBooking.Font = new Font("Orange Kid", 15F);
            btnAddBooking.ForeColor = SystemColors.ButtonHighlight;
            btnAddBooking.Location = new Point(55, 142);
            btnAddBooking.Name = "btnAddBooking";
            btnAddBooking.Size = new Size(300, 40);
            btnAddBooking.TabIndex = 22;
            btnAddBooking.Text = "ADD BOOKING";
            btnAddBooking.UseVisualStyleBackColor = true;
            btnAddBooking.Click += btnAddBooking_Click;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 800);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(buttonClose);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1000, 800);
            MinimumSize = new Size(1000, 800);
            Name = "fAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnChangeBooking;
        private Button btnHotelInfo;
        private Button btnClose;
        private PictureBox pictureBox1;
        private Button buttonClose;
        private Panel panel1;
        private Button btnAddBooking;
        private Button btnSearchBooking;
        private Label labelTitle;
    }
}