using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Movie Movie { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
