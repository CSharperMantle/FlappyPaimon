using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FlappyPaimon.Model
{
    /// <summary>
    /// Represents a pipe. The game will end if the <see cref="Player"/> hits a pipe.
    /// </summary>
    public class Pipe : CollidableItem
    {
        public Pipe(Point position, Size size)
            : base(position, size)
        {
            throw new NotImplementedException();
        }
    }
}
