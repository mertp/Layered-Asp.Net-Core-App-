using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using MvCViewUI.Models;

namespace MvCViewUI.Controllers
{
    //Dependency Injection of Business Layer
    public class CategoryController:Controller
    {
        private ICategoryBusinessService _categoryService;

        public CategoryController(ICategoryBusinessService categoryBusiness)
        {
            _categoryService = categoryBusiness;
        }

        public IActionResult Index()
        {
            var model = new CategoryListViewModel
            {
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }
    }
}
