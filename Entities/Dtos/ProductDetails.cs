using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Entities.Abstract;

namespace Entities.Dtos
{
    public class ProductDetails:IDto

    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public string CategoryName { get; set; }
    }
}
