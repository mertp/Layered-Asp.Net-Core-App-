using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccessLayer.Abstract
{
    //Inheriting from Core Layer IEntitiyRepository
    public interface IProductDaL:IEntityRepository<Product>
    {
        

    }
}
