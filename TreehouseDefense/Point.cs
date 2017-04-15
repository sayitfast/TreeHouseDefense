using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    internal class Point
    {
        public readonly int Y;
        public readonly int X;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int DistanceTo(int x, int y)
        {
            //int xDiff = X - x;
            //int yDiff = Y - y;

            //int xDiffSquared = xDiff * xDiff;
            //int yDiffSquared = yDiff * yDiff;

            //return (int) Math.Sqrt(xDiffSquared + yDiffSquared);

            return (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2)); // same as above
        }
    }
}