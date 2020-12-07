using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_di_ricerca_ITTS
{
    class Program
    {
        static void Main(string[] args)
        {
            //creazione del centro di ricerca
            var cr = new CentroDiRicerca("Centro di ricerca ITTS", "Rimini");
            //creazione delle aree di ricerca
            cr.AddAreaDiRicerca(new AreaDiRicerca("Informatica", "Sviluppo linguaggi di programmazione"));
            cr.AddAreaDiRicerca(new AreaDiRicerca("Telecomunicazioni", "Sviluppo dei sistemi di telecomunicazione"));
            cr.AddAreaDiRicerca(new AreaDiRicerca("Innovazione", "Computer quantici"));
            //impostazione dei responsabili di area
            cr.areeRicerca[0].SetResponsabile(new ResponsabileArea("Bill", "Gates", "10/10/1950", 24));
            cr.areeRicerca[1].SetResponsabile(new ResponsabileArea("Guglielmo", "Marconi", "9/9/1936", 24));
            cr.areeRicerca[2].SetResponsabile(new ResponsabileArea("Elon", "Musk", "1/3/1980", 24));
            //assunzione dei ricercatori per aree di competenza
            cr.areeRicerca[0].AddRicercatoreSenior(new Senior(1, "Thomas", "Casali", "20/03/1972", "Python", 120));
            cr.areeRicerca[0].AddRicercatoreSenior(new Senior(2, "Fabio", "Corbelli", "10/04/1957", "C#", 153));
            cr.areeRicerca[0].AddRicercatoreSenior(new Senior(3, "Fabio", "Ugolini", "14/06/1967", "VB.Net", 133));
            cr.areeRicerca[0].AddRicercatoreJunior(new Junior(4, "Mario", "Rossi", "22/03/1992", "linguaggi", 20));
            cr.areeRicerca[0].AddRicercatoreJunior(new Junior(5, "Riccardo", "Verdi", "21/03/1992", "linguaggi", 20));
            cr.areeRicerca[0].AddRicercatoreJunior(new Junior(6, "Alan", "Bianchi", "12/03/1992", "linguaggi", 20));
            cr.areeRicerca[0].AddRicercatoreJunior(new Junior(7, "Demis", "Raschia", "13/03/1992", "linguaggi", 20));

            //stampo il numero di ricercatori presenti in ogni area
            foreach (AreaDiRicerca a in cr.areeRicerca)
            {
                Console.WriteLine($"Nell'area di ricerca {a.Nome.ToUpper()} ci sono {a.NumRicercatoriJunior} ricercatori Junior e {a.NumRicercatoriSenior} ricercatori Senior");
            }

            //mi creo una variabile di riferimento all'area di ricerca di informatica
            var aInfo = cr.areeRicerca[0];

            //creo un team di ricerca da assegnare ad un progetto
            var team = new TeamDiRicerca("Team di ricerca Info1");
            team.SetResponsabile(aInfo.GetRicercatoreSeniorDaCodice(1));
            team.AddRicercatore(aInfo.GetRicercatoreJuniorDaCodice(4));
            team.AddRicercatore(aInfo.GetRicercatoreJuniorDaCodice(5));

            //creazione di un progetto
            aInfo.AddProgetto(new Progetto("Python 4", "Versione 4.0", team));

            //stampa tutti i progetti in corso con il team che segue il progetto
            foreach (AreaDiRicerca a in cr.areeRicerca)
            {
                Console.WriteLine($"\nNell'area di ricerca {a.Nome.ToUpper()} sono attivi i seguenti progetti:");
                int numProgetto = 1;
                foreach (Progetto p in a.progettiArea)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($" {numProgetto}) {p.Nome}");
                    Console.ResetColor();
                    Console.WriteLine($"  il team {p.team.NomeTeam.ToUpper()} che segue il progetto è composto da:");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"  {p.team.responsabile.Nome} {p.team.responsabile.Cognome}");
                    Console.ResetColor();
                    Console.WriteLine(" - Responsabile progetto");
                    int numRicercatori = 1;
                    foreach (Junior j in p.team.ricercatori)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write($"  {j.Nome} {j.Cognome}");
                        Console.ResetColor();
                        Console.WriteLine($" - Ricercatore {numRicercatori}");
                        numRicercatori++;
                    }
                    numProgetto++;
                }
            }

            Console.ReadKey();
        }

    }
}
