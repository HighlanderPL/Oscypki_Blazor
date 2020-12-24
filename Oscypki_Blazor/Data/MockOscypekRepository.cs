using Oscypki_Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oscypki_Blazor.Data
{
    public class MockOscypekRepository : IOscypekRepository
    {
        public IEnumerable<Oscypki> AllOscypki =>
            new List<Oscypki>
            {   new Oscypki {OscypkiId = 1, Name = "Oscypek", Description = "Smoked Polish Highlander Cheese made with Cows and Sheep Milk", ImagePath = "img/Oscypek.jpg", ImageThumbnailPath = "img/Oscypek_thumbnail.jpg", Price = 2M},
                new Oscypki {OscypkiId = 2, Name = "Small Oscypek", Description = "A small version of the Smoked Polish Highlander Cheese made with Cows and Sheep Milk", ImagePath = "img/Oscypek.jpg", ImageThumbnailPath = "img/Oscypek_small_thumbnail.jpg", Price = 1M},
                new Oscypki {OscypkiId = 3, Name = "Korbacz", Description = "Polish Highlander Cheese made with Cows and Sheep Milk in string form", ImagePath = "img/korbacz.jpg", ImageThumbnailPath = "img/korbacz_thumbnail.jpg", Price = 4M}

            };


        public Oscypki GetOscypekById(int OscypkiId)
        {
            return AllOscypki.FirstOrDefault(o => o.OscypkiId == OscypkiId);
        }

    }
}
