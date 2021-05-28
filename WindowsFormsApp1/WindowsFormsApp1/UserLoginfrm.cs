using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    // Giriş ve Üye olma işlemlerinin yapıldığı sayfadır.
    public partial class UserLoginfrm : Form
    {
        // Diğer sayfalarda da kullanıcaksak burda tanımlayıp o sayfalara parametre olarak göndermek gerekiyo, yoksa sadece o fonksiyonda kullanabilirsin
        User loginUser;
        int adminUser = 0, loginSuccessful = -1;
        string identityNo = "";
        string nameSurname = "";
        string email = "";
        string phoneNumber = "";
        string address = "";
        string password = "";

        public UserLoginfrm()
        {
            InitializeComponent();
        }


        // Login butonuna tıklandığı zaman form alanlarına yazılan kullanıcı ve şifre ile kontrol yapılarak uygunsa giriş işlemi yapılıp giriş sonrası ana ekrana yönlendirme yapılır,
        // kullanıcı henüz onaylanmamışsa ona göre bir hata mesajı, kullanıcı ve şifre bilgisi ile veritabanındaki bilgiler eşleşmiyorsa ona göre bir hata mesajı verilir.
        private void button1_Click(object sender, EventArgs e)
        {
            u.User(txtIdentityNo, txtPassword, ref adminUser, ref loginSuccessful, ref identityNo, ref nameSurname, ref email, ref phoneNumber, ref address, ref password);

            if (loginSuccessful > 0)
            {
                loginUser = new User();
                loginUser.address = address;
                loginUser.adminUser = adminUser;
                loginUser.identityNo = identityNo;
                loginUser.email = email;
                loginUser.loginSuccessful = loginSuccessful;
                loginUser.nameSurname = nameSurname;
                loginUser.password = password;
                loginUser.phoneNumber = phoneNumber;
                this.Hide();
                Form1 frm = new Form1(loginUser);
                frm.Show();
            }
        }

        Userfrm u = new Userfrm();

        // Register butonuna basıldığı zaman form alanlarına girilen bilgiler uygunsa yeni kullanıcı kaydı yapılır, aynı identity_no'ya ait veritabanında bir kayıt
        // varsa ona uygun bir hata mesajı verdirilir.
        private void btnRegister_Click(object sender, EventArgs e)
        {
            
             u.NewUser(0, txtIdentity_No, txtNameSurname, txtEmail, txtPhoneNumber, txtAddress, txtPw, txtPw2, groupBox2);
            
        }

        private void UserLoginfrm_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            txtPassword.UseSystemPasswordChar = true;
            checkBox2.Checked = true;
            txtPw.UseSystemPasswordChar = true;
            checkBox3.Checked = true;
            txtPw2.UseSystemPasswordChar = true;
            txtIdentity_No.MaxLength = 11;
            txtPhoneNumber.MaxLength = 11;
        }

        // şifrenin yıldızlı olarak veya normal görünmesini sağlar
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;

            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;

            }
        }

        // şifrenin yıldızlı olarak veya normal görünmesini sağlar
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txtPw.UseSystemPasswordChar = true;
            }
            else
            {
                txtPw.UseSystemPasswordChar = false;
            }
        }

        // şifrenin yıldızlı olarak veya normal görünmesini sağlar
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                txtPw2.UseSystemPasswordChar = true;
            }
            else
            {
                txtPw2.UseSystemPasswordChar = false;
            }
        }

        private void txtIdentityNo_TextChanged(object sender, EventArgs e)
        {

        }

        // linke tıklandığı zaman şifre değişikliği sayfasına yönlendirme yapılır.
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewPasswordfrm password = new NewPasswordfrm();
            password.ShowDialog();
        }
    }
}
