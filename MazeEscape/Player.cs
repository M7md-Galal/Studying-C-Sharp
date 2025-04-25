using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeEscape
{
    public class Player : IMazeObj
    {
        public char Symbol => '^';

        public bool IsWalkable => true;

        public int X { get; set; }
        public int Y { get; set; }


    }
}
