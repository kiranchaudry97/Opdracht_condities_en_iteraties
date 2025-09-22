namespace Opdracht_condities_en_iteraties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kort uitleg van de doel van het programma en wat de gebruiker moet doen
            /*tekst dat wordt getoont uitgeprint als output */
            System.Console.WriteLine("\n--- Omkeren ---");
            System.Console.WriteLine("Dit programma keert een tekst om met verschillende methodes,");
            System.Console.WriteLine("zodat je kan zien hoe de letters op verschillende manieren omgekeerd worden.");

            /* Tekst vragen :  gebruiker typt en drukt op enter om verder te gaan */
            System.Console.Write("Geef de tekst die je wil omkeren: ");
            string tekst = System.Console.ReadLine();

            /* Menu tonen , gebruiker kies de menu optie en kort uitleg  */
            System.Console.WriteLine("\nKies een methode:");
            System.Console.WriteLine("1 = For-loop - gaat van achter naar voor door de tekst met een for-lus");
            System.Console.WriteLine("2 = While-loop - doet hetzelfde maar gebruikt een while-lus ");
            System.Console.WriteLine("3 = Do-while-loop - werkt zoals while, maar voert de lus minstens 1 keer uit");
            System.Console.WriteLine("4 = Recursie - de functie roept zichzelf steeds opnieuw aan totdat alles omgekeerd is ");
            System.Console.WriteLine("5 = Stoppen - sluit de programma af");

            /*de gekozen menu de gebruiker heeft gekozen */
            System.Console.Write("Uw keuze: ");
            string keuze = System.Console.ReadLine();

            /*als de gebruiker voor 5 gekoost dat deze programma stop */
            if (keuze == "5")
            {
                System.Console.WriteLine("Programma afgesloten.");
                return;
            }

            /*de gekozen programma en dat dit resultaat toont en methodes van elk onderdeel van loop enzo.. */
            string resultaat = "";

            if (keuze == "1") /*start met laatse letter van de beschreven tekst print elke letter achter en omgekeerd*/
            {
                for (int i = tekst.Length - 1; i >= 0; i--)
                {
                    resultaat += tekst[i];
                }
            }
            else if (keuze == "2") /* While-loop */
            {
                int i = tekst.Length - 1;
                while (i >= 0)
                {
                    resultaat += tekst[i];
                    i--;
                }
            }
            else if (keuze == "3") /* Do-while-loop */
            {
                int i = tekst.Length - 1;
                if (tekst != "")
                {
                    do
                    {
                        resultaat += tekst[i];
                        i--;
                    } while (i >= 0);
                }
            }
            else if (keuze == "4") /* Recursie */
            {
                resultaat = OmkerenRecursief(tekst);
            }
            else
            {
                System.Console.WriteLine("Ongeldige keuze!");
                return;
            }

            /* Resultaat tonen en print */
            System.Console.WriteLine("\nOmgekeerde tekst: " + resultaat);
        }

        /* Recursieve methode apart als de string maar 1 letter heeft[1] en voor [0] dit roept de functie opnieuw aan  */
        static string OmkerenRecursief(string s)
        {
            if (s.Length <= 1) return s;
            return OmkerenRecursief(s.Substring(1)) + s[0];
        }
    }
}
