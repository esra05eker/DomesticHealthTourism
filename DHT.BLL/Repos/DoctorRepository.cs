using DHT.Data;
using DHT.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHT.BLL.Repos
{
    public class DoctorRepository : Repository<Doctor>
    {
        // doktor getir
        public static Doctor GetDoctor(int id)
        {
            // entity framework context'i çağırılıyor
            using (var db = new DhtContext())
            {
                return db.Doctors
                    .Include("HospitalClinic") // join işlemi
                    .Include("HospitalClinic.Clinic")
                    .Include("HospitalClinic.Hospital")
                    .Include("Appoinments")
                    .Where(a => a.Id == id)
                    .FirstOrDefault();
            }
        }

        // doktroları getirir
        public static List<Doctor> GetDoctors()
        {
            // entity framework context'i çağırılıyor
            using (var db = new DhtContext())
            {
                return db.Doctors
                    .Include("HospitalClinic") // join işlemi
                    .Include("HospitalClinic.Clinic")
                    .Include("HospitalClinic.Hospital")
                    .Include("Appoinments")
                    .ToList(); // liste olarak 
            }
        }

        // belli bir hastanedeki doktroları getirir
        public static List<Doctor> GetDoctorsInHospitalClinic(int hospitalClinicClinicId)
        {
            using (var db = new DhtContext())
            {
                return db.Doctors
                    .Include("HospitalClinic")
                    .Include("HospitalClinic.Clinic")
                    .Include("HospitalClinic.Hospital")
                    .Include("Appoinments")
                    .Where(a => a.HospitalClinic.Id == hospitalClinicClinicId)
                    .ToList();
            }
        }

    }
}
