using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccesLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Product> GetProductsWithCategories();
        public int ProductCount();
        public int ProductCountByCategoryNameHamburger();
        public int ProductCountByCategoryNameDrink();
        public decimal ProductPriceAvg();
        public string ProductNameByPriceMin();
        public string ProductNameByPriceMax();
        public decimal ProductAvgPriceByHamburger();
        public decimal ProductPriceBySteakBurger();
        public decimal TotalPriceByDrinkCategory();
        public decimal TotalPriceBySaladCategory();
        public decimal ProductPriceSum();

    }
}
