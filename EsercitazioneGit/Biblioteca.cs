using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

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

        private List<Libro> lista = new List<Libro>();

        public void AddLibro(Libro libro)
        {
            lista.Add(libro);
        }

        public Libro RicercaLibro(string titolo)
        {
            if (lista.Count == 0)
                throw new Exception("Lista dei libri vuota");

            foreach(Libro libro in lista)
            {
                if(libro.titolo == titolo)
                {
                    return libro;
                }
            }

            throw new Exception("Libro non trovato");
        }

        public List<Libro> RicercaAutore(string autore)
        {
            if (lista.Count == 0)
                throw new Exception("Lista dei libri vuota");

            List<Libro> list = new List<Libro>();


            foreach(Libro libro in lista)
            {
                if(libro.autore == autore)
                {
                    list.Add(libro);
                }
            }

            if (list.Count == 0)
                throw new Exception("Autore non trovato");


            return list;
        }

        public int LibriPresenti()
        {
            return lista.Count;
        }
    }
}
