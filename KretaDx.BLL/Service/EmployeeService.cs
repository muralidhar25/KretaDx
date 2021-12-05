global using KretaDx.BLL.Interface;
global using KretaDx.DAL.Repository.Interfaces;

namespace KretaDx.BLL.Service;

    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public List<Employee> GetEmployees()
        {
          return  _employeeRepository.GetEmployeeDetail();
        }
    }

