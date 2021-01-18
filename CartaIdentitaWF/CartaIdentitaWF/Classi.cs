using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartaIdentitaWF
{
    class Comune
    {
        string nome;
        string cap;
        public Comune(string comune, string cap)
        {
            nome = comune;
            this.cap = cap;
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public Comune Self
        {
            get { return this; }
        }

    }

    class CartaIdentita
    {
        string numero;
        public Comune rilasciato;
        DateTime dataEmissione;
        public CartaIdentita(string numero, Comune c, string data)
        {
            this.numero = numero;
            rilasciato = c;
            dataEmissione = Convert.ToDateTime(data);
        }
        public CartaIdentita(string numero, Comune c)
        {
            this.numero = numero;
            rilasciato = c;
            dataEmissione = DateTime.Now.Date;
        }
        public CartaIdentita(string numero)
        {
            this.numero = numero;
            dataEmissione = DateTime.Now.Date;
        }
        public CartaIdentita()
        {
            dataEmissione = DateTime.Now.Date;
        }
        public string Numero
        {
            get { return numero; }
        }
        public void setNumero(string numero)
        {
            this.numero = numero;
        }
        public bool Scaduta()
        {
            double anniRilascio = (DateTime.Now.Date - dataEmissione).TotalDays / 365;
            if (anniRilascio > 10) { return true; } else { return false; }
        }

        public CartaIdentita Self
        {
            get { return this; }
        }

    }
    class Persona
    {
        string nome, cognome;
        DateTime dataNascita;
        CartaIdentita cartaIdentita;
        Comune luogoNascita;
        public string Nome { get { return nome; } set { nome = value; } }
        public string Cognome { get { return cognome; } set { cognome = value; } }
        public CartaIdentita getCi()
        {
            return cartaIdentita;
        }
        public int getEta()
        {
            return Convert.ToInt32((DateTime.Now - dataNascita).TotalDays / 365);
        }
        public string getNomeCompleto()
        {
            return Cognome + " " + Nome;
        }

        public string getInfoPersona()
        {
            return Cognome + " " + Nome + " nato il " + dataNascita + " a " + luogoNascita.Nome;
        }
        public Persona(string nome, string cognome, string datan)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.dataNascita = Convert.ToDateTime(datan);
        }

        public Persona(string nome, string cognome, string datan, CartaIdentita ci, Comune luogoN)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.dataNascita = Convert.ToDateTime(datan);
            cartaIdentita = ci;
            luogoNascita = luogoN;
        }
        public void setCartaIdentita(CartaIdentita c)
        {
            cartaIdentita = c;
        }
        public void setLuogoNascita(Comune c)
        {
            luogoNascita = c;
        }
    }
}
