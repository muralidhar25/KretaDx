
global using KretaDx.DAL.Repository.Interfaces;
global using KretaDx.Model.Models;

namespace KretaDx.DAL.Repository.Services;

    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetEmployeeDetail()
        {
            List<Employee> employees = new List<Employee>();
            Employee employee = new Employee();
            employee.EmployeeId = 36;
            employee.EmployeeName = "Donald Jurickova";
            employee.EmployeeEmail = "donald.jurickova@any.com";
            employees.Add(employee);
            employee = new Employee();
            employee.EmployeeId = 36;
            employee.EmployeeName = "Ian Frannson";
            employee.EmployeeEmail = "ian.frannson@any.com";
            employees.Add(employee);
            employee = new Employee();
            employee.EmployeeId = 36;
            employee.EmployeeName = "Brayden Crawford";
            employee.EmployeeEmail = "brayden.crawford@any.com";
            employees.Add(employee);
            employee = new Employee();
            employee.EmployeeId = 36;
            employee.EmployeeName = "Leo Gross";
            employee.EmployeeEmail = "leo.gross@any.com";
            employees.Add(employee);
            employee = new Employee();
            employee.EmployeeId = 36;
            employee.EmployeeName = "Kate Sparrow";
            employee.EmployeeEmail = "kate.parrow@any.com";
            employees.Add(employee);
            employee = new Employee();
            employee.EmployeeId = 36;
            employee.EmployeeName = "Denis Lee";
            employee.EmployeeEmail = "denis.lee@any.com";
            employees.Add(employee);
            return employees;
        }
    }

