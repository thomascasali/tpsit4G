using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studente_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Classe c = new Classe("4G", "Informatica");
            Studente s = new Studente("Mario", "Rossi");
            c.addStudente(s);
            c.addStudente(new Studente("Filippo", "Verdi"));
            c.addStudente(new Studente("Paolo", "Bianchi"));
            c.addStudente(new Studente("Gianni", "Gialli"));
            Console.WriteLine($"nella classe ci sono {c.numStudenti()} studenti");
            int num = 1;
            Console.WriteLine("\nStampa con ciclo foreach:\n");
            foreach (Studente stud in c.studenti)
            {
                Console.WriteLine($"{num}) {stud.Cognome} {stud.Nome}");
                num++;
            }

            Console.WriteLine("\nStampa con ciclo for:\n");
            num = 1;
            for(int j=0; j<c.numStudenti(); j++)
            {
                Console.WriteLine($"{num}) {c.studenti[j].Cognome} {c.studenti[j].Nome}");
                num++;
            }
            Console.ReadKey();
        }
    }
}
