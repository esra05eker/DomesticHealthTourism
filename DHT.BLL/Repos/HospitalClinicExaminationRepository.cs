using DHT.Data;
using DHT.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHT.BLL.Repos
{
    public class HospitalClinicExaminationRepository : Repository<HospitalClinicExamination>
    {
        // muayene türlerini getirir (kulak burun boğaz,üroloji gibi)
        public static List<HospitalClinicExamination> GetHospitalClinicExaminations()
        {
            using (var db = new DhtContext())
            {
                return db.HospitalClinicExaminations
                    .Include("HospitalClinic")
                    .Include("HospitalClinic.Hospital")
                    .Include("HospitalClinic.Doctors")
                    .ToList();
            }
        }

        public static List<HospitalClinicExamination> GetHospitalClinicExaminations(int hospitalClinicId)
        {
            using (var db = new DhtContext())
            {
                return db.HospitalClinicExaminations
                    .Include("HospitalClinic")
                    .Include("HospitalClinic.Hospital")
                    .Include("HospitalClinic.Doctors")
                    .Where(a => a.HospitalClinicId == hospitalClinicId)
                    .ToList();
            }
        }

    }
}
