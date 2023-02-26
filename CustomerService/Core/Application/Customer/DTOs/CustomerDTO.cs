using Domain.Customer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerEntity = Domain.Customer.Entities.Customer;

namespace Application.Customer.DTOs
{
    public class CustomerDTO
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string DocumentNumber { get; set; }
        public string DocumentType { get; set; }
        public int DocumentTypeId { get; set; }
        public string Status { get; set; }
        public int StatusId { get; set; }

        public static CustomerEntity MapToEntity(CustomerDTO customerDTO)
        {
            return new CustomerEntity
            {
                CustomerId = customerDTO.CustomerId,
                Name = customerDTO.Name,
                BirthDate = customerDTO.BirthDate,
                DocumentNumber = customerDTO.DocumentNumber,
                DocumentType = (DocumentType)customerDTO.DocumentTypeId,
                Status = (Status)customerDTO.StatusId,
            };
        }

        public static CustomerDTO MapToDto(CustomerEntity customer)
        {
            return new CustomerDTO
            {
                CustomerId = customer.CustomerId,
                Name = customer.Name,
                BirthDate = customer.BirthDate,
                DocumentNumber = customer.DocumentNumber,
                DocumentType = customer.DocumentType.ToString(),
                DocumentTypeId = (int)customer.DocumentType,
                Status = customer.Status.ToString(),
                StatusId = (int)customer.Status,
            };
        }
    }
}
