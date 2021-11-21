using Microsoft.AspNetCore.Mvc;
using ProjetoLoja.Models;
using ProjetoLoja.Repositories;
using System.Collections.Generic;

namespace ProjetoLoja.Controllers
{
    public partial class ProductOfferController : Controller
    {

        private readonly IOfferRepository offerRepository;
        private readonly IOfferRegistrationRepository offerRegistration;

        public ProductOfferController(IOfferRepository offerRepository, IOfferRegistrationRepository offerRegistration)
        {
            this.offerRepository = offerRepository;
            this.offerRegistration = offerRegistration;
        }
        public IActionResult Offer(List<Customer> customer)
        {
            return View();
        }

        //Cadastra oferta
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Find(string attribute)
        {
            OfferRegistration registration = null;
            if (attribute != null)
            {
                registration = offerRegistration.GetCustomerOffer(attribute);
                return View("Offer", offerRegistration);
            }
            return View("Offer");

        }
    }

}
