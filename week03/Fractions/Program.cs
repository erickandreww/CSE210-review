using System;

class Program
{
    static void Main(string[] args)
    {
        List<Fractions> fractions = new List<Fractions>();

        Fractions f1 = new Fractions();
        Fractions f2 = new Fractions(5);
        Fractions f3 = new Fractions(3, 4);
        Fractions f4 = new Fractions(1, 3);
        
        foreach (Fractions fract in fractions)
        {
            Console.WriteLine(fract.GetFractionString());
            Console.WriteLine(fract.GetDecimalValue());
        }
    }
}