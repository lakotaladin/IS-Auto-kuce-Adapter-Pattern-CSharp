using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravljanjeInventaromVozila
{
    // Postojeća klasa (Adaptee)
    public class StariSistemInventaraVozila
    {
        private readonly Dictionary<int, Vozilo> vozila = new();
        private int sledeciId = 1;

        public void RegistrujNoviAuto(string marka, string model, int godinaProizvodnje, int kilometraza, decimal cena, string oprema)
        {
            var vozilo = new Vozilo
            {
                Id = sledeciId++,
                Marka = marka,
                Model = model,
                GodinaProizvodnje = godinaProizvodnje,
                Kilometraza = kilometraza,
                Cena = cena,
                Oprema = oprema
            };
            vozila[vozilo.Id] = vozilo;
            Console.WriteLine($"Novi automobil registrovan: {vozilo.Marka} {vozilo.Model}, {vozilo.GodinaProizvodnje}");
        }

        public void IzmeniDetaljeAuta(int autoId, decimal novaCena, string stanje, string dodatnaOprema)
        {
            if (vozila.TryGetValue(autoId, out var vozilo))
            {
                vozilo.Cena = novaCena;
                vozilo.Stanje = stanje;
                vozilo.Oprema += ", " + dodatnaOprema;
                Console.WriteLine($"Detalji automobila ažurirani: {vozilo.Marka} {vozilo.Model}, Nova cena: {vozilo.Cena}");
            }
            else
            {
                Console.WriteLine("Automobil sa datim ID-om nije pronađen.");
            }
        }

        public void ZabeleziProdajuAuta(int autoId, string imeKupca, DateTime datumProdaje, decimal iznos)
        {
            if (vozila.Remove(autoId, out var vozilo))
            {
                Console.WriteLine($"Automobil prodan: {vozilo.Marka} {vozilo.Model}, Kupac: {imeKupca}, Datum: {datumProdaje.ToShortDateString()}, Cena: {iznos}");
            }
            else
            {
                Console.WriteLine("Automobil sa datim ID-om nije pronadjen.");
            }
        }
    }
}
