using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SIT1/1");
<<<<<<< HEAD
            Console.WriteLine("Week 2");

            //create List
            List<Restaurant> restaurants = new List<RestaurantApp>
            {
                new RestaurantApp(1, "Quuanjude Roast Duck" , "Beijing Cuisine", 4.5),
                new RestaurantApp(2, "Donglaishun Hot Pot" , "Hot Pot", 4.6),
                new RestaurantApp(3, "Din Tai Fung" , "Taiwanese Cuisine", 4.7)
            };
=======
>>>>>>> 45fd6627323f50cc2875d87a532029e5cdd3622b

        }
    }
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public double Rating { get; set; }

        public Restaurant(int id,string name )
        {
            
        }
}
