using Newtonsoft.Json;
using System.Data;

namespace CurseWork
{
    public partial class fChangeInformation : Form
    {
        //create object hotel
        private Hotel hotel = Hotel.LoadFromFile();
        private List<Client> clients;
        private List<Room> rooms;
        private List<Employee> employees;
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

        //set admin or user
        public bool isAdmin;

        // create object for DataGridView
        private DataTable dataTable = new DataTable();
        private bool client = false;
        private bool employee = false;
        private bool room = false;

        // DataGridView location and size
        public int x;
        public int y;
        public int sizeX;
        public int sizeY;
        public fChangeInformation()
        {
            InitializeComponent();
            clients = hotel.Clients;
            rooms = hotel.Rooms;
            employees = hotel.Employees;

            //set the location of the DataGridView
            x = dgBookingChange.Location.X;
            y = dgBookingChange.Location.Y;

            //set the size of the DataGridView
            sizeX = dgBookingChange.Size.Width;
            sizeY = dgBookingChange.Size.Height;
        }
        private void dataClient()
        {
            title.Text = "Client Info";
            client = true;
            room = false;
            employee = false;
            //
            //menu strip buttons
            //
            clientToolStripMenuItem.Enabled = false;
            clientToolStripMenuItem.ForeColor = Color.FromArgb(192, 192, 255);
            employeeToolStripMenuItem.Enabled = true;
            employeeToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            roomToolStripMenuItem.Enabled = true;
            roomToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);

            aDDEMPLOYEEToolStripMenuItem.Visible = false;
            dELETEEMPLOYEEToolStripMenuItem.Visible = false;
            aDDROOMToolStripMenuItem.Visible = false;
            dELETEROOMToolStripMenuItem.Visible = false;

            nameEmployeeToolStripMenuItem1.Visible = false;
            idToolStripMenuItem.Visible = false;
            numberToolStripMenuItem.Visible = false;
            priceToolStripMenuItem.Visible = false;
            statusToolStripMenuItem.Visible = false;

            //set menu strip buttons for client
            addClientToolStripMenuItem.Visible = true;
            deleteClientToolStripMenuItem.Visible = true;
            deleteCheckOutToolStripMenuItem.Visible = true;
            nameToolStripMenuItem.Visible = true;
            surnameToolStripMenuItem.Visible = true;
            roomNumberToolStripMenuItem.Visible = true;
            dataCheckInToolStripMenuItem.Visible = true;
            //
            //table
            //
            clients.Sort(new CmprtClientsByName());

            dataTable.Clear();
            dataTable.Columns.Clear();

            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Surname", typeof(string));
            dataTable.Columns.Add("Phone", typeof(string));
            dataTable.Columns.Add("Room Number", typeof(int));
            dataTable.Columns.Add("Data Check In", typeof(DateTime));
            dataTable.Columns.Add("Data Check Out", typeof(DateTime));

            //add data to table
            foreach (var client in clients)
            {
                dataTable.Rows.Add(
                    client.Name,
                    client.Surname,
                    client.Phone,
                    client.RoomNumber,
                    client.CheckInDate,
                    client.CheckOutDate
                );
            }
            dgBookingChange.DataSource = dataTable;

            //create columns for sort tool strip
            List<string> sortValuesClient = new List<string> { "Name", "Surname", "Room Number", "Data Check In" };
            ts_cbSort.Items.Clear();
            ts_cbSort.Items.AddRange(sortValuesClient.ToArray());
            ts_cbSort.SelectedIndex = 0;
        }
        private void dataEmployee()
        {
            title.Text = "Employee Info";
            employee = true;
            room = false;
            client = false;
            //
            //menu strip buttons
            //
            employeeToolStripMenuItem.Enabled = false;
            employeeToolStripMenuItem.ForeColor = Color.FromArgb(192, 192, 255);
            clientToolStripMenuItem.Enabled = true;
            clientToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            roomToolStripMenuItem.Enabled = true;
            roomToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);

