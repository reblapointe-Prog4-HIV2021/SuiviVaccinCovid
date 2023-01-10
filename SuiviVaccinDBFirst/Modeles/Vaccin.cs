using System;
using System.Collections.Generic;

namespace SuiviVaccinDBFirst.Modeles
{
    public partial class Vaccin
    {
        public Vaccin()
        {
            Doses = new HashSet<Dose>();
            Immunisations = new HashSet<Immunisation>();
        }

        public int VaccinId { get; set; }
        public string Nom { get; set; }

        public virtual ICollection<Dose> Doses { get; set; }
        public virtual ICollection<Immunisation> Immunisations { get; set; }
    }
}
