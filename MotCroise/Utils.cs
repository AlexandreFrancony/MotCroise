namespace MotCroise
{
    internal class Utils
    {
        public static int saisieNombre()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string saisieString()
        {
            string? s = "";
            while (s == "" || s == null)
            {
                s = Console.ReadLine();
                if (s == "" || s == null)
                {
                    Console.WriteLine("La saisie ne peut pas être vide, veuillez recommencer.");
                }
            }
            return s;
        }

        public static void Wait()
        {
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey();
        }
    }
}
