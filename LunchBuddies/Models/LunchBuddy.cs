using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies.Models
{
    internal class LunchBuddy
    {
        public LunchBuddy (string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<string> Companions = new List<string>();

        //Define a method on your LunchBuddy class named eat() that will allow it to be invoked with the following four signatures.

        //1. `eat()` -Will select a random restaurant name from a list of strings(List of restaurant names can come from anywhere), print to console that the buddy is at that restaurant, and also return the restaurant.
        //2. `eat(string food)` -Will output that the buddy ate that specific food at the office.
        //3. `eat(List < LunchBuddy > companions)` -Will select a random restaurant name from a list of strings, print to console that the buddy is at that restaurant, and also output the first name of each lunch buddy in the specified list.
        //4. `eat(string food, List < LunchBuddy > companions)` -Will select a random restaurant name from a list of strings, print to console that the buddy at that restaurant, and ordered the specified food, with the first name of the teammates specified in the list.

        public void Eat()
        {
            var restuarant = new Restaurant();
            Console.WriteLine($"Your lunch buddy is at {restuarant.Name}.");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} ate {food} at the office.");
        }

        public void Eat(List<LunchBuddy> Companions)
        {
            var restuarant = new Restaurant();
            foreach (var companion in Companions)
            {
                Console.WriteLine($"{companion.FirstName} is at {restuarant.Name}.");
            }
        }

        public void Eat(string food, List<LunchBuddy> companions)
        {

        }
    }
}
