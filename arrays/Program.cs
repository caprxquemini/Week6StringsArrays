
string[] fruitBasket = { "apples", "bananas", "grapes" };

Console.WriteLine($"There are {fruitBasket.Length} types of fruit in the basket.");

for (int i = 0; i < fruitBasket.Length; i++)
{
    Console.WriteLine(fruitBasket[i]);
}

fruitBasket[0] = "lemons";
fruitBasket[1] = "strawberries";


for (int i = 0; i < fruitBasket.Length; i++)
{
    Console.WriteLine(fruitBasket[i]);
}