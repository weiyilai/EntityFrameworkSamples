using Application.Employee.Interfaces;
using Domain;
using System.Collections.Generic;
using System.Linq;

namespace Application.Employee
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public List<Employees> GetEmployees()
        {
            return _repository.GetAll().ToList();
        }
    }
}
