using Polymorphism.Domain;
using System;
using System.Collections.Generic;
using System.Threading;
using static System.Console;

namespace Polymorphism
{
    class Program
    {

        static List<Shape> shapeList = new List<Shape>();


        static void Main(string[] args)
        {

            CursorVisible = false;

            bool applicationRunning = true;

            do
            {
                Clear();

                WriteLine("1. Add square");
                WriteLine("2. Add rectangle");
                WriteLine("3. Add circle");
                WriteLine("4. Draw");
                WriteLine("5. Exit");

                ConsoleKeyInfo input = ReadKey(true);

                Clear();

                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        ShowAddSquareView();
                        break;

                    case ConsoleKey.D2:
                        ShowAddRectangleView();
                        break;

                    case ConsoleKey.D3:
                        ShowAddCircleView();
                        break;


                    case ConsoleKey.D4:
                        foreach (Shape shape in shapeList)
                        {
                            if (shape is Square square) square.Draw("*");
                            else if (shape is Rectangle rectangle) rectangle.Draw("*");
                            else if (shape is Circle cirlce) cirlce.Draw("*");
                        }

                        WriteLine("\n\t< Press any key to continue >");
                        ReadKey(true);

                        // back to white
                        ForegroundColor = ConsoleColor.White;
                        break;


                    case ConsoleKey.D5:
                        applicationRunning = false;
                        break;
                }

            } while (applicationRunning);

        }

        private static void ShowAddCircleView()
        {
            Write("Top: ");
            int top = int.Parse(ReadLine());

            Write("Left: ");
            int left = int.Parse(ReadLine());

            Write("Radius: ");
            int radius = int.Parse(ReadLine());

            Write("Color: ");
            ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), ReadLine(), true);


            Circle circle = new Circle(top, left, radius, color);
            shapeList.Add(circle);

            WriteLine("\n Circle added");
            Thread.Sleep(2000);
        }

        private static void ShowAddRectangleView()
        {
            Write("Top: ");
            int top = int.Parse(ReadLine());

            Write("Left: ");
            int left = int.Parse(ReadLine());

            Write("Length: ");
            int length = int.Parse(ReadLine());

            Write("Width: ");
            int width = int.Parse(ReadLine());

            Write("Color: ");
            ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), ReadLine(), true);


            Rectangle rectangle = new Rectangle(top, left, length, width, color);
            shapeList.Add(rectangle);

            WriteLine("\n Rectangle added");
            Thread.Sleep(2000);
        }

        private static void ShowAddSquareView()
        {
            Write("Top: ");
            int top = int.Parse(ReadLine());

            Write("Left: ");
            int left = int.Parse(ReadLine());

            Write("Length: ");
            int length = int.Parse(ReadLine());

            Write("Color: ");
            ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), ReadLine(), true);


            Square square = new Square(top, left, length, color);
            shapeList.Add(square);

            WriteLine("\n Square added");
            Thread.Sleep(2000);
        }
    }
}
