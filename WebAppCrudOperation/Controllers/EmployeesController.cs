using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppCrudOperation.Data;
using WebAppCrudOperation.Models;

namespace WebAppCrudOperation.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Result = _context.Employees.Include(x => x.Department).OrderBy(x => x.EmployeeName).ToList();
            return View(Result);
        }
        
           public IActionResult Create()
        {
            var Departments = _context.Departments.OrderBy(x => x.DepartmentName).ToList();

            if (Departments == null || !Departments.Any())
            {
                ViewBag.Departments = new List<SelectListItem>(); // Prevent null reference
            }
            else
            {
                ViewBag.Departments = Departments;
            }

            return View();
        }

    }
}

