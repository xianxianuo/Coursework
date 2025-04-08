namespace CurseWork
{
    partial class fHotelInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHotelInfo));
            labelTitle = new Label();
            labelOfRooms = new Label();
            labelAddress = new Label();
            labelName = new Label();
            labelOfClient = new Label();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Orange Kid", 60F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(3, 37, 140);
            labelTitle.Location = new Point(88, 63);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(443, 120);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "HOTEL INFO";
            // 
            // labelOfRooms
            // 
            labelOfRooms.AutoSize = true;
            labelOfRooms.BackColor = Color.Transparent;
            labelOfRooms.Font = new Font("Orange Kid", 20F);
            labelOfRooms.ForeColor = Color.FromArgb(3, 37, 140);
            labelOfRooms.Location = new Point(56, 336);
            labelOfRooms.Name = "labelOfRooms";
            labelOfRooms.Size = new Size(212, 41);
            labelOfRooms.TabIndex = 16;
            labelOfRooms.Text = "Number of rooms:";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.BackColor = Color.Transparent;
            labelAddress.Font = new Font("Orange Kid", 20F);
            labelAddress.ForeColor = Color.FromArgb(3, 37, 140);
            labelAddress.Location = new Point(56, 267);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(116, 41);
            labelAddress.TabIndex = 15;
            labelAddress.Text = "Address:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Transparent;
            labelName.Font = new Font("Orange Kid", 20F);
            labelName.ForeColor = Color.FromArgb(3, 37, 140);
            labelName.Location = new Point(56, 201);
            labelName.Name = "labelName";
            labelName.Size = new Size(87, 41);
            labelName.TabIndex = 14;
            labelName.Text = "Name:";
            // 
            // labelOfClient
            // 
            labelOfClient.AutoSize = true;
            labelOfClient.BackColor = Color.Transparent;
            labelOfClient.Font = new Font("Orange Kid", 20F);
            labelOfClient.ForeColor = Color.FromArgb(3, 37, 140);
            labelOfClient.Location = new Point(56, 403);
            labelOfClient.Name = "labelOfClient";
            labelOfClient.Size = new Size(216, 41);
            labelOfClient.TabIndex = 17;
            labelOfClient.Text = "Number of clients:";
            // 
            // buttonClose
            // 
            buttonClose.BackgroundImage = (Image)resources.GetObject("buttonClose.BackgroundImage");
            buttonClose.BackgroundImageLayout = ImageLayout.Stretch;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Location = new Point(547, 8);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(35, 35);
            buttonClose.TabIndex = 18;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // fHotelInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(600, 500);
            ControlBox = false;
            Controls.Add(buttonClose);
            Controls.Add(labelOfClient);
            Controls.Add(labelOfRooms);
            Controls.Add(labelAddress);
            Controls.Add(labelName);
            Controls.Add(labelTitle);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(600, 500);
            MinimumSize = new Size(600, 500);
            Name = "fHotelInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Load += fHotelInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTitle;
        private Label labelOfRooms;
        private Label labelAddress;
        private Label labelName;
        private Label labelOfClient;
        private Button buttonClose;
    }
}