using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHT.Entity.Entities
{
    // bütün entity'lerin ata sınıfı
    public abstract class BaseEntity
    {
        [Key] // PrimaryKey
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // id lerin otomatik artırmak için Auto-Increment
        public int Id { get; set; }
    }
}
