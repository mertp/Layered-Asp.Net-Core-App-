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
    public class ProductManager : IProductBusinessService
    {

        private IProductDaL _productDaL;

        public ProductManager(IProductDaL productDaL)
        {
            _productDaL = productDaL;
        }
        public List<Product> GetList()
        {
            return _productDaL.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDaL.GetList(p => p.CategoryID == categoryId);
        }

       
    }
}
