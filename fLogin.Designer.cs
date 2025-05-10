namespace CurseWork
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            label1 = new Label();
            buttonClose = new Button();
            buttonStart = new Button();
            tbPassword = new TextBox();
            tbLogin = new TextBox();
            btnShowPassword = new Button();
            labelTitle = new Label();
            labelAddress = new Label();
            labelName = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Orange Kid", 20F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(89, 41);
            label1.TabIndex = 0;
            label1.Text = "LOG IN";
            // 
            // buttonClose
            // 
            buttonClose.BackgroundImage = (Image)resources.GetObject("buttonClose.BackgroundImage");
            buttonClose.BackgroundImageLayout = ImageLayout.Stretch;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Jersey 10", 1F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonClose.ForeColor = Color.FromArgb(3, 37, 140);
            buttonClose.Location = new Point(498, 7);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(40, 40);
            buttonClose.TabIndex = 0;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.FromArgb(80, 75, 56);
            buttonStart.BackgroundImage = (Image)resources.GetObject("buttonStart.BackgroundImage");
            buttonStart.BackgroundImageLayout = ImageLayout.Stretch;
            buttonStart.FlatStyle = FlatStyle.Flat;
            buttonStart.Font = new Font("Orange Kid", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonStart.ForeColor = Color.WhiteSmoke;
            buttonStart.Location = new Point(80, 432);
            buttonStart.Margin = new Padding(3, 2, 3, 2);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(400, 50);
            buttonStart.TabIndex = 3;
            buttonStart.Text = "LOG IN";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.FromArgb(3, 37, 140);
            tbPassword.ForeColor = SystemColors.Window;
            tbPassword.Location = new Point(80, 363);
            tbPassword.Margin = new Padding(3, 2, 3, 2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(400, 47);
            tbPassword.TabIndex = 2;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // tbLogin
            // 
            tbLogin.BackColor = Color.FromArgb(3, 37, 140);
            tbLogin.ForeColor = SystemColors.Window;
            tbLogin.Location = new Point(80, 266);
            tbLogin.Margin = new Padding(3, 2, 3, 2);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(400, 47);
            tbLogin.TabIndex = 1;
            // 
            // btnShowPassword
            // 
            btnShowPassword.BackColor = Color.FromArgb(3, 37, 140);
            btnShowPassword.BackgroundImage = (Image)resources.GetObject("btnShowPassword.BackgroundImage");
            btnShowPassword.BackgroundImageLayout = ImageLayout.Stretch;
            btnShowPassword.FlatAppearance.BorderSize = 0;
            btnShowPassword.FlatStyle = FlatStyle.Popup;
            btnShowPassword.Image = (Image)resources.GetObject("btnShowPassword.Image");
            btnShowPassword.Location = new Point(422, 366);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(40, 40);
            btnShowPassword.TabIndex = 0;
            btnShowPassword.UseVisualStyleBackColor = false;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Orange Kid", 60F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(3, 37, 140);
            labelTitle.Location = new Point(143, 106);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(272, 120);
            labelTitle.TabIndex = 23;
            labelTitle.Text = "LOG IN";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.BackColor = Color.Transparent;
            labelAddress.Font = new Font("Orange Kid", 20F);
            labelAddress.ForeColor = Color.FromArgb(3, 37, 140);
            labelAddress.Location = new Point(80, 315);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(136, 41);
            labelAddress.TabIndex = 24;
            labelAddress.Text = "Password:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Transparent;
            labelName.Font = new Font("Orange Kid", 20F);
            labelName.ForeColor = Color.FromArgb(3, 37, 140);
            labelName.Location = new Point(80, 218);
            labelName.Name = "labelName";
            labelName.Size = new Size(41, 41);
            labelName.TabIndex = 25;
            labelName.Text = "Id:";
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(550, 550);
            ControlBox = false;
            Controls.Add(labelAddress);
            Controls.Add(labelName);
            Controls.Add(labelTitle);
            Controls.Add(btnShowPassword);
            Controls.Add(tbPassword);
            Controls.Add(buttonStart);
            Controls.Add(tbLogin);
            Controls.Add(label1);
            Controls.Add(buttonClose);
            DoubleBuffered = true;
            Font = new Font("Orange Kid", 20F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 7, 4, 7);
            MaximumSize = new Size(550, 550);
            MinimumSize = new Size(550, 550);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += fLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button buttonClose;
        private Button buttonStart;
        private TextBox tbPassword;
        private TextBox tbLogin;
        private Button btnShowPassword;
        private Label labelTitle;
        private Label labelAddress;
        private Label labelName;
    }
}