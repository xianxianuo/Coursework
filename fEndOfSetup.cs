using System.Data;

namespace CurseWork
{
    public partial class fEndOfSetup : Form
    {
        private Hotel hotel;
        private List<Room> rooms;
        DataTable dataTable = new DataTable();
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
        private bool isChanged = false;
        public fEndOfSetup()
        {
            InitializeComponent();
            hotel = Hotel.LoadFromFile();
            rooms = hotel.Rooms;
        }
        private void fEndOfSetup_Load(object sender, EventArgs e)
        {
            if (isChanged == false)
            {
                dataTable.Columns.Add("Room Number", typeof(int));
                dataTable.Columns.Add("Type", typeof(string));
                dataTable.Columns.Add("Price", typeof(decimal));
                dgTableEndSetInfo.DataSource = dataTable;

                foreach (Room room in rooms)
                {
                    dataTable.Rows.Add(room.RoomNumber, room.Type, room.Price);
                }

                dgTableEndSetInfo.DataSource = dataTable;

                DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
                comboBoxColumn.HeaderText = "Type";
                comboBoxColumn.DataSource = roomsType;
                comboBoxColumn.DataPropertyName = "Type";
                comboBoxColumn.ValueType = typeof(string);
                comboBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
                comboBoxColumn.DefaultCellStyle.NullValue = "Single Room"; // Set default value

                dgTableEndSetInfo.Columns.Remove("Type");
                dgTableEndSetInfo.Columns.Insert(1, comboBoxColumn);
            }
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
            for (int i = 0; i < dgTableEndSetInfo.Rows.Count - 1; i++)
            {
                int randomPrice = random.Next(100, 1000);
                dgTableEndSetInfo.Rows[i].Cells[2].Value = randomPrice;
                dgTableEndSetInfo.Rows[i].Cells[1].Value = roomsType[random.Next(0, roomsType.Count)];
            }
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (isChanged == false)
            {
                if (dgTableEndSetInfo.Rows.Count == 0)
                {
                    MessageBox.Show("Please add at least one room before proceeding.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                for (int i = 0; i < dgTableEndSetInfo.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = dgTableEndSetInfo.Rows[i];

                    // Check if the Id is empty
                    if (row.Cells[0].Value == null || row.Cells[0].Value.ToString() == "")
                    {
                        MessageBox.Show("Id cannot be empty! Row: " + (i + 1), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Check if the Name is empty
                    if (row.Cells[1].Value == null || row.Cells[1].Value.ToString() == "")
                    {
                        MessageBox.Show("Name cannot be empty! Row: " + (i + 1), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Check if the Password is empty
                    if (row.Cells[2].Value == null || row.Cells[2].Value.ToString() == "")
                    {
                        MessageBox.Show("Password cannot be empty! Row: " + (i + 1), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                hotel.Rooms.Clear(); // Clear existing rooms to avoid duplicates  

                for (int i = 0; i < dgTableEndSetInfo.Rows.Count - 1; i++)
                {
                    Room room = new Room { };
                    room.RoomNumber = Convert.ToInt32(dgTableEndSetInfo.Rows[i].Cells[0].Value);
                    room.Type = dgTableEndSetInfo.Rows[i].Cells[1].Value.ToString();
                    room.IsFree = true;
                    if (Convert.ToInt32(dgTableEndSetInfo.Rows[i].Cells[2].Value) == 0)
                    {
                        MessageBox.Show("Price cannot be 0!");
                        return;
                    }
                    else
                    {
                        room.Price = Convert.ToDecimal(dgTableEndSetInfo.Rows[i].Cells[2].Value);
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

                isChanged = true;
                btnStart.Text = "END OF SETUP";
                btnRandom.Visible = false;

                // Clear and reconfigure the dataTable for employees  
                dataTable.Clear();
                dataTable.Columns.Clear();
                dataTable.Columns.Add("Id", typeof(string));
                dataTable.Columns.Add("Name", typeof(string));
                dataTable.Columns.Add("Password", typeof(string));
                dgTableEndSetInfo.DataSource = dataTable;

                // Populate the dataTable with existing employees  
                foreach (Employee employee in hotel.Employees)
                {
                    dataTable.Rows.Add(employee.Id, employee.Name, employee.Password);
                }
            }
            else
            {
                // Validate the employee information before saving
                if (dgTableEndSetInfo.Rows.Count == 0 || dgTableEndSetInfo.Rows.Count == 1)
                {
                    MessageBox.Show("Please add at least one employee before proceeding.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                for (int i = 0; i < dgTableEndSetInfo.Rows.Count; i++)
                {
                    DataGridViewRow row = dgTableEndSetInfo.Rows[i];

                    if (row.IsNewRow) continue;

                    // Check if the Id is empty
                    if (row.Cells[0].Value == null || row.Cells[0].Value.ToString() == "")
                    {
                        MessageBox.Show("Id cannot be empty! Row: " + (i + 1), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Check if the Name is empty
                    if (row.Cells[1].Value == null || row.Cells[1].Value.ToString() == "")
                    {
                        MessageBox.Show("Name cannot be empty! Row: " + (i + 1), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Check if the Password is empty
                    if (row.Cells[2].Value == null || row.Cells[2].Value.ToString() == "")
                    {
                        MessageBox.Show("Password cannot be empty! Row: " + (i + 1), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                hotel.Employees.Clear(); // Clear existing employees to avoid duplicates  

                for (int i = 0; i < dgTableEndSetInfo.Rows.Count - 1; i++)
                {
                    Employee employee = new Employee();
                    employee.Id = dgTableEndSetInfo.Rows[i].Cells[0].Value.ToString();
                    employee.Name = dgTableEndSetInfo.Rows[i].Cells[1].Value.ToString();
                    employee.Password = dgTableEndSetInfo.Rows[i].Cells[2].Value.ToString();
                    hotel.Employees.Add(employee);
                }

                hotel.DeleteFileInfo();
                hotel.SaveToFile();
                MessageBox.Show("End of setup saved successfully!");
                this.Hide();
                fAdmin fAdmin = new fAdmin(true);
                fAdmin.Show();
            }
        }
        private void ts_btnAdd_Click(object sender, EventArgs e)
        {
            if(isChanged == false)
            {
                DataRow newRow = dataTable.NewRow();
                newRow["Room Number"] = 0;
                newRow["Type"] = "Single Room";
                newRow["Price"] = 0;
                dataTable.Rows.Add(newRow);
            }
            else
            {
                DataRow newRow = dataTable.NewRow();
                newRow["Id"] = "";
                newRow["Name"] = "";
                newRow["Password"] = "";
                dataTable.Rows.Add(newRow);
            }
        }
        private void ts_btnDelete_Click(object sender, EventArgs e)
        {
            if (dgTableEndSetInfo.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgTableEndSetInfo.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        DataTable currentTable = isChanged ? dataTable : dataTable;
                        currentTable.Rows.RemoveAt(row.Index);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}
