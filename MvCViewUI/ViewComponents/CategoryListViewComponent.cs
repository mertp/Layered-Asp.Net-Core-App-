using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MvCViewUI.Models;

namespace MvCViewUI.ViewComponents
{
    //Category View Component
    public class CategoryListViewComponent:ViewComponent
    {
        private ICategoryBusinessService _categoryService;

        public CategoryListViewComponent(ICategoryBusinessService categoryBusiness)
        {
            _categoryService = categoryBusiness;
        }
        public  ViewViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel
            {
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }
    }
}
