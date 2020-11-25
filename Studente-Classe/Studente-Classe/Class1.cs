using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studente_Classe
{
    class Studente
    {
        string nome;
        string cognome;
        int matricola;

        public Studente(string n, string c, int m)
        {
            nome = n;
            cognome = c;
            matricola = m;
        }

        public Studente(string n, string c)
        {
            nome = n;
            cognome = c;
        }

        public string Nome
        {
            get { return nome; }
        }
        public string Cognome
        {
            get { return cognome; }
        }
    }

    class Classe
    {
        string nome;
        string indirizzo;
        public List<Studente> studenti;

        public Classe(string nome, string indirizzo)
        {
            this.nome = nome;
            this.indirizzo = indirizzo;
            studenti = new List<Studente>();
        }
        public Classe()
        {
            this.nome = "";
            this.indirizzo = "";
            studenti = new List<Studente>();
        }

        public void addStudente(Studente s)
        {
            studenti.Add(s);
        }

        public int numStudenti()
        {
            return studenti.Count;
        }
    }
}
