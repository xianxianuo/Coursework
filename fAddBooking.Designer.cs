namespace CurseWork
{
    partial class fAddBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddBooking));
            label1 = new Label();
            tbPhoneNum = new TextBox();
            buttonClose = new Button();
            labelOfRooms = new Label();
            buttonStart = new Button();
            tbSurname = new TextBox();
            labelName = new Label();
            label2 = new Label();
            tbName = new TextBox();
            label3 = new Label();
            cbRoomNumber = new ComboBox();
            dtpDateSecond = new DateTimePicker();
            dtpDateFirst = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            labelTitle = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Orange Kid", 20F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(174, 41);
            label1.TabIndex = 19;
            label1.Text = "ADD BOOKING";
            // 
            // tbPhoneNum
            // 
            tbPhoneNum.BackColor = Color.FromArgb(20, 60, 178);
            tbPhoneNum.Font = new Font("Orange Kid", 15F);
            tbPhoneNum.ForeColor = Color.White;
            tbPhoneNum.Location = new Point(122, 520);
            tbPhoneNum.Margin = new Padding(3, 2, 3, 2);
            tbPhoneNum.Name = "tbPhoneNum";
            tbPhoneNum.Size = new Size(259, 37);
            tbPhoneNum.TabIndex = 5;
            // 
            // buttonClose
            // 
            buttonClose.BackgroundImage = (Image)resources.GetObject("buttonClose.BackgroundImage");
            buttonClose.BackgroundImageLayout = ImageLayout.Stretch;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Jersey 10", 1F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonClose.ForeColor = Color.FromArgb(3, 37, 140);
            buttonClose.Location = new Point(723, 14);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(40, 40);
            buttonClose.TabIndex = 27;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelOfRooms
            // 
            labelOfRooms.AutoSize = true;
            labelOfRooms.BackColor = Color.Transparent;
            labelOfRooms.Font = new Font("Orange Kid", 20F);
            labelOfRooms.ForeColor = Color.FromArgb(3, 37, 140);
            labelOfRooms.Location = new Point(121, 471);
            labelOfRooms.Name = "labelOfRooms";
            labelOfRooms.Size = new Size(179, 41);
            labelOfRooms.TabIndex = 26;
            labelOfRooms.Text = "Phone number:";
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.FromArgb(80, 75, 56);
            buttonStart.BackgroundImage = (Image)resources.GetObject("buttonStart.BackgroundImage");
            buttonStart.BackgroundImageLayout = ImageLayout.Stretch;
            buttonStart.FlatStyle = FlatStyle.Flat;
            buttonStart.Font = new Font("Orange Kid", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonStart.ForeColor = Color.WhiteSmoke;
            buttonStart.Location = new Point(201, 586);
            buttonStart.Margin = new Padding(3, 2, 3, 2);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(400, 50);
            buttonStart.TabIndex = 8;
            buttonStart.Text = "SAVE";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // tbSurname
            // 
            tbSurname.BackColor = Color.FromArgb(20, 60, 178);
            tbSurname.Font = new Font("Orange Kid", 15F);
            tbSurname.ForeColor = SystemColors.Window;
            tbSurname.Location = new Point(121, 334);
            tbSurname.Margin = new Padding(3, 2, 3, 2);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(545, 37);
            tbSurname.TabIndex = 2;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Transparent;
            labelName.Font = new Font("Orange Kid", 20F);
            labelName.ForeColor = Color.FromArgb(3, 37, 140);
            labelName.Location = new Point(120, 299);
            labelName.Name = "labelName";
            labelName.Size = new Size(123, 41);
            labelName.TabIndex = 21;
            labelName.Text = "Surname:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Orange Kid", 20F);
            label2.ForeColor = Color.FromArgb(3, 37, 140);
            label2.Location = new Point(120, 373);
            label2.Name = "label2";
            label2.Size = new Size(173, 41);
            label2.TabIndex = 29;
            label2.Text = "Room number:";
            // 
            // tbName
            // 
            tbName.BackColor = Color.FromArgb(20, 60, 178);
            tbName.Font = new Font("Orange Kid", 15F);
            tbName.ForeColor = SystemColors.Window;
            tbName.Location = new Point(121, 260);
            tbName.Margin = new Padding(3, 2, 3, 2);
            tbName.Name = "tbName";
            tbName.Size = new Size(545, 37);
            tbName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Orange Kid", 20F);
            label3.ForeColor = Color.FromArgb(3, 37, 140);
            label3.Location = new Point(120, 222);
            label3.Name = "label3";
            label3.Size = new Size(82, 41);
            label3.TabIndex = 33;
            label3.Text = "Name";
            // 
            // cbRoomNumber
            // 
            cbRoomNumber.BackColor = Color.FromArgb(20, 60, 178);
            cbRoomNumber.FlatStyle = FlatStyle.Popup;
            cbRoomNumber.Font = new Font("Orange Kid", 15F);
            cbRoomNumber.ForeColor = Color.White;
            cbRoomNumber.FormattingEnabled = true;
            cbRoomNumber.Location = new Point(122, 425);
            cbRoomNumber.Name = "cbRoomNumber";
            cbRoomNumber.Size = new Size(260, 38);
            cbRoomNumber.TabIndex = 4;
            // 
            // dtpDateSecond
            // 
            dtpDateSecond.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateSecond.CalendarForeColor = SystemColors.ControlLightLight;
            dtpDateSecond.CalendarMonthBackground = Color.FromArgb(3, 37, 140);
            dtpDateSecond.CalendarTitleBackColor = Color.FromArgb(3, 37, 140);
            dtpDateSecond.CalendarTitleForeColor = SystemColors.ControlLightLight;
            dtpDateSecond.CalendarTrailingForeColor = SystemColors.ControlLightLight;
            dtpDateSecond.Font = new Font("Orange Kid", 15F);
            dtpDateSecond.Location = new Point(405, 520);
            dtpDateSecond.Name = "dtpDateSecond";
            dtpDateSecond.Size = new Size(261, 37);
            dtpDateSecond.TabIndex = 7;
            // 
            // dtpDateFirst
            // 
            dtpDateFirst.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateFirst.CalendarForeColor = SystemColors.ControlLightLight;
            dtpDateFirst.CalendarMonthBackground = Color.FromArgb(3, 37, 140);
            dtpDateFirst.CalendarTitleBackColor = Color.FromArgb(3, 37, 140);
            dtpDateFirst.CalendarTitleForeColor = SystemColors.ControlLightLight;
            dtpDateFirst.CalendarTrailingForeColor = SystemColors.ControlLightLight;
            dtpDateFirst.Font = new Font("Orange Kid", 15F);
            dtpDateFirst.Location = new Point(405, 423);
            dtpDateFirst.MaxDate = new DateTime(2100, 1, 1, 0, 0, 0, 0);
            dtpDateFirst.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dtpDateFirst.Name = "dtpDateFirst";
            dtpDateFirst.Size = new Size(261, 37);
            dtpDateFirst.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Orange Kid", 20F);
            label4.ForeColor = Color.FromArgb(3, 37, 140);
            label4.Location = new Point(405, 373);
            label4.Name = "label4";
            label4.Size = new Size(115, 41);
            label4.TabIndex = 39;
            label4.Text = "Check In:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Orange Kid", 20F);
            label5.ForeColor = Color.FromArgb(3, 37, 140);
            label5.Location = new Point(405, 471);
            label5.Name = "label5";
            label5.Size = new Size(136, 41);
            label5.TabIndex = 40;
            label5.Text = "Check Out:";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Orange Kid", 60F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(3, 37, 140);
            labelTitle.Location = new Point(134, 88);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(529, 120);
            labelTitle.TabIndex = 41;
            labelTitle.Text = "ADD BOOKING";
            // 
            // fAddBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 682);
            ControlBox = false;
            Controls.Add(labelTitle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpDateSecond);
            Controls.Add(dtpDateFirst);
            Controls.Add(cbRoomNumber);
            Controls.Add(tbName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPhoneNum);
            Controls.Add(buttonClose);
            Controls.Add(labelOfRooms);
            Controls.Add(buttonStart);
            Controls.Add(tbSurname);
            Controls.Add(labelName);
            DoubleBuffered = true;
            MaximumSize = new Size(800, 700);
            MinimumSize = new Size(800, 700);
            Name = "fAddBooking";
            StartPosition = FormStartPosition.CenterScreen;
            Load += fAddBooking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbPhoneNum;
        private Button buttonClose;
        private Label labelOfRooms;
        private Button buttonStart;
        private TextBox tbSurname;
        private Label labelName;
        private Label label2;
        private TextBox tbName;
        private Label label3;
        private ComboBox cbRoomNumber;
        private DateTimePicker dtpDateSecond;
        private DateTimePicker dtpDateFirst;
        private Label label4;
        private Label label5;
        private Label labelTitle;
    }
}