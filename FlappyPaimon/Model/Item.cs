using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FlappyPaimon.Model
{
    /// <summary>
    /// A general game element.
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
        /// <remarks>
        /// The 0 (zero) point of the coordination system is located at the top-left corner,
        /// with values increasing going down and right, respectively for X- and Y-axis.
        /// </remarks>
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
        /// Update the current <see cref="Item"/> so as to progress the game. Called periodically by <see cref="FlappyPaimonModel"/>.
        /// </summary>
        /// <param name="deltaX">The span to move (positive goes to left).</param>
        /// <remarks>
        /// The default behavior is moving things left (down to zero).
        /// </remarks>
        public virtual void Update()
        {
            Position = new Point(Position.X + ITEM_MOVE_SPEED, Position.Y);
        }
    }
}
