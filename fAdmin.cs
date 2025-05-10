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
    public partial class fAdmin : Form
    {
        private Hotel hotel = Hotel.LoadFromFile();
        public bool isAdmin;
        public fAdmin(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;

            //set gif like background  
            string basePath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "Media");
            string gifPath = Path.Combine(basePath, "mob100.gif");
            if (File.Exists(gifPath))
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = null;
                pictureBox1.Image = Image.FromFile(gifPath);
            }
            else
            {
                MessageBox.Show("GIF файл не знайдено");
            }

            //set admin or user  
            if (isAdmin)
            {
                btnAddBooking.Visible = false;
                btnSearchBooking.Visible = false;
            }
            else
            {
                btnChangeEmployee.Visible = false;
                btnChangeRoomInfo.Visible = false;
            }
        }

        private void btnChangeBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            fChangeInformation fChangeClient = new fChangeInformation();
            fChangeClient.isAdmin = isAdmin;
            fChangeClient.Show();
        }

        private void btnChangeRoomInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            fChangeInformation fChangeRoom = new fChangeInformation();
            fChangeRoom.isAdmin = isAdmin;
            fChangeRoom.Show();
        }

        private void btnHotelInfo_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                this.Hide();
                fChangeHotel changeHotel = new fChangeHotel();
                changeHotel.Show();
            }
            else
            {
                fChangeHotel showHotel = new fChangeHotel();
                showHotel.Show();
            }
            this.Hide();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChangeEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            fChangeInformation fChangeEmployee = new fChangeInformation();
            fChangeEmployee.isAdmin = isAdmin;
            fChangeEmployee.Show();
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAddBooking fAddBooking = new fAddBooking();
            fAddBooking.Show();
        }

        private void btnSearchBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            fSearchBooking fSearchBooking = new fSearchBooking();
            fSearchBooking.Show();
        }
    }
}
