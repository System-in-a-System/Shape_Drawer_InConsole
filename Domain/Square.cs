using System;
using static System.Console;

namespace Polymorphism.Domain
{
    class Square : Shape
    {
        public Square(int top, int left, int length, ConsoleColor color)
            : base(top, left, color)
        {
            Length = length;
        }

        public int Length { get; }


        public override void Draw(string brush)
        {
                        
            SetCursorPosition(Left, Top);
            ForegroundColor = Color;

            string borderLine = "";
            for (int i = 1; i <= Length; i++)
            {
                borderLine += brush;
            }

            
            string middlePart = "";
            for (int i = 3; i <= Length; i++)
            {
                // New row
                middlePart += "\n";

                // Identation
                for (int l = 0; l < Left; l++)
                {
                    middlePart += " ";
                }


                for (int j = 1; j <= Length; j++)
                {
                    if (j == 1 || j == Length)
                    {
                        middlePart += brush;
                    }
                    else
                    {
                        middlePart += " ";
                    }
                }
            }

            // New row
            middlePart += "\n";
            // Identation
            for (int i = 0; i < Left; i++)
            {
                middlePart += " ";
            }


            string square = borderLine + middlePart + borderLine;
            
            WriteLine(square);
        }

    }
}
