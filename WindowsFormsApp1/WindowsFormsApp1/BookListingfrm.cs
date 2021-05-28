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
    // kütüphanedeki kitapların listelenmesini ve kitapların bilgileri üzerindeki güncelleme işlemlerinin yapılmasını sağlar
    public partial class BookListingfrm : Form
    {
        int UserAdmin = 0;
        public BookListingfrm(int userAdmin)
        {
            InitializeComponent();
            UserAdmin = userAdmin;
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IC35A29\\SQLEXPRESS;Initial Catalog=LibraryOtomation;Integrated Security=True");
        DataSet daset = new DataSet();


        // kitapların listelendiği fonksiyon, sayfa ilk açıldığında ve herhangi bir kitabın bilgileri üzerinde güncelleme yapıldığında çağırılır
        private void booklist()
        {
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select ID, Book_Name, Author, Publisher, Page_Number, Type, " +
                "case when type = 0 then 'Literature' when type = 1 then 'Children and Youth' when type = 2 then 'Education' when type = 3 then 'Research - History' when type = 4 then 'Religion Sufism' " +
                "when type = 5 then 'Art - Design' when type = 6 then 'Philosophy' when type = 7 then 'Hobby' when type = 8 then 'Science' when type = 9 then 'Comic book' " +
                "when type = 10 then 'Humor' when type = 11 then 'Mythology Myth' when type = 12 then 'Prestige Books' else '' end As TypeName, " +
                "Explanation, Total_Book, Book_Number, Registiration_Date, Shelf_No, Barcode_No, Delivered_Book from Book_Table", connection);
            adtr.Fill(daset, "Book_Table");
            dataGridView1.DataSource = daset.Tables["Book_Table"];
            connection.Close();
        }

        private void BookListingfrm_Load(object sender, EventArgs e)
        {
            booklist();

            // kullanıcının tipine göre (admin veya normal kullanıcı) butonların görünüp görünmemesini sağlar
            if (UserAdmin == 0)
            {
                label9.Hide();
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label8.Hide();
                label11.Hide();
                label10.Hide();
                label16.Hide();
                txtID.Hide();
                txtBookName.Hide();
                txtAuthor.Hide();
                txtPublisher.Hide();
                txtPages.Hide();
                cbType.Hide();
                txtExplanation.Hide();
                txtTotal.Hide();
                txtBookNumber.Hide();
                txtBarcode.Hide();
                txtShelf.Hide();
                btnUpdate.Hide();
                btnCancel.Hide();
                dataGridView1.Height = 390;
                dataGridView1.Width = 1110 ;
                dataGridView1.Location = new Point(25, 150);
                this.dataGridView1.Columns["Total_Book"].Visible = false;
                this.dataGridView1.Columns["Book_Number"].Visible = false;
                this.dataGridView1.Columns["Barcode_No"].Visible = false;
                this.dataGridView1.Columns["Shelf_No"].Visible = false;
                this.dataGridView1.Columns["Registiration_Date"].Visible = false;
                this.dataGridView1.Columns["Delivered_Book"].Visible = false;
                this.dataGridView1.Columns["Explanation"].Width = 350;
            }
        }

        // butona tıklandığı zaman seçili kitabın bilgileri güncellenir
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update Book_Table set Book_Name=@Book_Name, Author=@Author, Publisher=@Publisher, Page_Number=@Page_Number, Type=@Type, Explanation=@Explanation, Total_Book=@Total_Book, Book_Number=@Book_Number, Barcode_No=@Barcode_No, Shelf_No=@Shelf_No where ID=@ID", connection);
            command.Parameters.AddWithValue("@ID", txtID.Text);
            command.Parameters.AddWithValue("@Book_Name", txtBookName.Text);
            command.Parameters.AddWithValue("@Author", txtAuthor.Text);
            command.Parameters.AddWithValue("@Publisher", txtPublisher.Text);
            command.Parameters.AddWithValue("@Page_Number", txtPages.Text);
            command.Parameters.AddWithValue("@Type", cbType.SelectedIndex);
            command.Parameters.AddWithValue("@Explanation", txtExplanation.Text);
            command.Parameters.AddWithValue("@Total_Book", txtTotal.Text);
            command.Parameters.AddWithValue("@Book_Number", txtBookNumber.Text);
            command.Parameters.AddWithValue("@Barcode_No", txtBarcode.Text);
            command.Parameters.AddWithValue("@Shelf_No", txtShelf.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Update process has been done.");
            daset.Tables["Book_Table"].Clear();
            booklist();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        // butona tıklanıldığı zaman sayfa kapatılır
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchBook_TextChanged(object sender, EventArgs e)
        {
            SearchBook();
        }

        private void txSearchAuthor_TextChanged(object sender, EventArgs e)
        {
            SearchBook();
        }

        private void txSearchPublisher_TextChanged(object sender, EventArgs e)
        {
            SearchBook();
        }

        private void cboSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchBook();
        }

        // Kitapların kitap ismine, yazarına, tipine ve yayıncısına göre filtrelenmesini sağlar
        public void SearchBook()
        {
            daset = new DataSet();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select ID, Book_Name, Author, Publisher, Page_Number, Type, " +
                "case when type = 0 then 'Literature' when type = 1 then 'Children and Youth' when type = 2 then 'Education' when type = 3 then 'Research - History' when type = 4 then 'Religion Sufism' " +
                "when type = 5 then 'Art - Design' when type = 6 then 'Philosophy' when type = 7 then 'Hobby' when type = 8 then 'Science' when type = 9 then 'Comic book' " +
                "when type = 10 then 'Humor' when type = 11 then 'Mythology Myth' when type = 12 then 'Prestige Books' else '' end As TypeName, " +
                "Explanation, Total_Book, Book_Number, Registiration_Date, Shelf_No, Barcode_No, Delivered_Book  from Book_Table where Book_Name like  '%" + txtSearchBook.Text + "%' and Author like '%" + txSearchAuthor.Text + "%' and Publisher like '%" + txSearchPublisher.Text + "%' and ('" + cboSearchType.SelectedIndex + "' < 0 or Type = '" + cboSearchType.SelectedIndex + "') ", connection);
            adtr.Fill(daset, "Book_Table");
            dataGridView1.DataSource = daset.Tables["Book_Table"];
            connection.Close();
        }

       
        // datagridview üzerindeki bir kitaba tıklanınca ilgili bilgiler soldaki form alanlarına aktarılır
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            txtBookName.Text = dataGridView1.CurrentRow.Cells["Book_Name"].Value.ToString();
            txtAuthor.Text = dataGridView1.CurrentRow.Cells["Author"].Value.ToString();
            txtPublisher.Text = dataGridView1.CurrentRow.Cells["Publisher"].Value.ToString();
            txtPages.Text = dataGridView1.CurrentRow.Cells["Page_Number"].Value.ToString();
            cbType.SelectedIndex = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Type"].Value.ToString());
            txtExplanation.Text = dataGridView1.CurrentRow.Cells["Explanation"].Value.ToString();
            txtTotal.Text = dataGridView1.CurrentRow.Cells["Total_Book"].Value.ToString();
            txtBookNumber.Text = dataGridView1.CurrentRow.Cells["Book_Number"].Value.ToString();
            txtBarcode.Text = dataGridView1.CurrentRow.Cells["Barcode_No"].Value.ToString();
            txtShelf.Text = dataGridView1.CurrentRow.Cells["Shelf_No"].Value.ToString();
        }
        
        // girilen kitabın id'sine göre bilgileri getirilir
        private void txtID_TextChanged_1(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select ID, Book_Name, Author, Publisher, Page_Number, Type, " +
                "case when type = 0 then 'Literature' when type = 1 then 'Children and Youth' when type = 2 then 'Education' when type = 3 then 'Research - History' when type = 4 then 'Religion Sufism' " +
                "when type = 5 then 'Art - Design' when type = 6 then 'Philosophy' when type = 7 then 'Hobby' when type = 8 then 'Science' when type = 9 then 'Comic book' " +
                "when type = 10 then 'Humor' when type = 11 then 'Mythology Myth' when type = 12 then 'Prestige Books' else '' end As TypeName, " +
                "Explanation, Total_Book, Book_Number, Registiration_Date, Shelf_No, Barcode_No, Delivered_Book from Book_Table where ID like '" + txtID.Text + "' ", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                txtID.Text = read["ID"].ToString();
                txtBookName.Text = read["Book_Name"].ToString();
                txtAuthor.Text = read["Author"].ToString();
                txtPublisher.Text = read["Publisher"].ToString();
                txtPages.Text = read["Page_Number"].ToString();
                cbType.SelectedIndex = Convert.ToInt32(read["Type"].ToString());
                txtExplanation.Text = read["Explanation"].ToString();
                txtTotal.Text = read["Total_Book"].ToString();
                txtBookNumber.Text = read["Book_Number"].ToString();
                txtBarcode.Text = read["Barcode_No"].ToString();
                txtShelf.Text = read["Shelf_No"].ToString();

            }
            connection.Close();
        }
    }
}
