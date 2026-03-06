
namespace Naidisylesanded_peale_meetodeid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("kasutajatanav.txt"))
            {
                string[] tervitus = File.ReadAllLines("kasutajatanav.txt");
                Console.WriteLine(tervitus[0]);
            }
            else
            {
                Console.WriteLine("Sisesta oma nimi");
                string kasutajanimi = GetAnswer();
                Console.WriteLine("Tere, "+kasutajanimi);
                Console.WriteLine("Palun sisesta ka oma tanavanimi");
                string tanavanimi = GetAnswer();
                string failisisu = kasutajanimi + " ahaa! Elad " + tanavanimi + " tanaval!";
                Console.WriteLine(failisisu);
                File.WriteAllText("kasutajatanav.txt", failisisu);
            }
        }

        private static string GetAnswer()
        {
            Console.WriteLine("Sisesta siia:");
            string vastus = Console.ReadLine();
            return vastus;
        }
    }
}
