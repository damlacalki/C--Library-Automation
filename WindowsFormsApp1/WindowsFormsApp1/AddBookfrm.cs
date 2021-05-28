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
    public partial class AddBookfrm : Form
    {
        // Kütüphaneye kitap ekleme işleminin yapıldığı sayfa
        public AddBookfrm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IC35A29\\SQLEXPRESS;Initial Catalog=LibraryOtomation;Integrated Security=True");


        private void AddBookfrm_Load(object sender, EventArgs e)
        {

        }
       
        // butona tıklanınca Book_Table tablosuna yeni eklenen kitap bilgilerini atar
        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Book_Table(Book_Name, Author, Publisher, Page_Number, Type, Explanation, Total_Book, Book_Number, Registiration_Date, Barcode_No, Shelf_No, Delivered_Book) values(@Book_Name, @Author, @Publisher, @Page_Number, @Type, @Explanation, @Total_Book,  @Book_Number, @Registiration_Date, @Barcode_No, @Shelf_No, 0)", connection);
            //.Parameters.AddWithValue("@ID", txtID.Text);
            command.Parameters.AddWithValue("@Book_Name", txtBookName.Text);
            command.Parameters.AddWithValue("@Author", txtAuthor.Text);
            command.Parameters.AddWithValue("@Publisher", txtPublisher.Text);
            command.Parameters.AddWithValue("@Page_Number", txtPages.Text);
            command.Parameters.AddWithValue("@Type", cbType.SelectedIndex);
            command.Parameters.AddWithValue("@Explanation", txtExplanation.Text);
            command.Parameters.AddWithValue("@Total_Book", txtTotal.Text);
            command.Parameters.AddWithValue("@Book_Number", txtBookNumber.Text);
            command.Parameters.AddWithValue("@Registiration_Date", DateTime.Now.ToShortDateString());
            command.Parameters.AddWithValue("@Barcode_No", txtBarcode.Text);
            command.Parameters.AddWithValue("@Shelf_No", txtShelf.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Book registration process has been completed.");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                cbType.SelectedIndex = -1;
            }
        }

 
        // butona tıklanınca sayfayı kapatır
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // butona tıklanınca excel'den toplu kitap ekleme işlemi yapılacağı sayfayı açar
        private void btnAddExcel_Click(object sender, EventArgs e)
        {
            BookExcelfrm excelbook = new BookExcelfrm();
            excelbook.ShowDialog();
        } 
    }
}
