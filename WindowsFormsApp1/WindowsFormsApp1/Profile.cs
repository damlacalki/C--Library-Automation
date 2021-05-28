using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    // Kullanıcı profil detayının görüntülendiği ve güncellendiği sayfadır.
    public partial class Profile : Form
    {
        public static User user;
        int adminUser = 0, loginSuccessful = -1;
        string identityNo = "";
        string nameSurname = "";
        string email = "";
        string phoneNumber = "";
        string address = "";
        string password = "";

        Userfrm u = new Userfrm();
        public Profile(User loginUser)
        {
            user = loginUser;
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IC35A29\\SQLEXPRESS;Initial Catalog=LibraryOtomation;Integrated Security=True");
        DataSet daset = new DataSet();
        private void AdminLoginfrm_Load(object sender, EventArgs e)
        {
            SetAreas();
            checkBox2.Checked = true;
            txtPw2.UseSystemPasswordChar = true;
            checkBox1.Checked = true;
            txtPw.UseSystemPasswordChar = true;
        }

        // Ana ekrandan bu sayfaya gönderilen kullanıcı bilgisinin form alanlarına aktarılmasını sağlayan fonksiyon, sayfa ilk açıldığında ve bilgiler güncellendikten sonra
        // yeni bilgilerin getirilmesi sırasında çağırılır.
        public void SetAreas()
        {
            txtIdentity_No.Text = user.identityNo;
            txtAddress.Text = user.address;
            txtEmail.Text = user.email;
            txtNameSurname.Text = user.nameSurname;
            txtPhoneNumber.Text = user.phoneNumber;
            txtPw.Text = user.password;
            txtPw2.Text = user.password;
        }

        // şifrenin yıldızlanmış veya normal olarak görüntülenmesini sağlar
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txtPw2.UseSystemPasswordChar = true;
            }
            else
            {
                txtPw2.UseSystemPasswordChar = false;
            }
        }

        // şifrenin yıldızlanmış veya normal olarak görüntülenmesini sağlar
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPw.UseSystemPasswordChar = true;
            }
            else
            {
                txtPw.UseSystemPasswordChar = false;
            }
        }

        // form ekranı kapatıldığında kullanıcı bilgileri değiştirildiyse ana ekrana değişen kullanıcı bilgilerinin aktarılmasını sağlar
        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form = new Form1(user);
            form.GetUser(user);
            //form.ShowDialog();

        }

        // butona tıklandığı zaman kullanıcı bilgileri güncellenir.
        private void btnEdit_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update Member_Table set NameSurname=@NameSurname, Email=@Email, Phone_Number=@Phone_Number, Address=@Address, Password=@Password where Identity_No=@Identity_No", connection);
            command.Parameters.AddWithValue("@Identity_No", txtIdentity_No.Text);
            command.Parameters.AddWithValue("@NameSurname", txtNameSurname.Text);
            command.Parameters.AddWithValue("@Email", txtEmail.Text);
            command.Parameters.AddWithValue("@Phone_Number", txtPhoneNumber.Text);
            command.Parameters.AddWithValue("@Address", txtAddress.Text);
            command.Parameters.AddWithValue("@Password", txtPw.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Update process has been done.");
            connection.Close();

            u.User(txtIdentity_No, txtPw, ref adminUser, ref loginSuccessful, ref identityNo, ref nameSurname, ref email, ref phoneNumber, ref address, ref password);

            user = new User();
            user.address = address;
            user.adminUser = adminUser;
            user.identityNo = identityNo;
            user.email = email;
            user.loginSuccessful = loginSuccessful;
            user.nameSurname = nameSurname;
            user.password = password;
            user.phoneNumber = phoneNumber;

            Form1 frm = new Form1(user);
            SetAreas();

        }
    }
}
