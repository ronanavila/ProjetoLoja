using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  ProjetoLoja.Models;

namespace ProjetoLoja.Repositories
{
  
    public class StatusRepository : BaseRepository<Customer>, IStatusRepository
    {
        public StatusRepository(ApplicationContext contexto) : base(contexto)
        {
        }
    }

 
}
