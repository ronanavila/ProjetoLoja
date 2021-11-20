using System.Collections.Generic;
using ProjetoLoja.Models;


namespace ProjetoLoja.Repositories
{
    public interface ICustomerRepository
    {
        //public IList<Customer> GetCustomer();

        public List<Customer> GetCustomer(string attribute);
        public void InsertCustomer(Customer customer);
    }
}