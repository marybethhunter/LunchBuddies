using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies.Models
{
    internal class Restaurant
    {
        //1. It should have a private property that contains a List of restaurant names. `List<string>`
        //2. Its constructor should pick a random restaurant name and assign it to a public property called "Name"

        public Restaurant()
        {
             Name = assignName();
        }

        public string Name { get; set; }

        private List<string> _restaurantNames = new List<string> { "Vanelli's", "Amsterdam Deli", "Kermit's Soul Kitchen", "Cafe 212", "The Stables", "Nautical Whimsey"};

        public string assignName()
        {
            Random RandomRestName = new Random();
            string restName = _restaurantNames[RandomRestName.Next(_restaurantNames.Count)];
            return restName;
        }
    
    }
}
