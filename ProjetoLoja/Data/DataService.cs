using Microsoft.EntityFrameworkCore;
using ProjetoLoja.Repositories;

namespace ProjetoLoja
{
    class DataService : IDataService
    {
        private readonly ApplicationContext context;
        private readonly ICustomerRepository customerRepository;

        public DataService(ApplicationContext context, ICustomerRepository customerRepository)
        {
            this.context = context;
            this.customerRepository = customerRepository;
        }

        public void InicializaDB()
        {
            context.Database.Migrate();          
        }
    }
}
