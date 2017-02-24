using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThirtyDaysOfTDD.UnitTests
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            Items=new List<ShoppingCartItem>();
        }

    public List<ShoppingCartItem> Items { get; set; }
    }
}
