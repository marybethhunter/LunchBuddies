// See https://aka.ms/new-console-template for more information

using LunchBuddies.Models;

var restaurant1 = new Restaurant();
Console.WriteLine(restaurant1.Name);

//1. `eat()` -Will select a random restaurant name from a list of strings(List of restaurant names can come from anywhere), print to console that the buddy is at that restaurant, and also return the restaurant.

var friend = new LunchBuddy("Lauren", "Hignite");
friend.Eat();

//2. `eat(string food)` -Will output that the buddy ate that specific food at the office.

friend.Eat("sushi");

// 3. `eat(List < LunchBuddy > companions)` -Will select a random restaurant name from a list of strings, print to console that the buddy is at that restaurant, and also output the first name of each lunch buddy in the specified list.

List buddies = new List<Companions>();