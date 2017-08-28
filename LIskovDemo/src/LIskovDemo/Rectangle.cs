using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIskovDemo
{
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }


        public void SetHeight(int height)
        {
            this.Height = height;
        }

        public void SetWidth (int width)
        {
            this.Width = width;
        }

        public int GetArea ()
        {
            return Width * Height;
        }
    }
}
