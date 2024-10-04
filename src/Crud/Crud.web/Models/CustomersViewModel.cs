using Crud.web.Models.Entities;

namespace Crud.web.Models
{
    public class CustomersViewModel
    {
        public List<Customers> ActiveCustomers { get; set; }

        public List<Customers> AllCustomers { get; set;}
    }
}
