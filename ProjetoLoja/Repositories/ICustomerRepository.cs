using ProjetoLoja.Models;
using System.Collections.Generic;


namespace ProjetoLoja.Repositories
{
    public interface ICustomerRepository
    {
        public List<Customer> GetCustomer(string attribute);
        public void InsertCustomer(Customer customer);
    }
}