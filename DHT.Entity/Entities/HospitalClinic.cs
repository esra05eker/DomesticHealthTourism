using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHT.Entity.Entities
{
    public class HospitalClinic : BaseEntity
    {
        public HospitalClinic()
        {
            Doctors = new List<Doctor>();
            HospitalClinicExaminations = new List<HospitalClinicExamination>();
        }

        [Required]
        public int HospitalId { get; set; }

        [Required]
        public int ClinicId { get; set; }


        public Hospital Hospital { get; set; }

        public Clinic Clinic { get; set; }

        public ICollection<Doctor> Doctors { get; set; }

        public ICollection<HospitalClinicExamination> HospitalClinicExaminations { get; set; }

        public override string ToString()
        {
            return Hospital.Name + " - " + Clinic.Name;
        }
    }
}
