using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccination
{
    /// <summary>
    /// Create Enum for VaccinTypes
    /// </summary>
    public enum VaccinType
    {
        CovidShield = 1, Covaccin, Sputnic
    }
    /// <summary>
    /// Create Class for Vaccination to get properties
    /// </summary>
    class Vaccination
    {
        public VaccinType Vtype { get; set; }
        private static int Count = 1;
        public int Dosage { get; set; }
        public DateTime VaccinatedDate { get; set; }

        //Create Constrctor
        public Vaccination(VaccinType vaccintype, DateTime vacinDate)
        {
            this.Vtype = vaccintype;
            this.VaccinatedDate = vacinDate;
        }

    }
}
