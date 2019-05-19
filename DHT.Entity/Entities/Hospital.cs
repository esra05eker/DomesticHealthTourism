using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHT.Entity.Entities
{
    public class Hospital : BaseEntity
    {
        public Hospital()
        {
            Clinics = new List<HospitalClinic>();
        }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(15)]
        public string Phone { get; set; }

        [Required]
        [MaxLength(255)]
        public string Address { get; set; }

        [Required]
        public int DistrictId { get; set; }

        public District District { get; set; }

        public ICollection<HospitalClinic> Clinics { get; set; }

        [NotMapped] // veritabanı ile alakalı bir property değil anlamına geliyor sadece program için kolay erişim 
        public City City
        {
            get
            {
                if (District != null && District.City != null)
                    return District.City;

                return null;
            }
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
