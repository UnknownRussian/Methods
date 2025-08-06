using System.Text.RegularExpressions;

public class Opgave7c
{
    public static void Run()
    {
        Console.WriteLine("Give two, or more, types of input. It can be either string, int, decimal number or boolean.\nSeperate each input with (,)");
        Console.Write("Input: ");
        string input = Console.ReadLine();
        string[] inputSplitted = input.Split(",").Select(s => s.Trim()).ToArray();
        List<InputType> types = new List<InputType>();
        for (int i = 0; i < inputSplitted.Length; i++)
        {
            if (inputSplitted[i].Equals("false") || inputSplitted[i].Equals("true"))
                types.Add(new InputType("boolean", inputSplitted[i]));
            else if (inputSplitted[i].Contains("."))
                types.Add(new InputType("decimal", inputSplitted[i]));
            else if (Regex.IsMatch(inputSplitted[i], "[a-zA-Z]"))
                types.Add(new InputType("string", inputSplitted[i]));
            else
                types.Add(new InputType("int", inputSplitted[i]));
        }

        Console.WriteLine();
        Console.WriteLine("--- Results ---");
        types.ForEach(t => Console.WriteLine($"Type: {t.Type}, User input: {t.UserInput}"));
    }

}

internal class InputType {
    public string Type { get; private set; }
    public string UserInput { get; private set; }

    public InputType(string type, string userInput)
    {
        Type = type;
        UserInput = userInput;
    }
}