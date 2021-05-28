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
    // Kullanıcılar tarafından kütüphaneden en çok ödünç alınan kitapların listelendiği sayfa
    public partial class PopularBooks : Form
    {
        public PopularBooks()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IC35A29\\SQLEXPRESS;Initial Catalog=LibraryOtomation;Integrated Security=True");
        DataSet daset = new DataSet();

        private void PopularBooks_Load(object sender, EventArgs e)
        {
            MostPopularBooks();
        }
      

        // kitapların listelendiği fonksiyon, sayfa ilk açıldığında ve combodaki tür filtresi yapıldığı zaman çağırılır
        private void MostPopularBooks()
        {
            daset = new DataSet();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select ID, Book_Name, Author, Publisher, Page_Number, Type, " +
                "case when type = 0 then 'Literature' when type = 1 then 'Children and Youth' when type = 2 then 'Education' when type = 3 then 'Research - History' when type = 4 then 'Religion Sufism' " +
                "when type = 5 then 'Art - Design' when type = 6 then 'Philosophy' when type = 7 then 'Hobby' when type = 8 then 'Science' when type = 9 then 'Comic book' " +
                "when type = 10 then 'Humor' when type = 11 then 'Mythology Myth' when type = 12 then 'Prestige Books' else '' end As TypeName, " +
                "Explanation, Book_Number, Registiration_Date, Shelf_No, Barcode_No, Delivered_Book from Book_Table where ('" + cboFilter.SelectedIndex + "' < 0 or Type = '" + cboFilter.SelectedIndex + "') order by Delivered_Book Desc", connection);
            adtr.Fill(daset, "Book_Table");
            dataGridView1.DataSource = daset.Tables["Book_Table"];
            connection.Close();
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostPopularBooks();
        }
    }
}
