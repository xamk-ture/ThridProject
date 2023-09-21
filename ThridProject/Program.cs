using System;
using System.Collections.Generic;
using System.Threading;

namespace ThridProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Poista funktiosta kommentit, jotta voit kutsua funktioita.
            //Assignment1();
            //Assignment2();
            //Assignment3();
            //Assignment4();
            //Assignment5();
        }

        static void Assignment1()
        {
            //Tehtävä 1: Perus Boolean-arvot
            //Luo kaksi bool-muuttujaa: onkoPäivä ja onkoYö.
            //Aseta onkoPäivä arvoon true ja onkoYö arvoon false.
            //Tulosta molempien muuttujien arvot käyttäen Console.WriteLine() - metodia.
        }

        static void Assignment2()
        {
            //Tehtävä 2: Boolean Vertailut
            //Luo kaksi int-muuttujaa nimeltään lukuA ja lukuB.
            //Kysy käyttäjältä luvut ja tallenna ne muuttujiin.
            //Luo boolean-muuttuja onkoSama, joka vertailee, ovatko lukuA ja lukuB samat.
            //Tulosta onkoSama-muuttujan arvo.
        }

        static void Assignment3()
        {
            //Tehtävä 3: Ehtolauseet ja Booleanit
            //Luo bool-muuttuja nimeltään onkoSateista.
            //Kysy käyttäjältä, onko sateista ja tallenna vastaus onkoSateista-muuttujaan.
            //Kirjoita ehtolause(if-else), joka tulostaa "Ota sateenvarjo!"
            //jos onkoSateista on true, ja "Ei tarvita sateenvarjoa." jos se on false.
        }

        static void Assignment4()
        {
            //Tehtävä 4: Boolean Logiikka
            //Luo kolme bool-muuttujaa: osaanJavaa, osaanPythonia ja osaanCsharpia.
            //Kysy käyttäjältä, osaako hän Javaa, Pythonia ja C# ja tallenna vastaukset muuttujiin.
            //Esimerkiksi: "Osaatko Javaa? (true/false)" Käyttäjä vastaa joko true tai false.
            //Kirjoita ehtolause, joka tarkistaa, osaatko kaikkia kolmea kieltä.
            //Jos osaat, tulosta "Osaan kaikki kielet!".Jos et osaa, tulosta "En osaa kaikkia kieliä."
        }

        static void Assignment5()
        {
            //Tehtävä 5: Käyttäjän syöte ja Booleanit
            //Kysy käyttäjältä ikä käyttäen Console.ReadLine() ja tallenna se int-muuttujaan.
            //Tarkista, onko käyttäjän ikä suurempi tai yhtä suuri kuin 18.Jos on, aseta bool-muuttuja onkoTäysiIkäinen arvoon true, muuten false.
            //Tulosta onkoTäysiIkäinen-muuttujan arvo.
        }

        static void Assignment6()
        {
            //Tehtävä 6: Käyttäjän oikeudet
            //Tarkoituksena on simuloida ohjelmaa, joka tarkistaa,
            //onko käyttäjällä oikeudet tietylle toiminnolle perustuen kahteen kriteeriin: käyttäjän rooliin ja käyttäjän kokemusvuosiin.

            //Pyydä käyttäjältä hänen rooliaan. Vaihtoehdot voivat olla "Admin", "Käyttäjä" tai "Vieras".
            //Pyydä käyttäjältä hänen kokemusvuosiensa määrä(kokonaisluku).
            //Tallenna nämä tiedot muuttujiin.
            //Seuraavaksi, määrittele ehtolause, joka tarkistaa seuraavaa:
            //Luo boolean muuttuja nimeltään onkoOikeudet.

            //Käyttäjällä on oikeudet toimintoon,
            //jos hän on "Admin" TAI jos hän on "Käyttäjä" JA hänellä on vähintään 5 vuoden kokemus.

            //Tulosta onkoOikeudet-muuttujan arvo käyttäjälle. Esimerkiksi "Sinulla on oikeudet tähän toimintoon." tai "Sinulla ei ole oikeuksia tähän toimintoon."
        }
    }
}