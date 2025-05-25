namespace CurseWork
{
    partial class fChangeHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChangeHotel));
            labelTitle = new Label();
            buttonClose = new Button();
            buttonSave = new Button();
            tbAddress = new TextBox();
            labelAddress = new Label();
            tbName = new TextBox();
            labelName = new Label();
            tbClients = new TextBox();
            label1 = new Label();
            tbEmployees = new TextBox();
            label2 = new Label();
            btnChangeClients = new Button();
            btnChangeEmployee = new Button();
            title = new Label();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Orange Kid", 60F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(3, 37, 140);
            labelTitle.Location = new Point(87, 57);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(443, 120);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "HOTEL INFO";
            // 
            // buttonClose
            // 
            buttonClose.BackgroundImage = (Image)resources.GetObject("buttonClose.BackgroundImage");
            buttonClose.BackgroundImageLayout = ImageLayout.Stretch;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Location = new Point(547, 11);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(35, 35);
            buttonClose.TabIndex = 18;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(80, 75, 56);
            buttonSave.BackgroundImage = (Image)resources.GetObject("buttonSave.BackgroundImage");
            buttonSave.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Orange Kid", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave.ForeColor = Color.WhiteSmoke;
            buttonSave.Location = new Point(103, 509);
            buttonSave.Margin = new Padding(3, 2, 3, 2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(400, 50);
            buttonSave.TabIndex = 21;
            buttonSave.Text = "SAVE";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // tbAddress
            // 
            tbAddress.BackColor = Color.FromArgb(20, 60, 178);
            tbAddress.Font = new Font("Orange Kid", 15F);
            tbAddress.ForeColor = SystemColors.Window;
            tbAddress.Location = new Point(104, 292);
            tbAddress.Margin = new Padding(3, 2, 3, 2);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(400, 37);
            tbAddress.TabIndex = 20;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.BackColor = Color.Transparent;
            labelAddress.Font = new Font("Orange Kid", 20F);
            labelAddress.ForeColor = Color.FromArgb(3, 37, 140);
            labelAddress.Location = new Point(103, 249);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(116, 41);
            labelAddress.TabIndex = 22;
            labelAddress.Text = "Address:";
            // 
            // tbName
            // 
            tbName.BackColor = Color.FromArgb(20, 60, 178);
            tbName.Font = new Font("Orange Kid", 15F);
            tbName.ForeColor = SystemColors.Window;
            tbName.Location = new Point(104, 210);
            tbName.Margin = new Padding(3, 2, 3, 2);
            tbName.Name = "tbName";
            tbName.Size = new Size(400, 37);
            tbName.TabIndex = 19;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Transparent;
            labelName.Font = new Font("Orange Kid", 20F);
            labelName.ForeColor = Color.FromArgb(3, 37, 140);
            labelName.Location = new Point(103, 167);
            labelName.Name = "labelName";
            labelName.Size = new Size(87, 41);
            labelName.TabIndex = 23;
            labelName.Text = "Name:";
            // 
            // tbClients
            // 
            tbClients.BackColor = Color.FromArgb(20, 60, 178);
            tbClients.Font = new Font("Orange Kid", 15F);
            tbClients.ForeColor = SystemColors.Window;
            tbClients.Location = new Point(103, 374);
            tbClients.Margin = new Padding(3, 2, 3, 2);
            tbClients.Name = "tbClients";
            tbClients.Size = new Size(400, 37);
            tbClients.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Orange Kid", 20F);
            label1.ForeColor = Color.FromArgb(3, 37, 140);
            label1.Location = new Point(104, 331);
            label1.Name = "label1";
            label1.Size = new Size(99, 41);
            label1.TabIndex = 25;
            label1.Text = "Clients:";
            // 
            // tbEmployees
            // 
            tbEmployees.BackColor = Color.FromArgb(20, 60, 178);
            tbEmployees.Font = new Font("Orange Kid", 15F);
            tbEmployees.ForeColor = SystemColors.Window;
            tbEmployees.Location = new Point(103, 458);
            tbEmployees.Margin = new Padding(3, 2, 3, 2);
            tbEmployees.Name = "tbEmployees";
            tbEmployees.Size = new Size(400, 37);
            tbEmployees.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Orange Kid", 20F);
            label2.ForeColor = Color.FromArgb(3, 37, 140);
            label2.Location = new Point(103, 413);
            label2.Name = "label2";
            label2.Size = new Size(139, 41);
            label2.TabIndex = 27;
            label2.Text = "Employees:";
            // 
            // btnChangeClients
            // 
            btnChangeClients.BackgroundImage = (Image)resources.GetObject("btnChangeClients.BackgroundImage");
            btnChangeClients.BackgroundImageLayout = ImageLayout.Stretch;
            btnChangeClients.Font = new Font("Orange Kid", 10F);
            btnChangeClients.ForeColor = SystemColors.Control;
            btnChangeClients.Location = new Point(409, 374);
            btnChangeClients.Name = "btnChangeClients";
            btnChangeClients.Size = new Size(94, 36);
            btnChangeClients.TabIndex = 28;
            btnChangeClients.Text = "CHANGE";
            btnChangeClients.UseVisualStyleBackColor = true;
            btnChangeClients.Click += btnChangeClients_Click;
            // 
            // btnChangeEmployee
            // 
            btnChangeEmployee.BackgroundImage = (Image)resources.GetObject("btnChangeEmployee.BackgroundImage");
            btnChangeEmployee.BackgroundImageLayout = ImageLayout.Stretch;
            btnChangeEmployee.Font = new Font("Orange Kid", 10F);
            btnChangeEmployee.ForeColor = SystemColors.Control;
            btnChangeEmployee.Location = new Point(410, 458);
            btnChangeEmployee.Name = "btnChangeEmployee";
            btnChangeEmployee.Size = new Size(94, 37);
            btnChangeEmployee.TabIndex = 29;
            btnChangeEmployee.Text = "CHANGE";
            btnChangeEmployee.UseVisualStyleBackColor = true;
            btnChangeEmployee.Click += btnChangeEmployee_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Orange Kid", 20F);
            title.ForeColor = Color.White;
            title.Location = new Point(12, 8);
            title.Name = "title";
            title.Size = new Size(248, 41);
            title.TabIndex = 30;
            title.Text = "HOTEL INFORMATION";
            // 
            // fChangeHotel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(600, 600);
            ControlBox = false;
            Controls.Add(title);
            Controls.Add(btnChangeEmployee);
            Controls.Add(btnChangeClients);
            Controls.Add(tbEmployees);
            Controls.Add(label2);
            Controls.Add(tbClients);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Controls.Add(tbAddress);
            Controls.Add(labelAddress);
            Controls.Add(tbName);
            Controls.Add(labelName);
            Controls.Add(buttonClose);
            Controls.Add(labelTitle);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(600, 600);
            MinimumSize = new Size(600, 600);
            Name = "fChangeHotel";
            StartPosition = FormStartPosition.CenterScreen;
            Load += fHotelInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTitle;
        private Button buttonClose;
        private Button buttonSave;
        private TextBox tbAddress;
        private Label labelAddress;
        private TextBox tbName;
        private Label labelName;
        private TextBox tbClients;
        private Label label1;
        private TextBox tbEmployees;
        private Label label2;
        private Button btnChangeClients;
        private Button btnChangeEmployee;
        private Label title;
    }
}