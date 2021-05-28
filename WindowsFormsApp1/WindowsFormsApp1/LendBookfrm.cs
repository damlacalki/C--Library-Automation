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
    // Kütüphaneden kitap almak isteyen kullanıcıların yönlendirildiği sayfadır
    public partial class LendBookfrm : Form
    {
        int UserAdmin = 0;
        string IdentityNo = "";
        public LendBookfrm(int userAdmin, string identityNo)
        {
            InitializeComponent();
            UserAdmin = userAdmin;
            IdentityNo = identityNo;
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IC35A29\\SQLEXPRESS;Initial Catalog=LibraryOtomation;Integrated Security=True");
        DataSet daset = new DataSet();

        private void LendBookfrm_Load(object sender, EventArgs e)
        {
            txtIdentityNo.MaxLength = 11;
            booklist();
            dtDeliveryDate.Value = DateTime.Now;
            dtReturnDate.Value = DateTime.Now.AddDays(15);

            if (UserAdmin == 0)
            {
                txtIdentityNo.Text = IdentityNo;
                txtIdentityNo.Enabled = false;
                txtNameSurname.Enabled = false;
                txtEmail.Enabled = false;
                txtPhone.Enabled = false;
                GetMemberInformation();
            }
            else
            {
                txtIdentityNo.Enabled = true;
                txtNameSurname.Enabled = true;
                txtEmail.Enabled = true;
                txtPhone.Enabled = true;
            }
        }

       
        // butona tıklanınca sayfa kapatılır
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // kitapların listelendiği fonksiyon, sayfa ilk açıldığında, kitap eklendiğinde, kitap kiralandığında ve kitap çıkarıldığında çağırılır
        private void booklist()
        {
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Basket where User_Identity = " + IdentityNo, connection);
            adtr.Fill(daset, "Basket");
            dataGridView1.DataSource = daset.Tables["Basket"];
            connection.Close();
        }

        // butona tıklandığında soldaki formda girilen kitap bilgileri datagridview'e eklenir
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIdentityNo.Text != "" && txtNameSurname.Text != "" && txtEmail.Text != "" && txtPhone.Text != "")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insert into Basket(Book_Name, Author, Publisher, Page_Number, Book_Number,Barcode_No, Shelf_No, Delivery_Date, Return_Date, User_Identity) values(@Book_Name, @Author, @Publisher, @Page_Number, @Book_Number,@Barcode_No, @Shelf_No, @Delivery_Date, @Return_Date, @User_Identity)", connection);
                command.Parameters.AddWithValue("@Book_Name", txtBookName.Text);
                command.Parameters.AddWithValue("@Author", txtAuthor.Text);
                command.Parameters.AddWithValue("@Publisher", txtPublisher.Text);
                command.Parameters.AddWithValue("@Page_Number", txtPageNo.Text);
                command.Parameters.AddWithValue("@Book_Number", int.Parse(txtBookNumber.Text));
                command.Parameters.AddWithValue("@Barcode_No", txtBarcode.Text);
                command.Parameters.AddWithValue("@Shelf_No", txtShelf.Text);
                command.Parameters.AddWithValue("@Delivery_Date", Convert.ToDateTime(dtDeliveryDate.Text));
                command.Parameters.AddWithValue("@Return_Date", Convert.ToDateTime(dtReturnDate.Text));
                command.Parameters.AddWithValue("@User_Identity", IdentityNo);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Book borrowing process has been completed.");
                daset.Tables["Basket"].Clear();
                booklist();
                lblRemainingRight.Text = "";
                booknumber();
                foreach (Control item in gbBookInformation.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtBookNumber)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("You must first enter the book information.", "Warning");
            }
        }

        // girilen identity no bilgisine göre kullanıcının bilgileri formdaki alanlara getirilir.
        private void txtIdentityNo_TextChanged(object sender, EventArgs e)
        {
            GetMemberInformation();
        }

        public void GetMemberInformation()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Member_Table where Identity_No like '" + txtIdentityNo.Text + "'", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                txtNameSurname.Text = read["NameSurname"].ToString();
                txtEmail.Text = read["Email"].ToString();
                txtPhone.Text = read["Phone_Number"].ToString();
            }
            connection.Close();

            connection.Open();
            SqlCommand command2 = new SqlCommand("select sum(Book_Number) from Borrowed_Books where Identity_No='" + txtIdentityNo.Text + "' and ActivePassive = 1", connection);
            lblRegisteredBookNumber.Text = command2.ExecuteScalar().ToString();
            connection.Close();

            if (txtIdentityNo.Text == "")
            {
                foreach (Control item in gbMemberInformation.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";

                    }

                }
                lblRegisteredBookNumber.Text = "";
            }
        }

        // kitap sayısının getirildiği fonksiyon, kitap eklendiğinde, kitap kiralandığında ve kitap çıkarıldığında çağırılır
        private void booknumber()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select sum (Book_Number) from Basket", connection);
            lblRemainingRight.Text = command.ExecuteScalar().ToString();
            connection.Close();
        }

        // girilen kitap ismi bilgisine göre kitabın bilgileri formdaki alanlara getirilir.
        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Book_Table where Book_Name like '" +txtBookName.Text+ "'", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                txtAuthor.Text = read["Author"].ToString();
                txtPublisher.Text = read["Publisher"].ToString();
                txtPageNo.Text = read["Page_Number"].ToString();
                txtShelf.Text = read["Shelf_No"].ToString();
                txtBarcode.Text = read["Barcode_No"].ToString();

            }
            connection.Close();
            if (txtBookName.Text=="")
            {
                foreach (Control item in gbBookInformation.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtBookNumber)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
            
        }

        // butona tıklandığında kullanıcı tarafından kitap kütüphaneden alınır, Book_Table tablosunda kiralandığına dair gerekli güncelleme (Delivered_Book alanı) yapılır
        private void btnDeliver_Click(object sender, EventArgs e)
        {
            if (lblRemainingRight.Text!="")
            {
                if (lblRegisteredBookNumber.Text =="" && int.Parse(lblRemainingRight.Text)<=3 || lblRegisteredBookNumber.Text!="" && int.Parse(lblRegisteredBookNumber.Text)+int.Parse(lblRemainingRight.Text)<=3)
                {
                    if (txtIdentityNo.Text!="" && txtNameSurname.Text!="" && txtEmail.Text!="" && txtPhone.Text!="")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand("insert into Borrowed_Books(Identity_No, NameSurname, Email, Phone_Number, Book_Name, Author, Publisher, Page_Number, Book_Number, Barcode_No, Shelf_No, Delivery_Date, Return_Date, ActivePassive) values(@Identity_No, @NameSurname, @Email, @Phone_Number, @Book_Name, @Author, @Publisher, @Page_Number, @Book_Number, @Barcode_No, @Shelf_No, @Delivery_Date, @Return_Date, 1)", connection);
                            command.Parameters.AddWithValue("@Identity_No", txtIdentityNo.Text);
                            command.Parameters.AddWithValue("@NameSurname", txtNameSurname.Text);
                            command.Parameters.AddWithValue("@Email", txtEmail.Text);
                            command.Parameters.AddWithValue("@Phone_Number", txtPhone.Text);
                            command.Parameters.AddWithValue("Book_Name", dataGridView1.Rows[i].Cells["Book_Name"].Value.ToString());
                            command.Parameters.AddWithValue("Author", dataGridView1.Rows[i].Cells["Author"].Value.ToString());
                            command.Parameters.AddWithValue("Publisher", dataGridView1.Rows[i].Cells["Publisher"].Value.ToString());
                            command.Parameters.AddWithValue("Page_Number", dataGridView1.Rows[i].Cells["Page_Number"].Value.ToString());
                            command.Parameters.AddWithValue("Book_Number", int.Parse(dataGridView1.Rows[i].Cells["Book_Number"].Value.ToString()));
                            command.Parameters.AddWithValue("Barcode_No", dataGridView1.Rows[i].Cells["Barcode_No"].Value.ToString());
                            command.Parameters.AddWithValue("Shelf_No", dataGridView1.Rows[i].Cells["Shelf_No"].Value.ToString());
                            command.Parameters.AddWithValue("Delivery_Date", Convert.ToDateTime(dataGridView1.Rows[i].Cells["Delivery_Date"].Value.ToString()));
                            command.Parameters.AddWithValue("Return_Date", Convert.ToDateTime(dataGridView1.Rows[i].Cells["Return_Date"].Value.ToString()));
                            command.ExecuteNonQuery();
                            SqlCommand command3 = new SqlCommand("update Book_Table set Delivered_Book = Delivered_Book + 1, Book_Number=Book_Number-'" + int.Parse(dataGridView1.Rows[i].Cells["Book_Number"].Value.ToString())+"'where Book_Name='"+dataGridView1.Rows[i].Cells["Book_Name"].Value.ToString()+"' ", connection);
                            command3.ExecuteNonQuery();
                            connection.Close();
                        }
                        connection.Open();
                        SqlCommand command4 = new SqlCommand("delete from Basket", connection);
                        command4.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("The book is on loan.");
                        daset.Tables["Basket"].Clear();
                        booklist();
                        txtIdentityNo.Text = "";
                        lblRemainingRight.Text = "";
                        booknumber();
                        lblRegisteredBookNumber.Text = "";
                        
                    }
                    else
                    {
                        MessageBox.Show("You must first enter the member information.", "Warning");
                    }
                }
                else
                {
                    MessageBox.Show("The number of books borrowed cannot exceed 3.", "Warning");
                }
            }
            else
            {
                MessageBox.Show("Books must be added to the basket first.", "Warning");
            }

            
        }

        // butona tıklandığında kitabın listeden çıkarılması sağlanır
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Delete registration?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from basket where Book_Name='" + dataGridView1.CurrentRow.Cells["Book_Name"].Value.ToString() + "'", connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Deletion has been done.");
                daset.Tables["Basket"].Clear();
                booklist();
                lblRemainingRight.Text = "";
                booknumber();
            }
        }
    }
}
