using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovningsuppgift_objektorientering
{
    internal class Sphere : IShape
    {
        int radius = 0;

        public Sphere(int radius)
        {
            this.radius = radius;
        }

        public int Area()
        {
            int area = (int)(4 * 3.14 * Math.Pow(radius, 2));
            return area;
        }

        public int Circumferance()
        {
            int circumferance = (int)(3.14 * 2 * radius);
            return circumferance;
        }
    }
}