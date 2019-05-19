// toastr alert ayarları
toastr.options = {
    "closeButton": false, // kapatma  butonu gösterilsin mi
    "newestOnTop": false, // yeniler üstte gösterilsin
    "positionClass": "toast-top-right", // ekrandaki konumlandırma
    "showDuration": "300", // gösterilme süresi
    "hideDuration": "1000", // gizlenme süresi
    "timeOut": "5000", // zamanaşımı süresi
    "extendedTimeOut": "1000", // uzatılmış zamanaşımı sğresi
    "showEasing": "swing", // animasyon
    "hideEasing": "linear", // animasyon
    "showMethod": "fadeIn", // animasyon
    "hideMethod": "fadeOut" // animasyon
};

$(document).ready(function () {
    initDatepickers(); // datetimepicker ları initalize et
    var params = getQueryStringParams(); // urldeki querystringleri al ör: http://localhost:54671/Appoinment/Search?doctorId=2&date=2019-04-20 bu linkteki doctorId ve date değerlerini almak için kullanıyoruz

    /*
     * cmb ile başlayan değişkenler ilgili bilgileri tutan combobox'lardır. (select element vea dropdown element)
     * Örn: cmbCity değişkeni şehirlerin seçilebileceği bir combobox elementidir.
     * 
     * $.getJSON => jQuery'nin bu fonksiyonu ile server'a ajax isteği gönderiyoruz ve gelen cevap JSON olduğu için direk javascript object olarak işlem yapabiliyoruz.
     * 
     * fillOptions => bu fonksiyion ile herhangi bir combox'ın içerisindeki seçenekler dolduruluyor
     * 
     * .on('change') => bu event'ler combobox'lardan bir değer seçildiğinde tetiklenir. Proje içerisinde randevu ararken kullanıldı.
     * Seçilen ildeki ilçeler dinamik olarak veritabanında sorgulnır ve gelir cmbDistrict combobox'ı içerisine doldurulur. Diğerleri aynı şekilde devam eder.
     * 
     * 
     * 
     * */

    var cmbCity = $('#cmbCity');
    var cmbDistrict = $('#cmbDistrict');
    var cmbHospital = $('#cmbHospital');
    var cmbClinic = $('#cmbClinic');
    var cmbDoctor = $('#cmbDoctor');
    var txtDate = $('#txtDate');
    var btnSearch = $('#btnSearch');

    // Eğer cmbCity içerisindeki iller yüklenmemiş ise sayfa açıldığında otomatik yüklensin
    if (cmbCity.find('option').length <= 1) {
        $.getJSON('/ajax/GetCities', function (data) {
            fillOptions(cmbCity, data, 'Id', 'Name');
            if (!cmbCity.data('init')) {
                cmbCity.val(params.cityId).trigger('change').data('init', 1);
            }
        });
    }

    // il sçeildiğinde ilçeleri getir
    cmbCity.on('change', function () {
        var id = cmbCity.val(); // seçilen il id'si
        if (!id) {
            // eğer il seçili iken daha sonra seçilmemiş konuma getirilirse ilçeler yanlış gösterilmesin diye ilçeleri temizliyor.
            clearOptions(cmbDistrict);
            return;
        }

        // ilçeleri ajax ile alıyoruz
        $.getJSON('/ajax/GetDistrics?cityId=' + id, function (data) {
            fillOptions(cmbDistrict, data, 'Id', 'Name'); // gelen ilçeleri cmbDistrict içerisine doldur
            if (!cmbDistrict.data('init')) // eğer cmbDistrict elementinin data-init attribute'ü dolu değil ise
                cmbDistrict.val(params.districtId).trigger('change').data('init', 1); // urldeki &districtId=5 olsun diyelim ilçelerde otomatik olarak 5 id li ilçeyi seçtiriyoruz
        });
    });

    cmbDistrict.on('change', function () {
        var id = cmbDistrict.val();
        if (!id) {
            clearOptions(cmbHospital);
            return;
        }
        $.getJSON('/ajax/GetHospitals?districtId=' + id, function (data) {
            fillOptions(cmbHospital, data, 'Id', 'Name');
            if (!cmbHospital.data('init'))
                cmbHospital.val(params.hospitalId).trigger('change').data('init', 1);
        });
    });

    cmbHospital.on('change', function () {
        var id = cmbHospital.val();
        if (!id) {
            clearOptions(cmbClinic);
            return;
        }
        $.getJSON('/ajax/GetClinics?hospitalId=' + id, function (data) {
            fillOptions(cmbClinic, data, 'Id', 'Name');
            if (!cmbClinic.data('init'))
                cmbClinic.val(params.hospitalClinicId).trigger('change').data('init', 1);
        });
    });

    cmbClinic.on('change', function () {
        var id = cmbClinic.val();
        if (!id) {
            clearOptions(cmbDoctor);
            return;
        }
        $.getJSON('/ajax/GetDoctors?hospitalClinicId=' + id, function (data) {
            fillOptions(cmbDoctor, data, 'Id', 'Name');
            if (!cmbDoctor.data('init'))
                cmbDoctor.val(params.doctorId).trigger('change').data('init', 1);
        });
    });

    // url de date &date=2019-04-20 gibi bir değer var ise search alanında ki tarih textbox alanına bu tarihi yazıyoruz
    txtDate.val(params.date);

    // search butonuna tıklandığında
    btnSearch.on('click', function () {
        // doktor ve tarihin seçilmesi gerekiyor eğer seçilmemişse hata ver devam etme.
        if (!cmbDoctor.val() || !txtDate.val()) {
            show_alert('error', 'Select doctor and date !');
            return;
        }

        // arama yapılmak istenen veriler
        var data = {
            cityId: cmbCity.val(),
            districtId: cmbDistrict.val(),
            hospitalId: cmbHospital.val(),
            hospitalClinicId: cmbClinic.val(),
            doctorId: cmbDoctor.val(),
            date: txtDate.val()
        };

        // /Appoinment/Search?cityId=6&districtId=55&hospitalId=6&hospitalClinicId=6&doctorId=1&date=2019-04-20 gibi bir url oluşturduk
        window.location.href = '/Appoinment/Search?' + $.param(data);
    });

    // Make Appoinment butonuna tıklandığında
    $('.btnMakeAppoinment').on('click', function () {
        var me = $(this);
        var doctorId = me.data('doctor-id');
        var datetime = me.data('datetime');

        // Kullanıcıdan onay al
        bootbox.confirm('Are you sure to make appoinment at ' + datetime, function (confirmed) {
            if (confirmed) { // eğer onaylamışsa
                if (!isLoggedIn) { // giriş yapmamışsa uyarı ver
                    bootbox.alert('Please login to make appoinment. Click here to <a href="/Account/Login">login</a>');
                } else { // giriş yapmışsa randevu url'sine yönlendir
                    location.href = "/Appoinment/MakeAppoinment?doctorId=" + doctorId + "&datetime=" + datetime;
                }
            }
        });
    });

    // My Appoinments sayfasındaki kullanıcının daha önce aldığı randevularda Cancel butonuna tıklandığında
    $('.btnCancel').on('click', function (event) {
        event.preventDefault(); // varsayılan olarak url'ye gitmesini engelle
        var url = this.href;

        // Onay iste
        bootbox.confirm("Are you sure to cancel this appoinment?<br>Note: You can not undone this operation !", function (confirmed) {
            if (confirmed) // eğer onay vermiş ise
                window.location = url; // silme url'sine yönlendir
        });

    });

    // Muayene ücretlerini göster butonu
    $('.btnShowExaminationFees').on('click', function () {
        var me = $(this);
        var hospitalClinicId = me.data('id'); // data-id="xxx"

        $.get('/ajax/GetExaminationFees?hospitalClinicId=' + hospitalClinicId, function (data) {
            // data içerisinde html bir tablo dönmektedir. Buradaki dönen veri JSON değildir, HTML dir.
            // Çünkü dönen değeri direk modal içerisinde göstereceğiz
            bootbox.alert(data); // modal içerisinde göster
        });

    });


});

