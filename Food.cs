namespace SnakeGame
{
    public class Food
    {
        public Postiton foodPos = new Postiton();
        Random rand = new Random();
        Canvas canvas = new Canvas();
        public Food()
        {
            foodPos.x = rand.Next(5, canvas.Width);
            foodPos.y = rand.Next(5, canvas.Height);
        }

        public void drawFood()
        {
            Console.SetCursorPosition(foodPos.x , foodPos.y);
            Console.Write("F");
        }
        public Postiton foodLocation()
        {
            return foodPos;
        }
        public void newLocation()
        {
            foodPos.x = rand.Next(5, canvas.Width);
            foodPos.y = rand.Next(5, canvas.Height);
        }
    }
}