using System;
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
        public static readonly Size GEM_SIZE = new Size(62, 62);

        public Gem(Point position)
            : base(position, GEM_SIZE)
        {
        }
    }
}
