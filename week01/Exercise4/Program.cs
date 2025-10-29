using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        int largest = 0;
        int smallest = 999999999;
        
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
            if (numbers[i] < largest && numbers[i] > 0)
            {
                smallest = numbers[i];
            }
        }
        float average = ((float)sum) / numbers.Count;
        numbers.Sort();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine("The sorted list is:");
        numbers.ForEach(Console.WriteLine);
        
    }
}