namespace MotCroise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int WhereID = 0; //Compteur pour garder en mémoire à quel point le tableau est rempli
            Joueur[] joueursList = new Joueur[2];

            //Menu principal
            int choix = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu principal");
                Console.WriteLine("1. Jouer");
                Console.WriteLine("2. Créer un joueur");
                Console.WriteLine("3. Afficher les informations d'un joueur");
                Console.WriteLine("4. Afficher les informations de CasSimple.csv");
                Console.WriteLine("9. Quitter");
                Console.Write("Votre choix : ");
                choix = Utils.saisieNombre();
                switch (choix) 
                {//Le choix 0 doit Rester vide pour le cas où l'utilisateur ne rentre rien
                    case 1://Jouer
                        //TODO: Jouer
                        Console.WriteLine("W.I.P.");
                        Utils.Wait();
                    break;

                    case 2://Création
                        Console.Clear();
                        joueursList[WhereID] = Joueur.CreatePlayer(WhereID);
                        WhereID++;
                    break;

                    case 3://Infos
                        Console.Clear();
                        Console.Write("Entrez l'ID du joueur dont vous souhaitez connaitre les informations : ");
                        int id = Utils.saisieNombre();
                        joueursList[id].infos();
                    break;

                    case 4://Read Data
                        Console.Clear();
                        Console.WriteLine("Lecture du fichier CSV");
                        Data.Display(Data.Read);
                    break;

                    case 9://Quitter
                        Console.Clear();
                    break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Erreur de saisie, veuillez recommencer");
                    break;

                }
            } while (choix != 9);
        }
    }
}