            addClientToolStripMenuItem.Visible = false;
            deleteClientToolStripMenuItem.Visible = false;
            deleteCheckOutToolStripMenuItem.Visible = false;
            aDDROOMToolStripMenuItem.Visible = false;
            dELETEROOMToolStripMenuItem.Visible = false;
            dataCheckInToolStripMenuItem.Visible = false;

            nameToolStripMenuItem.Visible = false;
            surnameToolStripMenuItem.Visible = false;
            roomNumberToolStripMenuItem.Visible = false;
            numberToolStripMenuItem.Visible = false;
            priceToolStripMenuItem.Visible = false;
            statusToolStripMenuItem.Visible = false;

            //set menu strip buttons for employee
            aDDEMPLOYEEToolStripMenuItem.Visible = true;
            dELETEEMPLOYEEToolStripMenuItem.Visible = true;
            nameEmployeeToolStripMenuItem1.Visible = true;
            idToolStripMenuItem.Visible = true;
            //
            //table
            //
            employees.Sort(new CmprtEmployeesByName());

            dataTable.Clear();
            dataTable.Columns.Clear();

            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Id", typeof(string));
            dataTable.Columns.Add("Password", typeof(string));

            foreach (var employee in hotel.Employees)
            {
                dataTable.Rows.Add(employee.Name, employee.Id, employee.Password);
            }
            dgBookingChange.DataSource = dataTable;

