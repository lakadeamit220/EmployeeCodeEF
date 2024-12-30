using Microsoft.AspNetCore.Mvc;
using EmployeeCodeEF.Models; // Adjust based on your namespace
using System.Linq;
using EmployeeCodeEF.DBContextData;

namespace EmployeeCodeEF.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeDBContext _context;

        public HomeController(EmployeeDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Fetch all employees from the database
            var employees = _context.Employees.ToList();
            return View(employees);
        }
    }
}
