using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace BusinessLayer.Abstract
{
    //Business Layer Abstract Parts
    public interface IProductBusinessService
    {
        List<Product> GetList();
        List<Product> GetByCategory(int categoryId);
    }
}
