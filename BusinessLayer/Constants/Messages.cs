using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Constants
{
    public static class Messages
    {
        public static string NotEmptyCategoryName = "Kategori adını boş geçemezsiniz!";
        public static string NotEmptyCategoryDescription = "Açıklamayı boş geçemezsiniz!";
        public static string CategoryNameMinimumLength = "Lütfen en az 3 karakter girişi yapınız.";
        public static string CategoryNameMaximumLength = "Lütfen 20 karakterden fazla değer girişi yapmayınız.";
    }
}
