using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var areaErbivori = new AreaDiTerra("Area Erbivori",1000);
            AreaDiTerra areaFelini = new AreaDiTerra("Area Felini", 2500);
            var areaAnimaliAcquatici = new AreaDiAcqua("SEA World", 5000);
            var zoo = new Zoo("Zoo Universale", areaErbivori, areaFelini, areaAnimaliAcquatici);
            var r1 = new Recinto("Recinto1");
            areaErbivori.AddRecinto(r1);

            Console.WriteLine($"Il nome dell'area animali di acqua è {zoo.areaAquatici.getNome()}");
            Console.WriteLine($"La dimensione dell'area erbivori è {zoo.areaErbivori.getDimensione()} mq");
            Console.WriteLine($"Il recinto si chiama {zoo.areaErbivori.recinti[0].nome}");

            Console.ReadKey();
        }
    }
}
