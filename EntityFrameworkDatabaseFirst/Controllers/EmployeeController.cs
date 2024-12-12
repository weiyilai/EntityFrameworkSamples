using EntityFrameworkDatabaseFirst.Models;
using System.Linq;
using System.Web.Mvc;

namespace EntityFrameworkDatabaseFirst.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly NorthwindEntities _db;

        public EmployeeController()
        {
            _db = new NorthwindEntities();
        }

        // GET: Employee
        public ActionResult Index()
        {
            var employees = _db.Employees.AsNoTracking().ToList();
            return View(employees);
        }

        public ActionResult Create()
        {
            var employee = new Employees();
            return View(employee);
        }

        [HttpPost]
        public ActionResult Create(Employees model)
        {
            _db.Employees.Add(model);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var employee = _db.Employees.SingleOrDefault(item => item.EmployeeID == id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employees model)
        {
            var employee = _db.Employees.SingleOrDefault(item => item.EmployeeID == model.EmployeeID);
            employee.LastName = model.LastName;
            employee.FirstName = model.FirstName;
            employee.Title = model.Title;
            employee.TitleOfCourtesy = model.TitleOfCourtesy;
            employee.BirthDate = model.BirthDate;
            employee.HireDate = model.HireDate;
            employee.Address = model.Address;
            employee.City = model.City;
            employee.Region = model.Region;
            employee.PostalCode = model.PostalCode;
            employee.Country = model.Country;
            employee.HomePhone = model.HomePhone;
            employee.Extension = model.Extension;
            employee.PhotoPath = model.PhotoPath;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var employee = _db.Employees.SingleOrDefault(item => item.EmployeeID == id);
            return View(employee);
        }

        public ActionResult Delete(int id)
        {
            var employee = _db.Employees.SingleOrDefault(item => item.EmployeeID == id);
            _db.Employees.Remove(employee);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
