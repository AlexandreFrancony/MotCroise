namespace MotCroise
{
    internal class Joueur
    {
        public int id;
        public string pseudo;
        public int score;

        //Constructeur d'initialisation
        public Joueur(int id, string pseudo, int score)
        {
            this.id = id;
            this.pseudo = pseudo;
            this.score = score;
        }

        //Constructeur par défaut
        public Joueur()
        {
            this.id = 0;
            this.pseudo = "";
            this.score = 0;
        }

        //Méthode pour créer un joueur
        public static Joueur CreatePlayer(int WhereID, Joueur j)
        {
            Console.Clear();
            Console.Write("Création d'un joueur : ");
            while (j.pseudo == "")
            {
                Console.Write("Entrez le pseudo du joueur : ");
                string? nick = Utils.saisieString();
                if (nick != null)
                {
                    j.pseudo = nick;
                }
                else
                {
                    Console.WriteLine("Le pseudonyme ne peut pas être vide, Veuillez recommencer.");
                }
            }
            j.id = WhereID;
            j.score = 0;
            Console.WriteLine("Le joueur " + j.pseudo + " a bien été créé avec un ID de " + j.id + " et le score de " + j.score + ".");
            Utils.Wait();
            return j;
        }

        //Méthode qui affiche les informations du joueur
        public void infos()
        {
            Console.WriteLine("Affichage des informations\n\nID: " + this.id + " \nPseudo : " + this.pseudo + " \nScore : " + this.score);
            Utils.Wait();
        }
    }
}
