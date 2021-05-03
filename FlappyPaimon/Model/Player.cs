using System;
using System.Windows;

namespace FlappyPaimon.Model
{
    /// <summary>
    /// Represents the player.
    /// </summary>
    public class Player : CollidableItem
    {
        /// <summary>
        /// Acceleration const used when <see cref="UpdateY"/> is invoked.
        /// </summary>
        public const double ACCELERATION_Y = 0.5;

        /// <summary>
        /// Speed granted when jumping.
        /// </summary>
        public const double JUMP_SPEED_Y = -10;

        /// <summary>
        /// Momentum (<see cref="Point.Y"/> units per update) of the player in Y direction.
        /// A positive value means going down while a negative value means going up.
        /// </summary>
        public double SpeedY { get; private set; } = 0;

        public Player(Point position, Size size)
            : base(position, size)
        {
        }

        /// <summary>
        /// Update (refresh) momentum and position on Y-axis. This differs from the default behavior,
        /// as the player cannot go horizontally.
        /// </summary>
        public override void Update()
        {
            // Firstly, lets increase the momentum by a small delta (acceleration), which means slowing down and going down.
            SpeedY += ACCELERATION_Y;
            // Then move according to the speed.
            Position.Offset(0, SpeedY);
        }

        /// <summary>
        /// Jump. Set the <see cref="SpeedY"/> to a very negative value to jump up.
        /// </summary>
        public void Jump()
        {
            SpeedY = JUMP_SPEED_Y;
        }
    }
}
