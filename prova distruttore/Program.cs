using System;
using System.Threading;
using prova_distruttore;

namespace prova_distruttore
{
    internal class Program
    {
        static void Main(string[] args)
        {
           esempio esempio1= new esempio();
            Console.WriteLine("inserisci stringa: ");
            esempio1.Stringa = Console.ReadLine();

            Console.WriteLine("inserisci numero: ");
            esempio1.Numero = int.Parse(Console.ReadLine());
            esempio1.Dispose();
        }
    }
}