// Tarih seçme elementlerini initialize et
function initDatepickers() {
    // Bootstrap datepicker kütüphanesi ayarlarını yap ve initialize et
    $('.datepicker').datepicker({
        format: "yyyy-mm-dd", // 2019-04-05
        weekStart: 1, // pazartesi ile başla
        todayBtn: "linked", // bugün butonu görünsün mü
        language: "tr", // dil türkçe
        autoclose: true, // seçildikten sonra otomatik kapansın mı
        todayHighlight: true, // bugünün tarhihn belirgin göster
        startDate: "today" // başlangıç bugünden itibaren olsun geçmiş günler seçilemez
    })
        // otomatik dolurmayı kapat kötü bir görüntü oluşturuyor.
        .attr('autocomplete', 'off');
}

// toastr alert göster
function show_alert(type, message) {
    toastr[type](message);
}

// comboboxdaki seçenekleri temizle
function clearOptions(element) {
    fillOptions(element, []);
    element.trigger('change');
}

// Select elementlerine option eklemek için fonksiyon
function fillOptions(element, items, valKey, textKey) {
    $(element).find('option:gt(0)').remove();

    var options = items.map(function (item) {
        return $('<option>').val(item[valKey]).text(item[textKey]);
    });

    $(element).append(options).trigger('change');
}

// urldeki querystringleri parse object olalarak return et
function getQueryStringParams() {
    var url = location.href; // şuanki url yi al

    var parts = url.split("?"); // sorun iaşretinden ikiye böl 
    var params = {};

    if (parts.length > 1) {
        var noUrl = url.split("?")[1]; // 2.parçayı al:  cityId=1&districtId=2&hospitalId=6&hospitalClinicId=6&doctorId=1&date=2019-05-13
        var keyValue = noUrl.split('&').map(kvPair => {
            return { [kvPair.split("=")[0]]: kvPair.split("=")[1] }; // { cityId: 1 }
        });
        Object.assign(params, ...keyValue);
    }

    /*
     * {
     *  cityId: 1,
     *  districtId: 2,
     *  hospitalId: 6,
     *  hospitalClinicId: 6,
     *  doctorId: 1,
     *  date: "2019-05-13"
     * }
     */
    return params;
}