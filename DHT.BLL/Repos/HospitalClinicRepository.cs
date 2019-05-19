using DHT.Data;
using DHT.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHT.BLL.Repos
{
    public class HospitalClinicRepository : Repository<HospitalClinic>
    {
        public static List<HospitalClinic> GetHospitalsClinics() //klinikleri getirir
        {
            using (var db = new DhtContext())
            {
                return db.HospitalClinics
                    .Include("Clinic") //join
                    .Include("Hospital")
                    .Include("Doctors")
                    .Include("HospitalClinicExaminations")
                    .ToList();
            }
        }

        public static List<Clinic> GetClinicsInHospital(int hospitalId)
        {
            using (var db = new DhtContext())
            {
                return db.HospitalClinics
                    .Include("Clinic")
                    .Include("Hospital")
                    .Include("Doctors")
                    .Include("HospitalClinicExaminations")
                    .Where(a => a.Hospital.Id == hospitalId)
                    .Select(a => a.Clinic)
                    .ToList();
            }
        }
        // belli bir hastanedeki klinikleri getirir
        public static List<HospitalClinic> GetHospitalClinicsInHospital(int hospitalId)
        {
            using (var db = new DhtContext())
            {
                return db.HospitalClinics
                    .Include("Clinic")
                    .Include("Hospital")
                    .Include("Doctors")
                    .Include("HospitalClinicExaminations")
                    .Where(a => a.Hospital.Id == hospitalId)
                    .ToList();
            }
        }
    }
}
