using DHT.Data;
using DHT.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHT.BLL.Repos
{
    public class AppoinmentRepository : Repository<Appoinment>
    {
        // Bütün randevuları getirir.
        public static List<Appoinment> GetAppoinments()
        {
            using (var db = new DhtContext())
            {
                return db.Appoinments
                    .Include("Doctor")
                    .Include("Doctor.HospitalClinic")
                    .Include("Doctor.HospitalClinic.Hospital")
                    .Include("Doctor.HospitalClinic.Clinic")
                    .Include("Patient")
                    .OrderByDescending(a => a.AppointmentTime)
                    .ToList();
            }
        }

        public static List<Appoinment> GetAppoinments(int patientId)
        {
            using (var db = new DhtContext())
            {
                return db.Appoinments
                    .Include("Doctor")
                    .Include("Doctor.HospitalClinic")
                    .Include("Doctor.HospitalClinic.Hospital")
                    .Include("Doctor.HospitalClinic.Clinic")
                    .Include("Patient")
                    .Where(a => a.PatientId == patientId)
                    .OrderByDescending(a => a.AppointmentTime)
                    .ToList();
            }
        }

        public static List<Appoinment> Find(int doctorId, DateTime date)
        {
            using (var db = new DhtContext())
            { //truncate: format şekline göre verilmiş tarih bilgisini dönüştürür
                return db.Appoinments
                    .Include("Doctor")
                    .Include("Doctor.HospitalClinic")
                    .Include("Doctor.HospitalClinic.Hospital")
                    .Include("Doctor.HospitalClinic.Clinic")
                    .Include("Patient")
                    .Where(a => a.DoctorId == doctorId && DbFunctions.TruncateTime(a.AppointmentTime) == date.Date) //randevu tarihi 
                
                    .ToList();
            }
        }

        public static bool IsSuitable(int doctorId, DateTime dateTime) //doktorun muayene programı uygun mu?
        {
            using (var db = new DhtContext())
            {
                if (dateTime.Second > 0)
                    dateTime = dateTime.AddSeconds(dateTime.Second * -1);
                return !db.Appoinments
                    .Where(a => a.DoctorId == doctorId && a.AppointmentTime == dateTime)
                    .Any();
            }
        }
    }
}
