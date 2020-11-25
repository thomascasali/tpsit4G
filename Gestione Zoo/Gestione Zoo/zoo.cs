using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Zoo
{
    class Zoo
    {
        string nome;
        string citta;
        string indirizzo;
        string telefono;
        public AreaDiTerra areaFelini;
        public AreaDiTerra areaErbivori;
        public AreaDiAcqua areaAquatici;

        public Zoo(string nome, AreaDiTerra ae, AreaDiTerra af, AreaDiAcqua aa)
        {
            this.nome = nome;
            areaAquatici = aa;
            areaFelini = af;
            areaErbivori = ae;
        }
    }
    class AreaDiTerra
    {
        string nome;
        double dimensione;
        public List<Recinto> recinti;

        public AreaDiTerra(string nome,double dimensione)
        {
            this.nome = nome;
            this.dimensione = dimensione;
            recinti = new List<Recinto>();
        }

        public void AddRecinto(Recinto r)
        {
            recinti.Add(r);
        }
        public double getDimensione()
        {
            return dimensione;
        }
    }
    class AreaDiAcqua
    {
        string nome;
        double dimensione;
        Vasca[] vasche;
        public AreaDiAcqua(string nome, double dim)
        {
            this.nome = nome;
            this.dimensione = dim;
        }

        public string getNome()
        {
            return nome;
        }
    }

    class Recinto
    {
        public string nome;
        string posizioneGPS;
        double dimensione;
        AnimaleDiTerra[] animali;
        Custode custode;

        public Recinto(string nome)
        {
            this.nome = nome;
        }
    }
    class Vasca
    {
        string nome;
        string posizioneGPS;
        double capacita;
        AnimaleDiAcqua[] animali;
        Sub custode;
    }

    class Specie
    {
        string nomeComune;
        string nomeScientifico;
    }

    class Animale
    {
        string nome;
        Specie specie;
    }

    class AnimaleDiTerra: Animale
    {
        int numZampe;
        Recinto recinto;
    }
    class AnimaleDiAcqua : Animale
    {
        int numPinne;
        Vasca vasca;
    }

    class Custode
    {
        string nome;
        string cognome;
        DateTime dataNascita;
        int altezza;
        string cf;
        Recinto[] recinti;
    }

    class Sub : Custode {
        int oreImmersione;
        Vasca[] vasche;
    }
}
