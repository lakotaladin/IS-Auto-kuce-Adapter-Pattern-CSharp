using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravljanjeInventaromVozila
{
    // Adapter klasa
    public class AdapterInventaraVozila : IInventarVozila
    {
        private readonly StariSistemInventaraVozila _stariSistem;

        public AdapterInventaraVozila(StariSistemInventaraVozila stariSistem)
        {
            _stariSistem = stariSistem;
        }

        public void DodajVozilo(string marka, string model, int godina, int kilometraza, decimal cena, string oprema)
        {
            _stariSistem.RegistrujNoviAuto(marka, model, godina, kilometraza, cena, oprema);
        }

        public void AzurirajVozilo(int voziloId, decimal cena, string stanje, string novaOprema)
        {
            _stariSistem.IzmeniDetaljeAuta(voziloId, cena, stanje, novaOprema);
        }

        public void ProdajVozilo(int voziloId, string imeKupca, DateTime datumProdaje, decimal cenaProdaje)
        {
            _stariSistem.ZabeleziProdajuAuta(voziloId, imeKupca, datumProdaje, cenaProdaje);
        }
    }
}
