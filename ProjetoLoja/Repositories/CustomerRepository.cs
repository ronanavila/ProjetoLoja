using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoLoja.Models;

namespace ProjetoLoja.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        //Busca uma listagem de clientes
        //public IList<Customer> GetCustomer()
        //{
        //    return dbSet.Where(x => x.Name != null).ToList();
        //}

        public List<Customer> GetCustomer(string attribute)
        {
            attribute = attribute.ToLower();

            //var listCustomer = new List<Customer>();
            //var listStatus = new List<Status>();

            //var query = from customer in listCustomer
            //            join status in listStatus on
            //            new
            //            {
            //                Join = customer.StatusId
            //            }
            //            equals new
            //            {
            //                Join = status.Id
            //            }
            //            select new { newCustomer = customer, newStatus = status };

            return dbSet.Where(x => x.Name.ToLower().Contains(attribute) 
                    &&  x.Status.EndCustomer == false).ToList();
                    //|| x.CPF.Contains(attribute)
                    //&& x.Status.EndCustomer == false).ToList();
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
