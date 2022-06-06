using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entities.Concrete;

namespace BusinessLayer.Concrete
{
    //Implementing abstract interfaces in business layer
    public class CategoryManager : ICategoryBusinessService
    {
        //Dependecy Injection of data access layer
        private  ICategoryDal _categoryBusinessService;
        public CategoryManager(ICategoryDal categoryService)
        {
            _categoryBusinessService = categoryService;
        }
        public List<Category> GetAll()
        {
            return _categoryBusinessService.GetList();
        }
    }
}
