
using Solid.DIP.Models;
using Solid.DIP.Repository;

namespace Solid.DIP.Services
{
    public class CustomerServices
    {
        private readonly CustomerRepository _customerRepository;

       
        public CustomerServices()
        {
            _customerRepository = new CustomerRepository();
        }

        public Customer GetCustomer()
        {
            return _customerRepository.GetCustomers();
        }
    }
}

