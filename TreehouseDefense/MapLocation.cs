﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class MapLocation : Point
    {
        // point class constructor
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if (!map.OnMap(this))
            {
                throw new OutOFBoundsException(x + ", " + y + " is outside the boundaries of the map");
            }
        }
    }
}
