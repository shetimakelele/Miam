using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Miam.Data
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }

        public string Nom { get; set; }

        public string PrixMoyen { get; set; }

        public string Genre { get; set; }

        public string ImageLink { get; set; }
    }
}
