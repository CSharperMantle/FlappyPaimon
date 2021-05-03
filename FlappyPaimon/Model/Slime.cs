using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FlappyPaimon.Model
{
    /// <summary>
    /// Represents a slime. The game will end if the <see cref="Player"/> hits a slime.
    /// </summary>
    public class Slime : CollidableItem
    {
        public Slime(Point position, Size size)
            : base(position, size)
        {
        }
    }
}
