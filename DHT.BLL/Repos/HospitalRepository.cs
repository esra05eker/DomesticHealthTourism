using DHT.Data;
using DHT.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHT.BLL.Repos
{
    public class HospitalRepository : Repository<Hospital>
    {
        // hastaneleri getirir
        public static List<Hospital> GetHospitals()
        {
            using (var db = new DhtContext())
            {
                return db.Hospitals
                    .Include("District")
                    .Include("District.City")
                    .Include("Clinics")
                    .Include("Clinics.Clinic")
                    .Include("Clinics.HospitalClinicExaminations")
                    .ToList();
            }
        }

        // belirli bir ilçedeki hastaneleri getirir
        public static List<Hospital> GetHospitalsInDistrict(int districtId)
        {
            using (var db = new DhtContext())
            {
                return db.Hospitals
                    .Include("District")
                    .Include("District.City")
                    .Include("Clinics")
                    .Include("Clinics.Clinic")
                    .Include("Clinics.HospitalClinicExaminations")
                    .Where(a => a.DistrictId == districtId)
                    .ToList();
            }
        }
    }
}
