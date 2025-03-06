using Crud.web.Models.Entities;

namespace Crud.web.Models.ViewModel
{
    public class CustomerViewModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public char Gender { get; set; }
        public bool IsActive { get; set; }

        public List<Customer> ActiveCustomers { get; set; }

        public List<Customer> AllCustomers { get; set; }
    }
}
