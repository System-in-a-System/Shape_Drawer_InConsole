using System;
using static System.Console;

namespace Polymorphism.Domain
{
    class Rectangle : Shape
    {
        public Rectangle(int top, int left, int length, int width, ConsoleColor color)
            : base(top, left, color)
        {
            Length = length;
            Width = width;
        }

        public int Length { get; }
        public int Width { get; }



        public override void Draw(string brush)
        {
            SetCursorPosition(Left, Top);
            ForegroundColor = Color;

            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (i == 0 || j == 0 || j == Width - 1 || i == Length - 1)
                    {
                        Write("#");
                    }
                    else
                    {
                        CursorLeft++;
                    }
                }

                CursorTop++;
                CursorLeft = Left;
            }

            ForegroundColor = ConsoleColor.White;


        }
    }
}
