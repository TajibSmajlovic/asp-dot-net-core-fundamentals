using OdeToFood.Core;
using System.Collections.Generic;
using System.Linq;
using static OdeToFood.Core.Restaurant;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> restaurants;

        public InMemoryRestaurantData()

        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id = 1, Name = "Bosanka", Location= "Piramida", Cuisine = CuisineType.Bosnian},
                new Restaurant{Id = 2, Name = "Čevapara", Location= "Baščaršija", Cuisine = CuisineType.Bosnian},
                new Restaurant{Id = 3, Name = "Picerija", Location= "Dolac Malta", Cuisine = CuisineType.Italian}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}