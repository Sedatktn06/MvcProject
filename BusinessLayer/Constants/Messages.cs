using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Constants
{
    public static class Messages
    {
        //Category
        public static string NotEmptyCategoryName = "Kategori adını boş geçemezsiniz!";
        public static string NotEmptyCategoryDescription = "Açıklamayı boş geçemezsiniz!";
        public static string CategoryNameMinimumLength = "Lütfen en az 3 karakter girişi yapınız.";
        public static string CategoryNameMaximumLength = "Lütfen 20 karakterden fazla değer girişi yapmayınız.";

        //Writer
        public static string NotEmptyWriterName = "Yazar adını boş geçemezsiniz!";
        public static string NotEmptyWriterSurname = "Yazar soyadını boş geçemezsiniz!";
        public static string WriterNameMinimumLength =" Lütfen en az 2 karakter girişi yapınız.";
        public static string WriterSurnameMaximumLength = " Lütfen 50 karakterden fazla değer girişi yapmayınız.";
        public static string NotEmptyAbout = " Hakkımda kısmını boş geçemezsiniz.";
        public static string MustContainA = "Hakkında kısmında mutlaka A harfi bulunmalıdır";
        public static string NotEmptyTitle = "Ünvan kısmını boş geçemezsiniz.";

        //Contact
        public static string NotEmptyUserMail = "Mail adresini boş geçemezsiniz!";
        public static string NotEmptySubject = "Konu adını boş geçemezsiniz!";
        public static string NotEmptyUserName = "Kullanıcı adını boş geçemezsiniz!";
        public static string SubjectNameMinimumLength = "Lütfen en az 3 karakter girişi yapınız.";
        public static string UserNameMinimumLength = "Lütfen en az 3 karakter girişi yapınız.";
        public static string SubjectNameMaximumLength = "Lütfen 50 karakterden fazla değer girişi yapmayınız.";

        //Message
        public static string NotEmptyReceiverMail = "Alıcı adresini boş geçemezsiniz!";
        public static string NotEmptyMessage = "Mesajı boş geçemezsiniz!";
        public static string SubjectNameMaximumLength2 = "Lütfen 100 karakterden fazla değer girişi yapmayınız.";
        public static string InvalidEmail = "Geçersiz mail adresi";

    }
}
