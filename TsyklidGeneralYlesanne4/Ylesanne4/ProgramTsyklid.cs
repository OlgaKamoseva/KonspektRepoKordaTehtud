namespace TsüklidKontrolltööKamõsevaLOGITge25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ÜLESANNE 1:");

            int kasutajaVanus = 0;
            do
            {
                Console.WriteLine("Kui vana sa oled?");
                kasutajaVanus = int.Parse(Console.ReadLine());
            }
            while (kasutajaVanus > 0);

            Console.WriteLine("---=== Vajuta enter et näha järgmist ülesannet ===---");
            Console.ReadLine();

            Console.WriteLine("ÜLESANNE 2:");

            int aasta = 1000;                       // kui int aasta = 0, while ei käivita, sest tingimus on täitmata
            while (aasta > 999 && aasta < 2026)
            {
                Console.WriteLine("Palun sisesta aastaarv:");
                aasta = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("---=== Vajuta enter et näha järgmist ülesannet ===---");
            Console.ReadLine();

            Console.WriteLine("ÜLESANNE 3:");

            List <string> puuviljad = new List <string>() { "KaisuKiivi", "PlahvatavPapaia", "ÕudusÕun", "MegaMango", "ArmasApelsin" };
            Console.WriteLine("Kingiideed:");
            for (int i = 0; i < puuviljad.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {puuviljad.ElementAt(i)}");
            }

            Console.WriteLine("---=== Vajuta enter et näha järgmist ülesannet ===---");
            Console.ReadLine();

            Console.WriteLine("ÜLESANNE 4:");

            List <int> numbridMassiivis = new List<int>() { 3, 5, 7, 4, 6};
            int korrutatud = 1;                   // esialgne 1 ei ole osa massiivist, kuigi et kood töötaks, see peab siin olema
            foreach (int number in numbridMassiivis)
            {
                Console.WriteLine($"{korrutatud} korda {number} on {korrutatud*number}");
                korrutatud = korrutatud * number;
            }
        }
    }
}
