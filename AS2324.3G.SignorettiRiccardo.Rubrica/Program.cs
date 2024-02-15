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
        
        InserimentoRubrica();


        VisualizzaRubrica();

        
        RicercaPerNickname();
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

            Console.Write("Vuoi inserire un altro nominativo? (s/n): ");
            string risposta = Console.ReadLine().ToLower();
            if (risposta != "s")
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
            Console.WriteLine($"Nome: {nomi[i]} | Cognome: {cognomi[i]} | Nickname: {nickname[i]}");
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
                Console.WriteLine($"Nome: {nomi[i]} | Cognome: {cognomi[i]} | Nickname: {nickname[i]}");
                trovato = true;
            }
        }

        if (!trovato)
        {
            Console.WriteLine("Nessun nominativo trovato con il nickname inserito.");
        }
    }
}
