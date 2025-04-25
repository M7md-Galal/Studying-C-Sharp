using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeEscape
{
    internal class Wall : IMazeObj
    {
        public char Symbol => '=';

        public bool IsWalkable => true;
    }
}
