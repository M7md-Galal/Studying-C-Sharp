using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeEscape
{
    public class EmptySpace : IMazeObj
    {
        public char Symbol => ' ';

        public bool IsWalkable => false;
    }
}
