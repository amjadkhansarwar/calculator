using System;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Blue; 
        string calculator = "Calculator";
        int screenWidth = Console.WindowWidth;
        int textWidth = calculator.Length;
        int leftMargin = (screenWidth - textWidth) / 2;
        string centeredText = new string(' ', leftMargin) + calculator;
        Console.WriteLine(centeredText);

        Console.WriteLine();
        Console.WriteLine("Eller skriv avsluta");
    }
}