using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Model;
using WebApplication2.Services;

namespace WebApplication2.Pages
{
    public class ProductsListModel : PageModel
    {
        private readonly ILogger<ProductsListModel> _logger;
        public JsonFileZimProductService zimProductService;
        public IEnumerable<ZimProduct> Products { get; private set; }

        public ProductsListModel(ILogger<ProductsListModel> logger,
               JsonFileZimProductService zimproductservice)
        {
            _logger = logger;
            zimProductService = zimproductservice;

        }
        public void OnGet()
        {
            Products = zimProductService.GetProducts();
        }
    }
}
