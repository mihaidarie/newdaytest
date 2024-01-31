// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");

Console.WriteLine("What's your favorite alphabet char?");

var input = Console.ReadKey();

var diamondRepresentation = new DiamondGenerator().GenerateModel(input.KeyChar);

Console.WriteLine("\n");

foreach (var item in diamondRepresentation)
{
    foreach (var item2 in item)
    {
        Console.Write(item2);
    }

    Console.WriteLine("\n");
}