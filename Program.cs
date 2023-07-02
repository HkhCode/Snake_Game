namespace SnakeGame
{
    class Program
    {
        public static int[,] GameMatrix = new int[10, 20];
        /*
            0 => Free Space
            1 => Wall
            2 => snake head 
            3 => snake body
            4 => Apple
        */
        public static int[] SnakeHeadPosition = { 5, 11 }; // first index y , second index x
        public static void SeedData()
        {
            int width = GameMatrix.GetLength(0);
            int length = GameMatrix.GetLength(1);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == 0 || i == width - 1)
                    {
                        GameMatrix[i, j] = 1;
                    }
                    else if (j == 0 || j == length - 1)
                    {
                        GameMatrix[i, j] = 1;
                    }
                    else
                    {
                        GameMatrix[i, j] = 0;
                    }
                }
            }
            GameMatrix[SnakeHeadPosition[0], SnakeHeadPosition[1]] = 2;
            GameMatrix[5, 10] = 3;
            GameMatrix[5, 9] = 3;
            GameMatrix[5, 8] = 3;
            GameMatrix[5, 7] = 3;
            GameMatrix[7, 17] = 4;
        }
        public static void Snake(char input = 'w')
        {
            if (input.Equals('w'))
            {
                SnakeHeadPosition[0] += 1;
            }
            else if (input.Equals('s'))
            {
                SnakeHeadPosition[0] -= 1;
            }
            else if (input.Equals('d'))
            {
                SnakeHeadPosition[1] += 1;
            }
            else if (input.Equals('a'))
            {
                SnakeHeadPosition[1] -= 1;
            }
            else
            {
                Console.WriteLine("Wrong Key !");
            }
        }
        public static void DrawGameMap(int[,] matrix)
        {
            int width = matrix.GetLength(0);
            int length = matrix.GetLength(1);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (GameMatrix[i, j] == 1)
                    {
                        if (j == length - 1)
                        {
                            Console.WriteLine("/");
                        }
                        else
                        {
                            Console.Write("/");
                        }
                    }
                    else if (GameMatrix[i, j] == 0)
                    {
                        Console.Write(" ");
                    }
                    else if (GameMatrix[i, j] == 2)
                    {
                        Console.Write("@");
                    }
                    else if (GameMatrix[i, j] == 3)
                    {
                        Console.Write("#");
                    }
                    else if (GameMatrix[i, j] == 4)
                    {
                        Console.Write("0");
                    }
                }
            }
        }
        public static void Render(char key)
        {
             
        }
        static void Main(string[] args)
        {
            SeedData();
            DrawGameMap(GameMatrix);
            Console.ReadKey();
        }
    }

}