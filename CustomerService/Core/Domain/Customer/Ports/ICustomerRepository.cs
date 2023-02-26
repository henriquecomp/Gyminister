using System.Threading.Tasks;

namespace Domain.Customer.Ports
{
    public interface ICustomerRepository
    {
        Task<Entities.Customer> Get(int id);
        Task<int> Create(Entities.Customer customer);
    }
}
