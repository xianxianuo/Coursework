namespace CurseWork
{
    partial class fEndOfSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEndOfSetup));
            buttonClose = new Button();
            labelTitle = new Label();
            label3 = new Label();
            buttonStart = new Button();
            dgRoomFill = new DataGridView();
            labelNameTitle = new Label();
            btnRandom = new Button();
            ((System.ComponentModel.ISupportInitialize)dgRoomFill).BeginInit();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.BackgroundImage = (Image)resources.GetObject("buttonClose.BackgroundImage");
            buttonClose.BackgroundImageLayout = ImageLayout.Stretch;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Location = new Point(1123, 15);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(40, 40);
            buttonClose.TabIndex = 0;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Orange Kid", 25F);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(17, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(182, 50);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "END SET UP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Orange Kid", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(15, 29, 70);
            label3.Location = new Point(51, 217);
            label3.Name = "label3";
            label3.Size = new Size(578, 60);
            label3.TabIndex = 1;
            label3.Text = "Fill in information about the rooms";
            // 
            // buttonStart
            // 
            buttonStart.BackgroundImage = (Image)resources.GetObject("buttonStart.BackgroundImage");
            buttonStart.BackgroundImageLayout = ImageLayout.Stretch;
            buttonStart.Font = new Font("Orange Kid", 20F);
            buttonStart.ForeColor = Color.White;
            buttonStart.Location = new Point(751, 598);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(400, 50);
            buttonStart.TabIndex = 5;
            buttonStart.Text = "END SET UP";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // dgRoomFill
            // 
            dgRoomFill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgRoomFill.BackgroundColor = Color.FromArgb(255, 192, 192);
            dgRoomFill.BorderStyle = BorderStyle.None;
            dgRoomFill.ColumnHeadersHeight = 29;
            dgRoomFill.Cursor = Cursors.Hand;
            dgRoomFill.EnableHeadersVisualStyles = false;
            dgRoomFill.GridColor = Color.FromArgb(3, 37, 140);
            dgRoomFill.Location = new Point(51, 280);
            dgRoomFill.Name = "dgRoomFill";
            dgRoomFill.RightToLeft = RightToLeft.No;
            dgRoomFill.RowHeadersWidth = 51;
            dgRoomFill.ScrollBars = ScrollBars.Vertical;
            dgRoomFill.Size = new Size(1100, 300);
            dgRoomFill.TabIndex = 6;
            // 
            // labelNameTitle
            // 
            labelNameTitle.AutoSize = true;
            labelNameTitle.BackColor = Color.Transparent;
            labelNameTitle.Font = new Font("Orange Kid", 60F);
            labelNameTitle.Location = new Point(51, 97);
            labelNameTitle.Name = "labelNameTitle";
            labelNameTitle.Size = new Size(393, 120);
            labelNameTitle.TabIndex = 7;
            labelNameTitle.Text = "WELCOME!";
            // 
            // btnRandom
            // 
            btnRandom.BackgroundImage = (Image)resources.GetObject("btnRandom.BackgroundImage");
            btnRandom.BackgroundImageLayout = ImageLayout.Stretch;
            btnRandom.Font = new Font("Orange Kid", 20F);
            btnRandom.ForeColor = Color.White;
            btnRandom.Location = new Point(51, 598);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(400, 50);
            btnRandom.TabIndex = 8;
            btnRandom.Text = "RANDOM";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;
            // 
            // fEndOfSetup
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1200, 700);
            ControlBox = false;
            Controls.Add(btnRandom);
            Controls.Add(labelNameTitle);
            Controls.Add(dgRoomFill);
            Controls.Add(buttonStart);
            Controls.Add(label3);
            Controls.Add(labelTitle);
            Controls.Add(buttonClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1200, 700);
            Name = "fEndOfSetup";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += fEndOfSetup_Load;
            ((System.ComponentModel.ISupportInitialize)dgRoomFill).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose;
        private Label labelTitle;
        private Label label3;
        private Button buttonStart;
        private DataGridView dgRoomFill;
        private Label labelNameTitle;
        private Button btnRandom;
    }
}