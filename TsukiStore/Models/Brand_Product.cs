using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TsukiStore.Models
{
    public class Brand_Product
    {
        public int ProductId { get; set; }
        public Product Продукт { get; set; }  

        public int BrandId { get; set; }
        public Brand Бренд { get; set; }
    }
}
