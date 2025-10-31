using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("red", 5);
        Cicle cicle = new Cicle("Blue", 5);
        Rectangle rectangle = new Rectangle("Yellow", 5, 4);

        shapes.Add(square);
        shapes.Add(cicle);
        shapes.Add(rectangle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
        
    }
}