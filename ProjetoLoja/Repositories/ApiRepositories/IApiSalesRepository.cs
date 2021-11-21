using ProjetoLoja.Models;
using System.Collections.Generic;

namespace ProjetoLoja.Repositories.ApiRepositories
{
    public interface IApiSalesRepository
    {
        public List<Offer> GetSales(string id);
    }
}