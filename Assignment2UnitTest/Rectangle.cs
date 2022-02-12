using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2UnitTest
{
    public class Rectangle
    {
        private int length;
        private int width;
        public Rectangle()
        {
            length = 1;
            width = 1;
        }
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int GetLength()
        {
            return length;
        }
        public int SetLength(int length)
        {
            this.length = length;
            return length;
        }
        public int GetWidth()
        {
            return width;
        }
        public int SetWidth(int width)
        {
            this.width = width;
            return width;
        }
        public int GetPerimeter()
        {
            int peri = 2 * (length + width);
            return (peri);
        }
        public int GetArea()
        {
            int area = (length * width);
            return (area);
        }
    }
}
