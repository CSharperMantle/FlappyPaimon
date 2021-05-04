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
        public static readonly Size PIPE_SIZE = new Size(52, 640);

        public PipeType Type { get; }

        public Pipe(Point position, PipeType pipeType)
            : base(position, PIPE_SIZE)
        {
            Type = pipeType;
        }
    }

    /// <summary>
    /// Types of <see cref="Pipe"/>s.
    /// </summary>
    public enum PipeType
    {
        Upper,
        Lower
    }
}
