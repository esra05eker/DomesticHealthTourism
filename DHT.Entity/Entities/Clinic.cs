using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHT.Entity.Entities
{
    public class Clinic : BaseEntity
    {
        public Clinic()
        {
            Hospitals = new HashSet<HospitalClinic>();
        }
       
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public ICollection<HospitalClinic> Hospitals { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
