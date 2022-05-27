using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Miam.Data
{
    public class RestaurantService : IRestaurantService
    {
        private List<Restaurant> restaurants = new List<Restaurant>
        {
            new Restaurant { RestaurantId= 1, Nom= "Lamamina",PrixMoyen="19,90", Genre="Populaire", ImageLink="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT24c1QvC5AQS9y6w_4GoVboYCrl4uYUyZdVw&usqp=CAU"},
            new Restaurant { RestaurantId= 2, Nom= "Tourneflam",PrixMoyen="19,90", Genre="Populaire", ImageLink="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT24c1QvC5AQS9y6w_4GoVboYCrl4uYUyZdVw&usqp=CAU"},
            new Restaurant { RestaurantId= 3, Nom= "Macdo",PrixMoyen="19,90", Genre="Populaire", ImageLink="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT24c1QvC5AQS9y6w_4GoVboYCrl4uYUyZdVw&usqp=CAU"},
            new Restaurant { RestaurantId= 4, Nom= "Kfc",PrixMoyen="19,90", Genre="Populaire", ImageLink="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT24c1QvC5AQS9y6w_4GoVboYCrl4uYUyZdVw&usqp=CAU"},
            new Restaurant { RestaurantId= 5, Nom= "Saygon",PrixMoyen="19,90", Genre="Populaire", ImageLink="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT24c1QvC5AQS9y6w_4GoVboYCrl4uYUyZdVw&usqp=CAU"},
        };

        public List<Restaurant> GetRestaurants()
        {
            return restaurants;
        }
    }
}
