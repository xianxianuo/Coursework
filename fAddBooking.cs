using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private void buttonClose_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window? Information will be lost.";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                fAdministration fAdministration = new fAdministration();
                fAdministration.Show();
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text) ||
                string.IsNullOrWhiteSpace(tbSurname.Text) ||
                string.IsNullOrWhiteSpace(tbPhoneNum.Text) ||
                cbRoomNumber.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.");
                Focus();
            }

            client.Name = tbName.Text;
            client.Surname = tbSurname.Text;
            client.CheckInDate = dtpDateFirst.Value.Date;
            if (dtpDateSecond.Value.Date <= dtpDateFirst.Value.Date)
            {
                MessageBox.Show("Check-out date cannot be earlier than check-in date.");
                Focus();
            }
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
        }
    }
}
