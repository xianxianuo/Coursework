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
    public partial class fAdministration : Form
    {
        private Hotel hotel = Hotel.LoadFromFile();
        private int CurrentOccupied;
        private int CurrentFree;

        public fAdministration()
        {
            InitializeComponent();
            CurrentFree = hotel.NumberOfRooms;
            CurrentOccupied = 0;
            foreach (Room i in hotel.Rooms)
            {
                if (!i.IsFree)
                {
                    CurrentOccupied++;
                    CurrentFree--;
                }
            }
            lbCurrentOccupiedRooms.Text = "Occupied rooms: " + CurrentOccupied.ToString();
            lbCurrentFreeRooms.Text = "Free rooms: " + CurrentFree.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHotelInfo_Click(object sender, EventArgs e)
        {
            fHotelInfo fHotel = new fHotelInfo();
            fHotel.Show();
        }

        private void btnSearchBooking_Click(object sender, EventArgs e)
        {
            fSearchBooking fSearch = new fSearchBooking();
            fSearch.Show();
        }

        private void btnChangeBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            fChangeBooking fChange = new fChangeBooking();
            fChange.Show();
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAddBooking fAdd = new fAddBooking();
            fAdd.Show();
        }
    }
}
