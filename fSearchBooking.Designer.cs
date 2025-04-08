namespace CurseWork
{
    partial class fSearchBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSearchBooking));
            btnClose = new Button();
            btnSearchBooking = new Button();
            labelRoomNumber = new Label();
            tbSurname = new TextBox();
            labelSurname = new Label();
            labelTitle = new Label();
            labelCheckInDate = new Label();
            title = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(527, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 10;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSearchBooking
            // 
            btnSearchBooking.BackgroundImage = (Image)resources.GetObject("btnSearchBooking.BackgroundImage");
            btnSearchBooking.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearchBooking.FlatStyle = FlatStyle.Flat;
            btnSearchBooking.Font = new Font("Orange Kid", 20F);
            btnSearchBooking.ForeColor = SystemColors.ButtonHighlight;
            btnSearchBooking.Location = new Point(86, 338);
            btnSearchBooking.Name = "btnSearchBooking";
            btnSearchBooking.Size = new Size(400, 50);
            btnSearchBooking.TabIndex = 16;
            btnSearchBooking.Text = "ADD BOOKING";
            btnSearchBooking.UseVisualStyleBackColor = true;
            btnSearchBooking.Click += btnSearchBooking_Click;
            // 
            // labelRoomNumber
            // 
            labelRoomNumber.AutoSize = true;
            labelRoomNumber.BackColor = Color.Transparent;
            labelRoomNumber.Font = new Font("Orange Kid", 20F);
            labelRoomNumber.ForeColor = Color.FromArgb(3, 37, 140);
            labelRoomNumber.Location = new Point(86, 404);
            labelRoomNumber.Name = "labelRoomNumber";
            labelRoomNumber.Size = new Size(173, 41);
            labelRoomNumber.TabIndex = 20;
            labelRoomNumber.Text = "Room number:";
            labelRoomNumber.Visible = false;
            // 
            // tbSurname
            // 
            tbSurname.BackColor = Color.FromArgb(20, 60, 178);
            tbSurname.Font = new Font("Segoe UI", 15F);
            tbSurname.ForeColor = SystemColors.Window;
            tbSurname.Location = new Point(87, 280);
            tbSurname.Margin = new Padding(3, 2, 3, 2);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(400, 41);
            tbSurname.TabIndex = 19;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.BackColor = Color.Transparent;
            labelSurname.Font = new Font("Orange Kid", 20F);
            labelSurname.ForeColor = Color.FromArgb(3, 37, 140);
            labelSurname.Location = new Point(86, 241);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(123, 41);
            labelSurname.TabIndex = 18;
            labelSurname.Text = "Surname:";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Orange Kid", 60F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(3, 37, 140);
            labelTitle.Location = new Point(132, 121);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(338, 120);
            labelTitle.TabIndex = 17;
            labelTitle.Text = "SEARCH";
            // 
            // labelCheckInDate
            // 
            labelCheckInDate.AutoSize = true;
            labelCheckInDate.BackColor = Color.Transparent;
            labelCheckInDate.Font = new Font("Orange Kid", 20F);
            labelCheckInDate.ForeColor = Color.FromArgb(3, 37, 140);
            labelCheckInDate.Location = new Point(86, 455);
            labelCheckInDate.Name = "labelCheckInDate";
            labelCheckInDate.Size = new Size(173, 41);
            labelCheckInDate.TabIndex = 21;
            labelCheckInDate.Text = "Check in date:";
            labelCheckInDate.Visible = false;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Orange Kid", 25F);
            title.ForeColor = Color.White;
            title.Location = new Point(10, 4);
            title.Name = "title";
            title.Size = new Size(264, 50);
            title.TabIndex = 22;
            title.Text = "SEARCH BOOKING";
            // 
            // fSearchBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(582, 582);
            ControlBox = false;
            Controls.Add(title);
            Controls.Add(labelCheckInDate);
            Controls.Add(labelRoomNumber);
            Controls.Add(tbSurname);
            Controls.Add(labelSurname);
            Controls.Add(labelTitle);
            Controls.Add(btnSearchBooking);
            Controls.Add(btnClose);
            DoubleBuffered = true;
            MaximumSize = new Size(600, 600);
            MinimumSize = new Size(600, 600);
            Name = "fSearchBooking";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnSearchBooking;
        private Label labelRoomNumber;
        private TextBox tbSurname;
        private Label labelSurname;
        private Label labelTitle;
        private Label labelCheckInDate;
        private Label title;
    }
}