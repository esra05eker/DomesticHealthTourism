using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHT.Entity.Entities
{
    public class District : BaseEntity //District:  tablo adı     
    {
        public District()
        {
            Hospitals = new HashSet<Hospital>(); //hastane tablosundan aynı veri bir daha gelmez
        }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } //name kolonu boş geçilemez max alan uzunluğu 50 olmalı

        [Required]
        public int CityId { get; set; } //city id si boş geçilemez


        public City City { get; set; } 

        public ICollection<Hospital> Hospitals { get; set; }


        public override string ToString()
        {
            return Name;
        }
    }
}
