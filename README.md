# Library Management System

## Introduction
   
The Library Management System is a comprehensive software solution designed to streamline and enhance the operations of libraries. This system is built using C# for the frontend and MySQL for the backend database. It offers a range of features to efficiently manage books, patrons, and library transactions.

## Features
 
- **Book Management:**
  - Add new books to the library catalog with details like title, author, genre, and ISBN.
  - Update book information, including availability status and location.
  - Search for books using various criteria such as title, author, or genre.

- **Patron Management:** 
  - Add and edit patron information, including name, contact details, and membership status.
  - View patron borrowing history, including due dates and fines.

- **Transaction Handling:**
  - Check out books to patrons and record due dates.
  - Process book returns, calculate late fees if applicable, and update availability.
  - Maintain a transaction log for historical reference.

- **User Authentication:**
  - Secure login system for library staff with role-based access control.
  - Administrators can manage staff accounts and permissions.

- **Reporting and Analytics:**
  - Generate reports on book inventory, patron activity, and overdue books.
  - Monitor library statistics, including popular genres and peak borrowing times.

- **Notifications:**
  - Automatically send email reminders to patrons for overdue books.
  - Notify staff about important updates or system events.

## Installation

1. **Database Setup:**
   - Install MySQL and create a new database for the Library Management System.
   - Import the provided SQL schema and sample data to initialize the database.

2. **Application Setup:**
   - Clone this repository to your local machine.
   - Open the project in Visual Studio or your preferred C# development environment.
   - Configure the database connection string in the application settings.

3. **Build and Run:**
   - Build the application to resolve dependencies.
   - Run the application to start the Library Management System.

## Usage

1. **Login:**
   - Use your staff credentials to log in to the system.

2. **Book Management:**
   - Add new books and update existing book information.
   - Utilize the search feature to quickly find books.

3. **Patron Management:**
   - Add, edit, and view patron records.
   - Keep track of patron borrowing history.

4. **Transaction Handling:**
   - Check out books to patrons and record return transactions.
   - Calculate late fees automatically.

5. **Reports and Analytics:**
   - Generate reports to gain insights into library operations.
   - Manage overdue books effectively.

6. **Notifications:**
   - Ensure the email notification system is configured to send reminders and updates.


## Acknowledgments

We would like to express our gratitude to the open-source community and the following technologies that made this project possible:

- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [MySQL](https://www.mysql.com/)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/)


