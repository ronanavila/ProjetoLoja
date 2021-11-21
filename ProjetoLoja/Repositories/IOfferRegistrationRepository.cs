using ProjetoLoja.Models;

namespace ProjetoLoja.Repositories
{
    public interface IOfferRegistrationRepository
    {
        public OfferRegistration GetCustomerOffer(string attribute);
    }
}