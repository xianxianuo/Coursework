
# CurseWork

**CurseWork** is a desktop hotel management database application created for educational purposes.

## 📁 About the Project

This application allows you to:
- Add a new hotel with parameters (floors, rooms, etc.)
- Manage clients (add, edit, delete)
- Change room statuses
- Register employees
- Search by various parameters
- Serialize/deserialize data into `.json`

## 🧩 Technologies
- 💻 Windows Forms (WinForms)
- 📦 .NET Framework
- 📁 JSON files for data storage
- 🗃️ Basic staff authorization system

## 🏗️ Architecture

### Classes

- **Hotel** — hotel management, search, client operations, serialization
- **Client** — stores client data (name, dates, room)
- **Room** — stores room info (number, type, price, availability)

### Forms (UI)

- Add a hotel
- Edit room and employee info
- Admin menu
- Add and search bookings
- Login system

## 🚀 Getting Started

### Requirements
- Windows OS
- .NET Framework
- Visual Studio

### Steps
1. Clone the repository:
   ```bash
   git clone https://github.com/your_username/CurseWork.git
   ```
2. Open the solution in Visual Studio.
3. Create a folder named `Files` in the root directory.
4. Run the application. It will launch `fAddHotel` or `fLogin` based on the data file.

## 🧪 Data Structure

All data is stored in `Files/HotelData.json`. A backup is saved to `HotelDataCopy.json`.

## 🎨 UI Design

- [Figma Design](https://www.figma.com/design/QhgHXYlr5ERLbTDjDJJO0t/CurseDataBase?node-id=0-1&t=7jpApCCQDGGDDM0h-1) by xian xian
- [Design Inspiration](https://aconfuseddragon.neocities.org/) by aconfuseddragon

## 📬 Feedback

Want to help or share ideas? Contact me:
- **Discord:** `xian_xian_li` (`1001785919482888193`)

## 🤝 Contributing

Pull requests are welcome! Fork the repo, make changes, and submit a PR with a clear description.
- **Issues:** If you find a bug or have a feature request, please open an issue in the repository.
- **Contributors:** If you want to contribute, please fork the repository and create a pull request.
- **License:** This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
- **Support:** You can donate to support the project via [Monobank](https://monobank.ua/) using the jar https://send.monobank.ua/jar/9tsXkSkkdJ. Thank you for your support!

## 🧑‍💼 How to Use

### First Launch
When you start the program for the first time, you'll be prompted to fill out all hotel information.

### Logging In
- To log in as a **manager**, use the default credentials:
  - **Username:** `master`
  - **Password:** `master`
- These can be changed in the file `fLogin.cs`, around line 60:
  ```csharp
  if (login == "master" && password == "master")
  {
      this.Hide();
      fAdmin admin = new fAdmin(true); // Admin mode
      admin.ShowDialog();
      return;
  }
  ```

### Employee Passwords
All other employee passwords are stored in the `Files/HotelData.json` file.

### File Handling on Startup
Every time the application launches:
- The data file `HotelData.json` is copied to `HotelDataCopy.json` as a backup.

### Customizing File Loading
To use a different data file:
1. Place your file in the `Files` folder.
2. Modify the filename in the `Program.cs` file (around line 16):
   ```csharp
   string filePath = Path.Combine(folderPath, "HotelData.json");
   ```

You can also adjust the file path itself:
```csharp
string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
string folderPath = Path.Combine(projectDirectory, "Files");
string filePath = Path.Combine(folderPath, "HotelData.json");
```