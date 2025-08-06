using System;
using System.Runtime.InteropServices;

namespace ConsoleApp
{
    public class Program
    {
        private static bool isRunning = true;
        public static void Main(string[] args)
        {
            while (isRunning)
            {
                string[] btns = [
                    "Opgave 1",
                    "Opgave 2",
                    "Opgave 3",
                    "Opgave 4",
                    "Opgave 5",
                    "Opgave 6",
                    "Opgave 7a",
                    "Opgave 7b",
                    "Opgave 7c"
                ];

                Console.WriteLine("--- Main Menu ---");
                for (int i = 0; i < btns.Length; i++)
                    Console.WriteLine($"{i + 1}. {btns[i]}");
                Console.WriteLine("0. Exit Program");
                Console.Write("Option: ");
                string option = Console.ReadLine()!;

                if (option.Equals("0")) break;

                while (true)
                {
                    bool isError = false;
                    switch (option)
                    {
                        case "1":
                            Console.WriteLine(Opg1());
                            break;
                        case "2":
                            Opg2();
                            break;
                        case "3":
                            Console.WriteLine("Pick 3 whole numbers:");
                            int[] nums = new int[3];
                            for (int i = 0; i < nums.Length; i++) nums[i] = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Sum: {Opg3(nums)}");
                            Console.WriteLine($"Substraction: {Opg3a(nums)}");
                            Console.WriteLine($"Multiplication: {Opg3b(nums)}");
                            Console.WriteLine($"Sum of 2 numbers devided with 1 number: {Opg3c([nums[0], nums[1]], nums[2])}");
                            break;
                        case "4":
                            Console.Write("Write you name: ");
                            string name = Console.ReadLine();
                            Console.Write("Age (whole number): ");
                            int age = int.Parse(Console.ReadLine());
                            Console.WriteLine(Opg4(name, age));
                            break;
                        case "5":
                            Console.Write("Write a string with word seperated by a comma: ");
                            string str = Console.ReadLine();
                            Opg5(str).ToList().ForEach(word => Console.WriteLine(word));
                            break;
                        case "6":
                            Opgave6.StartGame();
                            break;
                        case "7":
                            Opgave7a.Run();
                            break;
                        case "8":
                            Opgave7b.Run();
                            break;
                        case "9":
                            Opgave7c.Run();
                            break;
                        default:
                            isError = true;
                            Console.WriteLine($"You wrote: {option}. Really?! Thats an error 40, try again!");
                            break;
                    }

                    if (isError) break;

                    Console.Write("Try again? (y/n): ");
                    string answer = Console.ReadLine();
                    option = answer == "y" ? option : "0";


                    if (option == "0") break;
                }
            }
        }

        private static string Opg1() => "Hello World"; // <-- Shit here!
        private static string opg1 = "Hello World!"; // <-- Same shit!

        private static void Opg2()
        {
            Console.WriteLine("Write somestuff:");
            string input = Console.ReadLine();
            Console.WriteLine($"You wrote: {input}");
        }

        private static int Opg3(int[] nums) => nums.Sum();

        private static int Opg3a(int[] nums)
        {
            int sum = nums[0];
            for (int i = 1; i < nums.Length; i++)
                sum -= nums[i];
            return sum;
        }

        private static int Opg3b(int[] nums)
        {
            int sum = nums[0];
            for (int i = 1; i < nums.Length; i++)
                sum *= nums[i];
            return sum;
        }

        private static double Opg3c(int[] nums, double d) => nums.Sum() / d;

        private static string Opg4(string name, int age)
        {
            string txt;
            if (age == 0 || age == 1)
                txt = "Du er nyfødt";
            else if (age == 2 || age == 3)
                txt = "Du er i dagplage eller vuggestue";
            else if (age == 4 || age == 5)
                txt = "Du er i børnehave";
            else if (age >= 6 && age <= 18)
                txt = "Du går i skole";
            else
                txt = "Nu begynder livet at blive alvor";

            return $"{name} - {txt}";
        }

        private static string[] Opg5(string txt) => txt.Split(",").Select(s => s.Trim()).ToArray();
    }
}
