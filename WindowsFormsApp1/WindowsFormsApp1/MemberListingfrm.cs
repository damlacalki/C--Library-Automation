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
    // sisteme kayıtlı kullanıcıların listelendiği sayfa
    public partial class MemberListingfrm : Form
    {
        
        public MemberListingfrm()
        {
            
            InitializeComponent();
        }

        // datagridview üzerindeki bir kayda çift tıklanınca ilgili satır üzerindeki bilgileri forma aktarır.
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDKEY.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            txtId.Text = dataGridView1.CurrentRow.Cells["Identity_No"].Value.ToString();
            txtNameSurname.Text = dataGridView1.CurrentRow.Cells["NameSurname"].Value.ToString();
            txtMail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells["Phone_Number"].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells["Address"].Value.ToString();
            txtPassword.Text = dataGridView1.CurrentRow.Cells["Password"].Value.ToString();
            cbAdminUser.SelectedIndex = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Admin_User"].Value.ToString());
            txtBooksRead.Text = dataGridView1.CurrentRow.Cells["BooksRead"].Value.ToString();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IC35A29\\SQLEXPRESS;Initial Catalog=LibraryOtomation;Integrated Security=True");
        DataSet daset = new DataSet();

        // kullanıcıların listelendiği fonksiyon, sayfa ilk açıldığında ve herhanggi bir kullanıcı üzerinde bir güncelleme işlemi yapıldığında çağırılır.
        private void memberlist()
        {
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Member_Table", connection);
            adtr.Fill(daset, "Member_Table");
            dataGridView1.DataSource = daset.Tables["Member_Table"];
            connection.Close();
        }

        private void MemberListingfrm_Load(object sender, EventArgs e)
        {
            memberlist();
            checkBox1.Checked = true;
            txtPassword.UseSystemPasswordChar = true;
        }

               
        // yazılan identity no değerine göre listeyi filtreler
        private void txtIDSearch_TextChanged(object sender, EventArgs e)
        {
            daset = new DataSet();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Member_Table where Identity_No like '%"+txtIDSearch.Text+"%' ", connection);
            adtr.Fill(daset, "Member_Table");
            dataGridView1.DataSource = daset.Tables["Member_Table"];
            connection.Close();
            
        }

        // butona tıklandığında sayfa kapatılır.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        
        // butona tıklandığında soldaki forma girilen değerler ile kullanıcı bilgileri güncellenir
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update Member_Table set Identity_No=@Identity_No, NameSurname=@NameSurname, Email=@Email, Phone_Number=@Phone_Number, Address=@Address, Password=@Password, Admin_User=@Admin_User, BooksRead=@BooksRead where ID=@ID", connection);
            command.Parameters.AddWithValue("@ID", txtIDKEY.Text);
            command.Parameters.AddWithValue("@Identity_No", txtId.Text);
            command.Parameters.AddWithValue("@NameSurname", txtNameSurname.Text);
            command.Parameters.AddWithValue("@Email", txtMail.Text);
            command.Parameters.AddWithValue("@Phone_Number", txtPhone.Text);
            command.Parameters.AddWithValue("@Address", txtAddress.Text);
            command.Parameters.AddWithValue("@Password", txtPassword.Text);
            command.Parameters.AddWithValue("@Admin_User", cbAdminUser.SelectedIndex);
            command.Parameters.AddWithValue("@BooksRead", int.Parse(txtBooksRead.Text));
            command.ExecuteNonQuery();
            MessageBox.Show("Update process has been done.");
            connection.Close();
            daset.Tables["Member_Table"].Clear();
            memberlist();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            cbAdminUser.SelectedIndex = -1;
        }


        // şifrenin yıldızlı ya da görünür olmasını sağlar
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

        // form üzerinde id bilgisi değiştirildiği zaman o id'ye ait kullanıcı bilgilerinin getirilmesini sağlar
        private void txtIDKEY_TextChanged_1(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select *from Member_Table where ID like '" + txtIDKEY.Text + "' ", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                txtIDKEY.Text = read["ID"].ToString();
                txtId.Text = read["Identity_No"].ToString();
                txtNameSurname.Text = read["NameSurname"].ToString();
                txtMail.Text = read["Email"].ToString();
                txtPhone.Text = read["Phone_Number"].ToString();
                txtAddress.Text = read["Address"].ToString();
                txtPassword.Text = read["Password"].ToString();
                cbAdminUser.Text = read["Admin_User"].ToString();
                txtBooksRead.Text = read["BooksRead"].ToString();


            }
            connection.Close();
        }
    }
}
