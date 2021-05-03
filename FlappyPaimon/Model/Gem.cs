﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FlappyPaimon.Model
{
    /// <summary>
    /// Represents a gem. Scoring a gem will increase the score by 10.
    /// </summary>
    public class Gem : CollidableItem
    {
        public Gem(Point position, Size size)
            : base(position, size)
        {
        }
    }
}
