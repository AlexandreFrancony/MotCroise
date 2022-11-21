namespace MotCroise
{
    internal class Joueur
    {
        public int id;
        public string pseudo;
        public int score;
        public string[] motsTrouves = new string[8];

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
        public static Joueur CreatePlayer(int WhereID)
        {
            Console.Clear();
            Console.WriteLine("Création d'un joueur : ");
            Joueur j = new Joueur();
            while (j.pseudo == "" || j.pseudo == null)
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
        public void toString()
        {
            Console.WriteLine("Affichage des informations\n\nID: " + this.id + " \nPseudo : " + this.pseudo + " \nScore : " + this.score);
            Utils.Wait();
        }

        public void addScore(int val)// j1.addScore(10);
        {
            this.score += val;
        }

        public void addWord(string word)//TODO : à verif
        {
            for (int i = 0; i < motsTrouves.Length; i++)
            {
                if (motsTrouves[i] == null)
                {
                    motsTrouves[i] = word;
                    break;
                }
            }
        }
    }
}
