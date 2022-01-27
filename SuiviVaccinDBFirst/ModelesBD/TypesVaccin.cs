using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SuiviVaccinDBFirst.ModelesBD
{
    public partial class TypesVaccin
    {
        public TypesVaccin()
        {
            Vaccins = new HashSet<Vaccins>();
        }

        public int TypeVaccinId { get; set; }
        public string Nom { get; set; }

        public virtual ICollection<Vaccins> Vaccins { get; set; }
    }
}
