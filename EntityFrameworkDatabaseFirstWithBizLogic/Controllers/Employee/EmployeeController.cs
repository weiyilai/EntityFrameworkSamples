using EntityFrameworkDatabaseFirstWithBizLogic.Models;
using System.Web.Mvc;

namespace EntityFrameworkDatabaseFirstWithBizLogic.Controllers.Employee
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeModel _employee;

        public EmployeeController()
        {
            _employee = new EmployeeModel();
        }

        // GET: Employee
        public ActionResult Index()
        {
            var employees = _employee.GetEmployees();
            return View(employees);
        }
    }
}