using Microsoft.AspNetCore.Mvc;
using ProjetoLoja.Models;
using ProjetoLoja.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLoja.Controllers
{
    public partial class ProductOfferController : Controller
    {

        private readonly ICustomerRepository customerRepository;
        private readonly IProductsRepository productsRepository;

        public ProductOfferController(ICustomerRepository customerRepository, IProductsRepository productsRepository)
        {
            this.customerRepository = customerRepository;
            this.productsRepository = productsRepository;
        }

        //public IActionResult Offer()
        //{
        //    return View();
        //}

        public IActionResult Offer(List<Customer> customer)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Find(string attribute)
        {
            if (attribute != null)
            {
                List<Customer> customers = customerRepository.GetCustomer(attribute);
                return View("Offer", customers);
            }
            return View("Offer");

        }
    }

}
