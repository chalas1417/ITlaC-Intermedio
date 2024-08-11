using Solid.DIP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.Repository
{
    public class CustomerRepository
    {
        public Customer GetCustomers()
        {
            return new Customer { Id = 42, Name = "Leidy" };
        }
    }
}
