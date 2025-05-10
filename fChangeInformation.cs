using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace CurseWork
{
    public partial class fChangeInformation : Form
    {
        //create object hotel
        private Hotel hotel = Hotel.LoadFromFile();
        private List<Client> clients;
        private List<Room> rooms;
        private List<Employee> employee;
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
        private DataTable searchDataTable = new DataTable();
        private bool isSearch = false;
        private string searchValue = "";
        private bool isSave = false;

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
            employee = hotel.Employees;

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
            isSave = false;
            this.Name = "fChangeClient";
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
            isSave = false;
            this.Name = "fChangeEmployee";
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
            employee.Sort(new CmprtEmployeesByName());

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
            isSave = false;
            this.Name = "fChangeRoom";
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
                fManager.ShowDialog();
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
            switch (this.Name)
            {
                case "fChangeClient":
                    dataClient();
                    break;
                case "fChangeEmployee":
                    dataEmployee();
                    break;
                case "fChangeRoom":
                    dataRoom();
                    break;
                default:
                    dataClient();
                    break;
            }
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
            if (!isSave)
            {
                string message = "Do you save changed info? Information will be lost.";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                    isSave = false;
                }
                dataClient();
            }
            else
            {
                dataClient();
            }
        }
        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSave)
            {
                string message = "Do you save changed info? Information will be lost.";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                    isSave = false;
                }
                dataEmployee();
            }
            else
            {
                dataEmployee();
            }
        }
        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSave)
            {
                string message = "Do you save changed info? Information will be lost.";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                    isSave = false;
                }
                dataRoom();
            }
            else
            {
                dataRoom();
            }
        }
        //
        // MENU STRIP buttons Edit-Client
        //
        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Add("NewClient", "NewSurname", 0, DateTime.Now, DateTime.Now.AddDays(1));
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
            employee.Sort(new CmprtEmployeesByName());
            foreach (var employee in employee)
            {
                dataTable.Rows.Add(employee.Name, employee.Id, employee.Password);
            }
        }
        private void idToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            employee.Sort(new CmprtEmployeesById());
            foreach (var employee in employee)
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
            if (this.Name == "fChangeClient")
            {
                if (!isSearch)
                {
                    hotel.Clients.Clear();
                    foreach (DataGridViewRow r in dgBookingChange.Rows)
                    {
                        if (r.IsNewRow) continue;
                        if (r.Cells["Room Number"].Value == null ||
                            r.Cells["Check In"].Value == null ||
                            r.Cells["Check Out"].Value == null ||
                            string.IsNullOrWhiteSpace(r.Cells["Name"].Value?.ToString()) ||
                            string.IsNullOrWhiteSpace(r.Cells["Surname"].Value?.ToString()) ||
                            string.IsNullOrWhiteSpace(r.Cells["Phone"].Value?.ToString()))
                        {
                            MessageBox.Show("Fill all fields");
                            return;
                        }
                        foreach (var room in hotel.Rooms)
                        {
                            if (Convert.ToInt32(r.Cells["Room Number"].Value) != room.RoomNumber)
                            {
                                MessageBox.Show("Room not found");
                                return;
                            }
                        }

                        hotel.Clients.Add(new Client
                        {
                            Name = r.Cells["Name"].Value as string,
                            Surname = r.Cells["Surname"].Value as string,
                            Phone = r.Cells["Phone"].Value as string,
                            CheckInDate = (DateTime)r.Cells["Data Check In"].Value,
                            CheckOutDate = (DateTime)r.Cells["Data Check Out"].Value,
                            RoomNumber = Convert.ToInt32(r.Cells["Room Number"].Value)
                        });

                        foreach (var room in hotel.Rooms)
                        {
                            if (Convert.ToInt32(r.Cells["Room Number"].Value) == room.RoomNumber)
                            {
                                room.SetBusy();
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < dgBookingChange.Rows.Count; i++)
                    {
                        var r = dgBookingChange.Rows[i];
                        if (r.IsNewRow || i >= hotel.Clients.Count) break;
                        var cli = hotel.Clients[i];

                        if (r.Cells["Room Number"].Value == null ||
                            r.Cells["Check In"].Value == null ||
                            r.Cells["Check Out"].Value == null ||
                            string.IsNullOrWhiteSpace(r.Cells["Name"].Value?.ToString()) ||
                            string.IsNullOrWhiteSpace(r.Cells["Surname"].Value?.ToString()) ||
                            string.IsNullOrWhiteSpace(r.Cells["Phone"].Value?.ToString()))
                        {
                            MessageBox.Show("Fill all fields");
                            return;
                        }


                        cli.Name = r.Cells["Name"].Value as string;
                        cli.Surname = r.Cells["Surname"].Value as string;
                        cli.RoomNumber = Convert.ToInt32(r.Cells["Room Number"].Value);
                        cli.CheckInDate = (DateTime)r.Cells["Data Check In"].Value;
                        cli.CheckOutDate = (DateTime)r.Cells["Data Check Out"].Value;

                        foreach (var room in hotel.Rooms)
                        {
                            if (Convert.ToInt32(r.Cells["Room Number"].Value) != room.RoomNumber)
                            {
                                MessageBox.Show("Room not found");
                                return;
                            }
                        }

                        foreach (var room in hotel.Rooms)
                        {
                            if (Convert.ToInt32(r.Cells["Room Number"].Value) == room.RoomNumber)
                            {
                                room.SetBusy();
                            }
                        }
                    }

                }
            }
        }
        private void SaveEmployees()
        {
            if (!isSearch)
            {
                hotel.Employees.Clear();
                foreach (DataGridViewRow r in dgBookingChange.Rows)
                {
                    if (r.IsNewRow) continue;
                    if (string.IsNullOrEmpty(r.Cells["Name"].Value as string) || string.IsNullOrEmpty(r.Cells["Id"].Value as string) || string.IsNullOrEmpty(r.Cells["Password"].Value as string))
                    {
                        MessageBox.Show("Fill all fields");
                        return;
                    }
                    hotel.Employees.Add(new Employee
                    {
                        Name = r.Cells["Name"].Value as string,
                        Id = r.Cells["Id"].Value as string,
                        Password = r.Cells["Password"].Value as string
                    });
                }
            }
            else
            {
                for (int i = 0; i < dgBookingChange.Rows.Count; i++)
                {
                    if (string.IsNullOrEmpty(dgBookingChange.Rows[i].Cells["Name"].Value as string) || string.IsNullOrEmpty(dgBookingChange.Rows[i].Cells["Id"].Value as string) || string.IsNullOrEmpty(dgBookingChange.Rows[i].Cells["Password"].Value as string))
                    {
                        MessageBox.Show("Fill all fields");
                        return;
                    }

                    var r = dgBookingChange.Rows[i];
                    if (r.IsNewRow || i >= hotel.Employees.Count) break;
                    var emp = hotel.Employees[i];

                    emp.Name = r.Cells["Name"].Value as string;
                    emp.Id = r.Cells["Id"].Value as string;
                    emp.Password = r.Cells["Password"].Value as string;
                }
            }
        }
        private void SaveRoom()
        {
            if (!isSearch)
            {
                hotel.Rooms.Clear();
                foreach (DataGridViewRow r in dgBookingChange.Rows)
                {
                    if (r.IsNewRow) continue;
                    if (string.IsNullOrEmpty(r.Cells["Room Type"].Value as string) || string.IsNullOrEmpty(r.Cells["Price"].Value as string))
                    {
                        MessageBox.Show("Fill all fields");
                        return;
                    }
                    var room = new Room
                    {
                        RoomNumber = Convert.ToInt32(r.Cells["Room Number"].Value),
                        Type = r.Cells["Room Type"].Value as string,
                        Price = Convert.ToDecimal(r.Cells["Price"].Value)
                    };
                    if ((r.Cells["Status"].Value as string) == "Free") room.SetFree();
                    else room.SetBusy();
                    hotel.Rooms.Add(room);
                }
            }
            else
            {
                for (int i = 0; i < dgBookingChange.Rows.Count; i++)
                {
                    if (string.IsNullOrEmpty(dgBookingChange.Rows[i].Cells["Room Type"].Value as string) || string.IsNullOrEmpty(dgBookingChange.Rows[i].Cells["Price"].Value as string))
                    {
                        MessageBox.Show("Fill all fields");
                        return;
                    }

                    var r = dgBookingChange.Rows[i];
                    if (r.IsNewRow || i >= hotel.Rooms.Count) break;
                    var room = hotel.Rooms[i];

                    room.Type = r.Cells["Room Type"].Value as string;
                    room.Price = Convert.ToDecimal(r.Cells["Price"].Value);

                    if ((r.Cells["Status"].Value as string) == "Free") room.SetFree();
                    else room.SetBusy();
                }
            }
        }
        //
        // MENU STRIP buttons File-Save
        //
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (this.Name)
            {
                case "fChangeClient":
                    SaveClients();
                    isSave = true;
                    break;
                case "fChangeEmployee":
                    SaveEmployees();
                    isSave = true;
                    break;
                case "fChangeRoom":
                    SaveRoom();
                    isSave = true;
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }
            hotel.DeleteFileInfo();
            hotel.SaveToFile();

            isSearch = false;
            isSave = true;
            MessageBox.Show("Дані успішно збережено!");
        }
        //
        // TOOL STRIP buttons
        //
        private void ts_btnAdd_Click(object sender, EventArgs e)
        {
            switch (this.Name)
            {
                case "fChangeClient":
                    addClientToolStripMenuItem_Click(sender, e);
                    break;
                case "fChangeEmployee":
                    aDDEMPLOYEEToolStripMenuItem_Click(sender, e);
                    break;
                case "fChangeRoom":
                    aDDROOMToolStripMenuItem_Click(sender, e);
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }
        }
        private void ts_btnSearch_Click(object sender, EventArgs e)
        {
            searchValue = ts_tbSearch.Text;
            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Enter search value");
                return;
            }

            searchDataTable = dataTable.Clone();
            searchDataTable.Rows.Clear();

            switch (this.Name)
            {
                case "fChangeClient":
                    foreach (var client in clients)
                    {
                        if (client.Name == searchValue || client.Surname == searchValue)
                        {
                            searchDataTable.Rows.Add(
                                client.Name,
                                client.Surname,
                                client.Phone,
                                client.RoomNumber,
                                client.CheckInDate,
                                client.CheckOutDate
                            );
                        }
                    }
                    break;

                case "fChangeEmployee":
                    foreach (var emp in employee)
                    {
                        if (emp.Name == searchValue || emp.Id == searchValue)
                            searchDataTable.Rows.Add(emp.Name, emp.Id, emp.Password);
                    }
                    break;

                case "fChangeRoom":
                    foreach (var room in rooms)
                    {
                        if (room.RoomNumber.ToString() == searchValue || room.Type == searchValue)
                        {
                            searchDataTable.Rows.Add(
                                room.RoomNumber,
                                room.Type,
                                room.Price,
                                room.IsFree ? "Free" : "Busy"
                            );
                        }
                    }
                    break;
                default:
                    MessageBox.Show("Error");
                    return;
            }

            dgBookingChange.DataSource = searchDataTable;
            isSearch = true;
        }
        private void ts_btnBack_Click(object sender, EventArgs e)
        {
            string message = "Do you save changed info? Information will be lost.";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                saveToolStripMenuItem_Click(sender, e);
                isSave = false;
                isSearch = false;
                dgBookingChange.DataSource = dataTable;
            }
            else
            {
                dgBookingChange.DataSource = dataTable;
            }
        }
        private void ts_cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            var actionsByForm = new Dictionary<string, Action[]>
            {
                ["fChangeClient"] = new Action[]
                {
                    () => nameToolStripMenuItem_Click(sender, e),
                    () => surnameToolStripMenuItem_Click(sender, e),
                    () => roomNumberToolStripMenuItem_Click(sender, e),
                    () => dataCheckInToolStripMenuItem_Click(sender, e)
                },
                ["fChangeEmployee"] = new Action[]
                {
                    () => nameEmployeeToolStripMenuItem1_Click(sender, e),
                    () => idToolStripMenuItem_Click(sender, e)
                },
                ["fChangeRoom"] = new Action[]
                {
                    () => numberToolStripMenuItem_Click(sender, e),
                    () => priceToolStripMenuItem_Click(sender, e),
                    () => statusToolStripMenuItem_Click(sender, e)
                }
            };

            int selectedIndex = ts_cbSort.SelectedIndex;

            if (actionsByForm.TryGetValue(this.Name, out Action[] actions) && selectedIndex >= 0 && selectedIndex < actions.Length)
            {
                actions[selectedIndex]();
            }
            else
            {
                MessageBox.Show("Please select the correct option.");
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
            switch(this.Name)
            {
                case "fChangeClient":
                    addClientToolStripMenuItem_Click(sender, e);
                    break;
                case "fChangeEmployee":
                    aDDEMPLOYEEToolStripMenuItem_Click(sender, e);
                    break;
                case "fChangeRoom":
                    aDDROOMToolStripMenuItem_Click(sender, e);
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }
        }
        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            switch(this.Name)
            {
                case "fChangeClient":
                    deleteClientToolStripMenuItem_Click(sender, e);
                    break;
                case "fChangeEmployee":
                    dELETEEMPLOYEEToolStripMenuItem_Click(sender, e);
                    break;
                case "fChangeRoom":
                    dELETEROOMToolStripMenuItem_Click(sender, e);
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }
        }
        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }
    }
}