            //create columns for sort tool strip
            List<string> sortValuesEmployee = new List<string> { "Name", "Id" };
            ts_cbSort.Items.Clear();
            ts_cbSort.Items.AddRange(sortValuesEmployee.ToArray());
            ts_cbSort.SelectedIndex = 0;
        }
        private void dataRoom()
        {
            title.Text = "Room Info";
            room = true;
            client = false;
            employee = false;
            //
            //menu strip buttons
            //
            roomToolStripMenuItem.Enabled = false;
            roomToolStripMenuItem.ForeColor = Color.FromArgb(192, 192, 255);
            employeeToolStripMenuItem.Enabled = true;
            employeeToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            clientToolStripMenuItem.Enabled = true;
            clientToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);

            addClientToolStripMenuItem.Visible = false;
            deleteClientToolStripMenuItem.Visible = false;
            deleteCheckOutToolStripMenuItem.Visible = false;
            aDDEMPLOYEEToolStripMenuItem.Visible = false;
            dELETEEMPLOYEEToolStripMenuItem.Visible = false;

            nameToolStripMenuItem.Visible = false;
            surnameToolStripMenuItem.Visible = false;
            roomNumberToolStripMenuItem.Visible = false;
            nameEmployeeToolStripMenuItem1.Visible = false;
            idToolStripMenuItem.Visible = false;

            //set menu strip buttons for room
            aDDROOMToolStripMenuItem.Visible = true;
            dELETEROOMToolStripMenuItem.Visible = true;
            numberToolStripMenuItem.Visible = true;
            priceToolStripMenuItem.Visible = true;
            statusToolStripMenuItem.Visible = true;
            //
            //table
            //
            dataTable.Clear();
            dataTable.Columns.Clear();

            dataTable.Columns.Add("Room Number", typeof(int));
            dataTable.Columns.Add("Room Type", typeof(string));
            dataTable.Columns.Add("Price", typeof(decimal));
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns[3].ReadOnly = true; //make status column read only

            rooms.Sort(new CmprtRoomsByNumber());

            foreach (var room in rooms)
            {
                if (room.IsFree)
                {
                    dataTable.Rows.Add(room.RoomNumber, room.Type, room.Price, "Free");
                }
                else
                {
                    dataTable.Rows.Add(room.RoomNumber, room.Type, room.Price, "Busy");
                }
            }

            //create columns for sort tool strip
            List<string> sortValuesRoom = new List<string> { "Room Number", "Price", "Status" };
            ts_cbSort.Items.Clear();
            ts_cbSort.Items.AddRange(sortValuesRoom.ToArray());
            ts_cbSort.SelectedIndex = 0;
        }
        private void Exit() //close the form
        {
            this.Close();
            if (isAdmin)
            {
                fAdmin fManager = new fAdmin(true);
                fManager.Show();
            }
            else
            {
                fAdmin fManager = new fAdmin(false);
                fManager.Show();
            }
        }
        private void fChangeClient_Load(object sender, EventArgs e)
        {
            if (!isAdmin)
            {
                openMenuStripItem.Visible = false;
            }

            dataClient();

            ts_cbSort.SelectedIndexChanged += ts_cbSort_SelectedIndexChanged;
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            string message = "Do you save changed info? Information will be lost.";
            string title = "Close Window";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                //save changes
                saveToolStripMenuItem_Click(sender, e);
                Exit();
            }
            else
            {
                //just close the form
                Exit();
            }
        }
        //
        // MENU STRIP BUTTONS WINDOW
        //
        private void hideToolStripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = false;

            dgBookingChange.Location = new Point(x, 120);
            dgBookingChange.Size = new Size(sizeX, sizeY + 50);

            showToolStripToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            showToolStripToolStripMenuItem.Enabled = true;

            hideToolStripToolStripMenuItem.ForeColor = Color.FromArgb(192, 192, 255);
            hideToolStripToolStripMenuItem.Enabled = false;
        }
        private void showToolStripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = true;
            dgBookingChange.Location = new Point(x, y);
            dgBookingChange.Size = new Size(sizeX, sizeY);

            hideToolStripToolStripMenuItem.ForeColor = Color.FromArgb(3, 37, 140);
            hideToolStripToolStripMenuItem.Enabled = true;

            showToolStripToolStripMenuItem.ForeColor = Color.FromArgb(192, 192, 255);
            showToolStripToolStripMenuItem.Enabled = false;
        }
        //
        // MENU STRIP BUTTONS FILE-OPEN
        //
        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Do you save changed info? Information will be lost.";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                saveToolStripMenuItem_Click(sender, e);
            }
            dataClient();
        }
        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Do you save changed info? Information will be lost.";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                saveToolStripMenuItem_Click(sender, e);
            }
            dataEmployee();
        }
        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Do you save changed info? Information will be lost.";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                saveToolStripMenuItem_Click(sender, e);
            }
            dataRoom();
        }
        //
        // MENU STRIP buttons Edit-Client
        //
        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Add("NewClient", "NewSurname", "000 000 00 00", 100, DateTime.Now, DateTime.Now.AddDays(1));
        }
        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgBookingChange.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgBookingChange.SelectedRows)
                {
                    dgBookingChange.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                MessageBox.Show("Select a row to delete.");
            }
        }
        //
        // MENU STRIP buttons Edit-Employee
        //
        private void aDDEMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Add("NewEmployee", "NewId", "NewPassword");
        }
        private void dELETEEMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgBookingChange.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgBookingChange.SelectedRows)
                {
                    dgBookingChange.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                MessageBox.Show("Select a row to delete.");
            }
        }
        //
        //  MENU STRIP buttons Edit-Room
        //
        private void aDDROOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num = 100;
            foreach (var room in rooms)
            {
                num++;
            }
            dataTable.Rows.Add(num, roomsType[0], 100, "Free");
        }
        private void dELETEROOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgBookingChange.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgBookingChange.SelectedRows)
                {
                    dgBookingChange.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                MessageBox.Show("Select a row to delete.");
            }
        }
        //
        // MENU STRIP buttons Sort-Client
        //
        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            clients.Sort(new CmprtClientsByName());
            foreach (var client in clients)
            {
                dataTable.Rows.Add(
                  client.Name,
                  client.Surname,
                  client.Phone,
                  client.RoomNumber,
                  client.CheckInDate,
                  client.CheckOutDate
                );
            }
        }
        private void surnameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            clients.Sort(new CmprtClientsBySurname());
            foreach (var client in clients)
            {
                dataTable.Rows.Add(
                  client.Name,
                  client.Surname,
                  client.Phone,
                  client.RoomNumber,
                  client.CheckInDate,
                  client.CheckOutDate
                );
            }
        }
        private void roomNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            clients.Sort(new CmprtClientsByRoomNumber());
            foreach (var client in clients)
            {
                dataTable.Rows.Add(
                  client.Name,
                  client.Surname,
                  client.Phone,
                  client.RoomNumber,
                  client.CheckInDate,
                  client.CheckOutDate
                );
            }
        }
        private void dataCheckInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            clients.Sort(new CmprtClientsByCheckInDate());
            foreach (var client in clients)
            {
                dataTable.Rows.Add(
                  client.Name,
                  client.Surname,
                  client.Phone,
                  client.RoomNumber,
                  client.CheckInDate,
                  client.CheckOutDate
                );
            }
        }
        //
        // MENU STRIP buttons Sort-Employee
        //
        private void nameEmployeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            employees.Sort(new CmprtEmployeesByName());
            foreach (var employee in employees)
            {
                dataTable.Rows.Add(employee.Name, employee.Id, employee.Password);
            }
        }
        private void idToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            employees.Sort(new CmprtEmployeesById());
            foreach (var employee in employees)
            {
                dataTable.Rows.Add(employee.Name, employee.Id, employee.Password);
            }
        }
        //
        // MENU STRIP buttons Sort-Room
        //
        private void numberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            rooms.Sort(new CmprtRoomsByNumber());
            foreach (var room in rooms)
            {
                if (room.IsFree)
                {
                    dataTable.Rows.Add(room.RoomNumber, room.Type, room.Price, "Free");
                }
                else
                {
                    dataTable.Rows.Add(room.RoomNumber, room.Type, room.Price, "Busy");
                }
            }
        }
        private void priceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            rooms.Sort(new CmprtRoomsByPrice());
            foreach (var room in rooms)
            {
                if (room.IsFree)
                {
                    dataTable.Rows.Add(room.RoomNumber, room.Type, room.Price, "Free");
                }
                else
                {
                    dataTable.Rows.Add(room.RoomNumber, room.Type, room.Price, "Busy");
                }
            }
        }
        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            rooms.Sort(new CmprtRoomsByAvailability());
            foreach (var room in rooms)
            {
                if (room.IsFree)
                {
                    dataTable.Rows.Add(room.RoomNumber, room.Type, room.Price, "Free");
                }
                else
                {
                    dataTable.Rows.Add(room.RoomNumber, room.Type, room.Price, "Busy");
                }
            }
        }
        //
        // Save methods
        //
        private void SaveClients()
        {
            foreach (DataGridViewRow row in dgBookingChange.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells[3].Value == null || !int.TryParse(row.Cells[3].Value.ToString(), out int roomNumber))
                {
                    MessageBox.Show("Invalid Room Number in row " + (row.Index + 1), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (row.Cells[4].Value == null || !DateTime.TryParse(row.Cells[4].Value.ToString(), out DateTime checkInDate) || checkInDate < DateTime.Now)
                {
                    MessageBox.Show("Check-In date cannot be in the past or empty in row " + (row.Index + 1), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (row.Cells[5].Value == null || !DateTime.TryParse(row.Cells[5].Value.ToString(), out DateTime checkOutDate) || checkOutDate <= checkInDate)
                {
                    MessageBox.Show("Check-Out date must be after Check-In date in row " + (row.Index + 1), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                for (int col = 0; col <= 2; col++)
                {
                    if (row.Cells[col].Value == null || string.IsNullOrWhiteSpace(row.Cells[col].Value.ToString()))
                    {
                        MessageBox.Show("Please fill all fields before saving. Row: " + (row.Index + 1), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            hotel.Clients.Clear();

            for (int i = 0; i < dgBookingChange.Rows.Count - 1; i++)
            {
                if (dgBookingChange.Rows[i].IsNewRow) continue;

                Client client = new Client
                {
                    Name = dgBookingChange.Rows[i].Cells[0].Value?.ToString(),
                    Surname = dgBookingChange.Rows[i].Cells[1].Value?.ToString(),
                    Phone = dgBookingChange.Rows[i].Cells[2].Value?.ToString(),
                    RoomNumber = Convert.ToInt32(dgBookingChange.Rows[i].Cells[3].Value),
                    CheckInDate = DateTime.Parse(dgBookingChange.Rows[i].Cells[4].Value?.ToString()),
                    CheckOutDate = DateTime.Parse(dgBookingChange.Rows[i].Cells[5].Value?.ToString())
                };

                hotel.AddClient(client, hotel);
            }

            hotel.DeleteFileInfo();
            hotel.SaveToFile();
        }

        private void SaveEmployees()
        {
            foreach (DataGridViewRow row in dgBookingChange.Rows)
            {
                if (string.IsNullOrWhiteSpace(row.Cells[0].Value.ToString()) ||
                    string.IsNullOrWhiteSpace(row.Cells[1].Value.ToString()) ||
                    string.IsNullOrWhiteSpace(row.Cells[2].Value.ToString()))
                {
                    MessageBox.Show("Please fill all fields before saving. Row: " + (row.Index + 1), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            hotel.Employees.Clear();

            for (int i = 0; i < dgBookingChange.Rows.Count - 1; i++)
            {
                Employee employee = new Employee();
                employee.Name = (string)dgBookingChange.Rows[i].Cells[0].Value;
                employee.Id = (string)dgBookingChange.Rows[i].Cells[1].Value;
                employee.Password = (string)dgBookingChange.Rows[i].Cells[2].Value;
                hotel.Employees.Add(employee);
            }

            hotel.DeleteFileInfo();
            hotel.SaveToFile();
        }
        private void SaveRoom()
        {
            foreach (DataGridViewRow row in dgBookingChange.Rows)
            {
                if (!int.TryParse(row.Cells[0].Value.ToString(), out int roomNumber))
                {
                    MessageBox.Show("Invalid Room Number in row " + (row.Index + 1), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(row.Cells[1].Value.ToString()) ||
                    string.IsNullOrWhiteSpace(row.Cells[3].Value.ToString()))
                {
                    MessageBox.Show("Please fill all fields before saving. Row: " + (row.Index + 1), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!decimal.TryParse(row.Cells[2].Value.ToString(), out decimal price) || price < 0)
                {
                    MessageBox.Show("Invalid Price in row " + (row.Index + 1), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int roomNumberEx = Convert.ToInt32(row.Cells[0].Value);
                if (hotel.Rooms.Any(r => r.RoomNumber == roomNumberEx))
                {
                    MessageBox.Show($"Room Number {roomNumberEx} already exists!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            hotel.Rooms.Clear();

            for (int i = 0; i < dgBookingChange.Rows.Count; i++)
            {
                Room room = new Room();
                room.RoomNumber = Convert.ToInt32(dgBookingChange.Rows[i].Cells[0].Value);
                room.Type = (string)dgBookingChange.Rows[i].Cells[1].Value;
                room.Price = Convert.ToDecimal(dgBookingChange.Rows[i].Cells[2].Value);
                if ((string)dgBookingChange.Rows[i].Cells[3].Value == "Free")
                {
                    room.SetFree();
                }
                else
                {
                    room.SetBusy();
                }
                hotel.Rooms.Add(room);
            }

            hotel.DeleteFileInfo();
            hotel.SaveToFile();
        }
        //
        // MENU STRIP buttons File-Save
        //
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(client)
            {
                SaveClients();
            }
            else if (employee)
            {
                SaveEmployees();
            }
            else if (room)
            {
                SaveRoom();
            }
        }
        //
        // TOOL STRIP buttons
        //
        private void ts_btnAdd_Click(object sender, EventArgs e)
        {
            if(client)
            {
                addClientToolStripMenuItem_Click(sender, e);
            }
            else if (employee)
            {
                aDDEMPLOYEEToolStripMenuItem_Click(sender, e);
            }
            else if (room)
            {
                aDDROOMToolStripMenuItem_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        private void ts_cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (client)
            {
                switch (ts_cbSort.SelectedItem.ToString())
                {
                    case "Name":
                        nameToolStripMenuItem_Click(sender, e);
                        break;
                    case "Surname":
                        surnameToolStripMenuItem_Click(sender, e);
                        break;
                    case "Room Number":
                        roomNumberToolStripMenuItem_Click(sender, e);
                        break;
                    case "Data Check In":
                        dataCheckInToolStripMenuItem_Click(sender, e);
                        break;
                }
            }
            else if (employee)
            {
                switch (ts_cbSort.SelectedItem.ToString())
                {
                    case "Name":
                        nameEmployeeToolStripMenuItem1_Click(sender, e);
                        break;
                    case "Id":
                        idToolStripMenuItem_Click(sender, e);
                        break;
                }
            }
            else if (room)
            {
                switch (ts_cbSort.SelectedItem.ToString())
                {
                    case "Room Number":
                        numberToolStripMenuItem_Click(sender, e);
                        break;
                    case "Price":
                        priceToolStripMenuItem_Click(sender, e);
                        break;
                    case "Status":
                        statusToolStripMenuItem_Click(sender, e);
                        break;
                }
            }
        }
        //
        // MENU STRIP buttons File-Exit
        private void saveAsMenuStripItem_Click(object sender, EventArgs e) //save file to pc
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveFileDialog.Title = "Save JSON file";
                saveFileDialog.FileName = "HotelData.json";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    File.WriteAllText(filePath, "{ \"example\": true }");
                    MessageBox.Show("File JSON has been saved:", "All clear!");
                }
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e) //open file from pc
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.Title = "Open JSON file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string jsonContent = File.ReadAllText(filePath);
                    MessageBox.Show("File JSON umpload:\n" + jsonContent, "All clear!");
                }
            }
        }
        private void copyMenuStripItem_Click(object sender, EventArgs e) //save copy
        {
            string basePath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "Files");
            string filePathHotel = Path.Combine(basePath, "HotelDataCopy.json");

            Hotel hotel = new Hotel();

            if (File.Exists(filePathHotel))
            {
                string hotelJson = File.ReadAllText(filePathHotel).Trim();
                if (!string.IsNullOrWhiteSpace(hotelJson))
                {
                    hotel = JsonConvert.DeserializeObject<Hotel>(hotelJson) ?? new Hotel();
                }
            }
            else
            {
                MessageBox.Show("File not found");
            }
        }
        private void copyOpenMenuStripMenuItem_Click(object sender, EventArgs e) //open copy
        {
            string basePath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "Files");
            string filePathHotel = Path.Combine(basePath, "HotelDataCopy.json");
            if (File.Exists(filePathHotel))
            {
                File.WriteAllText(filePathHotel, string.Empty);
                string hotelJson = JsonConvert.SerializeObject(this, Formatting.Indented);
                File.WriteAllText(filePathHotel, hotelJson);
            }
            else
            {
                MessageBox.Show("File not found");
            }
        }
        //
        // Context menu strip
        //
        private void toolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            if (client)
            {
                addClientToolStripMenuItem_Click(sender, e);
            }
            else if (employee)
            {
                aDDEMPLOYEEToolStripMenuItem_Click(sender, e);
            }
            else if (room)
            {
                aDDROOMToolStripMenuItem_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            if (client)
            {
                deleteClientToolStripMenuItem_Click(sender, e);
            }
            else if (employee)
            {
                dELETEEMPLOYEEToolStripMenuItem_Click(sender, e);
            }
            else if (room)
            {
                dELETEROOMToolStripMenuItem_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }
    }
}