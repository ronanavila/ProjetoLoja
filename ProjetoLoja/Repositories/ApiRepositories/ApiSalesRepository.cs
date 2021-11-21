using ProjetoLoja.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoLoja.Repositories.ApiRepositories
{
    public class ApiSalesRepository : BaseRepository<Offer>, IApiSalesRepository
    {
        public ApiSalesRepository(ApplicationContext contexto) : base(contexto)
        {

        }

        public List<Offer> GetSales(string id)
        {
            List<Offer> offer = new List<Offer>();
            //realiza as validacao, parei em teste, algum possivel problema com o modelo, quando colocado o contais tras somente 1 resultado.
            if (id != null)
                offer = dbSet.Where(x => x.SaleMade).Where(p => p.Customer.CPF.Contains(id)).ToList();


            if (offer != null)
                return offer;// dbSet.Where(x => x.Customer).Count() == 0);


            return null;

        }
    }
}

//SELECT PARA ORIENTACAO
//SELECT
//    PRODUCTS.ID, PRODUCTS.CODE, PRODUCTS.NAME, PRODUCTS.PRICE
//    , OFFER.ID, OFFER.QUANTITY, OFFER.QUANTITY* PRODUCTS.VALUE AS TOTALVALUE
//    , CUSTOMER.ID, CUSTOMER.NAME, CUSTOMER.CPF
//FROM OFFER
//        INNER JOIN CUSTOMER
//            ON CUSTOMER.ID = OFFER.CUSTOMERFOREIGNKEY
//        INNER JOIN PRODUCTS
//            ON PRODUCTS.ID = OFFER.CUSTOMERFOREIGNKEY
//WHERE
//    OFFER.SALEMADE = 1
//    AND (CUSTOMER.CPF = ID OR CUSTOMER.NAME = ID)
//GROUP BY
//	CUSTOMER.ID;