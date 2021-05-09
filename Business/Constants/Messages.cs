using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public class Messages
    {
        public static string BrandAdded="Marka Eklendi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string BrandsListed="Marka Listelendi";

        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarsListed = "Arabalar listelendi";
        public static string CarNameMinumumError = "Araba isminin uzunluğu en az 2 karakter olmalıdır";
        public static string DailyPriceError = "Arabanın günlük fiyatı 0'dan az olamaz";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorsListed = "Renkler listelendi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerModified = "Müşteri güncellendi";
        public static string CustomerListed = "Müşteriler listelendi";

        public static string RentAdded = "Kiralama eklendi";
        public static string RentNotComeBack = "Araç henüz kiralamadan dönmedi";
        public static string RentModified = "Kiralama güncellendi";
        public static string RentDeleted = "Kiralama silindi";
        public static string RentalListed = "Kiralamalar listelendi";
        public static string RentalAddedError = "Araç eklenemedi";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserModified = "Kullanıcı güncellendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserListed = "Kullanıcılar listelendi";

        public static string CheckCarImageLımıt="Bir arabanın en fazla 5 resmi olabilir";


        public static string AddedCarImages="Aracın Resmi eklendi";
        public static string DeletedCarImage="Aracın resmi silindi";
        public static string UpdatedCarImage="Araç güncellendi";
    }
}
