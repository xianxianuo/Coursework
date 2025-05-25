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
