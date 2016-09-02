using System;
using System.Security.Cryptography;

class AreaOfFigures
{
    public static double TriangleArea ()
    {
        double side = double.Parse ( Console.ReadLine () );
        double height = double.Parse ( Console.ReadLine () );
        return side * height / 2;
    }

    public static double SquareArea ()
    {
        double side = double.Parse ( Console.ReadLine () );
        return side * side;
    }

    public static double RectangleArea ()
    {
        double sideA = double.Parse ( Console.ReadLine () );
        double sideB = double.Parse ( Console.ReadLine () );
        return sideA * sideB;
    }

    public static double CircleArea ()
    {
        double radius = double.Parse ( Console.ReadLine () );
        return Math.PI * radius * radius;
    }

    public static void Main ( string[] args )
    {
        string figure = Console.ReadLine ().ToLower ();
        double result = 0;

        switch ( figure )
        {
            case "triangle":
                result = TriangleArea ();
                break;
            case "square":
                result = SquareArea ();
                break;
            case "rectangle":
                result = RectangleArea ();
                break;
            case "circle":
                result = CircleArea ();
                break;
            default:
                break;
        }

        Console.WriteLine ("{0:0.###}", result);
    }
}
