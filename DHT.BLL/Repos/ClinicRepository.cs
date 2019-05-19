using DHT.Data;
using DHT.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHT.BLL.Repos
{
    public class ClinicRepository : Repository<Clinic>
    {
        // klinikleri getirir
        public static List<Clinic> GetClinics()
        {
            using (var db = new DhtContext())
            {
                return db.Clinics
                    .Include("Hospitals")
                    .ToList();
            }
        }
    }
}
