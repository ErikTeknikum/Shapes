using Ovningsuppgift_objektorientering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovningsuppgift_objektorientering
{
    internal class Circle : IShape
    {
        int radius = 0;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public int Area()
        {
            int area = (int)(Math.Pow(radius, 2) * 3.1415);
            return area;
        }

        public int Circumferance()
        {
            int Circumferance = (int)(2 * radius * 3.1415);
            return Circumferance;
        }
    }
}
