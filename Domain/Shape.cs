using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Domain
{
    abstract class Shape
    {
        protected Shape(int top, int left, ConsoleColor color)
        {
            Top = top;
            Left = left;
            Color = color;
        }

        public int Top { get; set; } 
        public int Left { get; set; }
        public ConsoleColor Color { get; }

        
        public abstract void Draw(string brush);
    }
}
