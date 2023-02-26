using Domain.Customer.Entities;
using Domain.Customer.Ports;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Customer
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly GymDbContext _gymDbContext;
        public CustomerRepository(GymDbContext gymDbContext)
        {
            _gymDbContext = gymDbContext;
        }

        public async Task<int> Create(Domain.Customer.Entities.Customer customer)
        {
            _gymDbContext.Customer.Add(customer);
            await _gymDbContext.SaveChangesAsync();
            return customer.CustomerId;
        }

        public Task<Domain.Customer.Entities.Customer> Get(int id)
        {
            return _gymDbContext.Customer.Where(x => x.CustomerId == id).FirstOrDefaultAsync();
        }
    }
}
