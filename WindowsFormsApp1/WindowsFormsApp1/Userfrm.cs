using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    // Kullanıcı işlemlerinin veritabanına kaydedilmesi işi bu sayfada çalışan metotlarla yapılıyor.
    class Userfrm
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IC35A29\\SQLEXPRESS;Initial Catalog=LibraryOtomation;Integrated Security=True");
        SqlCommand command;
        SqlDataReader read;
        
        //Form1 menu = new Form1();

        // kullanıcı girişinin yapıldığı fonksiyon
        public SqlDataReader User(TextBox IdentityNo, TextBox Password, ref int adminUser, ref int loginSuccessful, ref string identityNo, ref string nameSurname,
                                  ref string email, ref string phoneNumber, ref string address, ref string password)
        {
            connection.Open();
            command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "select * from Member_Table where UserApproved in (0,1) and Identity_No='" + IdentityNo.Text+"' ";
            


            read = command.ExecuteReader();
            if (read.Read()==true)
            {
                if (read["UserApproved"].ToString() == "0")
                {
                    loginSuccessful = 0;
                    MessageBox.Show("User is not approved.", "Error2");
                }
                else
                {
                    if (Password.Text == read["Password"].ToString())
                    {
                        loginSuccessful = 1;
                        adminUser = Convert.ToInt32(read["Admin_User"].ToString());
                        identityNo = read["Identity_No"].ToString();
                        nameSurname = read["NameSurname"].ToString();
                        email = read["Email"].ToString();
                        phoneNumber = read["Phone_Number"].ToString();
                        address = read["Address"].ToString();
                        password = read["Password"].ToString();
                        //MessageBox.Show("Login Successful.");

                        //menu.ShowDialog();
                    }
                    else
                    {
                        loginSuccessful = 0;
                        MessageBox.Show("Check your password.", "Error1");

                    }
                }
            }
            else
            {
                loginSuccessful = 0;
                MessageBox.Show("Check your information.", "Error2");                
            }
            
            connection.Close();
            return read;
        }

        // yeni kullanıcı kaydetme işleminin yapıldığı fonksiyon
        public void NewUser(int AdminUser, TextBox Identity_No, TextBox NameSurname, TextBox Email, TextBox Phone_Number, TextBox Address, TextBox Pw, TextBox Pw2, GroupBox Group)
        
        {
            if (Pw.Text==Pw2.Text)
            {
                //if (Identity_No.Text.Length != 11)
                //{
                //MessageBox.Show("Identity Number must be at least 11 characters.");
                //}
                //else if (Phone_Number.Text.Length != 11)
                //{
                //MessageBox.Show("Phone Number must be at least 11 characters.");
                //}
                //else
                //{
                connection.Open();
                    command = new SqlCommand();
                    string myQuery = "select COUNT(*) from Member_Table where Identity_No='" + Identity_No.Text + "' ";
                    SqlCommand cmd = new SqlCommand(myQuery, connection);
                    command.Connection = connection;

                    int result = 0;
                    string getValue = cmd.ExecuteScalar().ToString();
                    if (getValue != null)
                    {
                        result = Convert.ToInt32(getValue.ToString());
                    }

                    if (result != 0)
                    {
                        MessageBox.Show("There is a member with this identity number.");
                    }
                    else
                    {
                        command.CommandText = "insert into Member_Table values('" + Identity_No.Text + "','" + NameSurname.Text + "','" + Email.Text + "','" + Phone_Number.Text + "','" + Address.Text + "','" + Pw.Text + "','" + AdminUser + "','" + 0 + "','" + 0 + "')";
                        int sonuc = command.ExecuteNonQuery();
                        MessageBox.Show("Member registiration completed.");
                    }


                    connection.Close();
                    foreach (Control item in Group.Controls) if (item is TextBox) item.Text = "";
            }
            //}
            else
            {
                MessageBox.Show("Passwords do not match.","Error");
            }

        }

        // kullanıcının şifresinin değiştirildiği fonksiyon
        public void NewPassword(TextBox Identity_No, TextBox Email, TextBox Pw, TextBox Pw2, GroupBox Group)
        {
            if (Pw.Text==Pw2.Text)
            {
                connection.Open();
                command = new SqlCommand("select *from Member_Table where Identity_No='" + Identity_No.Text + "' ", connection);
                read = command.ExecuteReader();
                if (read.Read() == true)
                {
                    if (Identity_No.Text == read["Identity_No"].ToString() && Email.Text == read["Email"].ToString())
                    {
                        connection.Close();
                        connection.Open();
                        command = new SqlCommand("update Member_Table set Password='"+Pw.Text+"' where Identity_No='"+Identity_No.Text+"' ",connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Password change successful.");
                        foreach (Control item in Group.Controls) if (item is TextBox) item.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Check your email information.", "Error1");
                    }
                }
                else
                {
                    MessageBox.Show("Check your identity no information.", "Error2");
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Passwords do not match.","Error3");
            }
        }
    }

    
}
