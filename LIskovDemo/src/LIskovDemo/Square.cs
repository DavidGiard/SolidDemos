using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIskovDemo
{
    public class Square : Rectangle
    {
        public new void SetHeight(int height)
        {
            this.Height = height;
            this.Width = height;
        }

        public new void SetWidth(int width)
        {
            this.Width = width;
            this.Height = width;
        }

    }
}
