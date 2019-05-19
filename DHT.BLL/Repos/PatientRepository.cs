using DHT.Data;
using DHT.Entity.Entities;
using DHT.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHT.BLL.Repos
{
    public class PatientRepository : Repository<Patient>
    {
        // hastaları getirir
        public static List<Patient> GetPatients()
        {
            using (var db = new DhtContext())
            {
                return db.Patients
                    .Include("Appoinments")
                    .ToList();
            }
        }

        public static Patient Login(string tcNo, string password) //giriş yapmış hastalar
        {
            using (var db = new DhtContext())
            {
                var md5password = StringUtils.MD5(password);

                return db.Patients  //tcnosu ve passwordü girilmişse
                    .Include("Appoinments")
                    .Where(a => a.TcNo.Equals(tcNo) && a.Password.Equals(md5password) )
                    .FirstOrDefault();
            }
        }
    }
}
