namespace CurseWork
{
    public partial class fChangeHotel : Form
    {
        private Hotel hotel = Hotel.LoadFromFile();
        private List<Room> rooms;
        private List<Employee> employees;
        private bool isAdmin;
        public fChangeHotel(bool isAdmin)
        {
            InitializeComponent();
            rooms = hotel.Rooms;
            employees = hotel.Employees;
            this.isAdmin = isAdmin;

            if (!isAdmin)
            {
                btnChangeEmployee.Visible = false;
                btnChangeClients.Visible = false;

                tbAddress.ReadOnly = true;
                tbName.ReadOnly = true;
                tbClients.ReadOnly = true;
                tbEmployees.ReadOnly = true;

                buttonSave.Visible = false;
            }
        }
        private void fHotelInfo_Load(object sender, EventArgs e)
        {
            tbName.Text = hotel.Name;
            tbAddress.Text = hotel.Address;
            tbClients.Text = hotel.Clients.Count.ToString();
            tbEmployees.Text = employees.Count.ToString();
            tbClients.ReadOnly = true;
            tbEmployees.ReadOnly = true;
        }
        private void Exit()
        {
            this.Close();
            if (isAdmin)
            {
                fAdmin fManager = new fAdmin(true);
                fManager.Show();
            }
            else
            {
                fAdmin fManager = new fAdmin(false);
                fManager.Show();
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (tbName.Text != hotel.Name || tbAddress.Text != hotel.Address)
            {
                string message = "Do you want to save changes before closing?";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    Exit();
                }
                else
                {
                    buttonSave_Click(sender, e);
                    Exit();
                }
            }
            else
            {
                Exit();
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text) || string.IsNullOrWhiteSpace(tbAddress.Text))
            {
                MessageBox.Show("Please enter hotel name and address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                hotel.Name = tbName.Text;
                hotel.Address = tbAddress.Text;
                hotel.SaveToFile();
                MessageBox.Show("Hotel information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Exit();
            }
        }
        private void btnChangeClients_Click(object sender, EventArgs e)
        {
            this.Close();
            fChangeInformation fChangeClient = new fChangeInformation();
            fChangeClient.Show();
        }
        private void btnChangeEmployee_Click(object sender, EventArgs e)
        {
            this.Close();
            fChangeInformation fChangeEmployee = new fChangeInformation();
            fChangeEmployee.isAdmin = true;
            fChangeEmployee.Show();
        }
    }
}
