public class Opgave7a
{
    private static TempUnit unit = TempUnit.Celsius;

    public static void Run()
    {
        UnitPicker();
        Console.Write("Please write a temprature: ");
        double temp = double.Parse(Console.ReadLine()!);
        PrintConversion(temp);
    }

    private static void PrintConversion(double temp)
    {
        if (unit == TempUnit.Celsius)
        {
            Console.WriteLine($"Celsius: {temp}");
            Console.WriteLine($"Fahrenheit: {(temp * 9 / 5) + 32}");
            Console.WriteLine($"Kelvin: {temp + 273.15}");
            Console.WriteLine($"Réaumur: {temp * 4 / 5}");
        }
        else if (unit == TempUnit.Fahrenheit)
        {
            Console.WriteLine($"Fahrenheit: {temp}");
            Console.WriteLine($"Celsius: {(temp - 32) * 5/9}");
            Console.WriteLine($"Kelvin: {((temp - 32) * 5/9) + 273.15}");
            Console.WriteLine($"Réaumur: {(temp - 32) * 4/9}");
        }
    }

    private static void UnitPicker()
    {
        bool loopOfDeath = true;
        while (loopOfDeath)
        {
            Console.WriteLine("Choose temprature unit:");
            Console.WriteLine("1. Celsius");
            Console.WriteLine("2. Fahrenheit");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    unit = TempUnit.Celsius;
                    loopOfDeath = false;
                    break;
                case "2":
                    unit = TempUnit.Fahrenheit;
                    loopOfDeath = false;
                    break;
                default:
                    Console.WriteLine("Bruh...");
                    break;
            }
        }
    }
}

internal enum TempUnit
{
    Celsius,
    Fahrenheit
}