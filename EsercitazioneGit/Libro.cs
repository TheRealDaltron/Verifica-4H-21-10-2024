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
        public int Anno { get { return anno; } set { if (anno < 0) { throw new Exception("Anno Invalido");} anno = value; } }
        public int Pagine { get { return pagine; } set { if (pagine <= 0) { throw new Exception("Numero Pagine Invalido"); } pagine = value; } }

        private int anno, pagine;

        public Libro(string _autore, string _titolo, string _editore, int _anno, int _pagine, int _an, int _pag)
        {
            autore = _autore;
            titolo = _titolo;
            editore = _editore;
            Anno = _an;
            Pagine = _pag;
        }



    }
}
