using System;

class Program
{
    static void Main(string[] args)
    {
        Square sqr = new  Square("green", 4);
        Rectangle rectangle =  new Rectangle("Black", 4.3, 4.3 );
        Circle circle = new Circle("Blue", 2.5);
        // Console.WriteLine($" {sqr.GetColor()},{sqr.GetArea()}");
        // Console.WriteLine($" {rectangle.GetColor()},{rectangle.GetArea()}");
        // Console.WriteLine($" {circle.GetColor()},{circle.GetArea()}");

        List<Shape> shapeList =  new  List<Shape>();

        shapeList.Add(sqr);
        shapeList.Add(rectangle);
        shapeList.Add(circle);

        foreach (Shape shapes  in shapeList)
        {
            DisplayArea( shapes);
        }

        static  void DisplayArea(Shape shapes)
        {
            Console.WriteLine($"{shapes.GetColor()}, {shapes.GetArea()}");
        }
    }
}