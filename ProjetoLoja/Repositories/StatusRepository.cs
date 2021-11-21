using ProjetoLoja.Models;

namespace ProjetoLoja.Repositories
{
    public class StatusRepository : BaseRepository<Customer>, IStatusRepository
    {
        public StatusRepository(ApplicationContext contexto) : base(contexto)
        {
        }
    }

}
