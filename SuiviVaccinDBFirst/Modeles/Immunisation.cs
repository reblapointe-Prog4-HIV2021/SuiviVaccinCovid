using System;
using System.Collections.Generic;

namespace SuiviVaccinDBFirst.Modeles
{
    public partial class Immunisation
    {
        public int ImmunisationId { get; set; }
        public DateTime Date { get; set; }
        public string Nampatient { get; set; }
        public string Variant { get; set; }
        public int? VaccinId { get; set; }
        public string Discriminator { get; set; }

        public virtual Vaccin Vaccin { get; set; }
    }
}
