namespace MotCroise
{
    internal class Jeu
    {
        public static Joueur[] gamePlayers = new Joueur[2];

        public void whoPlays(Joueur j1, Joueur j2)
        {
            Console.Clear();
            Console.WriteLine("Création des joueurs : ");
            gamePlayers[0] = j1;
            gamePlayers[1] = j2;

            //cas ou le joueur a trouvé un mot qui vaut 7 points
            //gamePlayers[0].addScore(MotTrouvé.length());
        }
    }
}
