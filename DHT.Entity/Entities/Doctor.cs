using DHT.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHT.Entity.Entities
{
    public class Doctor : BaseEntity
    {
        public Doctor()
        {
            Appoinments = new HashSet<Appoinment>();
        }
     
        [Required]
        [Index(IsUnique = true)]
        [MaxLength(11)]
        public string TcNo { get; set; }

        [Required]
        [MaxLength(100)]
        public string Firstname { get; set; }

        [Required]
        [MaxLength(100)]
        public string Lastname { get; set; }

        public Gender Gender { get; set; }

        [MaxLength(255)]
        public string Email { get; set; }

        [MaxLength(15)]
        public string Phone { get; set; }

        [Required]
        public int HospitalClinicId { get; set; }


        public HospitalClinic HospitalClinic { get; set; }

        public ICollection<Appoinment> Appoinments { get; set; }

        public override string ToString()
        {
            return Firstname + " " + Lastname;
        }
    }
}
