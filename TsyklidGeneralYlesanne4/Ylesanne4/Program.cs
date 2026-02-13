using System;

namespace Ylesanne4
{ 
    internal class Program
    {
        static void Main(string[] args) 
        {
            // #n4. "Stonksid"
            // kirjuta programm mis töötab tsüklis ja omab tehtavat koodi mis:
            // küsib kasutajalt temapoolse investeeritava summa
            // küsib kolme firma kohta millesse ta investeerida soovib (Tesla, TransferWise või Macro$lop)
            // valitud firma kohta otsustab programm kordaja.
            // kui selleks on Tesla, siis on kordaja fikseeritud -1.15
            // kui selleks on TransferWise, siis on kordajaks valemi tuleumus kus juhuarvu abil otsustatakse arv vahemikus 1 ja 100, juhuarv jagatakse 1000ga ja sinna liidetakse 1 juurde
            // kui selleks on Macro$lop, siis kasutatakse sama valemit TransferWise puhul, aga arv ise on alati negatiivne.
            // programm küsib ka kasutajalt kui pikaks ajaks (mitu päeva) investeering turul olla lasta
            // tsükkel kirjutab välja iga päeva kohta firmanime, hetkekordaja, kasutajaportfelliväärtuse
            // kui kasutaja portfell pole jõudnud alla nulli, siis kasutaja saab valida kas investeerida uuesti või mitte
            // kui aga portfell on nullis, öeldakse kasutajale et on pankrotis
            // kuvatakse kasutajale tema portfelli lõppväärtus.

            List<string> firmaNimed = new List<string>() { "Tesla", "TransferWise", "Macro$lop" };
            List<int> firmaValikud = new List<int>() { 1, 2, 3 };
            int firmaNumber = 0;
            bool investeerime = true;
            Random kordaja = new Random();

            while (investeerime == true)
            {
                Console.WriteLine("Palju sa soovid investeerida?");
                double investMoney = double.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine("Mis firmasse sa soovid investeerida?");
                    for (int i = 0; i < firmaNimed.Count; i++)
                    {

                        Console.WriteLine((i + 1) + ". " + firmaNimed.ElementAt(i));
                    }
                    firmaNumber = int.Parse(Console.ReadLine());
                }
                while (!firmaValikud.Contains(firmaNumber));

                if (firmaNumber == 1)
                {
                    double sissetulekTesla = investMoney * -1.15;
                }
                else if (firmaNumber == 2)
                {
                    double transKordaja = kordaja.Next(1, 100);
                    double sissetulekTrans = transKordaja / 1000 + 1;
                }
                else
                {
                    double macroKordaja = kordaja.Next(1, 100);
                    double sissetulekMacro = -(macroKordaja / 1000 + 1);
                }
            }
                string kasutajaVastus = "";
                do
                {
                    Console.WriteLine("Kas sa tahad veel investeerida? jah/ei");
                    kasutajaVastus = Console.ReadLine();
                }
                while (kasutajaVastus != "jah" && kasutajaVastus != "ei");

                if (kasutajaVastus == "jah")
                {
                    investeerime = true;
                }
                else
                {
                    investeerime = false;
                }
            




        }
    }
}