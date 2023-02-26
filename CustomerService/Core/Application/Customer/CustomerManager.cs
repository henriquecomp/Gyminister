using Application.Customer.DTOs;
using Application.Customer.Ports;
using Application.Customer.Requests;
using Application.Customer.Responses;
using Domain.Customer.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Customer
{
    public class CustomerManager : ICustomerManager
    {
        private ICustomerRepository _customerRepository;
        public CustomerManager(ICustomerRepository customerRepository)
        {
            _customerRepository= customerRepository;
        }

        public async Task<CustomerResponse> CreateCustomer(CreateCustomerRequest request)
        {
            var customer = CustomerDTO.MapToEntity(request.Data);

            if(customer.IsValid() && customer.CustomerId == 0)
                customer.CustomerId = await _customerRepository.Create(customer);
            else if(customer.IsValid() && customer.CustomerId > 0)
                //customer.CustomerId = await _customerRepository.Update(customer);

            request.Data.CustomerId = customer.CustomerId;

            return new CustomerResponse
            {
                Data = request.Data,
                Success = true,
            };

        }

        public async Task<CustomerResponse> GetCustomer(int id)
        {
            var customer = await _customerRepository.Get(id);

            if (customer == null)
            {
                return new CustomerResponse
                {
                    Success = false,
                    Message = "No Guest record was found with the given Id"
                };
            }

            return new CustomerResponse
            {
                Data = CustomerDTO.MapToDto(customer),
                Success = true,
            };
        }
    }
}
