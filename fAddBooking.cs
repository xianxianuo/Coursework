using System.Text.RegularExpressions;

namespace CurseWork
{
    public partial class fAddBooking : Form
    {
        private Hotel hotel = Hotel.LoadFromFile();
        private Client client = new Client();
        public fAddBooking()
        {
            InitializeComponent();
            cbRoomNumber.Items.Clear();
            foreach (Room i in hotel.Rooms)
            {
                if (i.IsFree == true)
                {
                    cbRoomNumber.Items.Add(i.RoomNumber.ToString());
                }
            }
        }
        //set tab interaction on Enter
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
            string message = "Do you want to close this window? Information will be lost.";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                fAdmin fAdmin = new fAdmin(false);
                fAdmin.Show();
            }
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text) ||
                string.IsNullOrWhiteSpace(tbSurname.Text) ||
                string.IsNullOrWhiteSpace(tbPhoneNum.Text))
            {
                MessageBox.Show("Please fill in all fields!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dtpDateSecond.Value.Date <= dtpDateFirst.Value.Date)
            {
                MessageBox.Show("Check-out date cannot be earlier than check-in date!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dtpDateFirst.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Check-in date cannot be in the past!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dtpDateSecond.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Check-out date cannot be in the past!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbRoomNumber.SelectedItem == null)
            {
                MessageBox.Show("Please select a room number!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Regex.IsMatch(tbPhoneNum.Text, @"^\d+$"))
            {
                MessageBox.Show("Please enter digits only!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPhoneNum.Focus();
            }
            else if (!tbPhoneNum.Text.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must contain digits only in phone number!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                client.Name = tbName.Text;
                client.Surname = tbSurname.Text;
                client.CheckInDate = dtpDateFirst.Value.Date;
                client.CheckOutDate = dtpDateSecond.Value.Date;
                client.Phone = tbPhoneNum.Text;
                client.RoomNumber = int.Parse(cbRoomNumber.SelectedItem.ToString());

                hotel.AddClient(client, hotel);

                hotel.SaveToFile();
                MessageBox.Show("Booking added successfully!");

                tbName.Clear();
                tbSurname.Clear();
                dtpDateSecond.Value = DateTime.Now;
                dtpDateFirst.Value = DateTime.Now;
                tbPhoneNum.Clear();

                this.Close();
                fAdmin fAdmin = new fAdmin(false);
                fAdmin.Show();
            }
        }
    }
}
