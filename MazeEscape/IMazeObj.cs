using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeEscape
{
    public interface IMazeObj
    {
        char Symbol { get; }
        bool IsWalkable { get; }
    }
}
