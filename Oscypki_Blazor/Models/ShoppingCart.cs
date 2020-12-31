using Oscypki_Blazor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Oscypki_Blazor.Models
{
    public class ShoppingCart
    {
        private readonly ApplicationDbContext _applicationDbContext;


        public string ShoppingCartGUID { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public ShoppingCart(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
           
        }


        public static ShoppingCart GetorCreateCart(IServiceProvider services) 
        {
          
            

            var SessionGUID = services.GetService<SessionState>();
            string guid = Guid.NewGuid().ToString();
            var context = services.GetService<ApplicationDbContext>();

            return new ShoppingCart(context) { ShoppingCartGUID = guid };

        }

        public void AddItemToCart(int id, int amount)
        {
            var shoppingCartItem = _applicationDbContext.ShoppingCartItems.SingleOrDefault(s => s.Oscypki.OscypkiId == id && s.ShoppingCartId == ShoppingCartGUID);
            var oscypek = _applicationDbContext.Oscpkis.SingleOrDefault(o => o.OscypkiId == id);
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartGUID,
                    Oscypki = oscypek,
                    Amount = 1,
                   
                };

                _applicationDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }

            _applicationDbContext.SaveChanges();

        }
    }
}
