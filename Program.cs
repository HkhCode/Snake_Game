using System;

namespace SnakeGame
{
    class Program
    {
        static int[,] GameMatrix = new int[10, 20];
        public static void DefineWalls(int[,] matrix)
        {
            // We Are Going To Define Walls Only , No Barriers Yet
            int MapWidth = matrix.GetLength(0);
            int MapHeight = matrix.GetLength(1);
            for (int i = 0; i < MapWidth; i++)
            {

            }
        }
        public static void DrawGameMap(int[,] matrix)
        {
            int MapWidth = matrix.GetLength(0);
            int MapHeight = matrix.GetLength(1);

            for (int i = 0; i < MapWidth; i++)
            {
                for (int j = 0; j < MapHeight; j++)
                {
                    if (i == 0 || i == MapWidth - 1)
                    {
                        if (j == MapHeight - 1)
                        {
                            Console.WriteLine("#");
                        }
                        else
                        {
                            Console.Write("#");
                        }
                    }
                    else
                    {
                        if (j == 0)
                        {
                            Console.Write("#");
                        }
                        else if (j == MapHeight - 1)
                        {
                            Console.WriteLine("#");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
            }
        }
        public void Snake()
        {

        }


        static void Main(string[] args)
        {
            DrawGameMap(GameMatrix);
            Console.ReadKey();
        }
    }

}