using System.IO;

namespace MotCroise
{
    internal class Data
    {
        // lire le fichier "CasSimple.csv" et le stocker dans un tableau de string
        //string path = "..\\..\\..\\Data\\CasSimple.csv";
        public static string[] Read
        {
            get
            {
                string[] lines = File.ReadAllLines("..\\..\\..\\Data\\CasSimple.csv");
                return lines;
            }
        }

        // afficher le contenu du tableau de string
        public static void Display(string[] lines)
        {
            foreach (string line in lines)
            {
                System.Console.WriteLine(line);
            }
            Utils.Wait();
        }
    }
}
