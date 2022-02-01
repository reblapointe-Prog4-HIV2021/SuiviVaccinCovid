using System;
using System.Collections.Generic;
using System.Text;

namespace SuiviVaccinCovidCodeFirst.Modeles
{
    public class Covid19 : Immunisation
    {
        public string Variant { get; set; }

        public override string ToString()
        {
            return $" Cas positif à la Covid-19 #{ImmunisationID} ({Variant}), le {Date} pour {NAMPatient}";
        }

    }
}
