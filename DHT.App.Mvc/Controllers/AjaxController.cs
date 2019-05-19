using DHT.BLL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DHT.App.Mvc.Controllers
{
    public class AjaxController : Controller
    {
        public JsonResult GetCities()
        {
            var list = CityRepository.GetCities().Select(a => new { a.Id, a.Name });
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetDistrics(int cityId)
        {
            var list = DistrictRepository.GetCityDistricts(cityId);
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

        public ActionResult GetExaminationFees(int hospitalClinicId)
        {
            var examinations = HospitalClinicExaminationRepository.GetHospitalClinicExaminations(hospitalClinicId);

            return View(examinations);
        }

    }
}