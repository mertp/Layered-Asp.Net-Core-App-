using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.DataAccess.Concrete.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    //İnheriting from Core Layer EfEntitiyRepositoryBase arguments with TEntity and TContext
    public class EfProductDal : EfEntityRepositoryBase<Product,NorthWindContext>,IProductDaL
    {
       
    }
}
