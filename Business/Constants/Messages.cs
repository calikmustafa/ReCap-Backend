﻿using System;
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
    }
}