using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovningsuppgift_objektorientering
{
    internal class Triangle : IShape
    {
        int width = 0;
        int height = 0;

        public Triangle(int width, int height)
        {

        }

        public int Area()
        {
            int area = (width*height) / 2;
            return area;
        }

        public int Circumferance()
        {
            int circumferance = (int)Math.Sqrt(width * width + height * height) + width + height;
            return circumferance;
        }
    }
}
