using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oscypki_Blazor.Models
{
    public class Oscypki
    {
        public int OscypkiId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public string ImageThumbnailPath { get; set; }

        public bool SpecialSale { get; set; }
    }
}
