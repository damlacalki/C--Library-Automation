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
    public partial class BooksOnLoanFrm : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IC35A29\\SQLEXPRESS;Initial Catalog=LibraryOtomation;Integrated Security=True");
        

        string IdentityNo = "";

        public BooksOnLoanFrm(string identityNo)
        {
            InitializeComponent();
            IdentityNo = identityNo;
        }

        private void BooksOnLoanFrm_Load(object sender, EventArgs e)
        {
            loanBooklist();
            returnedBooklist();
        }

        // Kullanıcıdaki kitapları listeler
        private void loanBooklist()
        {
            DataSet daset = new DataSet();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Borrowed_Books where ActivePassive = 1 and Identity_No = " + IdentityNo, connection);
            adtr.Fill(daset, "Borrowed_Books");
            dgvBooksOnLoan.DataSource = daset.Tables["Borrowed_Books"];
            connection.Close();
        }

        // Kullanıcının daha önceden alıp kütüphaneye iade ettiği kitapları listeler
        private void returnedBooklist()
        {
            DataSet daset = new DataSet();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Borrowed_Books where ActivePassive = 0 and Identity_No = " + IdentityNo, connection);
            adtr.Fill(daset, "Borrowed_Books");
            dgvBooksReturned.DataSource = daset.Tables["Borrowed_Books"];
            connection.Close();
        }
    }
}
