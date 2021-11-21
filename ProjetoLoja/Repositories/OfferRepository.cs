using ProjetoLoja.Models;

namespace ProjetoLoja.Repositories
{
    public class OfferRepository : BaseRepository<Offer>, IOfferRepository
    {
        public OfferRepository(ApplicationContext contexto) : base(contexto)
        {
        }
    }
}
