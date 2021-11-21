using ProjetoLoja.Models;
using System.Linq;

namespace ProjetoLoja.Repositories
{
    public class OfferRegistrationRepository : BaseRepository<Offer>, IOfferRegistrationRepository
    {
        public OfferRegistrationRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public OfferRegistration GetCustomerOffer(string attribute)
        {
            OfferRegistration OfferRegistration = new OfferRegistration();

            attribute = attribute.ToLower();

            //Busca Cliente por Cpf ou Nome que nao possuam true no finaliza venda
            var customerList = contexto.Set<Customer>()
                .Where(x => x.Name.ToLower().Contains(attribute)
                && x.Status.EndCustomer == false
                || x.CPF.Contains(attribute)
                && x.Status.EndCustomer == false).ToList();

            //Busca todos os Status
            var statusList = contexto.Set<Status>().ToList();

            //Busca todos os Produtos
            var productList = contexto.Set<Products>().ToList();

            //Adicona as Lista no modelo Offer a ser retornado
            OfferRegistration.ListCustomer = customerList;
            OfferRegistration.ListStatus = statusList;
            OfferRegistration.ListProducts = productList;

            return OfferRegistration;
        }
    }
}
