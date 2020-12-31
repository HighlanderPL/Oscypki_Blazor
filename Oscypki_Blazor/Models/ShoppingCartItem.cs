using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oscypki_Blazor.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }

        public Oscypki Oscypki { get; set; }

        public int Amount { get; set; }

        public string ShoppingCartId { get; set; }
    }
}
