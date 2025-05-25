namespace CurseWork
{
    public partial class fLogin : Form
    {
        private Hotel hotel = Hotel.LoadFromFile();

        /// Path to the image files
        private bool isHide = true;
        private string basePath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "Media");
        private string hidePath;
        private string showPath;
        public fLogin()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            hidePath = Path.Combine(basePath, "hide.png");
            showPath = Path.Combine(basePath, "show.png");
        }
        /// This method is used to handle the Enter key press event
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text.Trim();
            string password = tbPassword.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both login and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Admin login
            if (login == "master" && password == "master") // Admin credentials
            {
                this.Hide();
                fAdmin admin = new fAdmin(true); // Admin mode
                admin.ShowDialog();
                return;
            }

            var employee = hotel.Employees.FirstOrDefault(emp => emp.Id == login);

            if (employee == null)
            {
                MessageBox.Show("Login not found. Please check your login.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (employee.Password != password)
            {
                MessageBox.Show("Incorrect password. Please try again.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Successful login
            this.Hide();
            fAdmin user = new fAdmin(false); // Regular user mode
            user.ShowDialog();
        }
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (isHide)
            {
                tbPassword.UseSystemPasswordChar = false;
                btnShowPassword.BackgroundImage = Image.FromFile(hidePath);
                isHide = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
                btnShowPassword.BackgroundImage = Image.FromFile(showPath);
                isHide = true;
            }
        }
    }
}
