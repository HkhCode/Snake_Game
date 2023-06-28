namespace SnakeGame
{
    class Program
    {
        public static int score = 0;
        public static int[] SnakeHeadPosition = { 1, 2 };
        public static List<int[]> SnakeBody = new List<int[]>();
        public static void DrawGameMap(int MapWidth, int MapHeight, int[] snakePostion)
        {
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
                    else if (j == 0)
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
        public void Snake(int Direction)
        {
            // Direction 1 => up
            // Direction 2 => down
            // Direction 3 => right
            // Direction 4 => keft
            if (Direction == 1)
            {
                SnakeHeadPosition[0] += 1;
            }
            else if (Direction == 2)
            {
                SnakeHeadPosition[0] -= 1;
            }
            else if (Direction == 3)
            {
                SnakeHeadPosition[1] += 1;
            }
            else if (Direction == 4)
            {
                SnakeHeadPosition[1] -= 1;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
        public void Game()
        {

        }
        static void Main(string[] args)
        {
            // DrawGameMap(10 , 20);
            Console.ReadKey();
        }
    }

}