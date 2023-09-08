using Ovningsuppgift_objektorientering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovningsuppgift_objektorientering
{
    internal class Cylinder : IShape
    {
        int radius = 0;
        int height = 0;

        public Cylinder(int radius, int height)
        {
            this.radius = radius;
            this.height = height;
        }

        public int Area()
        {
            int area = (int)(2 * 3.1415 * radius * (radius + height));
            return area;
        }

        public int Circumferance()
        {
            int Circumference = (int)(2 * 1.1415 * radius);
            return Circumference;
        }
    }
}
