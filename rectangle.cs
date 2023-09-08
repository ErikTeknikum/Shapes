using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovningsuppgift_objektorientering
{
    internal class Rectangle: IShape
    {
        int width = 0;
        int height = 0;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Area()
        {
            int area = width * height;
            return area;
        }

        public int Circumferance()
        {
            int circumferance = (width + height) * 2;
            return circumferance;
        }
    }
}