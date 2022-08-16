using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departments> departments = new List<Departments>();
            departments.Add(new Departments { Id = 1, Name = "Eletronics"});
            departments.Add(new Departments { Id = 2, Name = "Fashion"});

            return View(departments);
        }
    }
}
