using System;

namespace AreaCalculator;
using System;

class Program // Math.PI is value of (pi)
{
    static void Main(string[] args) // User picks Shape
    {
        Console.WriteLine("Choose a shape:");
        Console.WriteLine("1. Circle");
        Console.WriteLine("2. Triangle");
        Console.WriteLine("3. Rectangle");
        Console.WriteLine("4. Square");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        if (choice == "1")  
            CalculateCircleArea(); // First static option for later
        else if (choice == "2") 
            CalculateTriangleArea();
        else if (choice == "3")  
            CalculateRectangleArea();
        else if (choice == "4")
            CalculateSquareArea();
        else
            Console.WriteLine("Invalid choice");
    }

    static void CalculateCircleArea() // First static solution 
    {
        Console.Write("Enter radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * radius * radius;
        Console.WriteLine("Area of Circle: " + area);
    }

    static void CalculateTriangleArea()
    {
        Console.Write("Enter base: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter height: ");
        double h = Convert.ToDouble(Console.ReadLine());
        double area = 0.5 * b * h;
        Console.WriteLine("Area of Triangle: " + area);
    }

    static void CalculateRectangleArea()
    {
        Console.Write("Enter width: ");
        double w = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter height: ");
        double h = Convert.ToDouble(Console.ReadLine());
        double area = w * h;
        Console.WriteLine("Area of Rectangle: " + area);
    }

    static void CalculateSquareArea()
    {
        Console.Write("Enter width: ");
        double w = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter height: ");
        double h = Convert.ToDouble(Console.ReadLine());
        double area = w * h;
        Console.WriteLine("Area of Square: " + area);
    }
    

public static double CalculateCircleArea(double radius)

    {
        return Math.PI * Math.Pow(radius, 2);
    }
} // πr²
    

    



