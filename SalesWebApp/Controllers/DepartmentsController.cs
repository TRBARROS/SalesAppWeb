using Microsoft.AspNetCore.Mvc;
using SalesWebApp.Models;

namespace SalesWebApp.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departament> List = new List<Departament>();
            List.Add(new Departament { Id = 1, Name = "Eletronics"});
            List.Add(new Departament { Id = 2, Name = "Fashion" });

            return View(List);
        }
    }
}
