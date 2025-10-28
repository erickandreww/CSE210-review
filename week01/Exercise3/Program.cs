using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Magic Number Game");
        string again = "yes";

        while (again == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            int attemps = 0;
            int answer;

            do
            {
                Console.Write("What is the magic number? ");
                answer = int.Parse(Console.ReadLine());
                if (answer < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (answer > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                attemps++;
            } while (answer != magicNumber);

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"{attemps} attemps!");
            Console.Write($"Do you want to try again? ");
            again = Console.ReadLine();
        }
    }
}