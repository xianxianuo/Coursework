using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CurseWork
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string folderPath = Path.Combine(projectDirectory, "Files");
            string filePath = Path.Combine(folderPath, "HotelData.json");

            string content = File.ReadAllText(filePath);

            if (File.Exists(filePath))
            {
                if (string.IsNullOrWhiteSpace(content))
                {
                    Application.Run(new fAddHotel());
                }
                else
                {
                    MessageBox.Show("Hotel data loaded!", "File checking", MessageBoxButtons.OK);
                    Application.Run(new fAdministration());
                }
            }
            else
            {
                MessageBox.Show("The file 'HotelData.json' does not exist. Please create the file first!", "File checking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
