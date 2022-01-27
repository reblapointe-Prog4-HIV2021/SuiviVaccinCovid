using SuiviVaccinDBFirst.ModelesBD;
using System;

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
            Console.WriteLine("Les vaccins.");
            foreach (Vaccins vaccin in context.Vaccins)
                Console.WriteLine($"{vaccin.TypeVaccinId}. Patient : {vaccin.Nampatient}. Date : {vaccin.Date}. Type : {vaccin.TypeVaccin.Nom}");
        }
    }
}
