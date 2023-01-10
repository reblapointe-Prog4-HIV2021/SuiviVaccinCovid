using System;
using System.Linq;
using SuiviVaccinCovidCodeFirst.Modeles;

namespace SuiviVaccinCovidCodeFirst
{
    class Program
    {
        static void Main(string[] _)
        {
            VaccinsContext context = new();


            if (!context.Vaccins.Any())
            {
                context.Vaccins.Add(new Vaccin { Nom = "Pfizer-BioNTech" });
                context.Vaccins.Add(new Vaccin { Nom = "Moderna" });
                context.Vaccins.Add(new Vaccin { Nom = "AstraZeneca" });
                context.SaveChanges();
            }

            Vaccin pfizer = context.Vaccins.Where(t => t.Nom == "Pfizer-BioNTech").FirstOrDefault();
            Vaccin moderna = context.Vaccins.Where(t => t.Nom == "Moderna").FirstOrDefault();
            Vaccin astrazenica = context.Vaccins.Where(t => t.Nom == "AstraZeneca").FirstOrDefault();

            Dose dose1Mylene = new()
            {
                Date = new DateTime(2021, 06, 15),
                NAMPatient = "LAPM12345678",
                Vaccin = moderna
            };

            Dose dose2Mylene = new()
            {
                Date = DateTime.Today,
                NAMPatient = "LAPM12345678",
                Vaccin = moderna
            };

            Dose dose1Gaston = new()
            {
                Date = new DateTime(2021, 8, 22),
                NAMPatient = "BHEG12345678",
                Vaccin = pfizer
            };

            context.Doses.Add(dose1Mylene);
            context.Doses.Add(dose2Mylene);
            context.Doses.Add(dose1Gaston);


            Covid19 casPositif = new()
            {
                Date = new DateTime(2022, 1, 22),
                NAMPatient = "BHEG12345678",
                Variant = "omicron"
            };
            context.CasCovid19.Add(casPositif);
            context.SaveChanges();

            context.Remove(dose1Gaston);
            dose1Mylene.Vaccin = astrazenica;

            context.SaveChanges();

            foreach (Immunisation immunisations in context.Immunisations)
                Console.WriteLine(immunisations);
        }
    }
}
