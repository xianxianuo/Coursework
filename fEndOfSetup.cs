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
    public partial class fEndOfSetup : Form
    {
        private Hotel hotel;
        private List<Room> rooms;
        private List<string> roomTypes = new List<string> { "Simple", "Lux", "VIP" };
        public fEndOfSetup()
        {
            InitializeComponent();
            hotel = Hotel.LoadFromFile();
            rooms = hotel.Rooms;

        }
        private void fEndOfSetup_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Room Number", typeof(int));
            dataTable.Columns.Add("Type", typeof(string));
            dataTable.Columns.Add("Price", typeof(decimal));
            dataTable.Columns.Add("Capacity", typeof(int));
            dataTable.Columns.Add("Is Busy", typeof(bool));

            for (int i = 0; i < rooms.Count; i++)
            {
                Room room = rooms[i];
                dataTable.Rows.Add(room.RoomNumber, room.Type, room.Price, room.Capacity, !room.IsFree);
            }

            dgRoomFill.DataSource = dataTable;

            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "Type";
            comboBoxColumn.DataPropertyName = "Type";
            comboBoxColumn.DataSource = roomTypes;
            comboBoxColumn.ValueType = typeof(string);

            dgRoomFill.Columns.RemoveAt(1);
            dgRoomFill.Columns.Insert(1, comboBoxColumn);
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
            }
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            hotel.DeleteFileInfo();
            hotel.Rooms.Clear(); // Clear existing rooms to avoid duplicates

            for (int i = 0; i < dgRoomFill.Rows.Count - 1; i++)
            {
                Room room = new Room { };
                room.RoomNumber = Convert.ToInt32(dgRoomFill.Rows[i].Cells[0].Value);
                room.Type = dgRoomFill.Rows[i].Cells[1].Value?.ToString() ?? "Simple";
                if (Convert.ToInt32(dgRoomFill.Rows[i].Cells[2].Value) == 0)
                {
                    MessageBox.Show("Price cannot be 0.!");
                    return;
                }
                else
                {
                    room.Price = Convert.ToDecimal(dgRoomFill.Rows[i].Cells[2].Value);
                }
                if (Convert.ToInt16(dgRoomFill.Rows[i].Cells[3].Value) == 0)
                {
                    MessageBox.Show("Capacity cannot be 0!");
                }
                else
                {
                    room.Capacity = Convert.ToInt16(dgRoomFill.Rows[i].Cells[3].Value);
                }
                room.IsFree = !Convert.ToBoolean(dgRoomFill.Rows[i].Cells[4].Value);
                hotel.Rooms.Add(room);
            }

            hotel.SaveToFile();
            MessageBox.Show("Changes saved successfully.");
            this.Hide();
            fAdministration fAdministration = new fAdministration();
            fAdministration.Show();
        }
    }
}
