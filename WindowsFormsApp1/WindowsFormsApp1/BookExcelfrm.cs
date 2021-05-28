using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace WindowsFormsApp1
{
    // Excel'den kitap yükleme işleminin yapıldığı sayfa
    public partial class BookExcelfrm : Form
    {
        public BookExcelfrm()
        {
            InitializeComponent();
        }

        // yapılan seçim ile yüklenen excel'in datagridview'e aktarılmasını sağlar
        private void cbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cbSheet.SelectedItem.ToString()];
            //dataGridView1.DataSource = dt;
            if (dt != null)
            {
                List<BookExcel> bookExcels = new List<BookExcel>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BookExcel bookExcel = new BookExcel();
                    bookExcel.Book_Name = dt.Rows[i]["Book_Name"].ToString();
                    bookExcel.Author = dt.Rows[i]["Author"].ToString();
                    bookExcel.Publisher = dt.Rows[i]["Publisher"].ToString();
                    bookExcel.Page_Number = dt.Rows[i]["Page_Number"].ToString();
                    bookExcel.Type = Convert.ToInt32(dt.Rows[i]["Type"].ToString());
                    bookExcel.Explanation = dt.Rows[i]["Explanation"].ToString();
                    bookExcel.Book_Number = Convert.ToInt32(dt.Rows[i]["Book_Number"].ToString());
                    bookExcel.Registiration_Date = dt.Rows[i]["Registiration_Date"].ToString();
                    bookExcel.Shelf_No = dt.Rows[i]["Shelf_No"].ToString();
                    bookExcel.Barcode_No = dt.Rows[i]["Barcode_No"].ToString();
                    bookExcel.Delivered_Book = Convert.ToInt32(dt.Rows[i]["Delivered_Book"].ToString());
                    bookExcel.Total_Book = dt.Rows[i]["Total_Book"].ToString();
                    bookExcels.Add(bookExcel);
                }
                bookTableBindingSource2.DataSource = bookExcels;
            }
        }

        DataTableCollection tableCollection;

        // bilgisayardan excel yükleme işlemi yapılır
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog=new OpenFileDialog() { Filter="Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx"})
            { 
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = openFileDialog.FileName;
                    using(var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable=(_) => new ExcelDataTableConfiguration() { UseHeaderRow = true}
                            });
                            tableCollection = result.Tables;
                            cbSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cbSheet.Items.Add(table.TableName);//add sheet the comboBox
                        }
                    }
                }
            }
        }

        // datagridview'e getirilen bilgilerin Book_Table tablosuna kaydedilmesini sağlar
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-IC35A29\\SQLEXPRESS;Initial Catalog=LibraryOtomation;Integrated Security=True";
                DapperPlusManager.Entity<BookExcel>().Table("Book_Table");
                List<BookExcel> bookExcels = bookTableBindingSource2.DataSource as List<BookExcel>;

                foreach (var item in bookExcels)
                {
                    item.Registiration_Date = Convert.ToDateTime(item.Registiration_Date).ToShortDateString();
                }
                if(bookExcels != null)
                {
                    using(IDbConnection db=new SqlConnection(connectionString))
                    {
                        db.BulkInsert(bookExcels);
                    }
                }
                MessageBox.Show("Finish!!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BookExcelfrm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'book_Table._Book_Table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.book_TableTableAdapter.Fill(this.book_Table._Book_Table);

        }
    }
}
