namespace Labyrinthe
{
    internal class Controller
    {
        private View view;
        private Labyrinthe labyrinthe;
        public Controller(View view, Labyrinthe labyrinthe)
        {
            this.view = view;
            this.labyrinthe = labyrinthe;
        }

        public void Run()
        {
            while (!labyrinthe.IsExit())
            {
                view.AfficherEntete();
                view.AfficherLabyrinthe(labyrinthe);
                ConsoleKeyInfo direction = Console.ReadKey();
                if (direction.Key == ConsoleKey.UpArrow)
                {
                    labyrinthe.MoveUp();
                }
                if (direction.Key == ConsoleKey.DownArrow)
                {
                    labyrinthe.MoveDown();
                }
                if (direction.Key == ConsoleKey.LeftArrow)
                {
                    labyrinthe.MoveLeft();
                }
                if (direction.Key == ConsoleKey.RightArrow)
                {
                    labyrinthe.MoveRight();
                }
            }
            view.AfficherVictoire();
        }
    }
}
