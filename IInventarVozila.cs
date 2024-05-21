using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravljanjeInventaromVozila
{
    // Interfejs cilja
    public interface IInventarVozila
    {
        void DodajVozilo(string marka, string model, int godina, int kilometraza, decimal cena, string oprema);
        void AzurirajVozilo(int voziloId, decimal cena, string stanje, string novaOprema);
        void ProdajVozilo(int voziloId, string imeKupca, DateTime datumProdaje, decimal cenaProdaje);
    }
}
