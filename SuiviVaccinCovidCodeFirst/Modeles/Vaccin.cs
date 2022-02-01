using System;
using System.Collections.Generic;
using System.Text;

namespace SuiviVaccinCovidCodeFirst.Modeles
{
    public class Vaccin
    {
        public int VaccinId { get; set; }
        public DateTime Date { get; set; }
        public string NAMPatient { get; set; }

        public TypeVaccin Type { get; set; }

        public override string ToString()
        {
            return $" Vaccin #{VaccinId} ({Type?.Nom}), adiminstré le {Date} à {NAMPatient}";
        }

    }
}
