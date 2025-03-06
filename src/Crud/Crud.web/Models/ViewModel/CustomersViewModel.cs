using Crud.web.Models.Entities;

namespace Crud.web.Models.ViewModel
{
    public class CustomersViewModel
    {
        public List<CustomerViewModel> ActiveCustomers { get; set; }

        public List<CustomerViewModel> AllCustomers { get; set; }
    }
}
