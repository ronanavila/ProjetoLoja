using ProjetoLoja.Models;

namespace ProjetoLoja.Repositories.ApiRepositories
{
    public interface IApiProductRepository
    {
        public Products PostProduct(Products products);
    }
}