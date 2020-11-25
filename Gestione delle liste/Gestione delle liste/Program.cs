using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_delle_liste
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numeriEstratti = new List<string>();
            var rnd = new Random();
            int estratto;
            do
            {
                estratto = rnd.Next(100);
                numeriEstratti.Add(estratto.ToString());
            } while (estratto != 0);

            Console.WriteLine("sono stati estratti " + numeriEstratti.Count + " numeri");

            string s="";
            foreach (string es in numeriEstratti)
            {
                s = s + es+ ", ";
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
