﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position()
        {
            
        }

        public Position(int positionX, int positionY)
        {
            X = positionX;
            Y = positionY;
        }
    }
}
