using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FlappyPaimon.Model
{
    /// <summary>
    /// A <see cref="CollidableItem"/> is an <see cref="Item"/> with a hitbox.
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
            // No more things to do here. The hit box is computed on-demand.
        }
    }
}
