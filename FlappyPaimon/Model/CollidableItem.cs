using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FlappyPaimon.Model
{
    /// <summary>
    /// An <see cref="Item"/> with a hit box and thus supports collision detection.
    /// </summary>
    public abstract class CollidableItem : Item
    {
        /// <summary>
        /// Computed hit box of the <see cref="CollidableItem"/>.
        /// </summary>
        public Rect HitBox => new Rect(Position, Size);

        public CollidableItem(Point position, Size size)
            : base(position, size)
        {
        }
    }
}
