using System;

namespace Shapes
{
    class Program
    {

        static void Main(string[] args)
        {
        Start:

            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Triangle");
            Console.WriteLine("4. Diamond ");
            Console.WriteLine("Select a number on what shape would you like to choose:");
            string userChoice = Console.ReadLine();

            double area;
            double perimeter;


            if (userChoice == "1")
            {
                Console.WriteLine("please enter the rectangles height:");
                int height = int.Parse(Console.ReadLine());
                Console.WriteLine("please enter the rectangles width:");
                int width = int.Parse(Console.ReadLine());
                for (int i = 1; i <= width; i++)
                {
                    for (int j = 1; j <= height; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");

                }
                area = height * width;
                perimeter = 2 * height + 2 * width;
                Console.WriteLine("area: {0}, perimeter:{1}", area, perimeter);
            }
            else if (userChoice == "2")
            {
                Console.WriteLine("please enter the square side length: ");
                int squareSide = Int32.Parse(Console.ReadLine());
                for (int i = 1; i <= squareSide; i++)
                {
                    for (int j = 1; j <= squareSide; j++)
                    {

                        Console.Write("*");

                    }
                    Console.WriteLine();
                }
                area = squareSide * squareSide;
                perimeter = 4 * squareSide;
                Console.WriteLine("Area: {0}, perimeter:{1}", area, perimeter);
            }

            else if (userChoice == "3")
            {
                int triangleSide, i, j, count = 1;
                Console.Write("please enter the triangles side length:");
                triangleSide = int.Parse(Console.ReadLine());
                count = triangleSide - 1;
                for (j = 1; j <= triangleSide; j++)
                {

                    for (i = 1; i <= count; i++)
                        Console.Write(" ");
                    count--;

                    for (i = 1; i <= 2 * j - 1; i++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                double triangleBase = 2 * triangleSide - 1;
                double height = triangleSide;
                area = (triangleBase * height) / 2;
                perimeter = triangleBase + 2 * triangleSide;
                Console.WriteLine("area: {0}, perimeter:{1}", area, perimeter);
            }
            else if (userChoice == "4")
            {
                int i, j, diamondSide;
                Console.Write("please enter the diamonds side length:");
                diamondSide = Convert.ToInt32(Console.ReadLine());
                for (i = 0; i <= diamondSide; i++)
                {
                    for (j = 1; j <= diamondSide - i; j++)
                        Console.Write(" ");
                    for (j = 1; j <= 2 * i - 1; j++)
                        Console.Write("*");
                    Console.Write("\n");
                }

                for (i = diamondSide - 1; i >= 1; i--)
                {
                    for (j = 1; j <= diamondSide - i; j++)
                        Console.Write(" ");
                    for (j = 1; j <= 2 * i - 1; j++)
                        Console.Write("*");
                    Console.Write("\n");
                }
                double diagonal = 2 * diamondSide - 1;
                area = diagonal * diagonal / 2;
                perimeter = 4 * diamondSide;
                Console.WriteLine("Area: {0}, perimeter:{1}", area, perimeter);

            }

        Decide:
            Console.WriteLine("Another shape? Y/N");
            string userAnswer = Console.ReadLine().ToLower();

            switch (userAnswer)
            {
                case "y":
                    goto Start;
                case "n":
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again");
                    goto Decide;

            }
        }
    }
}