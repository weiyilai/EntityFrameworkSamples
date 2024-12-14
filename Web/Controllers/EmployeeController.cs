using Application.Employee.Interfaces;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: Employee
        public ActionResult Index()
        {
            var employees = _employeeService.GetEmployees();
            return View(employees);
        }
    }
}