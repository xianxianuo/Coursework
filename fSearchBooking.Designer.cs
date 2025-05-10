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
            tbSearch = new TextBox();
            labelTitle = new Label();
            title = new Label();
            dgSearchClient = new DataGridView();
            rbName = new RadioButton();
            rbSurname = new RadioButton();
            rbPhone = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgSearchClient).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(615, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 35);
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
            btnSearchBooking.Location = new Point(138, 346);
            btnSearchBooking.Name = "btnSearchBooking";
            btnSearchBooking.Size = new Size(400, 50);
            btnSearchBooking.TabIndex = 16;
            btnSearchBooking.Text = "SEARCH";
            btnSearchBooking.UseVisualStyleBackColor = true;
            btnSearchBooking.Click += btnSearchBooking_Click;
            // 
            // tbSearch
            // 
            tbSearch.BackColor = Color.FromArgb(20, 60, 178);
            tbSearch.Font = new Font("Segoe UI", 15F);
            tbSearch.ForeColor = SystemColors.Window;
            tbSearch.Location = new Point(138, 238);
            tbSearch.Margin = new Padding(3, 2, 3, 2);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(400, 41);
            tbSearch.TabIndex = 19;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Orange Kid", 60F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(3, 37, 140);
            labelTitle.Location = new Point(175, 116);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(338, 120);
            labelTitle.TabIndex = 17;
            labelTitle.Text = "SEARCH";
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Orange Kid", 25F);
            title.ForeColor = Color.White;
            title.Location = new Point(22, 5);
            title.Name = "title";
            title.Size = new Size(264, 50);
            title.TabIndex = 22;
            title.Text = "SEARCH BOOKING";
            // 
            // dgSearchClient
            // 
            dgSearchClient.AllowUserToAddRows = false;
            dgSearchClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgSearchClient.BackgroundColor = Color.FromArgb(255, 219, 226);
            dgSearchClient.BorderStyle = BorderStyle.None;
            dgSearchClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSearchClient.GridColor = Color.Yellow;
            dgSearchClient.Location = new Point(38, 421);
            dgSearchClient.Name = "dgSearchClient";
            dgSearchClient.RowHeadersVisible = false;
            dgSearchClient.RowHeadersWidth = 51;
            dgSearchClient.Size = new Size(612, 80);
            dgSearchClient.TabIndex = 23;
            // 
            // rbName
            // 
            rbName.AutoSize = true;
            rbName.BackColor = Color.FromArgb(255, 219, 226);
            rbName.Font = new Font("Orange Kid", 15F);
            rbName.ForeColor = Color.FromArgb(3, 37, 140);
            rbName.Location = new Point(138, 284);
            rbName.Name = "rbName";
            rbName.Size = new Size(105, 34);
            rbName.TabIndex = 24;
            rbName.TabStop = true;
            rbName.Text = "By name";
            rbName.UseVisualStyleBackColor = false;
            // 
            // rbSurname
            // 
            rbSurname.AutoSize = true;
            rbSurname.BackColor = Color.FromArgb(255, 219, 226);
            rbSurname.Font = new Font("Orange Kid", 15F);
            rbSurname.ForeColor = Color.FromArgb(3, 37, 140);
            rbSurname.Location = new Point(267, 284);
            rbSurname.Name = "rbSurname";
            rbSurname.Size = new Size(130, 34);
            rbSurname.TabIndex = 25;
            rbSurname.TabStop = true;
            rbSurname.Text = "By surname";
            rbSurname.UseVisualStyleBackColor = false;
            // 
            // rbPhone
            // 
            rbPhone.AutoSize = true;
            rbPhone.BackColor = Color.FromArgb(255, 219, 226);
            rbPhone.Font = new Font("Orange Kid", 15F);
            rbPhone.ForeColor = Color.FromArgb(3, 37, 140);
            rbPhone.Location = new Point(431, 284);
            rbPhone.Name = "rbPhone";
            rbPhone.Size = new Size(107, 34);
            rbPhone.TabIndex = 26;
            rbPhone.TabStop = true;
            rbPhone.Text = "By phone";
            rbPhone.UseVisualStyleBackColor = false;
            // 
            // fSearchBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(682, 582);
            ControlBox = false;
            Controls.Add(rbPhone);
            Controls.Add(rbSurname);
            Controls.Add(rbName);
            Controls.Add(dgSearchClient);
            Controls.Add(title);
            Controls.Add(tbSearch);
            Controls.Add(labelTitle);
            Controls.Add(btnSearchBooking);
            Controls.Add(btnClose);
            DoubleBuffered = true;
            MaximumSize = new Size(700, 600);
            MinimumSize = new Size(700, 600);
            Name = "fSearchBooking";
            StartPosition = FormStartPosition.CenterScreen;
            Load += fSearchBooking_Load;
            ((System.ComponentModel.ISupportInitialize)dgSearchClient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnSearchBooking;
        private TextBox tbSearch;
        private Label labelTitle;
        private Label title;
        private DataGridView dgSearchClient;
        private RadioButton rbName;
        private RadioButton rbSurname;
        private RadioButton rbPhone;
    }
}