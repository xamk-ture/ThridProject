using System.Threading.Channels;

namespace CalculatorAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tehtävä 1:
            //Kysy käyttäjältä kaksi lukua ja tallenna ne muuttujiin x ja y.
            //Varmista, että käyttäjä syöttää oikean luvun käyttämällä int.TryParse() - metodia.
            //Kysy käyttäjältä operaatio, jonka haluat suorittaa luvuilla.
            //Käytä funktiota Calculator() suorittaaksesi operaation.
            //Tulosta lopputulos.


            Console.WriteLine("Syötä x");


            Console.WriteLine("Syötä y");

            Console.WriteLine("Saatavilla olevat operaatiot: summa, jako, miinus, kerto");
            Console.WriteLine("Valitse operaatio: ");

            //Tehtävä 3: Tee ohjelmasta jatkuva käyttämällä while(true) - silmukkaa.
            //Eli, kun käyttäjä on syöttänyt operaation, suorita se ja kysy haluatko jatkaa laskemista.
            //Kun käyttäjä syöttää "lopeta", lopeta ohjelman suoritus. Muussa tapauksessa jatka laskemista.
        }

        static int Calculator(int x, int y, string operation)
        {
            int result = 0;

            if (operation == "summa")
            {
                result = x + y;
            }
            else if (operation == "miinus")
            {
                result = x - y;
            }
            else if(operation == "kerto")
            {
                result = x * y;
            }
            else if(operation == "jako")
            {
                result = Divide(x, y);
            }
            else
            {
                Console.WriteLine("Virheellinen operaatio!");
            }   

            return result;
        }

        static int Divide(int a, int b)
        {
            //Tehtävä 2: Jakolasku
            //Kirjoita funktio, joka ottaa kaksi int-muuttujaa ja palauttaa niiden jakolaskun tuloksen.
            //Jos jakaja on 0, tulosta "Jakaja ei voi olla 0!" ja palauta 0 käyttämällä Try Catch tekniikkaa.
            //Tulosta Jakaja ei voi olla 0! käyttämällä Console.WriteLine() - metodia Catch - osassa.
            //Muussa tapauksessa palauta jakolaskun tulos.

            return 0;
        }
    }
}