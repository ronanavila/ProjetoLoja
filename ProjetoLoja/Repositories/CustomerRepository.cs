using ProjetoLoja.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoLoja.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public List<Customer> GetCustomer(string attribute)
        {
            attribute = attribute.ToLower();

            return dbSet.Where(x => x.Name.ToLower().Contains(attribute)
                    && x.Status.EndCustomer == false
                    || x.CPF.Contains(attribute)
                    && x.Status.EndCustomer == false).ToList();
        }

        //Insere o cliente no banco de dados.
        public void InsertCustomer(Customer customer)
        {
            if (customer != null)
            {

                //busca o ID do Status que correspode ao "Nome Livre"
                var status = contexto.Set<Status>()
                                .Where(x => x.Description == "Nome Livre")
                                .SingleOrDefault();

                customer.Status = status;
                dbSet.Add(customer);
                contexto.SaveChanges();
            }
        }
    }
}

