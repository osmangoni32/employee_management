using EmployInformationApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployInformationApplication.Controllers
{
    public class EmployDatabaseModelCreatController : Controller
    {
        private readonly EmployDatabase _empdb;
        public EmployDatabaseModelCreatController(EmployDatabase emp)
        {
            _empdb = emp;
        }
            
            
        public IActionResult Index()
        {
            return View();
        }
    }
}
