using System;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Domain.Customer.Enums;
using Domain.Customer.Ports;

namespace Domain.Customer.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string DocumentNumber { get; set; }
        public DocumentType DocumentType { get; set; }
        public Status Status { get; set; }

        public bool IsValid()
        {
            ValidateState();
            return true;
        }

        private void ValidateState()
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentException("Please type a valid name!");
            }
        }
    }
}
