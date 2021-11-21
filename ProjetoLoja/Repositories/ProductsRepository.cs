using ProjetoLoja.Models;

namespace ProjetoLoja.Repositories
{
    public class ProductsRepository : BaseRepository<Customer>, IProductsRepository
    {
        public ProductsRepository(ApplicationContext contexto) : base(contexto)
        {

        }

    }
}
