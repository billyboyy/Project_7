using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class GameMap
    {
        char[,] _Map;

        public void Init()
        {
            _Map = new char[60, 240];
            int x = 0;
            int y = 0;
            string[] lines = System.IO.File.ReadAllLines(@"../../../maptest.txt");
            foreach (string line in lines)
            {
                x++;
                foreach (char c in line)
                {
                    y++;
                    _Map[x, y] = c;
                }
                y = 0;
            }
            x = 0;
        }

        public void show()
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < _Map.GetLength(0) / 2 ; i++)
            {
                for (int j = 0 ; j < _Map.GetLength(1) / 2; j++)
                {
                    switch (_Map[i, j])
                    {
                        case '#':
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(_Map[i, j]);
                            break;
                        case '~':
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(_Map[i, j]);
                            break;
                        case 'X':
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write(_Map[i, j]);
                            break;
                        case ' ':
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(_Map[i, j]);
                            break;
                        default:
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(_Map[i, j]);
                            break;
                    }
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
        }
    }
}
