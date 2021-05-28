using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    // Üye olan kullanıcıların sisteme giriş yapabilmeleri için admin kullanıcıları tarafından onaylandığı sayfadır.
    public partial class UserApproveFrm : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IC35A29\\SQLEXPRESS;Initial Catalog=LibraryOtomation;Integrated Security=True");
        

        public UserApproveFrm()
        {
            InitializeComponent();
        }

        // kullanıcı listesini getiren fonksiyon, sayfa ilk açıldığında ve herhangi bir kayıt üzerinde onayla işlemi yapıldıktan sonra çağırılır.
        private void memberlist()
        {
            DataSet daset = new DataSet();
            
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Member_Table where UserApproved = 0", connection);
            adtr.Fill(daset, "Member_Table");
            dataGridView1.DataSource = daset.Tables["Member_Table"];
            connection.Close();
        }

        private void UserApproveFrm_Load(object sender, EventArgs e)
        {
            memberlist();
        }

        // datagridview'de her satır üzerinde onayla butonu bulunmakta, hangi satır üzerindeki butona tıklandıysa o kullanıcı için onaylama işlemi yapılır.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnApprove")
            {
                int row = dataGridView1.Rows[e.RowIndex].Index;

                connection.Open();
                SqlCommand command = new SqlCommand("update Member_Table set UserApproved=1 where Identity_No=@Identity_No", connection);
                command.Parameters.AddWithValue("@Identity_No", dataGridView1.Rows[row].Cells["Identity_No"].Value);
                command.ExecuteNonQuery();
                MessageBox.Show("Update process has been done.");
                connection.Close();
                memberlist();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnDecline")
            {
                int row = dataGridView1.Rows[e.RowIndex].Index;

                connection.Open();
                SqlCommand command = new SqlCommand("update Member_Table set UserApproved=2 where Identity_No=@Identity_No", connection);
                command.Parameters.AddWithValue("@Identity_No", dataGridView1.Rows[row].Cells["Identity_No"].Value);
                command.ExecuteNonQuery();
                MessageBox.Show("Update process has been done.");
                connection.Close();
                memberlist();
            }
        }
    }
}
