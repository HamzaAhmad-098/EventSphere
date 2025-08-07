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
