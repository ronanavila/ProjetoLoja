using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoLoja.Models;
using ProjetoLoja.Repositories.ApiRepositories;

namespace ProjetoLoja.Controllers.ApiController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiProductController : Controller
    {

        private readonly IApiProductRepository apiProductRepository;


        public ApiProductController(IApiProductRepository apiProductRepository)
        {
            this.apiProductRepository = apiProductRepository;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Products> Post([FromBody] Products products)
        {
            //valida o modelo e verifica se conseguiu postar o objeto
            if (ModelState.IsValid &&
                apiProductRepository.PostProduct(products) != null)
            {
                return products;
            }
            return BadRequest();
        }
    }
}
