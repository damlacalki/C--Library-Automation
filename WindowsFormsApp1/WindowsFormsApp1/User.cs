using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    // kullancı girişi yapıldıktan sonra ekranlarda kullanmak için giriş yapan kullanıcının bilgileri bu type'daki değerlere atılıyor.
    public class User
    {
        public int adminUser;
        public int loginSuccessful;
        public string identityNo;
        public string nameSurname;
        public string email;
        public string phoneNumber;
        public string address;
        public string password;
    }
}
