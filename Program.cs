using System;
public class Area
{
    public static void Main()
    {
        Console.WriteLine("Please, enter the Length of your rectangle: ");
        int Length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Thank you. Now, please enter the width of your rectangle: ");
        int Width= Convert.ToInt32(Console.ReadLine());
        int Area = Length * Width;
        Console.WriteLine("A rectangle with a length of " + Length +" and a width of " + Width + " is " +Area);
        Console.ReadKey();
    }
    }
