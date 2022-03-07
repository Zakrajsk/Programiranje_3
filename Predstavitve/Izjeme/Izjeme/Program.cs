using System;

/// <summary>
/// Zaposleni ste v nekem podjetju kot programerji. Direktor vam dodeli nalogo, da popravite spodnji program.
/// 
/// Program povpraša po nekem številu v konzoli, to število nato v metodi PreberiDecimalno pretvori 
/// v število tipa float ter shrani v bazo(le namišljeno).
/// 
/// Ker so v podjetju poleg programerjev zaposleni še matematiki in ekonomisti se spodnji program sesuva.
/// Problem je v tem, da ekonomisti nekatera števila pišejo z nenavadnim ločilom '-', npr. število 
/// 43.221 pišejo kot 43-221.
/// 
/// Program služi namenu, da lahko ekonomisti vnašajo števila v sistem iz katerega potem matematiki 
/// ta števila analizirajo, urejajo, ...
/// 
/// Naloga: Spodnji program popravi in dopolni tako, da metoda PreberiDecimalno ustrezno pregleda vhodni podatek, 
/// ter ob njegovi neustreznosti 'vrže' personalizirano napako (ki jo ustvarite spodaj). V glavni metodi Main nato te izjeme
/// ustrezno ulovite ter zraven izpišete ali je bilo število shranjeno.
/// Vhodni podatek shranimo le takrat, kadar je število mogoče pretvoriti v float! 
/// Primer:
/// Veljavna ->  3,12  1,0002  4.22  200.01  2  -10
/// Neveljavna ->  33.4a4  abrakadabra   22p0  22-34  02-34 
/// 
/// Dodatna omejitev:
///   Spodnje kode ne smete izbrisati! Lahko dodajate kodo, vrstice premikate, ...
/// </summary>

namespace Izjeme
{
    class Program
    {
        static void Main(string[] args)
        {
            // V spodnjem bloku ustrezno ulovite izjeme

            Console.Write("Vnesi število: ");
            string vhod = Console.ReadLine();
            PreberiDecimalno(vhod);
            Console.ReadKey();
            // Tukaj se vhodni podatek 'navidezno' shrani v bazo.
        }

        /// <summary>
        /// Metoda prejme vhod in preveri njegovo ustreznost, v kolikor je vhod
        /// v napačnem formatu naj metoda 'vrže' ustrezno personalizirano izjemo.
        /// </summary>
        /// <param name="vhod"> Vhodni niz </param>
        /// <returns> Prebrano število </returns>
        static float PreberiDecimalno(string vhod)
        {
            return float.Parse(vhod);
        }
    }

    // Izjema 1
    // Naj opisuje napačen vhodni parameter,
    // npr. NeveljavenVhodException -> kadar vhod ne vsebuje nobenega števila.

    // Izjema 2
    // Naj deduje po zgornji izjemi 1 in opiše bolj podrobno napako vhodnega podatka,
    // npr. NeVeljavenFormatVhoda -> kadar vhod sicer vsebuje števila vendar vsebuje tudi druge znake.

    // Izjema 3 
    // Naj deduje po izjemi 2 in opisuje napako ločila
    // npr. NeVeljavenFormatLocilaVhoda -> kadar vhod vsebuje samo števke vendar ima napačno ločilo.
}

// Uporabni viri:
// How to: User-defined exceptions (Microsoft)
// https://docs.microsoft.com/en-us/dotnet/standard/exceptions/how-to-create-localized-exception-messages
// 
// Best practices (Microsoft)
// https://docs.microsoft.com/en-us/dotnet/standard/exceptions/best-practices-for-exceptions
// 
// Using standard exception types (Microsoft)
// https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/using-standard-exception-types
