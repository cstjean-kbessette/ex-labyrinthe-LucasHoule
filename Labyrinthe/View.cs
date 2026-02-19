namespace Labyrinthe
{
    internal class View
    {
        public void AfficherLabyrinthe(Labyrinthe labyrinthe)
        {
            for (int x = 0; x < labyrinthe.Map.GetLength(0); x++)
            {
                for (int y = 0; y < labyrinthe.Map.GetLength(1); y++)
                {
                    if (labyrinthe.PosY == y && labyrinthe.PosX == x)
                        Console.Write('P');
                    else
                        Console.Write(labyrinthe.Map[x,y]);
                }
                Console.WriteLine();
            }
        }
        public void AfficherEntete()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Bienvenue dans le Labyrinthe !");
            Console.WriteLine("Utilisez les flèches pour vous déplacer.");
            Console.WriteLine("Atteignez la sortie 'E' pour gagner !");
            Console.WriteLine("--------------------------------------------------------------------------------------\n");
        }

        public void AfficherVictoire()
        {
            Console.Clear();
            Console.WriteLine("Félicitations ! Vous avez trouvé la sortie !");
            Console.WriteLine("Merci d'avoir joué !");
            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}
