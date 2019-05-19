using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHT.Entity.Entities
{
    public class City : BaseEntity
    {
        public City()
        {
            Districts = new HashSet<District>();
        }

        [Index(IsUnique = true)]
        public int Code { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }


        public ICollection<District> Districts { get; set; }


        public override string ToString()
        {
            return Name;
        }

    }
}
