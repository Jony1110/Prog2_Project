using Crud.web.Data;
using Crud.web.Models;
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
            var vm = new CustomersViewModel();
            var AllCustomers = _db.Customers.ToList();
            var ActiveCustomers = _db.Customers.Where(cust => cust.Activo).ToList();
            //ViewBag.CustomerInformation = info2;

            vm.ActiveCustomers = ActiveCustomers;
            vm.AllCustomers = AllCustomers;
            return View(vm);
        }
    }
}
