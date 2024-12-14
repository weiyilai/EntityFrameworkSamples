using Domain;
using System.Collections.Generic;

namespace Application.Employee.Interfaces
{
    public interface IEmployeeService
    {
        List<Employees> GetEmployees();
    }
}
