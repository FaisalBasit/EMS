# Employee Management System (EMS)

## Introduction

The Employee Management System (EMS) is a comprehensive solution developed to streamline the management of employee data within an organization. This system is built using C# Windows Forms for the user interface and SQL Server for the database management, ensuring robust and efficient handling of employee-related operations.

## Project Objective

The primary objective of the EMS is to provide a user-friendly interface for managing employee data, including adding, updating, and deleting employee records, managing projects, and handling salaries. The system aims to enhance productivity by automating routine tasks and providing real-time data access to administrators, managers, and employees.

## Features

### User Types

- **Admin**: Has full access to all features, including adding, updating, and deleting employee records, managing salaries, and overseeing projects.
- **Manager**: Can view and manage projects assigned to them and oversee the work of their team members.
- **Employee**: Can view available projects, accept tasks, and update the status of their tickets.

### Login System

- Employees log in using their employee ID and password.
- Admin ID is fixed at 1000, manager IDs range from 1001 to 1099, and employee IDs start from 1100.
- Only active employees can log in; inactive employees receive an error message.

### Dashboard

- Displays total employees, active employees, and inactive employees.
- Shows department information and employee data.
- Includes a pie chart representing the total available tickets of current projects.

### Employee Management

- Admin can add, update, and delete employee records.
- Employee data includes ID, full name, phone number, gender, position, status, password, manager ID, and department ID.
- Positions are predefined and include roles such as Developer, Designer, Consultant, etc.
- Passwords must meet specific security criteria.

### Salary Management

- Admin can update employee salaries.
- Salary data is linked to the employee record and can be viewed and edited through the salary management interface.

### Project Management

- **Admin**: Can create, update, and delete projects, assigning them to managers.
- **Manager**: Can view project details, track progress, and oversee team member contributions.
- **Employee**: Can view available projects, accept tasks, and update ticket statuses.

### Project Details

- Projects have IDs, names, number of tickets, manager IDs, and statuses (available or complete).
- Employees can accept tickets and update their status to complete when finished.
- Managers and employees can track project and ticket statuses through detailed overviews.

## Technologies Used

- **C# Windows Forms**: Provides a user-friendly and interactive graphical user interface.
- **SQL Server**: Manages the database, ensuring data integrity and security.
- **Visual Studio**: Integrated development environment used for building the application.

## Conclusion

The Employee Management System is a robust application designed to facilitate efficient management of employee and project data. By leveraging C# Windows Forms and SQL Server, the system offers a secure and user-friendly interface for administrators, managers, and employees, enhancing overall productivity and organizational management. This project exemplifies the application of modern software development practices in solving real-world business challenges.

## Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/FaisalBasit/EMS.git
   ```

2. **Open the solution file**:
   - Navigate to the project directory.
   - Open the solution file (`.sln`) in Visual Studio.

3. **Configure the database**:
   - Ensure SQL Server is installed and running.
   - Update the connection string in the `App.config` file with your SQL Server credentials.

4. **Build and run the application**:
   - Build the solution in Visual Studio.
   - Run the application.

## Usage

- **Admin**: Log in using the admin credentials and access all features including employee, salary, and project management.
- **Manager**: Log in with manager credentials to view and manage projects and oversee team contributions.
- **Employee**: Log in with employee credentials to view available projects, accept tasks, and update ticket statuses.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For any inquiries or support, please contact:

- **Name**: Faisal Basit
- **Email**: muhammadfaisal159@gmail.com
