using System;

public abstract class Shape
{
    public abstract void SetWidth(double width);
    public abstract void SetHeight(double height);
    public abstract double GetArea();
}

public class Rectangle : Shape
{
    private double width;
    private double height;

    public override void SetWidth(double width)
    {
        this.width = width;
    }

    public override void SetHeight(double height)
    {
        this.height = height;
    }

    public override double GetArea()
    {
        return width * height;
    }
}

public class Square : Shape
{
    private double side;

    public override void SetWidth(double width)
    {
        side = width;
    }

    public override void SetHeight(double height)
    {
        side = height;
    }

    public override double GetArea()
    {
        return side * side;
    }
}

class Program
{
    static void Main()
    {
        Shape rectangle = new Rectangle();
        rectangle.SetWidth(5);
        rectangle.SetHeight(10);
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");

        Shape square = new Square();
        square.SetWidth(5);
        square.SetHeight(10);
        Console.WriteLine($"Square Area: {square.GetArea()}");
    }
}
