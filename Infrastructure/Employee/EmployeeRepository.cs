using Application.Employee.Interfaces;
using Domain;

namespace Infrastructure.Employee
{
    public class EmployeeRepository : RepositoryBase<Employees>, IEmployeeRepository
    {
        public EmployeeRepository(NorthwindEntities entities) : base(entities)
        {
        }
    }
}
