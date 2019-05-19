using DHT.App.Mvc.Attributes;
using DHT.BLL.Repos;
using DHT.Entity.Entities;
using DHT.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DHT.App.Mvc.Controllers
{
    public class AccountController : BaseController
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string tcNo, string password)
        {
            var patient = PatientRepository.Login(tcNo, password);

            if (patient != null)
            {
                Session["user"] = patient;
                return Redirect("/");
            }

            SetAlert("warning", "Your credentials are wrong !");

            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon(); // Session bilgisi temizle
            return Redirect("/");
        }

        [SessionAuthorize]
        public ActionResult MyProfile()
        {
            var patient = PatientRepository.Get(sessionUser.Id);
            return View(patient);
        }

        [HttpPost]
        [SessionAuthorize]
        public ActionResult MyProfile(Patient patient, string RePassword = null)
        {
            // parola null değil ise kendisi, null ise "" boş string al
            var password = patient.Password ?? "";

            // ikinci parola (kontrol parolası) null değil ise kendisi, null ise "" boş string al
            var repassword = RePassword ?? "";

            if (!password.Equals(repassword))
            {
                SetAlert("warning", "Your passwords are not matching !");
            }
            else
            {
                // varolan patient bilgileri alıyoruz
                var existingPatient = PatientRepository.Get(sessionUser.Id);

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
                if (update > 0)
                {
                    SetAlert("success", "Your profile saved successfully");
                }
            }

            return View(patient);
        }

        public ActionResult Register()
        {
            if (isLoggedIn) return Redirect("/");
            return View(new Patient());
        }

        [HttpPost]
        public ActionResult Register(Patient patient, string RePassword)
        {
            if (isLoggedIn) return Redirect("/");

            var password = patient.Password ?? "";
            var repassword = RePassword ?? "";

            if (!password.Equals(repassword)) // parolalar eşleşmeli
            {
                SetAlert("warning", "Your passwords are not matching !");
            }
            else if (string.IsNullOrEmpty(patient.Password)) // parola null veya boş ise
            {
                SetAlert("warning", "You have to enter a valid password !");
            }
            else if (!StringUtils.IsNumeric(patient.TcNo) || patient.TcNo.Length != 11) // tc kimlik numarası sadece numaralardan ve 11 karakterden oluşmalı
            {
                SetAlert("warning", "You have to enter a valid T.C. Number !");
            }
            else
            {
                // parolaları veritabanında MD5 ile hashleyerek tuyuyoruz
                patient.Password = StringUtils.MD5(patient.Password);

                // insert işlemi başarılı ise
                var insert = PatientRepository.InsertOrUpdate(patient);
                if (insert > 0)
                {
                    SetAlert("success", "You have registered successfully. You can login now.");
                    return RedirectToAction("Login");
                }
            }

            return View(patient);
        }


    }
}