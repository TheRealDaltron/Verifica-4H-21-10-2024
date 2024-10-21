using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneGit
{
    internal class Biblioteca
    {
        Libro libro;

        private string nome, indirizzo, apertura, chiusura;

        public Biblioteca(string _nome, string _indirizzo, string _apertura, string _chiusura)
        {
            this.nome = _nome;
            this.indirizzo = _indirizzo;
            this.apertura = _apertura;
            this.chiusura = _chiusura;
        }


    }
}
