public abstract class Shape
{
    private string Color;
    public abstract double getArea();
    public Shape(string color)
    {
        this.Color = color;
    }
    public string getColor()
    {
        return Color;
    }
}

public class Traingle : Shape
{
    public double baseValue;
    public double heightValue;
    public Traingle(double b, double h, string color):base(color)
    {
        this.baseValue = b;
        this.heightValue = h;
    }
    public override double getArea()
    {
        return (baseValue * heightValue) / 2;
    }
    public void getResult()
    {
        var result = $"The area & color of {this.GetType().Name} is {this.getArea()} and {base.getColor()}";
        Console.WriteLine(result);
    }
}

public class Rectangle : Shape
{
    public double length;
    public double width;

    public Rectangle(double length, double width, string color):base(color)
    {
        this.length = length;
        this.width = width;
    }
    public override double getArea()
    {
        return (length * width);
    }
    public void getResult()
    {
        var result = $"The area and color of {this.GetType().Name} is {this.getArea()} and {base.getColor()}";
        Console.WriteLine(result);
    }
}

public class DriverCode
{
    // public static void Main(string [] args)
    // {
    //    Traingle T = new Traingle(10,20, "Blue");
    //    T.getResult();

    //    Rectangle R = new Rectangle(2,3,"Green");
    //    R.getResult();

    //    Console.ReadKey();
    // }
}