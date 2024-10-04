using Crud.web.Data;
using Crud.web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Crud.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly CrudDbContext _db;

        public HomeController(CrudDbContext db)
        {
            _db = db;
        }

        public IActionResult AnAction()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
