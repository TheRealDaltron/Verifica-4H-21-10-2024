using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EsercitazioneGit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        bool isBiblioteca = false;
        Libro libro;
        Biblioteca biblioteca;
        private void Libro_Click(object sender, RoutedEventArgs e)
        {
            if (isBiblioteca == false) 
            {
                MessageBox.Show("Errore, Biblioteca Inesistente");
            } else
            {
                if(TitoloLibro.Text != "" && AutoreLibro.Text != "" && EditoreLibro.Text != "" & AnnoLibro.Text != "" && PagineLibro.Text != "")
                {
                    int st;
                    if(int.TryParse(AnnoLibro.Text, out st) && int.TryParse(PagineLibro.Text, out st))
                    {
                        Libro lib = new Libro(TitoloLibro.Text, AutoreLibro.Text, EditoreLibro.Text, int.Parse(AnnoLibro.Text), int.Parse(PagineLibro.Text));
                        biblioteca.AddLibro(lib);
                    } else
                    {
                        MessageBox.Show("Anno o Pagine non corretti");
                    }
                } else
                {
                    MessageBox.Show("Parametri Non Completi");
                }
            }
        }

        private void Tostring_Click(object sender, RoutedEventArgs e)
        {
                if(TitoloLibro.Text != "" && AutoreLibro.Text != "" && EditoreLibro.Text != "" & AnnoLibro.Text != "" && PagineLibro.Text != "")
                {
                    int st;
                    if(int.TryParse(AnnoLibro.Text, out st) && int.TryParse(PagineLibro.Text, out st))
                    {
                        Libro lib = new Libro(TitoloLibro.Text, AutoreLibro.Text, EditoreLibro.Text, int.Parse(AnnoLibro.Text), int.Parse(PagineLibro.Text));
                        string messaggio = Libro.toString(lib);
                        MessageBox.Show(messaggio);
                    } else
                      {
                        MessageBox.Show("Anno o Pagine non corretti");
                      }
                } else 
                  {
                        MessageBox.Show("Parametri Non Completi");
                  }
        }

        private void Reading_Click(object sender, RoutedEventArgs e)
        {
            if (TitoloLibro.Text != "" && AutoreLibro.Text != "" && EditoreLibro.Text != "" & AnnoLibro.Text != "" && PagineLibro.Text != "")
            {
                int st;
                if (int.TryParse(AnnoLibro.Text, out st) && int.TryParse(PagineLibro.Text, out st))
                {
                    Libro lib = new Libro(TitoloLibro.Text, AutoreLibro.Text, EditoreLibro.Text, int.Parse(AnnoLibro.Text), int.Parse(PagineLibro.Text));
                    string messaggio = Libro.readingTime(lib);
                    MessageBox.Show(messaggio);
                }
            } else
            {
                MessageBox.Show("Parametri Non Completi");
            }
        }

        private void CreazioneBiblioteca_Click(object sender, RoutedEventArgs e)
        {
            if (Nome.Text != "" && Indirizzo.Text != "" && Apertura.Text != "" & Chiusura.Text != "")
            {
                biblioteca = new Biblioteca(Nome.Text, Indirizzo.Text, Apertura.Text, Chiusura.Text);
                isBiblioteca = true;


                MessageBox.Show("Biblioteca Creata");
            } else
            {
                MessageBox.Show("Parametri Non Completi");
            }
        }

        private void CercaTitolo_Click(object sender, RoutedEventArgs e)
        {
            if (isBiblioteca == true) 
            {
                if (TitoloRicerca.Text != "")
                {
                    Libro lb = biblioteca.CercaTitolo();

                    if (lb != null) 
                    {
                        MessageBox.Show("Libro Trovato");
                    }
                }
                else
                {
                    MessageBox.Show("Parametri Non Completi");
                }
            } else
            {
                MessageBox.Show("Biblioteca non Creata");
            }
        }

        private void CercaAutore_Click(object sender, RoutedEventArgs e)
        {
            if (isBiblioteca == true)
            {
                if (AutoreRicerca.Text != "")
                {
                    List<Libro> ls = biblioteca.CercaAutore();

                    if (ls.Count != 0)
                    {
                        MessageBox.Show($"Trovati {ls.Count} libri con quell'autore");
                    }
                }
                else
                {
                    MessageBox.Show("Parametri Non Completi");
                }
            }
            else
            {
                MessageBox.Show("Biblioteca non Creata");
            }
        }

        private void NumeroLibri_Click(object sender, RoutedEventArgs e)
        {
            if (!isBiblioteca == true)
            {
                MessageBox.Show(biblioteca.NumeroLibri());
            } else
            {
                MessageBox.Show("Biblioteca Non Creata");
            }
        }
    }
}