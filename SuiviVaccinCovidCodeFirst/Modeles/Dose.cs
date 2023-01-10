using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviVaccinCovidCodeFirst.Modeles
{
    public class Dose
    {
        public int DoseId { get; set; }
        public DateTime Date { get; set; }
        public string NAMPatient { get; set; }
        public Vaccin Vaccin { get; set; }

        public override string ToString()
        {
            return $" Vaccin #{DoseId} ({Vaccin?.Nom}), administré le {Date} à {NAMPatient}";
        }

    }
}
