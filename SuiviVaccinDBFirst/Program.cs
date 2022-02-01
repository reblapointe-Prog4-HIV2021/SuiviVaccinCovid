using System;
using SuiviVaccinDBFirst.ModelesBD;

namespace SuiviVaccinDBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
           VaccinBDContext context = new VaccinBDContext();

            Console.WriteLine("Les types de vaccin.");
            foreach (TypesVaccin type in context.TypesVaccin)
                Console.WriteLine($"{type.TypeVaccinId}. {type.Nom}");

            Console.WriteLine();
            Console.WriteLine("Les immunisations.");
            foreach (Immunisations immunisation in context.Immunisations)
                Console.WriteLine(
                    $"{immunisation.ImmunisationId}. Patient : {immunisation.Nampatient}. " +
                    $"Date : {immunisation.Date}. " +
                    $"Type : {immunisation.Discriminator} " +
                    $"({(immunisation.Discriminator == "Vaccin" ? immunisation.TypeVaccin.Nom : immunisation.Variant)})");
       }
    }
}
