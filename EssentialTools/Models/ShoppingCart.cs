using System.Collections.Generic;

namespace EssentialTools.Models
{
    public class ShoppingCart
    {
        //private LinqValueCalculator calc;
        private IValueCalculator calc;

        //public ShoppingCart(LinqValueCalculator calcParam)
        public ShoppingCart(IValueCalculator calcParam)
        {
            calc = calcParam;
        }

        public IEnumerable<Product> Products { get; set; }

        public decimal CalculateProductTotal()
        {
            return calc.ValueProducts(Products);
        }
    }
}