using DHT.App.Mvc.Attributes;
using DHT.App.Mvc.Models;
using DHT.BLL.Repos;
using DHT.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;

namespace DHT.App.Mvc.Controllers
{
    public class AppoinmentController : BaseController
    {
        [SessionAuthorize]
        public ActionResult Index()
        {
            return View(AppoinmentRepository.GetAppoinments(sessionUser.Id));
        }

        public ActionResult Search(int doctorId, DateTime date)
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
            searchViewModel.AppoinmentsPairs = pairs; // ViewModel deki AppoinmentsPairs ata, view içerisinde bunu kullanacağız


            return View(searchViewModel);
        }

        [SessionAuthorize]
        public ActionResult MakeAppoinment(int doctorId, DateTime dateTime)
        {
            // eğer randevu alınmaya müsait ise
            if (AppoinmentRepository.IsSuitable(doctorId, dateTime))
            {
                var appoinment = new Appoinment()
                {
                    DoctorId = doctorId,
                    PatientId = sessionUser.Id,
                    AppointmentTime = dateTime
                };

                var insert = AppoinmentRepository.InsertOrUpdate(appoinment);
                if (insert > 0)
                {
                    SetAlert("success", "Appoinment has been made successfully.");
                }
                else
                {
                    SetAlert("danger", "An error occured to process making appoinment !");
                }
            }
            else
            {
                SetAlert("warning", "Not suitable appoinment !");
            }
            return RedirectToAction("Index");
        }

        [SessionAuthorize]
        public ActionResult Cancel(int id)
        {
            var appoinment = AppoinmentRepository.Get(id);

            // randevu yoksa veya randevunun sahibi giriş yapmış kullanıcı değil ise iptal etmesine izin vermiyoruz
            if (appoinment == null || appoinment.PatientId != sessionUser.Id)
            {
                SetAlert("danger", "This operation is not allowed !");
            }
            else if (appoinment.AppointmentTime < DateTime.Now) // randvu geçmiş ise ipptal edilemez
            {
                SetAlert("danger", "You can not cancel past appoinment !");
            }
            else
            {
                var delete = AppoinmentRepository.Delete(appoinment);
                if (delete > 0)
                {
                    SetAlert("success", "Appoinment deleted");
                }
            }

            return RedirectToAction("Index");
        }

    }
}