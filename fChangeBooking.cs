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
    public partial class fChangeBooking : Form
    {
        private Hotel hotel = Hotel.LoadFromFile();
        private List<Client> clients;
        private List<Room> rooms;

        DataTable dataTable = new DataTable();

        // Для пошуку
        private DataTable dataTableSearch;
        private bool isSearch = false;
        private string searchText = string.Empty;

        public fChangeBooking()
        {
            InitializeComponent();
            clients = hotel.Clients;
            rooms = hotel.Rooms;
            List<string> sortValues = new List<string>{
                "Name",
                "Surname",
                "RoomNumber"
            };

            ts_cbSort.ComboBox.DataSource = sortValues; // Fix for CS1061
        }
        private void fChangeBooking_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Surname", typeof(string));
            dataTable.Columns.Add("Phone", typeof(string));
            dataTable.Columns.Add("Check In Date", typeof(DateTime));
            dataTable.Columns.Add("Check Out Date", typeof(DateTime));
            dataTable.Columns.Add("RoomNumber", typeof(int)); // Додаємо колонку для номера кімнати

            foreach (Client client in clients)
            {
                dataTable.Rows.Add(client.Name, client.Surname, client.Phone, client.CheckInDate, client.CheckOutDate, client.RoomNumber);
            }

            dgBookingChange.DataSource = dataTable;

            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "Room Number";
            comboBoxColumn.DataPropertyName = "RoomNumber"; // Прив'язка до даних
            foreach (Room room in rooms)
            {
                comboBoxColumn.Items.Add(room.RoomNumber);
            }
            comboBoxColumn.ValueType = typeof(int);

            // Замінюємо колонку RoomNumber на комбобокс
            dgBookingChange.Columns.Remove("RoomNumber");
            dgBookingChange.Columns.Insert(5, comboBoxColumn);

            dataTableSearch = dataTable.Clone();
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
        private void ts_btnSearch_Click(object sender, EventArgs e)
        {
            searchText = ts_tbSearch.Text.ToString();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a search term.");
                dgBookingChange.DataSource = dataTable; // Оновлюємо джерело даних
            }
            else
            {
                dataTableSearch.Clear();
                foreach (Client client in clients)
                {
                    if (client.Surname == searchText)
                    {
                        dataTableSearch.Rows.Add(client.Name, client.Surname, client.Phone, client.CheckInDate, client.CheckOutDate, client.RoomNumber);
                    }
                }
                dgBookingChange.DataSource = dataTableSearch; // Встановлюємо нове джерело даних
                isSearch = true;
            }
        }
        private void ts_btnAdd_Click(object sender, EventArgs e)
        {
            DataTable currentTable = isSearch ? dataTableSearch : dataTable;

            DataRow newRow = currentTable.NewRow();
            newRow["Name"] = "Enter Name";
            newRow["Surname"] = "Enter Surname";
            newRow["Phone"] = "Enter Phone";
            newRow["Check In Date"] = DateTime.Today;
            newRow["Check Out Date"] = DateTime.Today.AddDays(1);

            currentTable.Rows.Add(newRow);
            dgBookingChange.DataSource = currentTable;
        }
        private void ts_btnDelete_Click(object sender, EventArgs e)
        {
            if (dgBookingChange.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgBookingChange.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        DataTable currentTable = isSearch ? dataTableSearch : dataTable;
                        currentTable.Rows.RemoveAt(row.Index);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isSearch == false)
            {
                hotel.Clients.Clear();

                for (int i = 0; i < dgBookingChange.Rows.Count - 1; i++)
                {
                    Client client = new Client();

                    client.Name = (string)dgBookingChange.Rows[i].Cells[0].Value;
                    client.Surname = (string)dgBookingChange.Rows[i].Cells[1].Value;
                    client.Phone = (string)dgBookingChange.Rows[i].Cells[2].Value;
                    client.CheckInDate = (DateTime)dgBookingChange.Rows[i].Cells[3].Value;
                    client.CheckOutDate = (DateTime)dgBookingChange.Rows[i].Cells[4].Value;
                    client.RoomNumber = Convert.ToInt32(dgBookingChange.Rows[i].Cells[5].Value);

                    hotel.AddClient(client, hotel);
                }

                // Зберігаємо дані в файл
                hotel.DeleteFileInfo();
                hotel.SaveToFile();
                MessageBox.Show("Booking changed successfully!");
                this.Hide();
                fAdministration fAdministration = new fAdministration();
                fAdministration.Show();
            }
            else
            {
                foreach (Client client in clients)
                {
                    if (client.Surname == searchText)
                    {
                        client.Name = (string)dgBookingChange.Rows[0].Cells[0].Value;
                        client.Surname = (string)dgBookingChange.Rows[0].Cells[1].Value;
                        client.Phone = (string)dgBookingChange.Rows[0].Cells[2].Value;
                        client.CheckInDate = (DateTime)dgBookingChange.Rows[0].Cells[3].Value;
                        client.CheckOutDate = (DateTime)dgBookingChange.Rows[0].Cells[4].Value;
                        client.RoomNumber = Convert.ToInt32(dgBookingChange.Rows[0].Cells[5].Value);
                    }
                }

                // Зберігаємо дані в файл
                hotel.DeleteFileInfo();
                hotel.SaveToFile();
                MessageBox.Show("Booking changed successfully!");
                this.Hide();
                fAdministration fAdministration = new fAdministration();
                fAdministration.Show();
            }
        }
        private void ts_btnBack_Click(object sender, EventArgs e)
        {
            dgBookingChange.DataSource = dataTable; // Оновлюємо джерело даних
        }
    }
}
