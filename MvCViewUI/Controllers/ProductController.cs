using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using MvCViewUI.Models;

namespace MvCViewUI.Controllers
{
    //Dependency Injection of Business Layer
    public class ProductController : Controller
    {
        private IProductBusinessService _productService;

        public ProductController(IProductBusinessService productBusiness)
        {
            _productService = productBusiness;
        }
        //Index View
        public IActionResult Index(int category)
        {
            var model = new ProductListViewModel
            {
                //Filtering with category id
                Products = category > 0 ? _productService.GetByCategory(category) : _productService.GetList()
            };
            return View(model);
        }
    }
}
