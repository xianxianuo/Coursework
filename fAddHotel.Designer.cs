namespace CurseWork
{
    partial class fAddHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddHotel));
            buttonStart = new Button();
            labelTitle = new Label();
            labelName = new Label();
            tbHotelName = new TextBox();
            labelAddress = new Label();
            tbAdress = new TextBox();
            labelOfRooms = new Label();
            buttonClose = new Button();
            tbNumberOfRooms = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.FromArgb(80, 75, 56);
            buttonStart.BackgroundImage = (Image)resources.GetObject("buttonStart.BackgroundImage");
            buttonStart.BackgroundImageLayout = ImageLayout.Stretch;
            buttonStart.FlatStyle = FlatStyle.Flat;
            buttonStart.Font = new Font("Orange Kid", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonStart.ForeColor = Color.WhiteSmoke;
            buttonStart.Location = new Point(191, 430);
            buttonStart.Margin = new Padding(3, 2, 3, 2);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(400, 50);
            buttonStart.TabIndex = 12;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Orange Kid", 60F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(3, 37, 140);
            labelTitle.Location = new Point(179, 69);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(441, 120);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "ADD HOTEL";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Transparent;
            labelName.Font = new Font("Orange Kid", 20F);
            labelName.ForeColor = Color.FromArgb(3, 37, 140);
            labelName.Location = new Point(190, 188);
            labelName.Name = "labelName";
            labelName.Size = new Size(87, 41);
            labelName.TabIndex = 1;
            labelName.Text = "Name:";
            // 
            // tbHotelName
            // 
            tbHotelName.BackColor = Color.FromArgb(20, 60, 178);
            tbHotelName.ForeColor = SystemColors.Window;
            tbHotelName.Location = new Point(191, 223);
            tbHotelName.Margin = new Padding(3, 2, 3, 2);
            tbHotelName.Name = "tbHotelName";
            tbHotelName.Size = new Size(400, 29);
            tbHotelName.TabIndex = 2;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.BackColor = Color.Transparent;
            labelAddress.Font = new Font("Orange Kid", 20F);
            labelAddress.ForeColor = Color.FromArgb(3, 37, 140);
            labelAddress.Location = new Point(190, 254);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(116, 41);
            labelAddress.TabIndex = 3;
            labelAddress.Text = "Address:";
            // 
            // tbAdress
            // 
            tbAdress.BackColor = Color.FromArgb(20, 60, 178);
            tbAdress.ForeColor = SystemColors.Window;
            tbAdress.Location = new Point(191, 292);
            tbAdress.Margin = new Padding(3, 2, 3, 2);
            tbAdress.Name = "tbAdress";
            tbAdress.Size = new Size(400, 29);
            tbAdress.TabIndex = 4;
            // 
            // labelOfRooms
            // 
            labelOfRooms.AutoSize = true;
            labelOfRooms.BackColor = Color.Transparent;
            labelOfRooms.Font = new Font("Orange Kid", 20F);
            labelOfRooms.ForeColor = Color.FromArgb(3, 37, 140);
            labelOfRooms.Location = new Point(190, 323);
            labelOfRooms.Name = "labelOfRooms";
            labelOfRooms.Size = new Size(212, 41);
            labelOfRooms.TabIndex = 13;
            labelOfRooms.Text = "Number of rooms:";
            // 
            // buttonClose
            // 
            buttonClose.BackgroundImage = (Image)resources.GetObject("buttonClose.BackgroundImage");
            buttonClose.BackgroundImageLayout = ImageLayout.Stretch;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Jersey 10", 1F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonClose.ForeColor = Color.FromArgb(3, 37, 140);
            buttonClose.Location = new Point(724, 9);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(40, 40);
            buttonClose.TabIndex = 16;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // tbNumberOfRooms
            // 
            tbNumberOfRooms.BackColor = Color.FromArgb(20, 60, 178);
            tbNumberOfRooms.ForeColor = SystemColors.Window;
            tbNumberOfRooms.Location = new Point(191, 361);
            tbNumberOfRooms.Margin = new Padding(3, 2, 3, 2);
            tbNumberOfRooms.Name = "tbNumberOfRooms";
            tbNumberOfRooms.Size = new Size(400, 29);
            tbNumberOfRooms.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Orange Kid", 20F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(145, 41);
            label1.TabIndex = 0;
            label1.Text = "ADD HOTEL";
            // 
            // fAddHotel
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 243, 217);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 582);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(tbNumberOfRooms);
            Controls.Add(buttonClose);
            Controls.Add(labelOfRooms);
            Controls.Add(buttonStart);
            Controls.Add(tbAdress);
            Controls.Add(labelAddress);
            Controls.Add(tbHotelName);
            Controls.Add(labelName);
            Controls.Add(labelTitle);
            DoubleBuffered = true;
            Font = new Font("Jersey 10", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "fAddHotel";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonStart;
        private Label labelTitle;
        private Label labelName;
        private TextBox tbHotelName;
        private Label labelAddress;
        private TextBox tbAdress;
        private Label labelNumberFloors;
        private Label labelOfRooms;
        private TextBox tbNumberOfFloor;
        private Button buttonClose;
        private TextBox tbNumberOfRooms;
        private Label label1;
    }
}