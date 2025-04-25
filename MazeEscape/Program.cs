
namespace MazeEscape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maze maze = new Maze(20, 40);
            while (true)
            {
                maze.DrowMaze();
                maze.UpdatePlayerMovement();
            }
        }
    }
}
