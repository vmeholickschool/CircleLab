using CircleLab;
using System;

Console.WriteLine("Welcome to the Circle Tester");

double radius; //variable to store radius
Circle circle; // Variable to store our Circle object


while (true)
{
    Console.Write("Enter radius: ");
    string input = Console.ReadLine();


    if (double.TryParse(input, out radius))
    {

        if (Validator.ValidateRadius(radius))
        {
            circle = new Circle(radius);
            break;
        }
        else
        {

            Console.WriteLine("Invalid input. Radius must be greater than zero.");
        }
    }
    else
    {

        Console.WriteLine("Invalid input. Please enter a valid number for the radius.");
    }
}


Console.WriteLine($"Diameter: {circle.CalculateDiameter()}");
Console.WriteLine($"Circumference: {circle.CalculateCircumference()}");
Console.WriteLine($"Area: {circle.CalculateArea()}");

string choice;

do
{
    Console.Write("Should the circle grow? (y/n): ");
    choice = Console.ReadLine().ToLower();
    Console.WriteLine();


    if (choice == "yes" || choice == "y")
    {
        circle.Grow();
        Console.WriteLine("The circle is magically growing.");

        Console.WriteLine($"Diameter: {circle.CalculateDiameter()}");
        Console.WriteLine($"Circumference: {circle.CalculateCircumference()}");
        Console.WriteLine($"Area: {circle.CalculateArea()}");
    }
} while (choice == "yes" || choice == "y");


Console.WriteLine($"Goodbye. The circle’s final radius is {circle.GetRadius()}.");

ExitProgram.WaitForAnyKeyToExit();


