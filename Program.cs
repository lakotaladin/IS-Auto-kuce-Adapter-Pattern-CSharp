using System;
using System.Collections.Generic;

namespace UpravljanjeInventaromVozila
{
    class Program
    {
        static void Main(string[] args)
        {
            StariSistemInventaraVozila stariSistem = new StariSistemInventaraVozila();
            IInventarVozila inventarVozila = new AdapterInventaraVozila(stariSistem);

            // dodavanje novog vozila
            inventarVozila.DodajVozilo("AUDI", "A6", 2016, 74000, 30000, "Automatska klima, aluminijumske felne 19 inca");

            // azuriranje postojećeg vozila
            inventarVozila.AzurirajVozilo(1, 25000, "Dobro", "Nove gume");

            // prodaja vozila
            inventarVozila.ProdajVozilo(1, "Aladin Lakota", DateTime.Now, 30000);
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("Operacije zavrsene, koristeci adaptirani sistem inventara. Radi.");
            Console.ReadLine();
        }
    }
}

