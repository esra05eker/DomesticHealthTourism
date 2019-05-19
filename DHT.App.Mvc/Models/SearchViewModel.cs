using DHT.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DHT.App.Mvc.Models
{
    // Randevu arama sayfasında kullanılan ViewModel.
    // MVC'de her View bir adet model kullanılabilir. Eğer yapmak istediğimiz özellik birden fazla model(entity)'ye ihtiyaç duyuyorsa
    // viewmodel olarak adlandırılan bir class oluşturulur ve ihtiyaç duyulan alt modeller bu sınıfa property olarak eklenir.
    public class SearchViewModel
    {
        // randevu alınmak istenen doktor
        public Doctor Doctor { get; set; }

        // randevu alınacak tarih
        public DateTime Date { get; set; }

        // randevu tablosundaki verileri içeren Dictionary
        // keyleri aşağıdaki Timer property'sindeki saatlerdir.
        public Dictionary<string, Appoinment> AppoinmentsPairs { get; set; }

        public string[] Times
        {
            get
            {
                return new string[] {
                    "09:00",
                    "09:30",
                    "10:00",
                    "10:30",
                    "11:00",
                    "11:30",
                    "12:00",
                    "12:30",
                    "13:00",
                    "13:30",
                    "14:00",
                    "14:30",
                    "15:00",
                    "15:30",
                    "16:00",
                    "16:30",
                    "17:00",
                };
            }
        }

    }
}