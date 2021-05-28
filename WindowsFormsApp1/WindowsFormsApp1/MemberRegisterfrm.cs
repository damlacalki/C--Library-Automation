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
    // admin kullanıcıları tarafından yeni kullanıcı girişinin yapıldığı sayfa
    public partial class MemberRegisterfrm : Form
    {
        public MemberRegisterfrm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IC35A29\\SQLEXPRESS;Initial Catalog=LibraryOtomation;Integrated Security=True");

        private void MemberRegisterfrm_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            txtPassword.UseSystemPasswordChar = true;
        }
                    


        // butona tıklandığında sayfa kapatılır
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // butona tıklandığı zaman form alanına girilen bilgilerle yeni bir kullanıcı oluşturulur.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if (txtId.Text.Length != 11)
            //{
            //    MessageBox.Show("Identity Number must be at least 11 characters.");
            //}
            //else
            //{
                connection.Open();
                SqlCommand command = new SqlCommand("insert into Member_Table(Identity_No, NameSurname, Email, Phone_Number, Address, Password, Admin_User, BooksRead, UserApproved) values(@Identity_No, @NameSurname, @Email, @Phone_Number, @Address, @Password, @Admin_User, @BooksRead, @UserApproved)", connection);
                //command.Parameters.AddWithValue("@ID", txtIDKEY.Text);
                command.Parameters.AddWithValue("@Identity_No", txtId.Text);
                command.Parameters.AddWithValue("@NameSurname", txtNameSurname.Text);
                command.Parameters.AddWithValue("@Email", txtMail.Text);
                command.Parameters.AddWithValue("@Phone_Number", txtPhone.Text);
                command.Parameters.AddWithValue("@Address", txtAddress.Text);
                command.Parameters.AddWithValue("@Password", txtPassword.Text);
                command.Parameters.AddWithValue("@Admin_User", cbAdminUser.SelectedIndex);
                command.Parameters.AddWithValue("@BooksRead", txtBooksRead.Text);
                command.Parameters.AddWithValue("@UserApproved", 1);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Member registration process has been completed.");
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtBooksRead)
                        {
                            item.Text = "";
                        }

                    }
                }
            //}            
        }

        // girilen şifrenin normal veya yıldızlı olarak gösterilmesini sağlar
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
    }
}
