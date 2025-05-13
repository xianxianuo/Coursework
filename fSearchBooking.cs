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
        DataTable dataTable = new DataTable();
        private string searchSurname,
                searchName;
        private bool isAdmin;
        public fSearchBooking(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
        }
        private void fSearchBooking_Load(object sender, EventArgs e)
        {
            dataTable.Clear();
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Surname", typeof(string));
            dataTable.Columns.Add("Phone", typeof(string));
            dataTable.Columns.Add("CheckInDate", typeof(DateTime));
            dataTable.Columns.Add("CheckOutDate", typeof(DateTime));
            dataTable.Columns.Add("RoomNumber", typeof(int));
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            // Find the client by previously saved name and surname
            Client client = hotel.Clients.FirstOrDefault(c => c.Name == searchName && c.Surname == searchSurname);

            if (client != null)
            {
                DataRow row = dataTable.Rows[0]; // Only one row is expected in the result

                // Check if any data was changed by comparing table values with the client object
                bool hasChanges =
                    client.Name != row["Name"].ToString() ||
                    client.Surname != row["Surname"].ToString() ||
                    client.Phone != row["Phone"].ToString() ||
                    client.CheckInDate != DateTime.Parse(row["CheckInDate"].ToString()) ||
                    client.CheckOutDate != DateTime.Parse(row["CheckOutDate"].ToString()) ||
                    client.RoomNumber != int.Parse(row["RoomNumber"].ToString());

                // If there are changes, ask the user if they want to save them
                if (hasChanges)
                {
                    DialogResult result = MessageBox.Show(
                        "Information changed. Do you want to update the information?",
                        "Information changed",
                        MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        // Apply changes to the client object
                        client.Name = row["Name"].ToString();
                        client.Surname = row["Surname"].ToString();
                        client.Phone = row["Phone"].ToString();
                        client.CheckInDate = DateTime.Parse(row["CheckInDate"].ToString());
                        client.CheckOutDate = DateTime.Parse(row["CheckOutDate"].ToString());
                        client.RoomNumber = int.Parse(row["RoomNumber"].ToString());

                        // Update the file
                        hotel.DeleteFileInfo();
                        hotel.SaveToFile();
                    }
                }

                // Either after saving or skipping, clear the table and go back to admin form
                dataTable.Clear();
                this.Hide();
                if (isAdmin)
                {
                    fAdmin fAdmin = new fAdmin(true);
                    fAdmin.Show();
                }
                else
                {
                    fAdmin fAdmin = new fAdmin(false);
                    fAdmin.Show();
                }
            }
            else
            {
                // Client was not found — likely due to incorrect search reference
                MessageBox.Show("Booking not found. Please try again.");
                this.Hide();
                if (isAdmin)
                {
                    fAdmin fAdmin = new fAdmin(true);
                    fAdmin.Show();
                }
                else
                {
                    fAdmin fAdmin = new fAdmin(false);
                    fAdmin.Show();
                }
            }
        }
        private void btnSearchBooking_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            if (string.IsNullOrWhiteSpace(tbSearch.Text))
            {
                MessageBox.Show("Please enter a search term");
                return;
            }
            bool bookingFound = false;
            Func<Client, bool> predicate = null;

            if (rbName.Checked)
                predicate = c => c.Name == tbSearch.Text;
            else if (rbSurname.Checked)
                predicate = c => c.Surname == tbSearch.Text;
            else if (rbPhone.Checked)
                predicate = c => c.Phone == tbSearch.Text;
            else
            {
                MessageBox.Show("Please select a search option");
                return;
            }

            Client foundClient = hotel.Clients.FirstOrDefault(predicate);
            if (foundClient != null)
            {
                bookingFound = true;
                searchName = foundClient.Name;
                searchSurname = foundClient.Surname;

                dataTable.Rows.Add(foundClient.Name, foundClient.Surname, foundClient.Phone,
                                   foundClient.CheckInDate, foundClient.CheckOutDate, foundClient.RoomNumber);
            }
            else
            {
                MessageBox.Show("Booking not found");
            }

            dgSearchClient.DataSource = dataTable;
        }
    }
}
