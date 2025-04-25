using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MazeEscape
{
    public class Maze
    {
        private  int _Width;
        private  int _Height;
        private IMazeObj[,] Grid;
        private Player Player;
        public Maze(int rows ,int cols)
        {
            _Width = rows;
            _Height = cols;
            Grid = new IMazeObj[rows, cols];
            Player = new Player
            {
                X = 1,
                Y = 1,
            };
        }

        public void DrowMaze()
        {
            Console.Clear();
            for (int i = 0; i < _Width; i++)
            {
                for (int j = 0; j < _Height; j++)
                {
                    Grid[i, j] = new Wall();
                    if (i == 0 || j == 0 || i == _Width -1 || j == _Height - 1)
                    {
                        
                        Console.Write(Grid[i, j].Symbol);
                    }
                    else if(i == Player.X && j == Player.Y)
                    {
                        Console.Write(Player.Symbol);
                    }
                    else if(i % 3 == 0 && j %3 == 0)
                    {
                        Console.Write(Grid[i, j].Symbol);
                    }
                    else
                    {
                        Grid[i, j] = new EmptySpace();
                        Console.Write(Grid[i, j].Symbol);
                    }
                }
                Console.WriteLine();
            }
        }
        public void Move(int dx, int dy)
        {
            int newX = Player.X + dx;
            int newY = Player.Y + dy;

            if (newX < _Width && newX >= 0 && newY < _Height && newY >=0 && Grid[newX,newY].IsWalkable == false)
            {
                Player.X = newX;
                Player.Y = newY;
                DrowMaze();
            }
        }
        public void UpdatePlayerMovement()
        {
            ConsoleKeyInfo userInput = Console.ReadKey();
            ConsoleKey key = userInput.Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    Move(-1, 0);
                    break;
                case ConsoleKey.DownArrow:
                    Move(1, 0);
                    break;
                case ConsoleKey.LeftArrow:
                    Move(0, -1);
                    break;
                case ConsoleKey.RightArrow:
                    Move(0, 1);
                    break;
                    
            }
        }
    }
}
