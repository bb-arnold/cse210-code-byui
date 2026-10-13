using System;

class Program
{
    static void Main(string[] args)
    {   
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("green", 4);
        Rectangle rectangle = new Rectangle("orange", 4, 5);
        Circle circle = new Circle("blue", 5);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }
    }
}