using System;  // <-- enne nimeruumi, viidatakse selles failis/klassis kasutatud pakettidele/moodulitele ja süsteemi muudele osadele
// süsteemi muuks osaks voib olla kas operatsioonisüsteemi võimalused või ka teised projektid. Teised projektid viidatakse tavaliselt solution (.sln) failist.

namespace KamosevaLOGITge25KonspektKordaTehtud // <-- nimeruum, sisaldab {} sulgude vahel konteinerit kus asub kogu programmi kood nime all "UusVanaToo"
{
    internal class Program // <-- programmi klass, mis on ka omakorda konteiner tüüp, kus sees on kogu programmi kood
    {
        static void Main(string[] args) //<-- "main" on programmi sees olev meetod mis vaikeväärtusena alati käivitakse, kus ei ole teist meetodit käivituseks määratud
        {


            /*      --- ctrl + k + c/u ---      */


            //--------------------------------------------------------------------//

            /*           ---===         T E O O R I A        ===---              */

            //--------------------------------------------------------------------//




            /*       -= S Ü N T A K S =-         */
            /*
           console.writeline(" 'ommik"); // <- "1"
           string vastus = console.readline(); // <- "2"
           console.writeline("c:");

           ; -iga koodilause koodiplokki sees lõppep lauselõpumärgiga
           console - console on windowsi süsteemi / c# käsurea adresseerimise pakett, millega saab erinevaid käsurea operatsioone teha
           .         - kasutatakse adresseerimiseks et saada punktile eelnevast objektist mingisugune meetod funktsioon, mis kirjutatakse pärast punkti, võib mõelda nagu kaustasuunas olevat / släshi.antud juhul adresseeritakse
           reas "1" console tööriista
           writeline - funktsioon mida parasjagu kasutatakse.writeline kuvab käsureale teksti, või kaasaantud parameetreid.
           () - sulupaar mis omab funktsiooni tööks vajalikku infot/ parameetreid.
           {} - tähistab koodiplokki konteineri jaoks.
           [] - tähistab massiivi.
           "" - tähistavad sõne andmetüüpi andmeid.andmed ise asuvad jutumärkide vahel.
           "string" - andmetüüp, mis kirjutatakse alati muutuja ette.andmetüübis endas asuvad ka andmetüübile vajalikud funktsioonid.
           "vastus" - muutuja, mille nimi on "vastus" mis omab string-tüüpi andmeid mis omistatakse sinna sisse omistusoperaatoriga.
           readline - funktsioon, mida reas "2" kasutatakse.readline loeb käsurea pealt väikeväärtusena sõne-tüüpi andmeid.
           //			- tähistab üherealist kommentaari.
           ///			- funktsiooni summary kommentaar, kirjeldab meetodeid mille tekst kuvatakse välja tootpildina
           / пустота / -taane - aitab arendajal aru saada, kuskohas millise koodiploki sees kood parasjagu asub, ning aitab järge pidada
              */
            //  /**/ -tähistab plokk - kommentaari, kõik tärnide vahel on välja kommenteeritud


            /*
            string string = "abc"; //is bäd
            string sõne = "abc"; //is gud
            */


            /*
            1     2   3   4  5
            string näidis = "def"; // 1 - muutuja kirjutatakse alates andmetüübist, ilma andmetüübita ei saa c# muutujat deklareerida
            2 - seejärel kirjutatakse muutuja nimi mis väljendab andmed ja nende andmete eesmärki nimisõnana
            soovitatavalt kasutada muutujate nimetamisel camelcase stiili.esimene täht on väike, ülejäänud sõnad muutuja nimes algavad suure tähega.
             3 - omistusoperaator mis annab muutujale andmed sisse
             4 - andmed mida omistatakse
             5 - lauselõpumärk
            */



            /*
            int mingiarv = 4;

            mingiarv = mingiarv + 15; //
            mingiarv = mingiarv * 15; //
            mingiarv = mingiarv - 15; //
            mingiarv = mingiarv / 15; //

            mingiarv += 15; //
            mingiarv -= 15; //
            mingiarv *= 15; //
            mingiarv /= 15; //
            */



            /*     -= L I H T A N D M E T Ü Ü B I D =-       */
            /*
            string tekst = "mingisugune inimloetav tekstike"; //TEKST
            char täht = 'A';
            int arv = 1; //täisarv
            float komakohagaarv = 1.5f; //32bit
            double suuremkomakohagaarv = 1.5d; //64bit
            decimal kümmendsüsteemiskomakohagaarv = 1.5M;
            var x = 123;
            var y = "ABC";
            bool jahvõiei = false; //kas true või false.
            

            int minuArv = 9001;
            Console.WriteLine(minuArv);
            double minuDouble = minuArv;
            Console.WriteLine(minuDouble);

            double minuUusDouble = 6.7;
            Console.WriteLine(minuUusDouble);
            int minuUusArv = (int)minuUusDouble;
            Console.WriteLine(minuUusArv);

            double newData1 = 1.23d;
            float newFloat1 = (float)newData1;
            long newLong1 = (long)newFloat1;
            int newInt1 = (int)newLong1;
            char newChar1 = (char)newInt1;

            int backToInt = newChar1;
            long backToLong = backToInt;
            float backToFloat = backToLong;
            double backToDouble = backToFloat;
            */


            /*     -= K O M P O S I I T A N D M E T Ü Ü B I D =-       */

            /*    MASSIIV    */
            /*
            [] -> Massiiv on komposiitandmetüüp, mille sees saab olla mitmeid sama tüüpi lihtandmeid. Masiivi tähistatakse kantsulgudega.
                    Massiiva saab olla ükskõik millist lihtandmetüüpi massiive, massiivi tekitamisel peab ära ütlema kui pikk või suur vastav massiiv on. Kuigi massiivis saab olla
                    lihtandmetüübid, saab massiive moodustada ka teistest massiividest ja muudest komposiitandmetüüpidest. Kui on moodustatud massiiv, mis koosneb teistest massiividest
                    on tegu mitmedimensioonilise massiiviga. Näiteks on 2D massiiv - selline massiiv kus on sees omakorda veel kaks lihtandmetüübist koosnevat massiivi, näiteks flost.
            -= Esimene tekitusviis =-
            int[] uusMassiiv = new int[3];          // Andmetüüp int väljendab, et tegu on täisarvutüüpi anamega, mis on massiiv, ja omab endas täisarve
                                                    // Muutuja nimi on "uusMassiiv" ning võrdusmärgi taga omistatakse sinna massiiv kolme elemendiga, kus mitte ükski element hetkel
                                                    // veel väärtust ei oma. Kui mitu elementi väljendatakse kantsulgude vahel, peale andmetüüpi ja peale kaitstud sõna "new". New ütleb
                                                    // et tegu on uue väärtusega selle muutuja sees.
            -= Teine tekitusviis =- 
            int[] uusMassiiv2 = [1, 2, 3];          // Teine massiivi tekitusviis kus massiivi pikkuse sätestamise asemel antakse muutujasse kohe kindlate väärtustega elemendid kaasa. 
                                                    // Massiivi pikkust sätestama ei pea, kuna see tuletatakse elementide arvust.

            /*  - - Massiivi sisemised meetodid - -  */
            /*
            int kuiPaljuOn = uusMassiiv.Length;     // Massiivi meetod "Length" mille saame kasutusele võtta/adresseerida punkti abil. Loendab kokku mittu elementi massiivis on ja
                                                    // tagastab selle väärtuse. Selles näites omistatakse tagastatav väärtus muutujasse "kuiPaljuOn". Väärtus saab olla ainult täisarv, 
                                                    // sest poolikuid või osalisi elemente ei ole olemas. */
            /* 2 - LOEND */
            /*
            // List<T>   -> Loend on komposiitandmetüüp, kus sarnaselt massiiviga, saab olla mitmeid samat tüüpi andmeid. List kirjutatakse kui oma andmetüüp,
            //              kus sulgude vahel on loendis olevate individuaalsete elementide andmetüüp. Samamoodi nagu massiive, saab loendeid olla ükskõik
            //              millist lihtandmetüüpi ja komposiitandmetüüpi (isegi kui see on teine list). Erinevalt massiivist aga ei pea ütlema kui pikk loend
            //              ise on, massiivis tuleb see ette öelda. Loendi eripära on see, et teda saab dünaamiliselt oma pikkusel muuta, see tähendab et
            //              elemente saab eemaldada koos selle elemendi asukohaga. Massiivi puhul nii teha ei saa sest massiiv on konstantse ehk
            //              muutumatu pikkusega. Listi üksikelemendi andmetüüp asub noolsulgude vahel "<>" kaitstud sõna "List" järel.
            // Esimene tekitusviis:
            List<int> arvuLoend = new List<int>(); //Andmetüübi kirjeldus "List<>" näitab et tegu on loendiga, Listi noolsulgude vahel, on loendis olevate
                                                   //andmete andmetüüp, antud juhul on siin täisarvud, ehk "int". Muutuja enda nimeks, kus andmeid
                                                   //hoitakse on "arvuLoend". Sellesse muutujasse omistatakse kaitstud sõna "new" abil uus, PIKKUSETA ja tühi
                                                   //loend täisarvudega. 
                                                   // Teine tekitusviis:
            List<int> arvuLoend2 = new List<int>() { 1, 2, 3 };     //Teine loendi tekitusviis, andmetüübi kirjeldus "List<>" näitab et tegu on loendiga,
                                                                    //Listi noolsulgude vahel, on loendis olevate andmete andmetüüp, antud juhul on siin
                                                                    //täisarvud, ehk "int". Muutuja enda nimeks, kus andmeid hoitakse on "arvuLoend2". Sellesse
                                                                    //muutujasse omistatakse kaitstud sõna "new" abil uus ja tühi loend täisarvudega, kuid
                                                                    //pärast andmetüübi taga olevaid sulge, anname loogeliste sulgude vahel talle kaasa kohe
                                                                    //ka elemendid. Antud juhul on tegu täisarvudega 1, 2 ja 3. Enam ei ole tegu PIKKUSETA EGA
                                                                    //TÜHJA loendiga, vaid sarnaselt massiivile, tekib selle loendi pikkus, põhinedes sellele
                                                                    //mitu elementi on kaasa antud.
                                                                    // Kolmas tekitusviis:
            List<int> arvuLoend3 = new List<int>(3);        //Kolmas loendi tekitusviis, andmetüübi kirjeldus "List<>" näitab et tegu on loendiga, Listi
                                                            //noolsulgude vahel, on loendis olevate andmete andmetüüp, antud juhul on siin täisarvud, ehk
                                                            //"int". Muutuja enda nimeks, kus andmeid hoitakse on "arvuLoend2". Sellesse muutujasse
                                                            //omistatakse kaitstud sõna "new" abil uus ja tühi loend täisarvudega kuid loend omab kolme
                                                            //tühja elementi. Elementide arv sätestakase peale noolsulge olevate tavaliste sulgude vahele.
                                                            //Arve, ega väärtusi, nende elementide sees veel ei ole.
            */

            /* 3 - SÕNASTIK */
            /*
            // Dictionary <T, T>  -> Dictionary on komposiitandmetüüp mis omab võtiväärtuspaare. Erinevalt eelnevatest komposiitandmetõõpidest, saab Dictionary omada kahte erinevat andmetõõpi millest esimene 
                                     väljendab võtme andmetõõpu ning teine võtme taga olevat väärtuse andmetüüpi. Need andmetüübid saavad üksteisest erineda või isegi omada klasse andmetüüpidena ning ka muid
                                     komposiitandmetüüpe.
            Esimene tekitusviis:
            Dictionary<int,string> sonastik = new Dictionary<int,string>();     // Andmetüübi kirjeldus "Dictionary<>" näitab et tegu on sõnastikuga, ehk loendiga võtiväärtuspaaridest. Dictionary noolsulgude 
                                                                                // vahel asetatakse kaks andmetüübi, esimene neist on võtme andmetüüp (antud juhul "int") teine neist on võtme taga oleva väärtuse
                                                                                // andmetüüp (sel juhul "string"). Muutuja nimeks on "sõnastik" kuhu omistatakse käsusõnaga "new" uus tühi sõnastik vastavate
                                                                                // andmetüüpidega.

            // Teine tekitusviis:
            Dictionary<int,string> sonastik = new Dictionary<int,string>() {{1,"astelpaju"},{2,"muulukas"},{3,"maasikas"}};     
                                                                                // Andmetüübi kirjeldus "Dictionary<>" näitab et tegu on sõnastikuga, ehk loendiga võtiväärtuspaaridest. Dictionary noolsulgude 
                                                                                // vahel asetatakse kaks andmetüübi, esimene neist on võtme andmetüüp (antud juhul "int") teine neist on võtme taga oleva väärtuse
                                                                                // andmetüüp (sel juhul "string"). Muutuja nimeks on "sõnastik" kuhu omistatakse käsusõnaga "new" uus sõnastik koos elementidega,
                                                                                // mis asuvad loogelistes sulgudes ja iga element ise on veel omakorda loogelistes sulgudes infoga mis vastab dictionary andmetüüpide 
                                                                                // sätestusele.

            Sõnastikku tööriistad:

            sõnastik.Add(4, "Tikker");          // .Add() võimaldab olemasoleva sõnaraamatu lõppu lisada elementi. Sulgude vahel on andmed, mille andmetüübid vastavad täiendava sõnastiku andmetüüpide sätestusega.
            sõnastik.Remove(2);                 // .Remove() eemaldab kindla võtme järgi sõnastikus oleva elemendi. Sulgude vahel on selle võtme andmetüüpile vastav väärtus, mitte võtme taga oleva väärtuse väärtus.
            sõnastik.Clear();                   // .Clear() teeb sõnastiku täielikult tühjaks.
            sõnastik.ContainsKey(4);            // .ContainsKey() tagastab kas "true" või "false" vastavalt sellele kas ta leiab antud sõnastikust parameetrina kaasa antud võtme.
            sõnastik.ContainsValue("Tikker");   // .ContainsValue() tagastab kas "true" või "false" vastavalt sellele kas ta leiab antud sõnastikust parameetrina kaasa antud väärtuse.
            */

            /*   4 - MITMIK/HULK   */
            // Andmetüübi kirjeldus "Tuple<>" näitab et siin on tegu erinevate andmete hulgaga ehk mitmikuga. Tuple noolsulgude vahele asetatakse kõik soovitud vajadusel erinevad andmetüübid mis väljendavad tupli 
            // sees väljenduvate andmete asukohtade andmetüüpe. Kui esimene andmetüüp on string, siis Tuple esimene objekt on string tüüpi andmed, kui teine andmetüüp on List<int[]> hoiatakse teises objektis loendeid
            // mille sees on massiivid täisarvudega. Just nagu kõik teised komposiitandmetüübid, võtab ka Tuple vastu kõiki andmetüüpe, kaasaarvatud iseennast. Erinevalt teistest komposiitandmetüüpidest, ei saa ühte
            // Tuple elemendi kohapeal muuta, vaid kogu Tuple tuleb protsessi käigus rekombineerida muudetud andmetest ja olemasolevatest andmetest uuesti.
            Tuple<string, string> piparmundiTupla = new Tuple<string, string>("vasak tupla", "parem tupla");
            // Esimene tekitusviis:
            Tuple<bool, int, string> someTupla = new Tuple<bool, int, string>(true, 1, "abc");
            // Andmetüübi kirjeldus "Tuple<>" ütleb et selles muutujas on mitmik. Selles mitmikus on esimeseks bool, teiseks int, ning kolmandaks string tüüpi objektid. Tuple vajab ka kohe esmast omistust, seega kaitstud
            // sõna new ja andmetüüpi kirjeldus "Tuple<bool, int, string>" vajab peale sead sulgude vahele esmaseid andmeid. Antud juhul on siin (true, 1, "abc");

            // Tuple töötlemine:
            // Ütleme et on olemas ülaltoodud piparmündiTupla. See on Tuple. Justnahu päris tupla, tahame sealt üha ära süüa. Ehk asendada ühe kahest objektist uue sõnaga mis loeks "NJÄM NJÄM NJÄM"
            // Tuplet ei saa muuta, aga seda saab rekombineerida, seega me saame teha nii:
            string uuspool = "NJÄM NJÄM NJÄM";
            piparmundiTupla = new Tuple<string, string>(piparmundiTupla.Item1, uuspool);

            // Tuple adresseerimine:
            // Justnagu eelnevalt näidatud, me saame adresseerida tuple erinevaid objekte siiski eraldi. Selle jaoks on iga tekitatud Tuple sees genereeritud muutujad ".Item#" millega me saame adresseerida
            // soovitud objekti.
            // NB! erinevalt loendist ja massiivist, algab lugemine arvust 1, ehk esimene Item ei ole Item0, vaid Item1
            string pool1 = piparmundiTupla.Item1;           // siin asetame muutujasse "pool1" valitud tuplest esimese objekti, ning
            string pool2 = piparmundiTupla.Item2;           // seal asetame muutujasse "pool2" valitud tuplest teise objekti



            /*      -= J U H U A R V =-       */
            /* Random klass annab võimaluse programmerijale genereerida pseudorandom väärtusi.
            
            Random juhuarv = new Random();        // Klassinimi "Random" on kasutatav kui andmetüüp, mis ütleb et järgnevas muutujas nimega "juhuarv" on uus random tüüpi objekt, mis omistatakse sinna 
                                                  // "new Random()" käsuga. Konstruktor ulatab muutuja sisse Random tüüpi klassi. Antud muutuja nüüd ise ei ole see juhuarv, ta toimib kui juhuarvude
                                                  // generaatorina millest punkti abil saab adresseerida Random genereerimise tööriistu
            int a = juhuarv.Next();               // .Next() on meetod Random klassis mis on genereeriv meetod juhuarvu genereerimiseks. Seda saab kasutada kui väärtusena, ning ta tagastab suvalise arvu. 
                                                  // Ilma parameetrita tagastab andmetüübi maksimaalpiirides mingisuguse juhuarvu
            int miski = juhuarv.Next(5);          // .Next() ühe parameetriga anname talle ülemise piiri, mille alumine piir on vaikeväärtusena 0
            int miski2 = juhuarv.Next(-5, 5);     // .Next() kahe parameetriga kirjeldab ära täieliku vahemiku, olgu see siis negatiivne või positiivne
            double aDbl = juhuarv.NextDouble();   // .NextDouble() annab double-tüüpi väärtusi, parameetri kasutus on identne
            float aLng = juhuarv.NextSingle();    // .NextSingle() annab float-tüüpi väärtuse mis on vahemikus 0.0 ja 1.0





            /*      -= K A I T S T U D   S Õ N A D =-       */

            // Kaitstud sõnad on kindlad nimisõnad/tegusõnad mida C# kasutab oma koodistruktuuride tähistamiseks. Et ära hoida keerukat näpuga jälje ajamist, ning kompilaatori töö
            // lihtsustamist, ei saa järgnevaid sõnu muutuja nimetusel kasutada, nendeks on:
            /*
             abstract     as          base        bool        break       byte        case
             catch        char        checked     class       count       continue    decimal
             default      delegate    do          double      else        enum        event
             explicit     extern      false       finally     fixed       float       for
             foreach      goto        if          implicit    in          int         interface
             internal     is          lock        long        namespace   new         null
             object       operator    out         override    params      private     protected
             public       readonly    ref         return      sbyte       sealed      short
             sizeof       stackalloc  static      string      struct      switch      this
             throw        true        try         typeof      uint        ulong       unchecked  
             unsafe       ushort      using       virtual     void        volatile    while
            */



            /* -= O M I S T U S O P E R A A T O R I D =-*/
            /*
             = ->Üksik võrdusmärk omistab muutja sisse väärtuse, mida adresseeritakse muutuja enda nimega
             int muutuja = 1;
            // += -> võrdusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva väärtuse
            muutuja += 2;
            // -= -> võrdusmärk mille ees on miinus, automaatselt lahutab muutujas olevast väärtusest võrdusmärgi teisel pool oleva väärtuse
            muutuja -= 1;
            // *= -> võrdusmärk mille ees on korrutusmärk, automaatselt korrutab muutuja sisu võrdusmärgi teisel pool oleva väärtuse kordi
            muutuja *= 3;
            // /= -> võrdusmärk mille ees on jagamismärk, automaatselt jagab muutuja sisu võrdusmärgi teisel pool oleva väärtuse osadeks
            muutuja /= 4;
            // %= -> võrdusmärk mille ees on modulus, automaatselt jätab muutujasse jäägi
            muutuja %= 2;

            // ++ -> on kiirtehe, mis muutujale liidab ainult ühe juurde
            muutuja++;
            // -- -> on kiirtehe, mis muutujast lahutab ainult ühe maha
            muutuja--;
            */



            /* V Õ R D L U S O P E R A A T O R I D */
            /*
             ==   -> "on täpselt sama" Võrdlusmärkide ühel pool olev objekt peab vastama oma olemuselt täpselt võrdlusmärkide teisel pool oleva objektiga
             >    -> "on suurem kui" - Märgist vasakul pool olev objekt peab olema suurem kui paremal pool olev objekt
             <  -> "on väiksem kui" - Märgist vasakul pool olev objekt peab olema väiksem kui paremal pool olev objekt
             >=   -> "on suurem kui, või samavõrdne" - märgist vasakul pool olev objekt peaks olema vähemalt sama suur või suurem kui paremal pool olev objekt
             <=   -> "on väiksem kui, või samavõrdne" - märgist vasakul pool olev objekt peaks olema maksimaalselt sama suur või väiksem kui paremal pool olev objekt
             !=   -> "ei tohi olla" võrdlusmärgi vasakul pool olev objekt ei tohi omada identset kuju paremal pool oleva objektiga, kõik muud väärtused on lubatud
            */



            /* -= L O O G I L I S E D   T E H T E D =- */
            /*
             &&   -> "AND" loogiline tehe, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse vastuse "true" juhul kui
             mõlemal pool märki "&&" olevad tingimused omakorda annavad oma avaldise tulemusena "true"
             või teisisõnu: true + true = true
             ||   -> "OR" loogiline tehe, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse vastuse "true" juhul kui
             ühel pool märki "||" olevad tingimused omakorda annavad oma avaldise tulemusena "true", pole vahet millisel pool
             või teisisõnu: true + false = true
             !-> "NOT" loogiline tehe, mida kasutatakse tingimuse avaldise tulemuse inverteerimiseks.Tulemus mis muidu tagastaks "true", hüüumärgi abil
             nüüd tagastab false, ja vastupidi
             või teisisõnu: true = false / false = true
            */



            /*   -= T I N G I M U S L A U S E =-    */
            /*
            if (true)   // Kaitstud sõna "if" kutsub esile tingimuslause, mille tingimuseavaldis on sellele järgnevate () sulgude vahel
            {           // Järgneb {} loogeliste sulgude vahel koodiplokk, mis teostatakse siis, kui tingimuse avaldis annab tulemusena "true",
                        // "false" tulemuse puhul jäetakse kood vahele
            }
            else if (true)  // Kaitstud sõnad "else" ja "if" (koos "else if") kutsuvad esile sekundaarse tingimuslause, mille tingimus on samamoodi sellele järgnevate sulgude vahel, ning millele
                            // peab alati eelnema kas "if" või teine "else if". Else if tingimust kontrollitakse ainult siis, kui sellele eelnev tingimus tagastab avaldise tulemusena "false".
            {               // Järgneb {} loogeliste sulgude vahel koodiplokk, mis teostatakse siis, kui else if tingimuse avaldis annab tulemusena "true",
                            // "false" tulemuse puhul minnakse edasi järgneva tingimuse või teostatava koodi juurde
            }
            else            // Kaitstud sõna "else" kutsub esile järeltingimuslause, millele peab eelnema alati kas "if" või "else if" tingimuslause, ning mille koodiploki sisu täidetakse ilma oma
            { 				// tingimuse avaldise kontrollita (ei oma avaldist) kuna else koodiplokk teostatakse kõikide teiste tingimuste läbikukkumisel (kõik eelnevad tagastavad tulemusena "false")
            }
            */





            /*    -= T I N G I M U S L A U S E - SWITCHCASE =-     */
            /*
            int option = 3;  //------
            switch (option)  // "switch" on kaitstud sõna alternatiivse tingimuskontrolli jaoks mida saab if-elseif-else asemel kasutada. Sulgude vahele käib muutuja nimi, mille põhjal
                             // tingimuslik ümberlülitus toimub. Siin sulgude vahel ei ole tingimus ise, vaid kõigest kontrollitav muutuja, või omakorda sulgude vahel muu tingimuse avaldis.
                             // Pärast lülitusvalikut tuleb koodiplokk {}
            {
                case 1:      // Koodiplokki sees on erinevad juntumid või vasted väärtuste korral mis võivad olla lülitusvalikus oleva muutuja sees. Iga juhtum/vaste kirjutatakse kaitstud
                             // sõnaga "case" ning väärtus selle järel millele see juhtum vastab. Antud juhul see juhtum toimib, kui muutujas "option" on täisarv 1. Peale võimalikku
                             // väärtust on koloon väljendades juhtumi täitumisel tehtavat programmikoodi.
                    Console.WriteLine("Nope"); // Antud juhul kuvatakse juhtumi 1 puhul kasutajale sõnum.
                    break;
                case 2:      // Juhtumeid võib olla mitmeid, antud juhul on siin näidises neid 3+1 (3 kindlat väärtust ja 1 väikeväärtus)
                    break;
                case 3:
                    Console.WriteLine(option); // Antud juhul kuvatakse juhtumi 3 puhul kasutajale muutujas "option" asuv väärtus välja
                    break;
                default:     // Default juhtum täitub siis, kui ülejäänud kirjeldatud juhtumid ei kata switchi lälitusvalikus olevas muutujas asuvat väärtust. Toimib nagu else, kuid erinevalt
                             // if-elseif-else struktuurist võib default olla ka alguses.
                    break;   // Kui antud juhtumi tegevus on tehtud, väljutatakse mitte ainult juhtumist, vaid ka kogu käesolevast tingimustikust. Peale breaki in lauselõpumärk
            }
            */



            /* -=    T E I S E N D A M I N E / C A S T I M I N E    =-*/
            /*
            Castimine on arvu teisendamine ühest andmetüübist teise.Castimist on kahte eri liiki, Automaatne(Implicit) ja manuaalne(Explicit)
             Automaatne castimine toimub siis, kui teisendatakse väiksemast andmetüübist suuremasse, sellisel juhul programmeerija spetsiifiliselt castima ei pea.
             Manuaalne castimine toimub siis, kui teisendatakse suuremast andmetüübist väiksemasse, sellisel juhul on vaja suurema andmetüübiga muutuja ette, asetada sulupaar kus on soovitav andmetüüp sees

            / Manuaalne castimine(Explicit) /
            double newData1 = 1.23d;			// Tekitatakse, või on olemas doubletüüpi andmed muutujas newData1
            float newFloat1 = (float)newData1;  // Toimub teisendus väiksemasse float andmetüüpi, double andmetüübist.
            long newLong1 = (long)newFloat1;	// Toimub teisendus väiksemasse long andmetüüpi, float andmetüübist
            int newInt1 = (int)newLong1;		// Toimub teisendus väiksemasse int andmetüüpi, long andmetüübist
            char newChar1 = (char)newInt1;		// Toimub teisendus väiksemasse char andmetüüpi, int andmetüübist

            / Automaatne castimine(Implicit) /
            int backToInt = newChar1;			// Toimub automaatne teisendus char andmetüübist int andmetüüpi
            long backToLong = backToInt;		// Toimub automaatne teisendus int andmetüübist long andmetüüpi
            float backToFloat = backToLong;		// Toimub automaatne teisendus long andmetüübist float andmetüüpi
            double backToDouble = backToFloat;  // Toimub automaatne teisendus float andmetüübist double andmetüüpi

            Suuremast väiksemasse teisendus kaotab andmeresolutsiooni,
            kaotatud andmeid ei saa tagasi suuremasse andmetüüpi castimisega tagasi.
            */




            /* -= P A R S I M I N E =- */
            /*
            // Parsimine on tekstist katse teisendada mingit tüüpi arvandmeid. Teisendus toimub küsides mingist andmetüübist talle sisseehitatud meetodi "Parse()" abil mingist sõnest arvandmeid
            string seeOnTekst = "1";                    // Mingisugune sõne mis omab endas potensiaalset mingit arvulist väärtust
            int teisendatud = int.Parse(seeOnTekst);    // Muutuja "teisendatud" kuhu omistatakse "Parse()" meetodi abil sõnest arvväärtus
            Console.WriteLine(teisendatud);             // Teisenduse väljakuvamine

            // Parsimisel on olemas ka alternatiivne meetod "TryParse()". TryParse üritab teisendada, ning kui teisendus kukub läbi, tagastatakse algne väärtus/false
            string seeOnTekst2 = "2";                                                 // Mingisugune sõne mis omab endas potensiaalset mingit arvulist väärtust
            Console.WriteLine(int.TryParse(seeOnTekst2, out int result));             // Teisenduse tulemuse väljakuvamine

            // Konverteerimine on mingisuguse andme otsene teisendus ükskõik millisesse teise andmetüüpi. Selle jaoks on olemas moodul "Convert".
            // Convert moodulis on sarnaselt arvandmetüüpides olevale ToString() meetodile ka muude andmetüüpide vastavad konverteerimismeetodid.
            var mingiInfo = "6.7";                                                    // On olemas mingisugune teisendamist vajav info
            string mingiInfoTekst = Convert.ToString(mingiInfo);                      // Convert.ToString() teisendab tundmatust andmetüübist info stringiks/sõneks
            char mingiInfoChar = Convert.ToChar(mingiInfo);                           // teisendus täheks
            int mingiInfoInt = Convert.ToInt32(mingiInfo);                            // teisendus int andmetüüpi
            long mingiInfoLong = Convert.ToInt64(mingiInfo);                          // teisendus long andmetüüpi
            decimal mingiInfoDecimal = Convert.ToDecimal(mingiInfo);                  // teisendus decimaliks
            double mingiInfoDouble = Convert.ToDouble(mingiInfo);                     // teisendus double andmetüüpi
            byte mingiInfoByte = Convert.ToByte(mingiInfo);                           // teisendus baidiks
            bool mingiInfoBool = Convert.ToBoolean(mingiInfo);                        // teisendus boolean andmetüüpi
            */



            /*       -= T S Ü K L I D =-       */
            /*
            Tsüklid on programmeerimise viis, kuidas automatiseerida korduv tegevus ära, see aitab hoida andmemahtu kokku, programmeerija sama koodi mitu korda kirjutamist, ning väldib ka
            kordustest tekkinud vigu. C# on neli peamist tsüklli liiki:
             1. do -while
             2. while
             3. for
             4. foreach

             Tsüklitel on kolm peamist komponenti -käsklus ise, tsükli tingimus ja tehtav kood
            */


            /*   TSÜKLID  DO-WHILE   */
            /*
            // Do-while tsükkel erineb kõigist teistest tsüklidest sellega, et tingimusekontroll toimub pärast esimest tegevusringi. Kõikides teistes tsüklites toimub tingimusekontroll enne
            // esimest ringi.
            int tsükliMuutuja1 = 0;                     //Mingisugune muutuja, mis omab tsükli töö tingimuse abil kontrollimiseks vajalikku väärtust ekh tsüklimuutuja
            do                                          //"do" on kaitstud sõna, mis alustab do while tsüklit, sellele järgneb tsüklis tehtav koodiplokk ning esimene ring täidetakse
                                                        //ilma tingimuse kontrollita
            {
                Console.WriteLine(tsükliMuutuja1);      //Koodiplokki sees olev tegevus, antud juhul kuvatakse tsüklimuutuja arv välja
                tsükliMuutuja1++;                       //ning tsüklimuutujat suurendatakse.
                //ILMA TSÜKLIMUUTUJA KAASAMISETA TSÜKLI TÖÖSSE, KÄIB TSÜKKEL RINGI LÕPMATULT, TSÜKLIMUUTUJA TULEB MINGIL KUJUL MUUTA KAS KAUDSELT VÕI OTSESELT, ET SÜSTEEM SAAKS EDASI TEISTE
                //TEGEVUSTE JUURDE MINNA, ILMA SELLETA SEE EI OLE VÕIMALIK
            } while (tsükliMuutuja1 != 5);              //"while" on kaitstud sõna mis do-while tsükli lõpetab, pärast seda toimub esimene tingimuse kontroll, kus kontrollitakse tsükli
                                                        //töösse kaasatud muutuja olukorda. Kui tingimus täitub ehk tingimuse avaldise tulemus on "true" täidetakse veel üks ring, ning 
                                                        //kontrollitakse tingimust uuesti. Antud juhul tsükkel toimub niikaua, kuni tsüklimuutuja ei ole 5, ta saab olla 4, ja 6, ja
                                                        //ükskõik mis muu, aga mitte 5.
            */


            /*   TSÜKLID WHILE   */
            // While tsükkel on kõige tüüpilisemat laadi tsükkel, tal on tingimusekontroll esimese ringi alduses, kuid tsükkel ei oma sisseehitatud tsüklimuutujat, selle peab sätestama programmeerija
            /*
            string tsükliMuutuja2 = "";                 // mingisugune muutuja, mis omab tsükli töö tingimuse abil kontrollimiseks vajalikku väärtust ehk tsüklimuutuja
            while (tsükliMuutuja2 != "0")               // "while" on kaitstud sõna, mis alustab while tsüklit, sellele järgneb sulgude vahel "()" olev tingimusekontroll, kus kontrollitakse
                                                        // tsüklimuutuja hetkeseisu, ning kui avaldis tagastab "true", tsükkel töötab veel ühe ringi, kui tingimus ei täitu, siis ei täideta
                                                        // ka järgnevat ringi, ning tsükli töö katkeb. Antud juhul kontrollitakse, et tsüklimuutuja ei oleks võrdne sõnega kus on tähemärk
                                                        // arvu 0 jaoks
            {
                Console.WriteLine("esita tekst:");      // Koodiploki "{}" sees olev tegevus, antud juhul küsitakse kasutajalt teksti esitust
                tsükliMuutuja2 = Console.ReadLine();    // mis seejärel omistatakse enda sisse.
            }
            */


            /*      TSÜKLID FOR     */

            // For tsükkel, võrreldes dowhile või while tsükliga omab endas tsükli töö edasiviimiseks tsükli enda sätestuse sees, peale tingimuskontrolli ka enda tsüklimuutujat, ning selle
            // iseenda tsüklimuutuja muutmist. Tal on olemas kõik vajalik, et teha oma tööd automaatselt kui while või dowhile tsüklil.
            /*
            int[] arvuMassiiv = new int[5];                     // Muutuja, kus on andmed, mida tsükkel läbi töötleb
            for (int k = 0; k < arvuMassiiv.Length; k++)        // Kaitstud sõna "for" alustab for tsüklit, pärast mida on sulud, mille vahel on kõik tsükli tõõ jaoks vajalik. Esimene parameeter
                                                                // tekitab tsükli töö jaoks kohaliku muutuja - tsüklimuutuja ei eksisteeri väljaspool tsükli enda konteksti. Selle sätestuses
                                                                // on kohalik muutuja "int k = 0;"
                                                                // Teine parameeter on tsükli töö kontrollimiseks vajalik tingimusekontroll. Samamoodi nagu while või dowhile juures, tingimuse
                                                                // täitumisel ("true") tsükkel teeb ühe ringi, mittetäitumisel tsükli töö katkeb.
                                                                // Kolmas parameeter on tsüklimuutuja muutmine, selles näites seda kiirtehega ++ seda inkremeneeritakse. On võimalik ka muud for
                                                                // sulgude vahelised operatsiooni konfiguratsioonid.
                                                                // Iga for tsükli parameeter on tegelikult oma täielik koodilause. Seega, eraldatakse sulgude vahel lauselõpumärgiga, v.a. viimane.
                                                                // Sulgudele järgneb koodiplokk {}
                                                            
            {
                Console.WriteLine("Sisesta " + k + ". arv");    // Tegevus koodiploki sees, kus küsitakse kasutades tsüklimuutujat, kasutajalt järgmist/mingindat arvu.
                arvuMassiiv[k] = int.Parse(Console.ReadLine()); // Kasutades tsüklimuutujat, täidetakse massiiv.
            }
            */



            //--------------------------------------------------------------------------------//

            /*           ---===         N Ä I T E Ü L E S A N N E D        ===---            */

            //--------------------------------------------------------------------------------//


            /* näiteülesanne 1 */
            /*
            int palk = 2345;
            int kulud = 1122;

            Console.WriteLine("Kas see kuu kulusid või väljaminekuid oli? (jah/ei)");
            string kasutajaVastus = Console.ReadLine();
            if (kasutajaVastus == "jah")
            {

                Console.WriteLine("Sisesta kõik kulutused ühe arvuna");
                kulud = int.Parse(Console.ReadLine());
            }
            int kontojääk = palk - kulud;
            Console.WriteLine(kontojääk + " puulehte on alles"); // print(kontojääk + " puulehte on alles")
            Console.WriteLine(" palun sisesta oma hästi tehtud töö boonus: ");
            int boonus = int.Parse(Console.ReadLine()); // boonus = int(input("palun sisesta oma hästi tehtud töö boonus: "))
            kontojääk = kontojääk + boonus; // same python
            Console.WriteLine("sinu lõppväljavõte on: " + kontojääk + " puulehte");
            */



            /* näiteülesanne 2 */
            // programm küsib kasutajalt tema vanust
            // kui ta on noorem kui 18öeldakse kasutajale "tõmba metsa, kuradi alakas"
            // kui ta on vanem kui 18, pakutakse mojitot

            /*
            int kasutajavanus = 0;
            Console.WriteLine("kui vana sa oled?");
            kasutajavanus = int.Parse(Console.ReadLine());
            if (kasutajavanus >= 18)
            {
                Console.WriteLine("tere tulemast, palun teie mojito 🍸");
            }
            else
            {
                Console.WriteLine("tõmba metsa, kuradi alakas");
            }
            */



            /* näiteülesanne 4 */
            /*
            Console.WriteLine("Palun sisesta oma vanus");                                               //  <-- esitame kasutajale küsimuse
            int kasutajavanus = int.Parse(Console.ReadLine());                                          //  <-- tekitame muutuja kasutajavanus, omistame sinna käsurealt int.Parse abiga täisarvu
            Console.WriteLine("Palun sisesta oma vanavanema vanus");                                    //  <-- esitame kasutajale küsimuse
            int kasutajaVanavanemaVanus = int.Parse(Console.ReadLine());                                //  <-- tekitame muutuja kasutajavanavanemavanus, omistame sinna käsurealt int.Parse abiga täisarvu
            int vanusteVahe = kasutajaVanavanemaVanus - kasutajavanus;                                  //  <-- tekitame uue täisarvu muutuja kuhu omistame vanuste vahe tulemuse
            Console.WriteLine(kasutajaVanavanemaVanus - kasutajavanus);                                 //  <-- saab ka otse kuvada, ilma muutujata
            Console.WriteLine("Kui palju sa vanem oled?");                                              //  <-- esitame kasutajale uue küsimuse
            kasutajavanus += int.Parse(Console.ReadLine());                                             //  <-- kasutame omistusoperaatorit et lisada muutujale kasutaja poolt esitatud täisarvu (+ arv, mitte uus arv)
            Console.WriteLine("Vanuste vahe on nüüd: " + (kasutajaVanavanemaVanus - kasutajavanus));    //  <-- kuvame uue vanuse vahe koos tekstiga
            */




            /* näiteülesanne 5*/
            /*
            Console.WriteLine("Kui kaugele oli su viimane kuulitõuge (m)?");
            float kaugus = float.Parse(Console.ReadLine());
            if (kaugus <= 1.00 && kaugus >= 0.00)
            {
                Console.WriteLine("Sa suudad kindlasti rohkem, cmon bruh");
            }
            else if (kaugus <= 2.00 && kaugus >= 1.01)
            {
                Console.WriteLine("Noh, tuleb juba, jouad veel!");

            }
            else if (kaugus <= 3.00 && kaugus >= 2.01)
            {
                Console.WriteLine("Tubli kolm meetrit umbes, peaaegu vist... not sure");
            }
            else if (kaugus < 0)
            {
                Console.WriteLine("MIKS SA TAGURPIDI VISKAD?!?!?!");
            }
            else
            {
                Console.WriteLine("Ossaraks, seda on varsti orbiidilt naha");
            }
            */


            /* näiteülesanne 6 */
            /*
            Console.WriteLine("Palun sisesta oma vanus");
            int kasutajavanus = int.Parse(Console.ReadLine());
            if (kasutajavanus <= 0)
            {
                Console.WriteLine("Ajarändureid me ei teeninda");
            }
            else if (kasutajavanus > 0 && kasutajavanus < 18)
            {
                Console.WriteLine("Palun sisesta oma nimi");
                string kasutajanimi = Console.ReadLine();
                Console.WriteLine("Kallis " + kasutajanimi + ", palun kutsu oma lapsevanem");
            }
            else
            {
                Console.WriteLine("Palun sisesta oma eesnimi");
                string eesnimi = Console.ReadLine();
                Console.WriteLine("Palun sisesta oma perekonnanimi");
                string perekonnanimi = Console.ReadLine();
                if (perekonnanimi == "" || eesnimi == "")
                {
                    Console.WriteLine("Sisestama pidi mõlemad nimed, lollike");
                }
                else if (perekonnanimi != "" && eesnimi != "")
                {
                    Console.WriteLine($"Tere tulemast Po... I mean, GitHubi, {eesnimi} {perekonnanimi}!");
                }
            }
            */


            /* näiteülesanne 7 - kalkulaator */
            /*
            Console.WriteLine("Palun sisesta esimene arv");
            float arv1 = 0.0f;
            arv1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Palun sisesta teine arv");
            float arv2 = 0.0f;
            arv2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Mis tüüpi tehet sa teha tahad? (valik: + - * / ^ V)");
            string tehteTüüp = "";
            tehteTüüp = Console.ReadLine();

            double tulemus = 0.0d;

            bool tehtud = true;

            if (tehteTüüp == "+")
            {
                tulemus = arv1 + arv2;
            }
            else if (tehteTüüp == "-")
            {
                tulemus = arv1 - arv2;
            }
            else if (tehteTüüp == "*")
            {
                tulemus = arv1 * arv2;
            }
            else if (tehteTüüp == "/")
            {
                tulemus = arv1 / arv2;
            }
            else if (tehteTüüp == "^")
            {
                tulemus = Math.Pow(arv1, arv2);
            }
            else if (tehteTüüp == "V")
            {
                tulemus = Math.Pow(arv1, (1 / arv2));
            }
            else
            {
                Console.WriteLine("Tehtetüüp pole valitud, tehet ei sooritata.");
                tehtud = false;
            }
            if (tehtud)
            {
                Console.WriteLine($"Tehte tulemus on: {arv1} {tehteTüüp} {arv2} = {tulemus}");
            }
            
            */


            /* näiteülesanne 8 */

            // kirjuta programm mis
            // küsib kasutajalt pikkust sentimeetrites
            // küsib tema perekonnaliikmete pikkust (ema isa vend)
            // programm arvutab välja perekonna keskmise pikkuse, vanemate keskmise pikkuse, laste keskmise pikkuse ja kahe keskmise vahe
            // kõik arvud peab programm esitama komakohtadega arvudena

            /*
            int kasutajapikkus = 0;
            int vennapikkus = 0;
            int emapikkus = 0;
            int isapikkus = 0;
            List<int> vanused = new List<int>();
            List<string> isikud = new List<string>() { "sinu", "oma venna", "oma isa", "oma ema" };
            int i = 0;
            do
            {
                Console.WriteLine("Sisesta " + isikud.ElementAt(i) + " pikkus sentimeetrites");
                //kuvame kasutajale teate, koos isikuga mida adresseeritakse ts]klimuutuja abil järjendist "isikud"
                vanused.Add(int.Parse(Console.ReadLine()));
                // Add on listi meetod elemendi lisamiseks, lisatakse otse parsitud täisarv käsurea pealt
                i++;
                //suurendame i-d ühe võrra
            }
            while (i < isikud.Count);

            float perekeskmine = ((float)(vanused.ElementAt(0) + vanused.ElementAt(3) + vanused.ElementAt(1) + vanused.ElementAt(2)) / 4) / 100;
            float vanematekeskmine = ((float)(vanused.ElementAt(3) + vanused.ElementAt(2)) / 2) / 100;
            float lastekeskmine = ((float)(vanused.ElementAt(0) + vanused.ElementAt(1)) / 2) / 100;
            float vahe = 0;
            if (vanematekeskmine > lastekeskmine)
            {
                vahe = vanematekeskmine - lastekeskmine;
            }
            else
            {
                vahe = lastekeskmine - vanematekeskmine;
            }
            Console.WriteLine("perekeskmine on " + Math.Round(perekeskmine, 2) + "m. Vanematekeskmine on " + Math.Round(vanematekeskmine, 2) + "m." +
                " \nlastekeskmine on " + Math.Round(lastekeskmine, 2) + "m. Kahe keskmise vahe on " + Math.Round(vahe, 2) + "m.");
            */

            /* näidisülesanne 9 + sünoptiku sõnum */

            // Kirjuta programm mis küsib kasutajalt viie järgmise päeva temperatuuri ja ilma kirjeldust kui sünoptik on sisestused lõpetanud, kuva viis rida,
            // mis kirjeldab viis päeva mõlema omadusega
            /*
            float[] temps = new int[5];                    // Temperatuuride massiiv
            string[] kirjeldused = new string[5];          // Kirjelduste massiiv
            for (int i = 0; i < temps.Length; i++)         // Võtame sünoptikult temperatuuri andmed ükshaaval
            {
                Console.WriteLine("Esita palun jargmine temperatuur:");
                temps[i]=float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ole hea, kirjelda ka eesolev nadal");
            for (int i = 0; i < kirjeldused.Length; i++)   // Võtame sünoptikult päeva kirjelduse ükshaaval
            {
                Console.WriteLine("kirjelda " + (i + 1) + ". paeva");
                kirjeldused[i] = Console.ReadLine();
            }
            Console.WriteLine("Palun edasta uudistejaamale ilmateade:");
            for (int i = 0; i < temps.Length; i++)
            {
                Console.WriteLine((i + 1) + ". paeval on temperatuur " + temps[i] + " kraadi ja ilm on" + kirjeldused[i] + ".");
            }
            */




            /*

            int suunaKood = 0;
            // "int" näitab et me määrame täisarvu tüüpi muutuja
            // "suunaKood" - uue muutuja nimi
            // "=" abil omistame muutujale suunaKood algväärtuse
            // 0 - suunaKood muutuja algväärtus
            // ; lõpetab käsurea/lause
            Console.WriteLine("Palun sisesta oma suunakood");
            // Console moodul seostab käsurea kasutajaga tekstipõhise konsooliakna kaudu
            // . näitab et järgmine osa (WriteLine) kuulub enne täppi olevale moodulile (Console)
            // WriteLine on meetod, mis kuvab kasutajale antud teksti
            // () sulgude vahel on andmed/parameeter, mis kuulub antud käsule
            // "Palun sisesta oma suunakood" - kasutajale kuvav tekst
            // ; lõpetab käsurea/lause
            suunaKood = int.Parse(Console.ReadLine());
            //suunaKood - muutuja, mida määrasime ennem
            // "=" abil määrame sellele uue väärtuse
            // "int" näitab et me töötame täsarvu tüüpi muutujaga
            // . näitab et järgmine osa (Parse) kuulub enne täppi olevale moodulile (int)
            // Parse vahetab muutuja tüüpi tekstist teise tüüpi vastu, sel juhul täisarvu (int)
            // () Parse käsule kuuluvates sulgudes on parameeter, mida tahame parseerida
            // Console moodul seostab käsurea kasutajaga tekstipõhise konsooliakna kaudu
            // . näitab et järgmine osa (ReadLine) kuulub enne täppi olevale moodulile (Console)
            // ReadLine on meetod, mis "loeb" andmeid, mida kasutaja sisestab konsooliaknas
            // () Readline kuuluvates sulgudes asuvad andmed, millega programm töötab. Aga neid sisestame mitte meie, vaid kasutaja
            // ; lõpetab käsurea/lause
            if (suunaKood > 9999 && suunaKood < 100000)
            // "if" kontrollib kas ees olev tingimus on järgitud, ning kui nii on, ehk tulemusena annab "true", teosatatakse järgnevat koodiplokki, ning "else if" ja "else" plokke ignoreeritakse. Muidu koodi jäetakse vahele
            // () sulgudes asub kontrollitav tingimus
            // suunaKood - kontrollitav muutuja
            // > näitab, et suunaKood muutuja arvväärtus peab olema suurem kui kontrollitav väärtus
            // 9999 - väärtus, mida me määrasime alampiiriks, ehk kui suunaKood väärtus on 9999 või vähem, "if" annab tulemusena "false"
            // && määrab, et mõlemad tingimused peavad olema täidetud, et "if" annaks tulemusena "true"
            // < näitab, et suunaKood muutuja arvväärtus peab olema vähem kui kontrollitav väärtus
            // 100000 - väärtus, mida me määrasime ülempiiriks, ehk kui suunaKood väärtus on 100000 või suurem, "if" annab tulemusena "false"
            {
                Console.WriteLine("Ahhaa, nyyd tean kus sa elad!");
            }
            // {} loogeliste sulgude vahel asub koodiplokk, mida täidetakse, kui "if" tingimus annab tulemusena "true"
            // Console moodul seostab käsurea kasutajaga tekstipõhise konsooliakna kaudu
            // . näitab et järgmine osa (WriteLine) kuulub enne täppi olevale moodulile (Console)
            // WriteLine on meetod, mis kuvab kasutajale antud teksti
            // () sulgude vahel on andmed/parameeter, mis kuulub antud käsule
            // "Ahhaa, nyyd tean kus sa elad!" - kasutajale kuvav tekst
            // ; lõpetab käsurea/lause
            else if (suunaKood <= 9999)
            // "else if" kontrollib uue ees oleva tingimuse juhul, kui "if" tingimus andis tulemusena "false", ehk polnud järgitud
            // () sulgudes asub uus kontrollitav tingimus
            // suunaKood - kontrollitav muutuja
            // <= näitab, et suunaKood muutuja arvväärtus peab olema võrdne või vähem kui kontrollitav väärtus
            // 9999 - väärtus, mida me määrasime ülempiiriks, ehk kui suunaKood väärtus on 9999 või vähem, "else if" annab tulemusena "true"
            {
                Console.WriteLine("yks taht on puudu");
            }
            // {} loogeliste sulgude vahel asub koodiplokk, mida täidetakse, kui "if" tingimus annab tulemusena "true"
            // Console moodul seostab käsurea kasutajaga tekstipõhise konsooliakna kaudu
            // . näitab et järgmine osa (WriteLine) kuulub enne täppi olevale moodulile (Console)
            // WriteLine on meetod, mis kuvab kasutajale antud teksti
            // () sulgude vahel on andmed/parameeter, mis kuulub antud käsule
            // "yks taht on puudu" - kasutajale kuvav tekst
            // ; lõpetab käsurea/lause
            else
            // "else" järgnev koodiplokk täidetakse ainult juhul kui mõlemad "if" ja "else if" annavad tulemusena "false"
            {
                Console.WriteLine("yks taht on yle");
            }
            // {} loogeliste sulgude vahel asub koodiplokk, mida täidetakse, kui "if" tingimus annab tulemusena "true"
            // Console moodul seostab käsurea kasutajaga tekstipõhise konsooliakna kaudu
            // . näitab et järgmine osa (WriteLine) kuulub enne täppi olevale moodulile (Console)
            // WriteLine on meetod, mis kuvab kasutajale antud teksti
            // () sulgude vahel on andmed/parameeter, mis kuulub antud käsule
            // "yks taht on yle" - kasutajale kuvav tekst
            // ; lõpetab käsurea/lause
            */

        }
    }
}
