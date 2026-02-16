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
            double tananeKordaja = 0;
            double uusRaha = 0;
            double sissetulek = 0;

            Random kordaja = new Random();

            Console.WriteLine("Palju sa soovid investeerida?");
            double investMoney = double.Parse(Console.ReadLine());
            while (investeerime == true)
            {

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
                Console.WriteLine($"{firmaNimed.ElementAt(firmaNumber-1)} it is!");
                Console.WriteLine("Mitu paeva soovid investeering turul lasta? Kirjuta taisarvuga");
                int aeg = int.Parse(Console.ReadLine());
                int[] paevTurul = new int[aeg];
                for (int k = 0; k < paevTurul.Length; k++)
                {
                    if (investMoney > 0)
                    {
                        if (firmaNumber == 1)
                        {
                            tananeKordaja = -1.15;
                            uusRaha = Math.Round(investMoney * tananeKordaja, 2);
                            sissetulek = uusRaha - investMoney;

                        }
                        else if (firmaNumber == 2)
                        {
                            tananeKordaja = kordaja.Next(1, 100);
                            tananeKordaja = tananeKordaja / 1000 + 1;
                            uusRaha = Math.Round(investMoney * tananeKordaja, 2);
                            sissetulek = uusRaha - investMoney;
                        }
                        else
                        {
                            tananeKordaja = -(kordaja.Next(1, 100));
                            tananeKordaja = tananeKordaja / 1000 + 1;
                            uusRaha = Math.Round(investMoney * tananeKordaja, 2);
                            sissetulek = uusRaha - investMoney;
                        }
                        Console.WriteLine($"Paev {k + 1}: Tana investeeritud {investMoney} eur");
                        Console.WriteLine($"Tanane kordaja on {tananeKordaja}");
                        Console.WriteLine($"Sul on hetkel {uusRaha} eur");
                        Console.WriteLine($"Sul on juurde {sissetulek} eur");
                        investMoney = uusRaha;
                        Console.ReadLine();
                    }
                    else
                    {
                        k = aeg + 1;
                    }


                }
                if (investMoney > 0)
                {
                    string kasutajaVastus = "";
                    do
                    {
                        Console.WriteLine($"Sul on lopuks {investMoney} eur.");
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
                        Console.WriteLine("Baibai, edu sulle!");
                    }
                }
                else
                {
                    Console.WriteLine("Pizdets, oled PankRott");
                    investeerime = false;
                }
            }
        }
    }
}