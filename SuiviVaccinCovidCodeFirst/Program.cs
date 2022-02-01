using System;
using System.Linq;
using SuiviVaccinCovidCodeFirst.Modeles;

namespace SuiviVaccinCovidCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            VaccinContext context = new VaccinContext();


            if (context.TypesVaccin.Count() == 0)
            {
                context.TypesVaccin.Add(new TypeVaccin { Nom = "Pfizer-BioNTech" });
                context.TypesVaccin.Add(new TypeVaccin { Nom = "Moderna" });
                context.TypesVaccin.Add(new TypeVaccin { Nom = "AstraZeneca" });
                context.SaveChanges();
            }

            TypeVaccin pfizer = context.TypesVaccin.Where(t => t.Nom == "Pfizer-BioNTech").FirstOrDefault();
            TypeVaccin moderna = context.TypesVaccin.Where(t => t.Nom == "Moderna").FirstOrDefault();
            TypeVaccin astrazenica = context.TypesVaccin.Where(t => t.Nom == "AstraZeneca").FirstOrDefault();

            Vaccin dose1Mylene = new Vaccin
            {
                Date = new DateTime(2021, 06, 15),
                NAMPatient = "LAPM12345678",
                Type = moderna
            };

            Vaccin dose2Mylene = new Vaccin
            {
                Date = DateTime.Today,
                NAMPatient = "LAPM12345678",
                Type = moderna
            };

            Vaccin dose1Gaston = new Vaccin
            {
                Date = new DateTime(2021, 8, 22),
                NAMPatient = "BHEG12345678",
                Type = pfizer
            };

            context.Vaccins.Add(dose1Mylene);
            context.Vaccins.Add(dose2Mylene);
            context.Vaccins.Add(dose1Gaston);

            context.SaveChanges();

            context.Remove(dose1Gaston);
            dose1Mylene.Type = astrazenica;

            context.SaveChanges();

            foreach (Vaccin vaccin in context.Vaccins)
                Console.WriteLine(vaccin);
        }
    }
}
