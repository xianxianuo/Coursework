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
            string filePath2 = Path.Combine(folderPath, "HotelDataCopy.json");

            string content = File.ReadAllText(filePath);
            string content2 = File.ReadAllText(filePath2);

            if (File.Exists(filePath))
            {
                if (string.IsNullOrWhiteSpace(content))
                {
                    Application.Run(new fAddHotel());
                }
                else
                {
                    MessageBox.Show("Hotel data loaded!", "File checking", MessageBoxButtons.OK);
                    File.Copy(filePath, filePath2, true);
                    Application.Run(new fLogin());
                }
            }
            else
            {
                if (Directory.Exists(filePath2))
                {
                    if (string.IsNullOrWhiteSpace(content2))
                    {
                        Application.Run(new fAddHotel());
                    }
                    else
                    {
                        File.Copy(filePath2, filePath, true);
                        MessageBox.Show("Hotel data loaded!", "File checking", MessageBoxButtons.OK);
                        Application.Run(new fLogin());
                    }
                }
                else
                {
                    MessageBox.Show("Hotel data not found!", "File checking", MessageBoxButtons.OK);
                }
            }
        }
    }
}
