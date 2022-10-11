using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarUpdate = "Araç güncellendi";
        public static string CarDeleted = "Araç silindi";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandDeleted = "Marka silindi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorDeleted = "Renk silindi";         

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserDeleted = "Kullanıcı silindi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerDeleted = "Müşteri silindi";

        public static string RentalAdded = "Kiralama eklendi";
        public static string RentalUpdated = "Kiralama güncellendi";
        public static string RentalDeleted = "Kiralama silindi";

        public static string CarNameInvalid = "Araç ismi geçersiz";
        public static string UserNameInvalid = "Kullanıcı ismi geçersiz";
        public static string CustomerNameInvalid = "Müşteri ismi geçersiz";

        public static string CarsListed = "Araçlar listelendi";
        public static string BrandsListed = "Markalar listelendi";
        public static string ColorsListed = "Renkler listelendi";
        public static string UsersListed = "Kullanıcılar listelendi"; 
        public static string CustomersListed = "Müşteriler listelendi";
        public static string RentalsListed = "Kiralamalar listelendi";
       
        
        public static string RentalNotAdded = "Araç kiralama için uygun değil";
        public static string MeintenanceTime = "Sistem bakımda";

        public static string CarImageAdded = "Araç görseli eklendi";
        public static string CarImageDeleted = "Araç görseli silindi";
        public static string CarImageUpdated = "Araç görseli güncellendi";
        public static string CarImageLimitExceded ="Görsel limiti aşıldığı için yeni görsel eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Erişim belirteci oluşturuldu";
    }
}
