using Crud.web.Data;
using Microsoft.AspNetCore.Mvc;

namespace Crud.web.Controllers
{
    public class CustomersController: Controller

    {
        private readonly CrudDbContext _db;
        public CustomersController(CrudDbContext db)
        {
            _db = db;
            
        }

        public ActionResult Index()
        {
            var info = _db.Customers.ToList();
            return View(info);
        }
    }
}
