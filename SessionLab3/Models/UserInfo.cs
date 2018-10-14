using System.Collections;
using System.Collections.Generic;

namespace SessionLab3.Models
{
    public class UserInfo
    {
        public UserInfo()
        {
            ShoppingCart = new List<Product>();
        }
        public IEnumerable<Product> ShoppingCart  { get; set; }
    }
}