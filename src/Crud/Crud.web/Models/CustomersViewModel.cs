using Crud.web.Models.Entities;

namespace Crud.web.Models
{
    public class CustomersViewModel
    {
        public List<Customer> ActiveCustomers { get; set; }

        public List<Customer> AllCustomers { get; set;}
    }
}
