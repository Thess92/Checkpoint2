using Checkpoint2;
using System.Diagnostics;

List<Product> products = new List<Product>();

while (true)
{
    Console.WriteLine("To enter a new product - follow the steps | To quit - type: 'Q'");

    Console.Write("Enter Category: ");
    string category = Console.ReadLine(); //Takes user input and saves it in variable 'category'.

    if (category.ToUpper().Trim() == "Q") // Ends the loop if the user types 'Q'.
    {
        break;
    }

    Console.Write("Enter Product Name: ");
    string productName = Console.ReadLine(); //Takes user input and saves it in variable 'productName'.

    Console.Write("Enter Price: ");
    double price = Convert.ToDouble(Console.ReadLine()); //Takes user input and saves it in variable 'price'.

    products.Add(new Product(category, productName, price)); // Creates a new instance of the Product class with the user inputs, then adds it to list 'products'.
    Console.WriteLine("The product was successfully added!");
    Console.WriteLine("-----------------------------------------");
}

List<Product> sortedProducts = products.OrderBy(x => x.Price).ToList(); // Sorts the products by price from low to high and saves them in a new list.

Console.WriteLine();
Console.WriteLine("-----------------------------------------");
Console.WriteLine("Your added products:");
Console.WriteLine("Category".PadRight(15) + "Product Name".PadRight(15) + "Price");

foreach (var product in sortedProducts)
{
    Console.WriteLine(product.Category.PadRight(15) + product.ProductName.PadRight(15) + product.Price); // Displays each product in the list 'sortedProducts'.
}

double priceSum = products.Sum(x => x.Price); // Calculates the sum of all the products in the list.

Console.WriteLine("-----------------------------------------");
Console.WriteLine("Total price sum: " + priceSum);

Console.ReadLine();