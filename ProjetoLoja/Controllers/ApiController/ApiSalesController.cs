using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoLoja.Models;
using ProjetoLoja.Repositories.ApiRepositories;
using System.Collections.Generic;

namespace ProjetoLoja.Controllers.ApiController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiSalesController : Controller
    {

        private readonly IApiSalesRepository apiSalesRepository;


        public ApiSalesController(IApiSalesRepository apiSalesRepository)
        {
            this.apiSalesRepository = apiSalesRepository;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<Offer>> Get(string id)
        {
            List<Offer> offer = new List<Offer>();

            //valida o modelo e verifica se conseguiu postar o objeto
            if (ModelState.IsValid)
                offer = apiSalesRepository.GetSales(id);

            if (offer != null)
                return offer;

            return BadRequest();
        }

    }
}

