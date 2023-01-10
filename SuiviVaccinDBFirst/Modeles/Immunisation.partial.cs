using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviVaccinDBFirst.Modeles
{
    public partial class Immunisation
    {
        public override string ToString()
        {
            return $"{ImmunisationId}. Patient : {Nampatient}. " +
                    $"Date : {Date}. " +
                    $"Type : {Discriminator} " +
                    $"({(Discriminator == "Vaccin" ? Vaccin.Nom : Variant)})";
        }
    }
}
