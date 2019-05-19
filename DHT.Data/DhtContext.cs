using DHT.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHT.Data
{
    public class DhtContext : DbContext //DhtContext DbContext sınıfından türemiştir
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<HospitalClinic> HospitalClinics { get; set; }
        public DbSet<HospitalClinicExamination> HospitalClinicExaminations { get; set; }
        public DbSet<Appoinment> Appoinments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<SysAdmin> SysAdmins { get; set; }

        
        public DhtContext() : base("Data Source=.;Initial Catalog=DomesticHealthTourism;Integrated Security=True;")
        {
            //Configuration.LazyLoadingEnabled = false;
        }

    }

    

}
