using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoLoja.Models;

namespace ProjetoLoja.Repositories
{
    public class OfferRepository : BaseRepository<Customer>, IOfferRepository
    {
        public OfferRepository(ApplicationContext contexto) : base(contexto)
        {
        }

    }
}
