using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Model;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [Route("/APIproducts")]
    [ApiController]
    public class ZimProductsController : ControllerBase
    {
       public ZimProductsController(JsonFileZimProductService zimProductService) 
        {
            this.ZimProductService = zimProductService;
        }

        public JsonFileZimProductService ZimProductService { get; }
        [HttpGet]
        public IEnumerable<ZimProduct> Get()
        {
            return ZimProductService.GetProducts();
        }
    }
}
