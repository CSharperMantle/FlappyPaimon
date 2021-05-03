using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FlappyPaimon.Model
{
    /// <summary>
    /// An <see cref="Item"/> is a general game element.
    /// </summary>
    public abstract class Item
    {
        /// <summary>
        /// Moving speed of all general <see cref="Item"/>s.
        /// </summary>
        public const double ITEM_MOVE_SPEED = -1;

        /// <summary>
        /// Top-left coordination of the <see cref="Item"/>.
        /// </summary>
        /// The 0 (zero) point of the coordination system is located at the top-left corner,
        /// with values increasing going down and right, respectively for X- and Y- axis.
        public Point Position { get; protected set; }

        /// <summary>
        /// Size of the <see cref="Item"/>.
        /// </summary>
        public Size Size { get; protected set; }

        public Item(Point position, Size size)
        {
            Position = position;
            Size = size;
        }

        /// <summary>
        /// Default method to update the current <see cref="Item"/>, to move things left (down to zero).
        /// </summary>
        /// <param name="deltaX">The span to move (positive goes to left).</param>
        public virtual void Update()
        {
            Position.Offset(ITEM_MOVE_SPEED, 0);
        }
    }
}
