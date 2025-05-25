namespace CurseWork
{
    public partial class fAdmin : Form
    {
        private Hotel hotel = Hotel.LoadFromFile();
        public bool isAdmin;
        public fAdmin(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;

            //set gif like background  
            string basePath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "Media");
            string gifPath = Path.Combine(basePath, "mob100.gif");
            if (File.Exists(gifPath))
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = null;
                pictureBox1.Image = Image.FromFile(gifPath);
            }
            else
            {
                MessageBox.Show("GIF файл не знайдено");
            }
        }
        private void btnChangeBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            fChangeInformation fChangeClient = new fChangeInformation();
            fChangeClient.isAdmin = isAdmin;
            fChangeClient.Show();
        }
        private void btnHotelInfo_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                this.Hide();
                fChangeHotel changeHotel = new fChangeHotel(true);
                changeHotel.Show();
            }
            else
            {
                fChangeHotel showHotel = new fChangeHotel(false);
                showHotel.Show();
            }
            this.Hide();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAddBooking fAddBooking = new fAddBooking();
            fAddBooking.Show();
        }
        private void btnSearchBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (isAdmin)
            {
                fSearchBooking fSearchBooking = new fSearchBooking(true);
                fSearchBooking.Show();
            }
            else
            {
                fSearchBooking fSearchBooking = new fSearchBooking(false);
                fSearchBooking.Show();
            }
        }
    }
}
