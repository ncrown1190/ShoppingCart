// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Collections;

/*Task:Make a shopping list application which uses collections to store your items. 
 * (You will be using two collections, one for the menu and one for the shopping list.) 
 */

using System.Collections.Generic;

Console.WriteLine("     Welcome to Chirpus Market!");
Console.WriteLine("  These are the options available at our store: ");

// 01 First we can create dictionary and add the items in the dictionary
//example
//Dictionary<string, double> itemStock = new Dictionary<string, double>();
//itemStock.Add("banana", 0.59);
//itemStock.Add("coke", 1.15);

// Another way we can create dictionary and initialize at the same time
Dictionary<string, double> items = new Dictionary<string, double>()
{
    {"banana", 1.00 },
    {"apples", 1.50},
    {"oranges", 1.30 },
    {"bread", 1.20 },
    {"fish", 10.5 },
    {"water", 2.06 },
    {"pepsi", 1.25 },
    {"gatorade", 1.89 }
};

//Displaying items of the dictionary
foreach (var item in items)
{
    Console.WriteLine($"{item.Key} - {item.Value:c}");
}

//Creating a list, using a loop to store the name of the items customer ordered.
List<string> inputList = new List<string>();
// 
double totalPrice = 0;

bool addAnother;

do
{
    Console.Write("What item would you like to order?  ");
    string itemSelected = Console.ReadLine();
    bool doesItemExists = items.ContainsKey(itemSelected.ToLower());

    //if items doesn't exist displaying error message
    while (doesItemExists == false)
    {
        Console.Write("Sorry, we don't have those. Please try again. ");
        itemSelected = Console.ReadLine();
        doesItemExists = items.ContainsKey(itemSelected);
    }
    //if item selected exist. Adding to order to the list
    inputList.Add(itemSelected);

    //adding the price of selected items to totalPrice
    totalPrice = totalPrice + items[itemSelected];

    Console.WriteLine($"Adding \"{itemSelected}\" to the cart at {items[itemSelected]:c}");

    Console.Write("Would you like to order another item or stop (y/n):  ");
    string userInput = Console.ReadLine();

    //converting user response add/stop to true/false
    addAnother = userInput.ToLower().Trim() == "y";
} while (addAnother == true);

Console.Clear();
Console.WriteLine("Thanks for your order!");
Console.WriteLine("Here's what you got:");
//displaying the receipt
foreach (string item in inputList)
{
    Console.WriteLine($"  {item}         {items[item]:c}");
}
// Displaying total amount
Console.WriteLine($" Your total is {totalPrice:c}");

Random random = new Random();
int randomNumber = random.Next(0, 4);
randomNumber = randomNumber * 5;
Console.WriteLine($"You will get {randomNumber}% discount for your next purchase!!");

//foreach (KeyValuePair<string, double> ele in items)
//{
//    Console.WriteLine("Key = {0}, Value = {1}", ele.Key[0], ele.Value);
//}
//Console.WriteLine("First element: " + items);
