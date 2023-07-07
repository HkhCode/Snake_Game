using System.Collections.Generic;
namespace SnakeGame
{
    public class Snake
    {
        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        char key = 'w';
        char dir = 'u';
        public List<Postiton> snakeBody {get;set;}
        public int x { get; set; }
        public int y { get; set; }
        public int score {get;set;}
        public Snake()
        {
            x = 20;
            y = 20;
            score = 0;
            snakeBody = new List<Postiton>();
            snakeBody.Add(new Postiton(x, y));
        }

        public void drawSnake()
        {
            foreach (Postiton pos in snakeBody)
            {
                Console.SetCursorPosition(pos.x, pos.y);
                Console.Write("█");
            }

        }

        private void direction()
        {
            if (key == 'w' && dir != 'd')
            {
                dir = 'u';
            }
            else if (key == 's' && dir != 'u')
            {
                dir = 'd';
            }
            else if (key == 'd' && dir != 'l')
            {
                dir = 'r';
            }
            else if (key == 'a' && dir != 'r')
            {
                dir = 'l';
            }
        }
        public void moveSnake()
        {
            direction();
            if (dir == 'u')
            {
                y--;
            }
            else if (dir == 'd')
            {
                y++;
            }
            else if (dir == 'r')
            {
                x++;
            }
            else if (dir == 'l')
            {
                x--;
            }
            snakeBody.Add(new Postiton(x, y));
            snakeBody.RemoveAt(0);
            Thread.Sleep(100);
        }

        public void Input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                key = keyInfo.KeyChar;
            }
        }
        public void eat(Postiton food, Food f)
        {
            Postiton sn = snakeBody[snakeBody.Count - 1];
            if (sn.x == food.x && sn.y == food.y)
            {
                snakeBody.Add(new Postiton(x, y));
                f.newLocation();
                score++;
            }

        }
        public void isDead()
        {
            Postiton sn = snakeBody[snakeBody.Count - 1];
            for(int i = 0;i<snakeBody.Count-2;i++)
            {
                Postiton sb = snakeBody[i];
                if(sn.x == sb.x && sn.y == sb.y)
                {
                    throw new SnakeException("YOU LOST!");
                }
            }
        }
        public void hitWall(Canvas canvas)
        {
            Postiton sn = snakeBody[snakeBody.Count - 1];
            if(sn.x >= canvas.Width || sn.y >= canvas.Height || sn.x <= 0 || sn.y <= 0)
            {
                throw new SnakeException("YOU LOST!");
            }
        }
    }
}