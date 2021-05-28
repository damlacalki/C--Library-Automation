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
    // kitapların kütüphaneye iadesinin yapıldığı sayfa
    public partial class LendedBooksReturnfrm : Form
    {
        public LendedBooksReturnfrm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IC35A29\\SQLEXPRESS;Initial Catalog=LibraryOtomation;Integrated Security=True");
        DataSet daset = new DataSet();

        private void LendedBooksReturnfrm_Load(object sender, EventArgs e)
        {
            BorrowedList();
        }

        // Kullanıcının kütüphaneden aldığı kitapların listesi, sayfa ilk açıldığında filtresiz tüm alınan kitapları listeler
        private void BorrowedList()
        {
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Borrowed_Books where ActivePassive = 1", connection);
            adtr.Fill(daset, "Borrowed_Books");
            dataGridView1.DataSource = daset.Tables["Borrowed_Books"];
            connection.Close();
        }

        // Cancel butonuna tıklandığında sayfayı kapatır. Bir önceki sayfaya geçilir
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // identity no yazıldığında o yazılan numaraya göre kitapları filtreler
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["Borrowed_Books"].Clear();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Borrowed_Books where Identity_No like '%" + txtID.Text + "%' and ActivePassive = 1 ", connection);
            adtr.Fill(daset, "Borrowed_Books");
            connection.Close();
            if (txtID.Text=="")
            {
                daset.Tables["Borrowed_Books"].Clear();
                BorrowedList();
            }
        }

        // kitap adı yazıldığında o yazılan ada göre kitapları filtreler
        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["Borrowed_Books"].Clear();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Borrowed_Books where Book_Name like '%" + txtBookName.Text + "%' and ActivePassive = 1 ", connection);
            adtr.Fill(daset, "Borrowed_Books");
            connection.Close();
            if (txtBookName.Text == "")
            {
                daset.Tables["Borrowed_Books"].Clear();
                BorrowedList();
            }
        }

        // butona basıldığı zaman kitabın kütüphaneye iade işlemi gerçekleştirilir.
        private void btnReceive_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update Borrowed_Books set ActivePassive = 0 where Identity_No=@Identity_No and Book_Name=@Book_Name", connection);
            command.Parameters.AddWithValue("@Identity_No", dataGridView1.CurrentRow.Cells["Identity_No"].Value.ToString());
            command.Parameters.AddWithValue("@Book_Name", dataGridView1.CurrentRow.Cells["Book_Name"].Value.ToString());
            command.ExecuteNonQuery();
            SqlCommand command2 = new SqlCommand("update Book_Table set Book_Number=Book_Number+'"+dataGridView1.CurrentRow.Cells["Book_Number"].Value.ToString()+"' where Book_Name=@Book_Name", connection);
            command2.Parameters.AddWithValue("@Book_Name", dataGridView1.CurrentRow.Cells["Book_Name"].Value.ToString());
            command2.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("The book has been returned.");
            daset.Tables["Borrowed_Books"].Clear();
            BorrowedList();
        }
    }
}
