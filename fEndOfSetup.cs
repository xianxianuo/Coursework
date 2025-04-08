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
        private List<string> roomsType = new List<string>
        {
            "Single Room",
            "Double Room",
            "Triple Room",
            "Quad Room",
            "Suite",
            "Family Room",
            "Presidential Suite",
        };
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

            foreach (Room room in rooms)
            {
                dataTable.Rows.Add(room.RoomNumber, room.Type, room.Price);
            }

            dgRoomFill.DataSource = dataTable;

            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "Type";
            comboBoxColumn.DataSource = roomsType;
            comboBoxColumn.DataPropertyName = "Type";
            comboBoxColumn.ValueType = typeof(string);
            comboBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            comboBoxColumn.DefaultCellStyle.NullValue = "Single Room"; // Set default value

            dgRoomFill.Columns.Remove("Type");
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
                Application.Exit();
                hotel.DeleteFileInfo();
            }
        }
        //Random btn DELETE BEFORE RELEASE!!!
        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < dgRoomFill.Rows.Count - 1; i++)
            {
                int randomPrice = random.Next(100, 1000);
                dgRoomFill.Rows[i].Cells[2].Value = randomPrice;
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
                room.Type = dgRoomFill.Rows[i].Cells[1].Value.ToString();
                room.IsFree = true;
                if (Convert.ToInt32(dgRoomFill.Rows[i].Cells[2].Value) == 0)
                {
                    MessageBox.Show("Price cannot be 0!");
                    return;
                }
                else
                {
                    room.Price = Convert.ToDecimal(dgRoomFill.Rows[i].Cells[2].Value);
                }
                switch (room.Type)
                {
                    case "Single Room":
                        room.Capacity = 1;
                        break;
                    case "Double Room":
                        room.Capacity = 2;
                        break;
                    case "Triple Room":
                        room.Capacity = 3;
                        break;
                    case "Quad Room":
                        room.Capacity = 4;
                        break;
                    case "Suite":
                        room.Capacity = 2;
                        break;
                    case "Family Room":
                        room.Capacity = 4;
                        break;
                    case "Presidential Suite":
                        room.Capacity = 2;
                        break;
                    default:
                        room.Capacity = 1;
                        break;
                }

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
