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
Open the .sln file in Visual Studio.

Restore NuGet packages if not auto-restored.

Create the MySQL database (script provided in resources/ if applicable).

Update your DB connection string in the DL layer.

Build and run the project.

🧑‍💼 Roles
Admin: Can manage events, users, finances, sponsors, vendors, and view reports.

User: Can register for events and view their own data only.

📄 Reports
Reports are auto-generated using iTextSharp as PDFs:

Participant List

Event Budgets

Sponsor Contributions

Vendor Expenses

Summary Finance Sheets

📚 Documentation
Full project documentation available in:

📄 Project Report.docx

📄 Project Report.pdf

These include:

ERD (Entity Relationship Diagram)

Flowcharts

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

Add login authentication via OAuth

Cloud MySQL hosting support

Event Notifications (Email/SMS)

Role-based analytics dashboard

⭐ Why This Project Matters
This project showcases real-world database integration, user management, role-based access control, UI design, and layered software architecture — all highly valuable for roles like:

Software Engineer

Backend Developer

Full Stack Developer

.NET Developer

Technical Intern (Europe/US/UK remote)

📌 License
This project is for educational use. All rights reserved.

yaml
Copy
Edit

---

Let me know if you'd like me to:

- **Add screenshots** to the README  
- **Generate a PDF version**  
- **Add database schema creation script**  
- **Include GitHub badges (stars, forks, etc.)**

Would you like me to upload the `README.md` file for you now?
