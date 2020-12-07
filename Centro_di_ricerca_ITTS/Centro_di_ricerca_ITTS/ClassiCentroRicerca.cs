using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_di_ricerca_ITTS
{

    class CentroDiRicerca
    {
        string nome;
        string citta;
        public List<AreaDiRicerca> areeRicerca;
        public CentroDiRicerca(string nome, string citta)
        {
            this.nome = nome;
            areeRicerca = new List<AreaDiRicerca>();
        }

        public void AddAreaDiRicerca(AreaDiRicerca a)
        {
            areeRicerca.Add(a);
        }

    }
    class AreaDiRicerca
    {
        string nome;
        string descrizione;
        double estensione;
        ResponsabileArea responsabile;
        public List<Senior> ricecatoriSenior; //elenco di tutti i ricercatori senior dell'area
        public List<Junior> ricecatoriJunior; //elenco di tutti i ricercatori senior dell'area
        public List<Progetto> progettiArea; //elenco di tutti i progetti
        public AreaDiRicerca(string nome, string descrizione)
        {
            this.nome = nome;
            this.descrizione = descrizione;
            ricecatoriSenior = new List<Senior>();
            ricecatoriJunior = new List<Junior>();
            progettiArea = new List<Progetto>();
        }
        public string Nome
        {
            get { return nome; }
        }
        public int NumRicercatoriJunior
        {
            get { return ricecatoriJunior.Count(); }
        }
        public int NumRicercatoriSenior
        {
            get { return ricecatoriSenior.Count(); }
        }
        public void AddRicercatoreSenior(Senior s)
        {
            ricecatoriSenior.Add(s);
        }
        public void AddRicercatoreJunior(Junior j)
        {
            ricecatoriJunior.Add(j);
        }
        public void AddProgetto(Progetto p)
        {
            progettiArea.Add(p);
        }
        public void SetResponsabile(ResponsabileArea ra)
        {
            responsabile = ra;
        }

        public Senior GetRicercatoreSeniorDaCodice(int codice)
        {
            foreach (Senior s in ricecatoriSenior)
            {
                if (s.Codice == codice)
                {
                    return s;
                }
            }
            return null;
        }
        public Junior GetRicercatoreJuniorDaCodice(int codice)
        {
            foreach (Junior j in ricecatoriJunior)
            {
                if (j.Codice == codice)
                {
                    return j;
                }
            }
            return null;
        }
    }

    class Progetto
    {
        string nome;
        string descrizione;
        public TeamDiRicerca team;

        public Progetto(string n, string d, TeamDiRicerca t)
        {
            nome = n;
            descrizione = d;
            team = t;
        }

        public void SetDescrizione(string d)
        {
            descrizione = d;
        }
        public string Nome
        {
            get { return nome; }
        }
        public string Descrizione
        {
            get { return descrizione; }
        }
    }

    class Persona
    {
        protected string nome;
        protected string cognome;
        protected DateTime dataNascita;

        public Persona(string nome, string cognome, string dataNascita)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.dataNascita = Convert.ToDateTime(dataNascita);
        }

        public string Nome
        {
            get { return nome; }
        }
        public string Cognome
        {
            get { return cognome; }
        }
        public DateTime DataNascita
        {
            get { return dataNascita; }
        }
        public int GetEta()
        {
            return Convert.ToInt32((DateTime.Now.Date - dataNascita).TotalDays / 365);
        }
    }
    class ResponsabileArea : Persona
    {
        int maxOreLavoro;
        public ResponsabileArea(string nome, string cognome, string dataNascita, int maxOreLavoro) : base(nome, cognome, dataNascita)
        {
            this.maxOreLavoro = maxOreLavoro;
        }
    }
    class Ricercatore : Persona
    {
        protected int codice;
        protected string specializzazione;
        protected double stipendio;

        public Ricercatore(int codice, string nome, string cognome, string dataNascita, string spec) : base(nome, cognome, dataNascita)
        {
            this.codice = codice;
            specializzazione = spec;
        }

        public int Codice
        {
            get { return codice; }
        }
    }

    class Junior : Ricercatore
    {
        private int oreLavoro;
        public Junior(int codice, string nome, string cognome, string dataNascita, string specializzazione, int oreLavoro) : base(codice, nome, cognome, dataNascita, specializzazione)
        {
            this.oreLavoro = oreLavoro;
        }
    }

    class Senior : Ricercatore
    {
        private int numPubblicazioni;
        public Senior(int codice, string nome, string cognome, string dataNascita, string specializzazione, int p) : base(codice, nome, cognome, dataNascita, specializzazione)
        {
            numPubblicazioni = p;
        }
    }

    class TeamDiRicerca
    {
        string nomeTeam;
        public Senior responsabile;
        public List<Junior> ricercatori;

        public TeamDiRicerca(string nome)
        {
            nomeTeam = nome;
            ricercatori = new List<Junior>();
        }
        public string NomeTeam
        {
            get { return nomeTeam; }
            set { nomeTeam = value; }
        }
        public void SetResponsabile(Senior resp)
        {
            responsabile = resp;
        }
        public void AddRicercatore(Junior ric)
        {
            ricercatori.Add(ric);
        }
        public bool RemoveRicercatore(Junior ric)
        {
            foreach (Junior j in ricercatori)
            {
                if (j == ric)
                {
                    ricercatori.Remove(ric);
                    return true;
                }
            }
            return false;
        }
        public int NumRicercatori()
        {
            return ricercatori.Count;
        }
        public string GetListaRicercatori()
        {
            string s = "";
            foreach (Junior j in ricercatori)
            {
                s = s + j.Nome + " " + j.Cognome + ";";
            }
            return s;
        }

    }

}
