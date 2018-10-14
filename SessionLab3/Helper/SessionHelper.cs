using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Http;
using SessionLab3.Models;

namespace SessionLab3.Helper
{
    public class SessionHelper
    {
        public static ShoppingCart GetShoppingCart(ISession session)
        {
            var result = session.GetObject<ShoppingCart>("ShoppingCart") ?? new ShoppingCart();
            return result;
        }
        
        public static void AddProductToShoppingCart(ISession session, Product product)
        {
            var shoppingCart = session.GetObject<ShoppingCart>("ShoppingCart") ?? new ShoppingCart();
            shoppingCart.ProductList.Add(product);
            
            session.SetObject("ShoppingCart", shoppingCart);
        }
    }
}