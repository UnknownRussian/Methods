public class Opgave6
{
    private static int tries = 5;
    private static int num = 0;

    public static void StartGame()
    {
        Console.WriteLine("Let play a game...");
        Console.WriteLine("Guess a number between 1 and 25");
        num = GenNum();
        do
        {
            Console.WriteLine($"You have {tries} left");
            int userGuess = int.Parse(Console.ReadLine());
            int ctrl = Control(userGuess);
            Console.WriteLine(Msg(ctrl));
            if (ctrl == 0) break;
            tries--;
            if (tries == 0) Console.WriteLine("You lost!");
        } while (tries != 0);
    }

    private static int GenNum()
    {
        return new Random().Next(1, 25);
    }

    private static int Control(int userGuess)
    {
        if (userGuess > num) return 1;
        else if (userGuess < num) return -1;
        else return 0;
    }

    private static string Msg(int ctrlNum)
    {
        switch (ctrlNum)
        {
            case -1:
                return "To Low";
            case 1:
                return "To High";
            case 0:
                return "Yea boi!";
            default:
                return "Error 40";
        }
    }
}