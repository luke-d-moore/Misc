using DrawShapes.Interfaces;
using DrawShapes.Shape;

public class Program
{
    static void Main(string[] args)
    {
        //Create the shape objects
        var shapes = new IShape[5];
        shapes[0] = new Rectangle(10, 10, 30, 40);
        shapes[1] = new Square(15, 30, 35);
        shapes[2] = new Ellipse(100, 150, 300, 200);
        shapes[3] = new Circle(1, 1, 300);
        shapes[4] = new TextBox(5, 5, 200, 100, "sample text");

        //Draw the shapes
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("Requested Drawing");
        Console.WriteLine("----------------------------------------------------------------");
        for (int i = 0; i < shapes.Length; i++)
        {
            shapes[i].Draw();
        }
        Console.WriteLine("----------------------------------------------------------------");

        Console.ReadKey();
    }
}