using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20112023_Classe_prodotto
{
    class Prodotto
    {
        private string nome;
        private double prezzo;
        // Costruttore senza parametri
        public Prodotto()
        {
            nome = "N/D";
            prezzo = 0.0;
        }
        // Costruttore con parametri
        public Prodotto(string nome, double prezzo)
        {
            this.nome = nome;
            this.prezzo = prezzo;
        }
        // Metodi per impostare i valori degli attributi
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public void SetPrezzo(double prezzo)
        {
            this.prezzo = prezzo;
        }
        // Metodi per ottenere i valori degli attributi
        public string GetNome()
        {
            return nome;
        }
        public double GetPrezzo()
        {
            return prezzo;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Istanzia due oggetti di tipo Prodotto
            Prodotto prodotto1 = new Prodotto();
            Prodotto prodotto2 = new Prodotto();
            // Chiede all'utente di inserire il nome e il prezzo per il primo prodotto
            Console.WriteLine("Inserisci il nome del primo prodotto:");
            string nomeprodotto1 = Console.ReadLine();
            Console.WriteLine("Inserisci il prezzo del primo prodotto:");
            double prezzoprodotto1;
            while (!double.TryParse(Console.ReadLine(), out prezzoprodotto1))
            {
                Console.WriteLine("Non si può inserire un carattere diverso da un numero!\nInserisci un prezzo valido:");
            }
            while (prezzoprodotto1 <= 0)
            {
                Console.WriteLine("Inserire un numero maggiore di 0");
                prezzoprodotto1 = Convert.ToDouble(Console.ReadLine());
            }
            // Imposta i valori inseriti dall'utente per il primo prodotto
            prodotto1.SetNome(nomeprodotto1);
            prodotto1.SetPrezzo(prezzoprodotto1);
            Console.Clear();
            // Chiede all'utente di inserire il nome e il prezzo per il secondo prodotto
            Console.WriteLine("Inserisci il nome del secondo prodotto:");
            string nomeprodotto2 = Console.ReadLine();
            Console.WriteLine("Inserisci il prezzo del secondo prodotto:");
            double prezzoprodotto2;
            while (!double.TryParse(Console.ReadLine(), out prezzoprodotto2))
            {
                Console.WriteLine("Non si può inserire un carattere diverso da un numero!\nInserisci un prezzo valido:");
            }
            while (prezzoprodotto2 <= 0)
            {
                Console.WriteLine("Inserire un numero maggiore di 0");
                prezzoprodotto2 = Convert.ToDouble(Console.ReadLine());
            }
            // Imposta i valori inseriti dall'utente per il secondo prodotto
            prodotto2.SetNome(nomeprodotto2);
            prodotto2.SetPrezzo(prezzoprodotto2);
            Console.Clear();
            // Stampa i valori degli attributi dei prodotti
            Console.WriteLine("Prodotto 1 - Nome: " + prodotto1.GetNome() + ", Prezzo: " + prodotto1.GetPrezzo());
            Console.WriteLine("Prodotto 2 - Nome: " + prodotto2.GetNome() + ", Prezzo: " + prodotto2.GetPrezzo());
            Console.ReadLine(); 
            // Aspetta un input per chiudere il programma
        }
    }
}
