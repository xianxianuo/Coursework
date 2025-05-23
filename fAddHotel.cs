﻿using System;
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
    public partial class fAddHotel : Form
    {
        private Hotel hotel;
        public fAddHotel()
        {
            InitializeComponent();
        }
        private void FormAddHotel_Load(object sender, EventArgs e)
        {
            hotel = Hotel.LoadFromFile();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                // Переходимо до наступного елемента керування
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
                return true; // Блокуємо стандартну дію клавіші Enter
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            hotel = new Hotel();
            hotel.Name = tbHotelName.Text;
            hotel.Address = tbAdress.Text;
            hotel.NumberOfRooms = Convert.ToInt32(tbNumberOfRooms.Text);
            hotel.Clients = new List<Client>();
            hotel.Rooms = new List<Room>(); // Initialize the Rooms property

            int numOfEmployees = Convert.ToInt32(tbNumOfEmployee.Text);
            hotel.AddEmployees(numOfEmployees);

            for (int i = 1; i <= hotel.NumberOfRooms; i++)
            {
                Room room = new Room();  // Create a new Room object
                room.SetRoomNumber(i);
                hotel.Rooms.Add(room);  // Add the new room to the list
            }
            hotel.SaveToFile();
            this.Hide();
            MessageBox.Show("Hotel added successfully");
            fEndOfSetup endOfSetup = new fEndOfSetup();
            endOfSetup.Show();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
