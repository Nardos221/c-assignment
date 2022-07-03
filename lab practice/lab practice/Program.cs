public interface Shape
{
    public double getArea();
    public double getPerimeter();

}


class Circle : Shape
{
    static double PI = 3.14;
    int _radius;
    public int radius
    {
        get => _radius;
        set => _radius = value;
    }

    public double getArea()
    {
        return PI * (radius * radius);

    }
    public double getPerimeter()
    {
        return 2 * PI * radius
            ;
    }

}
class Triangle : Shape
{
    int _base;
    int _height;
    int _length1;
    int _length2;
    public int base1
    {
        get => _base;
        set => _base = value;
    }
    public int height
    {
        get => _height;
        set => _height = value;
    }
    public int length1
    {
        get => _length1;
        set => _length1 = value;
    }
    public int lenght2
    {
        get => _length2;
        set => _length2 = value;
    }
    public double getArea()
    {
        return 1 / 2 * (base1 * height);

    }
    public double getPerimeter()
    {
        return length1 + _length2 + base1;
    }


}
class Square : Shape
{
    int _length;
    int _width;
    public int length

    {
        get { return _length; }
        set { _length = value; }
    }

    public int width
    {
        get { return _width; }
        set { _width = value; }
    }
    public double getArea()
    {
        return width * length;

    }
    public double getPerimeter()
    {
        return 2 * (width + length);
    }
}
class major
{
    public static void Main(string[] args)
    {

        Circle circle = new Circle();
        Console.WriteLine("CIRCLE");
        Console.WriteLine("Enter your radus");
        circle.radius = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Area: ");
        Console.WriteLine(circle.getArea());
        Console.WriteLine("Perimeter: ");
        Console.WriteLine(circle.getPerimeter());

        Console.WriteLine("SQUARE");
        Square square = new Square();
        Console.WriteLine("Enter your length");
        square.length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your width");
        square.width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Area: ");
        Console.WriteLine(square.getArea());
        Console.WriteLine("Perimeter: ");
        Console.WriteLine(square.getPerimeter());

        Console.WriteLine("TRIANGLE");
        Triangle triangle = new Triangle();
        Console.WriteLine("Enter your base");
        triangle.base1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your height");
        triangle.height = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your length 1");
        triangle.length1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your length 2");
        triangle.lenght2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Area: ");
        Console.WriteLine(triangle.getArea());
        Console.WriteLine("Perimeter: ");
        Console.WriteLine(triangle.getPerimeter());



    }
}

