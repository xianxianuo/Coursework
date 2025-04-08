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
    public partial class fSearchBooking : Form
    {
        private Hotel hotel = Hotel.LoadFromFile();
        public fSearchBooking()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            labelCheckInDate.Text = "";
            labelRoomNumber.Text = "";
            labelCheckInDate.Visible = false;
            labelRoomNumber.Visible = false;
        }
        private void btnSearchBooking_Click(object sender, EventArgs e)
        {
            bool bookingFound = false;
            foreach (Client i in hotel.Clients)
            {
                if (i.Surname == tbSurname.Text)
                {
                    labelRoomNumber.Visible = true;
                    labelCheckInDate.Visible = true;

                    labelRoomNumber.Text = "Room number: " + i.RoomNumber.ToString();
                    labelCheckInDate.Text = "Check in date: " + i.CheckInDate.ToString();
                    bookingFound = true;
                    break;
                }
            }

            if (!bookingFound)
            {
                MessageBox.Show("Booking not found");
            }
        }
    }
}
