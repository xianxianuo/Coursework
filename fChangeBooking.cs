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
        public fChangeBooking()
        {
            InitializeComponent();
            clients = hotel.Clients;
            rooms = hotel.Rooms;
        }
        private void fChangeBooking_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
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
        private void btnStart_Click(object sender, EventArgs e)
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
    }
}
