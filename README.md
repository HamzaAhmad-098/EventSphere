# 📊 ITECManagementSystem

A complete **ITEC Event Management System** developed in **C# (.NET 8)** using **Windows Forms** and **MySQL**, designed to handle events, users, committees, sponsors, finance tracking, and reporting for academic and professional institutes.

---

## 🧠 Project Summary

This desktop-based application allows administrators to:
- Register events and participants.
- Assign committee roles.
- Handle sponsors, vendors, and financial transactions.
- Generate automated reports.
- Implement user-based role access (admin vs normal users).

---

## 🚀 Features

✅ Event & Category Management  
✅ Participant Registration  
✅ Committee Role Assignment  
✅ Finance & Budget Management  
✅ Sponsor and Vendor Handling  
✅ Automatic PDF Report Generation (iTextSharp)  
✅ Role-Based Authentication (Admin & Regular Users)  
✅ Clean UI with organized layers (UI, BL, DL, Models)  

---

## 🧱 Project Structure
```text
ITECManagementSystem/
│
├── .vs/ # Visual Studio config
├── BL/ # Business Logic Layer
├── DL/ # Data Access Layer
├── Models/ # Data Models
├── Properties/ # App configurations
├── UI/ # Windows Forms UI
├── bin/Debug/net8.0-windows/ # Compiled binaries
├── obj/ # Build objects
├── resources/ # Images, assets, etc.
│
├── ITECManagementSystem.csproj # Project file
├── ITECManagementSystem.sln # Solution file
├── Program.cs # Main entry point
├── M1.txt.txt # Initial notes
├── Project Report.docx # Full documentation
├── Project Report.pdf # Exported PDF report

```
---

## 🧪 Technologies Used

| Tech Stack       | Description                        |
|------------------|------------------------------------|
| C# (WinForms)    | Desktop GUI & logic                |
| MySQL            | Relational Database                |
| OOP              | Three tier Architecture(UI,BL,DL)  |
| iTextSharp       | PDF report generation              |
| ADO.NET          | Database connection & CRUD         |
| .NET 8           | Runtime framework                  |

---

## ⚙️ Setup Instructions

### Prerequisites
- Visual Studio 2022+
- MySQL Server & MySQL Workbench
- .NET 8 SDK

### Clone & Run

```bash
git clone https://github.com/YourUsername/ITECManagementSystem.git
cd ITECManagementSystem
```
1. Open the .sln file in Visual Studio.
2. Restore NuGet packages if not auto-restored.
3. Create the MySQL database (script provided in project requirements in the same repo ).
4. Update your DB connection string in the DL layer.
5. 
Build and run the project.

📄 Reports
Reports are auto-generated using iTextSharp as PDFs:
1. Participant List
2. Event Budgets
3. Sponsor Contributions
4. Vendor Expenses
   
Summary Finance Sheets

📚 Documentation
Full project documentation available in:

📄 Project Report.docx

📄 Project Report.pdf

These include:

ERD (Entity Relationship Diagram)
Module Descriptions
DB Schema
UI Screenshots

🙋‍♂️ Author
Hamza Ahmad
📘 BS Computer Science (2nd Year)

📍 UET Lahore

✉️ GitHub: HamzaAhmad-098

🌐 Future Improvements

Switch to .NET MAUI for cross-platform

Cloud MySQL hosting support

Event Notifications (Email/SMS)

Role-based analytics dashboard

⭐ Why This Project Matters
This project showcases real-world database integration, user management, role-based access control, UI design, and layered software architecture — all highly valuable for roles like:

1. Software Engineer
2. Backend Developer
3. Full Stack Developer
4. .NET Developer
## 📫 Contact

If you’d like to reach out or collaborate:

- 📧 Email: [jhajji1223@gmail.com](mailto:jhajji1223@gmail.com)
- 🌐 Portfolio: [https://portfolio.hamzaxdevelopers.dpdns.org](https://portfolio.hamzaxdevelopers.dpdns.org) 

📌 License
This project is for educational use. All rights reserved.



