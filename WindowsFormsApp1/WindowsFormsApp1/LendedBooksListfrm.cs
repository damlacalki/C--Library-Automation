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
    // kitapların listelendiği sayfa
    public partial class LendedBooksListfrm : Form
    {
        public LendedBooksListfrm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IC35A29\\SQLEXPRESS;Initial Catalog=LibraryOtomation;Integrated Security=True");
        
        private void LendedBooksListfrm_Load(object sender, EventArgs e)
        {
            BorrowedList();
        }

        // kütüphaneden alınan tüm kitapları listeler
        private void BorrowedList()
        {
            DataSet daset = new DataSet();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Borrowed_Books ", connection);
            adtr.Fill(daset, "Borrowed_Books");
            dataGridView1.DataSource = daset.Tables["Borrowed_Books"];
            connection.Close();
        }

        // kütüphaneden alınıp gecikmeli olarak iade edilen kitapları listeler
        private void BorrowedListDelayed()
        {
            DataSet daset = new DataSet();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Borrowed_Books where ActivePassive = 0 and convert(varchar, Return_Date, 104)  > convert(varchar, getdate(), 104)", connection);
            adtr.Fill(daset, "Borrowed_Books");
            dataGridView1.DataSource = daset.Tables["Borrowed_Books"];
            connection.Close();
        }

        // kütüphaneden alınıp zamanında iade edilen kitapları listeler
        private void BorrowedListNonDelayed()
        {
            DataSet daset = new DataSet();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Borrowed_Books where ActivePassive = 0 and convert(varchar, Return_Date, 104)  <= convert(varchar, getdate(), 104)", connection);
            adtr.Fill(daset, "Borrowed_Books");
            dataGridView1.DataSource = daset.Tables["Borrowed_Books"];
            connection.Close();
        }

        // yapılan seçime göre filtreler uygulanır
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                BorrowedList();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                BorrowedListDelayed();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                BorrowedListNonDelayed();
            }
        }
    }
}
