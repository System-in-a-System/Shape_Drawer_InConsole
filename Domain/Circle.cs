using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Polymorphism.Domain
{
    class Circle : Shape
    {
        public Circle(int top, int left, int radius, ConsoleColor color)
            : base(top, left, color)
        {
            Radius = radius;
        }
        

        public int Radius { get; }


        public override void Draw(string brush)
        {
            SetCursorPosition(Left, Top);
            ForegroundColor = Color;

            double rIn = Radius - 1, rOut = Radius + 1;

            for (int i = Radius; i >= -Radius; --i)
            {

                SetCursorPosition(Left, Top++);

                for (int j = -Radius; j < rOut; j++)
                {
                    double value = j * j + i * i;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write(brush);
                    }
                    else
                    {
                        CursorLeft++;
                    }
                }
                
                WriteLine();
            }

            Console.ReadKey();

            ForegroundColor = ConsoleColor.White;
        }
    }
}
