using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TGetProductsWithCategories();
        public int TProductCount();
        public int TProductCountByCategoryNameHamburger();
        public int TProductCountByCategoryNameDrink();
        public decimal TProductPriceAvg();
        public string TProductNameByPriceMin();
        public string TProductNameByPriceMax();
        public decimal TProductAvgPriceByHamburger();
        public decimal TProductPriceBySteakBurger();
        public decimal TTotalPriceByDrinkCategory();
        public decimal TTotalPriceBySaladCategory();
        public decimal TProductPriceSum();
    }
}
