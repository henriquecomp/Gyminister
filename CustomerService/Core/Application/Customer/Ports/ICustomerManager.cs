using Application.Customer.Requests;
using Application.Customer.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Customer.Ports
{
    public interface ICustomerManager
    {
        Task<CustomerResponse> CreateCustomer(CreateCustomerRequest request);
        Task<CustomerResponse> GetCustomer(int id);
    }
}
