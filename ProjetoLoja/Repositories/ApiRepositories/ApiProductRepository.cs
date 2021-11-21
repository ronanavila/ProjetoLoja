using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  ProjetoLoja.Models;

 namespace ProjetoLoja.Repositories.ApiRepositories
{
    public class ApiProductRepository : BaseRepository<Products>, IApiProductRepository
    {
        public ApiProductRepository(ApplicationContext contexto) : base(contexto)
        {

        }

        public Products PostProduct(Products products)
        {
            //valida se o obejto é nulo e se nao existe alguem com o mesmo codigo
            if (products != null &&
                dbSet.Where(x => x.Code == products.Code).Count() ==  0)
            {     
                dbSet.Add(products);
                contexto.SaveChanges();
                return products;
            }
            return null;
        }

    }
}
