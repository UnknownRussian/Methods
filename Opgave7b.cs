public class Opgave7b
{
    public static void Run()
    {
        try
        {
            Console.Write("Please write a whole number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Decimal: {ConvertToDecimal(num)}");
            Console.WriteLine($"Hexadecimal: {ConvertToHex(num)}");
            Console.WriteLine($"Binary: {ConvertToBin(num)}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.GetBaseException()}");
            Console.WriteLine("Bruh...");
        }

    }

    private static decimal ConvertToDecimal(int num)
    {
        return new decimal(num);
    }

    private static string ConvertToHex(int num)
    {
        return num.ToString("X4");
    }

    private static string ConvertToBin(int num)
    {
        return Convert.ToString(num, 2);
    }
}