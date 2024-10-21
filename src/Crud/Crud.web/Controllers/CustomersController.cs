using Crud.web.Data;
using Crud.web.Models;
using Crud.web.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Crud.web.Controllers
{
    public class CustomersController : Controller

    {
        private readonly CrudDbContext _context;
        public CustomersController(CrudDbContext context)
        {
            _context = context;

        }

        public ActionResult Index()
        {
            var vm = new CustomersViewModel();
            var AllCustomers = _context.Customers.ToList();
            var ActiveCustomers = _context.Customers.Where(cust => cust.IsActive).ToList();
            //ViewBag.CustomerInformation = info2;

            vm.ActiveCustomers = ActiveCustomers;
            vm.AllCustomers = AllCustomers;
            return View(vm);
        }

        // GET: Customers1/Details/5
        public async Task<IActionResult> Details(int id)
        {

            var customers = await _context.Customers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customers == null)
            {
                return NotFound();
            }

            return View(customers);
        }

        // GET: Customers1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers1/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Customer vm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Customers1/Edit/5
        public async Task<IActionResult> Edit(int id)
        {

            var customers = await _context.Customers.FindAsync(id);
            if (customers == null)
            {
                return NotFound();
            }
            return View(customers);
        }

        // POST: Customers1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Customer vm)
        {
            if (id != vm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                _context.Update(vm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vm);
        }

        // GET: Customers1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers = await _context.Customers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customers == null)
            {
                return NotFound();
            }

            return View(customers);
        }

        // POST: Customers1/Delete/5
        [HttpPost, ActionName(nameof(Delete))]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customers = await _context.Customers.FindAsync(id);
            if (customers != null)
            {
                _context.Customers.Remove(customers);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomersExists(int id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }
    }
}
