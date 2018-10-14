using System.Collections.Generic;

namespace SessionLab3.Models
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            ProductList = new List<Product>();
        }
        public IList<Product> ProductList  { get; set; }
    }
}