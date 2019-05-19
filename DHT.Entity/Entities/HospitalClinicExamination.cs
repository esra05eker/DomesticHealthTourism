using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHT.Entity.Entities
{
    public class HospitalClinicExamination : BaseEntity
    {

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public decimal Fee { get; set; }

        [Required]
        public int HospitalClinicId { get; set; }

   

        public HospitalClinic HospitalClinic { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
