using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SuiviVaccinDBFirst.ModelesBD
{
    public partial class Vaccins
    {
        public int VaccinId { get; set; }
        public DateTime Date { get; set; }
        public string Nampatient { get; set; }
        public int? TypeVaccinId { get; set; }

        public virtual TypesVaccin TypeVaccin { get; set; }
    }
}
