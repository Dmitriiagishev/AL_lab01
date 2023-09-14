using System;
using System.Security.Cryptography.X509Certificates;

class Rectangle
{
    private double side1, side2;
    public double Area { get => CalculateArea(); }
    public double Perimeter { get => CalculatePerimeter(); }

    public Rectangle(double sideA, double sideB)
    {
        side1 = sideA;
        side2 = sideB;
    }
    private double CalculateArea()
    {
        return side1 * side2;
    }
    private double CalculatePerimeter()
    {
        return 2 * (side1 + side2);
    }
    public void print()
    {
        Console.WriteLine("Area of rectangle = " + Area + "\nPerimeter of rectangle = " + Perimeter);
    }
}
class point
{
    public int x, y;   
    public point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public void get(int x1, int y1)
    {
        x1 = x;
        y1 = y;
    }
}
class figure
{
    string name;
    point p1;
    point p2;
    point p3;
    point p4;
    point p5;
    public figure(point p1, point p2, point p3)
    {
        this.p1 = p1;
        this.p2 = p2;
        this.p3 = p3;
        this.p4 = p3;
        this.p5 = p3;
        name = "triangle"; 
    }
    public figure(point p1, point p2, point p3, point p4): this(p1, p2, p3)
    {
        this.p4 = p4;
        this.p5 = p4;
        name = "rectangle";
    }
    public figure(point p1, point p2, point p3, point p4, point p5) : this(p1, p2, p3, p4)
    {
        this.p5 = p5;
        name = "pentagon";
    }
    public double LengthSide(point a, point b)
    {
        return Math.Sqrt((a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y));
    }

    public double PerimeterCalculator()
    {
        
        return LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p4) + LengthSide(p4, p5) + LengthSide(p1, p5);
    }

    public void get()
    {
        Console.WriteLine("figure: " + name + "\nPerimeter = " + PerimeterCalculator());
    }
}
internal class Program
{
    private static void Main()
    {
        // Задание 1
        int max_int = int.MaxValue;
        int min_int = int.MinValue;
        Console.WriteLine("Excercise 1\n\nint\n" + "Max int value: " + max_int + "\nMin int value: " + min_int);
        float max_float = float.MaxValue;
        float min_float = float.MinValue;
        Console.WriteLine("float\n" + "Max float value: " + max_float + "\nMin float value: " + min_float);
        char max_char = char.MaxValue;
        char min_char = char.MinValue;
        Console.WriteLine("char\n" + "Max char value: " + max_char + "\nMin char value: " + min_char);
        bool max_bool = true;
        bool min_bool = false;
        Console.WriteLine("bool\n" + "Max bool value: " + max_bool + "\nMin bool value: " + min_bool);
        // Задание 2
        Console.WriteLine("\nExcercise 2\n");
        Console.WriteLine("Enter first side of rectangle:");
        double side1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second side of rectangle:");
        double side2 = Convert.ToDouble(Console.ReadLine());
        Rectangle rec_1 = new Rectangle(side1, side2);
        rec_1.print();
        // Задание 3
        Console.WriteLine("\nExcercise 3\n");
        Console.WriteLine("Enter 3, 4 or 5 points of figure:");
        int num = Convert.ToByte(Console.ReadLine());
        if (num < 3 || num > 5)
        {
            Console.WriteLine("Wrong number of points, it will be set to 3");
            num = 3;
        } 
        point p1 = new point(1, 1);
        point p2 = new point(1, 2);
        point p3 = new point(2, 2);
        point p4 = new point(2, 1);
        point p5 = new point(0, 0);
        
        if (num == 3)
        {
            figure f_new = new figure(p1, p2, p3);
            f_new.get();
        } else if (num == 4)
        {
            figure f_new = new figure(p1, p2, p3, p4);

            f_new.get();
        } else if (num == 5)
        {
            figure f_new = new figure(p1, p2, p3, p4, p5);
            f_new.get();
        }
    }
}
