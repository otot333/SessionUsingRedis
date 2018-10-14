using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SessionLab3.Helper;
using SessionLab3.Models;

namespace SessionLab3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        // GET
        [HttpGet]
        public ShoppingCart Index()
        {
            var result = SessionHelper.GetShoppingCart(HttpContext.Session);
            return result;
        }

        [HttpPost]
        public void AddProduct(Product product)
        {
            SessionHelper.AddProductToShoppingCart(HttpContext.Session, product);
        }
    }
}