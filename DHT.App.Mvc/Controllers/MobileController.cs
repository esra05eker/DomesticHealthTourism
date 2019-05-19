using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DHT.App.Mvc.Models;
using DHT.BLL.Repos;
using DHT.Entity.Entities;
using DHT.Tools;

namespace DHT.App.Mvc.Controllers
{
    public class MobileController : Controller
    {
        public JsonResult Login(string tcNo, string password)
        {
            var patient = PatientRepository.Login(tcNo, password);

            if (patient != null)
            {
                var response = new
                {
                    patient.Id,
                    patient.TcNo,
                    patient.Firstname,
                    patient.Lastname,
                    patient.Email,
                    patient.Phone,
                    patient.Gender
                };
                return Json(response, JsonRequestBehavior.AllowGet);
            }
            return Json("{}", JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult UpdateProfile(Patient patient)
        {
            // parola null değil ise kendisi, null ise "" boş string al
            var password = patient.Password ?? "";

            // varolan patient bilgileri alıyoruz
            var existingPatient = PatientRepository.Get(patient.Id);

            // üzerinde değişiklikleri işliyoruz
            existingPatient.Firstname = patient.Firstname;
            existingPatient.Lastname = patient.Lastname;
            existingPatient.Email = patient.Email;
            existingPatient.Phone = patient.Phone;
            existingPatient.Gender = patient.Gender;

            // eğer parola girilmiş ise (girilmemiş ise değiştirilmiyor anlamında gelir)
            if (password.Length > 0)
            {
                existingPatient.Password = StringUtils.MD5(patient.Password);
            }

            // güncelleme işlemi başarılı ise
            var update = PatientRepository.InsertOrUpdate(existingPatient);

            var response = new
            {
                patient.Id,
                patient.TcNo,
                patient.Firstname,
                patient.Lastname,
                patient.Email,
                patient.Phone,
                patient.Gender
            };


            return Json(response, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Register(Patient patient)
        {
            patient.Password = StringUtils.MD5(patient.Password);

            // insert işlemi başarılı ise
            var insert = PatientRepository.InsertOrUpdate(patient);

            var response = new
            {
                patient.Id,
                patient.TcNo,
                patient.Firstname,
                patient.Lastname,
                patient.Email,
                patient.Phone,
                patient.Gender
            };

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCities()
        {
            var list = CityRepository.GetCities().Select(a => new { a.Id, a.Name });
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetDistrics(int cityId)
        {
            var list = DistrictRepository.GetCityDistricts(cityId).Select(a => new { a.Id, a.Name, a.CityId });
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetHospitals(int districtId)
        {
            var list = HospitalRepository.GetHospitalsInDistrict(districtId).Select(a => new
            {
                a.Id,
                a.Name
            });
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetClinics(int hospitalId)
        {
            var list = HospitalClinicRepository.GetHospitalClinicsInHospital(hospitalId).Select(a => new
            {
                a.Id,
                a.Clinic.Name
            });
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetDoctors(int hospitalClinicId)
        {
            var list = DoctorRepository.GetDoctorsInHospitalClinic(hospitalClinicId).Select(a => new
            {
                a.Id,
                Name = a.Firstname + " " + a.Lastname
            });
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SearchAppoinment(int doctorId, DateTime date)
        {
            // daha önce alınmış randevuları getir
            List<Appoinment> appoinments = AppoinmentRepository.Find(doctorId, date).Where(a => a.AppointmentTime > DateTime.Now).ToList();

            // bütün randevuları saatine göre Dictionary de tutacağız
            Dictionary<string, Appoinment> pairs = new Dictionary<string, Appoinment>();

            // Dictionary ye ekle
            foreach (var appoinment in appoinments)
            {
                pairs.Add(appoinment.AppointmentTime.ToString("HH:mm"), appoinment);
            }

            // randevu alınacak doktorun bilgilerini getir
            var doctor = DoctorRepository.GetDoctor(doctorId);

            // Burada arama sayfasında işimize yarayacak verileri tutan bir ViewModel oluşturuyoruz.
            var searchViewModel = new SearchViewModel()
            {
                Doctor = doctor,
                Date = date
            };

            // Viewmodel içerisinde randevu alınabilecek saatler var bu saatler müsait ise randevu alınabilecek şekilde kanısına vararak Dictionary'y ekliyoruz
            foreach (var time in searchViewModel.Times)
            {
                // Eğer daha önce randevu alınmışsa bir sonraki saate geç
                if (pairs.Any(a => a.Key.Equals(time))) continue;

                // date bilgisinde saat normal 00:00, buna randevu saatine ekleyerek istenen Datetime nesnesini elde ediyoruz
                var newDate = date + TimeSpan.ParseExact(time, "hh\\:mm", CultureInfo.InvariantCulture);

                // bugün saat 14 de sorgulama yapıyorsaki 14 den önceki randevular boş olsa bile göstemiyoruz çünkü o saat geçmişte kaldı.
                if (newDate > DateTime.Now)
                {
                    pairs.Add(time, new Appoinment()
                    {
                        DoctorId = doctorId,
                        Doctor = doctor,
                        AppointmentTime = newDate
                    });
                }


            }

            // Dictionary yapmamızdaki amaç bu satırdaki gibi bunları saat bilgisine göre sıralayabilmekti. Burada Bütün randevuları saate göre sıralıyoruz.
            pairs = pairs.OrderBy(a => a.Key).ToDictionary((keyItem) => keyItem.Key, (valueItem) => valueItem.Value);

            List<dynamic> list = new List<dynamic>();
            foreach (var pair in pairs)
            {
                list.Add(new
                {
                    Date = pair.Value.AppointmentTime.ToString("dd-MM-yyyy"),
                    Time = pair.Value.AppointmentTime.ToString("HH:mm"),
                    HospitalName = pair.Value.Hospital.Name,
                    ClinicName = pair.Value.Doctor.HospitalClinic.Clinic.Name,
                    DoctorName = pair.Value.Doctor.Firstname + " " + pair.Value.Doctor.Lastname,
                    isSuitable = pair.Value.Id == 0
                });
            }

            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public JsonResult MakeAppoinment(int doctorId, int patientId, DateTime dateTime)
        {

            var appoinment = new Appoinment()
            {
                DoctorId = doctorId,
                PatientId = patientId,
                AppointmentTime = dateTime
            };

            var insert = AppoinmentRepository.InsertOrUpdate(appoinment);

            return Json(appoinment, JsonRequestBehavior.AllowGet);
        }

        public JsonResult CancelAppoinment(int id)
        {
            var appoinment = AppoinmentRepository.Get(id);

            var delete = AppoinmentRepository.Delete(appoinment);

            return Json(delete > 0, JsonRequestBehavior.AllowGet);
        }

        public JsonResult MyAppoinments(int patientId)
        {
            var appoinments = AppoinmentRepository.GetAppoinments(patientId).Select(a => new
            {
                Id = a.Id,
                Date = a.AppointmentTime.ToString("dd-MM-yyyy"),
                Time = a.AppointmentTime.ToString("HH:mm"),
                HospitalName = a.Hospital.Name,
                ClinicName = a.Doctor.HospitalClinic.Clinic.Name,
                DoctorName = a.Doctor.Firstname + " " + a.Doctor.Lastname,
                isSuitableForCancel = a.AppointmentTime >= DateTime.Now
            });
            return Json(appoinments, JsonRequestBehavior.AllowGet);
        }

    }
}