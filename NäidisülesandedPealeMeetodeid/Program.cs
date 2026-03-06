using System; 

namespace EsimeneProjekt
{
    internal class Program 
    {
        private static Pension(int vanus)
        {
            string kyss = "";
            if (vanus > 65)
            {
                kyss = "Kuidas jalad liiguvad? Hasti?";
            }
            else
            {
                kyss = "Palju monsterid jood?";
            }
            return kyss;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Kui vana sa oled?");
            int vanus = int.Parse(Console.ReadLine());
            string biba = Pension();
            Console.WriteLine(biba);
        }
    }
}
