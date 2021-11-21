using Microsoft.AspNetCore.Mvc;
using ProjetoLoja.Models;
using ProjetoLoja.Repositories;

namespace ProjetoLoja.Controllers
{
    public class CustomerRegistrationController : Controller
    {

        private readonly ICustomerRepository customerRepository;


        public CustomerRegistrationController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public IActionResult Registration()
        {
            return View();
        }

        //cadastro de  clientes
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registration(Customer customer)
        {
            if (ModelState.IsValid)
            {
                customerRepository.InsertCustomer(customer);
                return RedirectToAction("Registration");
            }

            return View(customer);

        }
    }
}
