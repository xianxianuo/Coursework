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
        public fAdministration()
        {
            InitializeComponent();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            fAddBooking fAddBooking = new fAddBooking();
            fAddBooking.ShowDialog();
        }
        private void btnBookingInfo_Click(object sender, EventArgs e)
        {
            fChangeBookingInfo fBookingInfo = new fChangeBookingInfo();
            fBookingInfo.ShowDialog();
            this.Hide();
        }
        private void btnRoomInfo_Click(object sender, EventArgs e)
        {
            fChangeRoomInfo fRoomInfo = new fChangeRoomInfo();
            fRoomInfo.ShowDialog();
            this.Hide();
        }
        private void btnHotelInfo_Click(object sender, EventArgs e)
        {
            fHotelInfo fHotel = new fHotelInfo();
            fHotel.ShowDialog();
            this.Hide();
        }
    }
}
