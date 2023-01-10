using System;
using SuiviVaccinDBFirst.Modeles;

namespace SuiviVaccinDBFirst
{
    class Program
    {
        static void Main(string[] _)
        {
            VaccinsContext context = new();

            Console.WriteLine("Les types de vaccin.");
            foreach (Vaccin v in context.Vaccins)
                Console.WriteLine($"{v.VaccinId}. {v.Nom}");

            Console.WriteLine();
            Console.WriteLine("Les immunisations.");
            foreach (Immunisation i in context.Immunisations)
                Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
