using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = new List<Shape>();
        shapeList.Add(new Square("red", 10));
        shapeList.Add(new Rectangle("orange", 5, 20));
        shapeList.Add(new Circle("yellow", 6));
        shapeList.Add(new Rectangle("green", 50, 60));
        shapeList.Add(new Circle("blue", 31));
        shapeList.Add(new Square("purple", 55));

        foreach (Shape shape in shapeList)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea().ToString("0.000")}");
        }

    }
}