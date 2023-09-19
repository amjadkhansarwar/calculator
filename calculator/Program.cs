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
        var allLines = File.ReadAllLines("../../../Files/student.csv");

        List<string> ages = new List<string>();

        foreach (var line in allLines)
        {
            string[] values = line.Split(',');
            if(values.Length >= 2)
            {
                string age = values[1];
                ages.Add(age);
            }
        }
        foreach(string age in ages)
        {
            int ageValue;
            ageValue = Convert.ToInt32(age);
            if (ageValue % 2 == 0)
                Console.WriteLine(ageValue);
        }
            Console.ReadLine();
    }
}