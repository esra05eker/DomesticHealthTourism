using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHT.Entity.Entities
{
    public class Appoinment : BaseEntity
    {
        public Appoinment()
        {

        }

        public DateTime AppointmentTime { get; set; }

        [Required] //attribute PatientId kolonuna şart veya kısıtlama getirmiştir. PatientId columnu null değer alamaz
        public int PatientId { get; set; }  //PatientId-->property

        [Required] //attribute DoctorId kolonuna şart veya kısıtlama getirmiştir. DoctorId columnu null değer alamaz
        public int DoctorId { get; set; } //DoctorId-->property



        public Patient Patient { get; set; }

        public Doctor Doctor { get; set; }

        [NotMapped] // veritabanı ile alakalı bir property değil anlamına geliyor sadece program için kolay erişim 
        public Hospital Hospital
        {
            get
            {
                if (Doctor != null && Doctor.HospitalClinic != null)
                    return Doctor.HospitalClinic.Hospital;

                return null;
            }
        }

    }
}
