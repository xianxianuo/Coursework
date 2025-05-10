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
    public partial class fChangeHotel : Form
    {
        private Hotel hotel = Hotel.LoadFromFile();
        private List<Room> rooms;
        private List<Employee> employees;
        public fChangeHotel()
        {
            InitializeComponent();
            rooms = hotel.Rooms;
            employees = hotel.Employees;

            if (this.Name == "showHotel")
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
            tbClients.Text = rooms.Count.ToString();
            tbEmployees.Text = employees.Count.ToString();
            tbClients.ReadOnly = true;
            tbEmployees.ReadOnly = true;
        }
        private void Exit()
        {
            this.Close();
            if (this.Name == "changeHotel")
            {
                fAdmin fManager = new fAdmin(true);
                fManager.ShowDialog();
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
                string message = "Do you want to close this window? Information will be lost.";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
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
            //fChangeEmployee fChangeEmployee = new fChangeEmployee();
            //fChangeEmployee.Show();
        }
    }
}
