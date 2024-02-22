namespace AS2324._3G.SignorettiRiccardo.Rubrica;
using System;

class Program
{
    const int MaxContatti = 100;
    static string[] nomi = new string[MaxContatti];
    static string[] cognomi = new string[MaxContatti];
    static string[] nickname = new string[MaxContatti];
    static int numContatti = 0;

    static void Main(string[] args)
    {
        InserimentoRubrica();//qui andiamo ad inserire il nome cognome e nickname
        VisualizzaRubrica();//qui abbiamo una visualizzazione della rubrica
        RicercaPerNickname();//qui andiamo a fare una ricerca con il nickname
        RicercaPerNomeCaseInsensitive();
        RicercaCognomiPerIniziale("A");
        RicercaCognomiContenenti("son");
        Console.ReadLine();
    }

    static void InserimentoRubrica()
    {
        Console.WriteLine("Inserimento dei nominativi nella rubrica:");

        while (numContatti < MaxContatti)
        {
            Console.Write("Inserisci il nome: ");
            nomi[numContatti] = Console.ReadLine();
            Console.Write("Inserisci il cognome: ");
            cognomi[numContatti] = Console.ReadLine();
            Console.Write("Inserisci il nickname: ");
            nickname[numContatti] = Console.ReadLine();

            numContatti++;

            Console.Write("Vuoi inserire un altro nominativo? (si/no): ");
            string risposta = Console.ReadLine().ToLower();
            if (risposta != "si")
            {
                break;
            }
        }

    }
    static void VisualizzaRubrica()
    {
        Console.WriteLine("\nRubrica completa:");

        for (int i = 0; i < numContatti; i++)
        {
            Console.WriteLine($"Nome-Cognome-Nickname:  {nomi[i]}-{cognomi[i]}-{nickname[i]}");
        }
    }

    static void RicercaPerNickname()
    {
        Console.Write("\nInserisci il nickname da cercare: ");
        string nickDaCercare = Console.ReadLine();

        bool trovato = false;
        Console.WriteLine("\nRisultati della ricerca:");

        for (int i = 0; i < numContatti; i++)
        {
            if (nickname[i] == nickDaCercare)
            {
                Console.WriteLine($"Nome-Cognome-Nickname:  {nomi[i]}-{cognomi[i]}-{nickname[i]}");
                trovato = true;
            }
        }

        if (!trovato)
        {
            Console.WriteLine("Nessun nominativo trovato con il nickname inserito.");

        }
    }
    static void RicercaPerNomeCaseInsensitive()
    {
        Console.Write("\nInserisci il nome da cercare (case insensitive): ");
        string nomeDaCercare = Console.ReadLine().ToLower();

        bool trovato = false;
        Console.WriteLine("\nRisultati della ricerca:");

        for (int i = 0; i < numContatti; i++)
        {
            if (nomi[i].ToLower() == nomeDaCercare)
            {
                Console.WriteLine($"Nome-Cognome-Nickname:  {nomi[i]}-{cognomi[i]}-{nickname[i]}");
                trovato = true;
            }
        }

        if (!trovato)
        {
            Console.WriteLine("Nessun nominativo trovato con il nome inserito (case insensitive).");
        }
    }
    static void RicercaCognomiPerIniziale(string iniziale)
    {
        Console.WriteLine($"\nRicerca dei cognomi che iniziano con '{iniziale}':");

        bool trovato = false;
        for (int i = 0; i < numContatti; i++)
        {
            if (cognomi[i].StartsWith(iniziale, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Nome-Cognome-Nickname:  {nomi[i]}-{cognomi[i]}-{nickname[i]}");
                trovato = true;
            }
        }

        if (!trovato)
        {
            Console.WriteLine($"Nessun cognome trovato che inizia con '{iniziale}'.");
        }
    }
    static void RicercaCognomiContenenti(string contenuto)
    {
        Console.WriteLine($"\nRicerca dei cognomi che contengono '{contenuto}':");

        bool trovato = false;
        for (int i = 0; i < numContatti; i++)
        {
            if (cognomi[i].ToLower().Contains(contenuto.ToLower()))
            {
                Console.WriteLine($"Nome-Cognome-Nickname:  {nomi[i]}-{cognomi[i]}-{nickname[i]}");
                trovato = true;
            }
        }

        if (!trovato)
        {
            Console.WriteLine($"Nessun cognome trovato che contiene '{contenuto}'.");
        }
    }
}