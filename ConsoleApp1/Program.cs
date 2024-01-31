// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("What's your favorite alphabet char?");

var input = Console.ReadKey();

var diamondRepresentation = new DiamondGenerator().GenerateModel(input.KeyChar);

Console.WriteLine("\n");

Console.WriteLine("Use _ to display the diamond? Y/N");

var useDash = Console.ReadKey().KeyChar.ToString().ToUpper() == "Y";

Console.WriteLine("\n");

foreach (var item in diamondRepresentation)
{
    foreach (var item2 in item)
    {
        if (useDash)
        {
            if (item2 == ' ')
            {
                Console.Write('_');
            }
            else
            {
                Console.Write(item2);
            }
        }
        else
        {
            Console.Write(item2);
        }
    }

    Console.WriteLine("\n");
}