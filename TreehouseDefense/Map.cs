using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    internal class Map
    {
        // instance variables
        public readonly int Width;

        public readonly int Height;

        // constructor
        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point)
        {
            // bool inBounds = point.X >= 0 && point.X < Width && point.Y >= 0 && point.Y < Height;

            // bool inBounds = !(point.X < 0 || point.Y >= Width || point.Y < 0 || point.Y >= Height);  // same thing as above using or instead of and

            // return inBounds;

            return point.X >= 0 && point.X < Width && point.Y >= 0 && point.Y < Height;
        }
    }
}