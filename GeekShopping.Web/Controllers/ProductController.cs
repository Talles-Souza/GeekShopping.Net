using GeekShopping.Web.Models;
using GeekShopping.Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        public async Task<ActionResult> ProductIndex()
        {
            var product = await _productService.FindAll();
            return View(product);
        }
        public async Task<ActionResult> ProductCreate()
        {
            return View();
        } 
        [HttpPost]  
        public async Task<ActionResult> Create(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine(model);
                var response = await _productService.Create(model);
                if (response != null) return RedirectToAction(nameof(ProductIndex));
            }  
            return View(model);
        }
    }
}
