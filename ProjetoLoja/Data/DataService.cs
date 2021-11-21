using Microsoft.EntityFrameworkCore;
using ProjetoLoja.Repositories;

namespace ProjetoLoja
{
    class DataService : IDataService
    {
        private readonly ApplicationContext context;     

        public DataService(ApplicationContext context)
        {
            this.context = context;         
        }

        public void InicializaDB()
        {
            context.Database.Migrate();
        }
    }
}
