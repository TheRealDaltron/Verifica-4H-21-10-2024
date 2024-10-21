using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneGit
{
    internal class Libro
    {
        public string autore { get; set; }
        public string titolo { get; set; }
        public string editore { get; set; }
        public int Anno { get { return anno; } set { anno = value; if (anno < 0) { throw new Exception("Anno Invalido");}  } }
        public int Pagine { get { return pagine; } set { pagine = value; if (pagine <= 0) { throw new Exception("Numero Pagine Invalido"); } } }

        private int anno, pagine;

        public Libro(string _autore, string _titolo, string _editore, int _an, int _pag)
        {
            autore = _autore;
            titolo = _titolo;
            editore = _editore;
            Anno = _an;
            Pagine = _pag;
        }

        public string toString(Libro libro)
        {
            return $"Il libro è {libro.titolo} scritto da {libro.autore} di {libro.Pagine} pagine, pubblicato da {libro.editore} nel {libro.Anno}";
        }

        public string readingTime(Libro libro)
        {
            if (libro.Pagine < 100) 
            {
                return "1h";
            } else if (libro.Pagine >= 100 && libro.Pagine <= 200)
            {
                return "2h";
            } else
            {
                return ">2h";
            }
        }

    }
}
