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
            foreach (Vaccin vaccin in context.Vaccins)
                Console.WriteLine($"{vaccin.VaccinId}. {vaccin.Nom}");

            Console.WriteLine();
            Console.WriteLine("Les immunisations.");
            foreach (Immunisation immunisation in context.Immunisations)
                Console.WriteLine(
                    $"{immunisation.ImmunisationId}. Patient : {immunisation.Nampatient}. " +
                    $"Date : {immunisation.Date}. " +
                    $"Type : {immunisation.Discriminator} " +
                    $"({(immunisation.Discriminator == "Vaccin" ? immunisation.Vaccin.Nom : immunisation.Variant)})");
            Console.ReadKey();
        }
    }
}
