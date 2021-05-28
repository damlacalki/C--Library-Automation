using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    // excel'den kitap yüklemesi yapılmak istendiğinde exceldeki sütunlar ile bu type'daki değerler eşleştirilerek tabloya bu isimlerdeki kolonlara veriler atılıyor.
    public class BookExcel
    {
        public string Book_Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Page_Number { get; set; }
        public int? Type { get; set; }
        public string Explanation { get; set; }
        public int? Book_Number { get; set; }
        public string Registiration_Date { get; set; }
        public string Shelf_No { get; set; }
        public string Barcode_No { get; set; }
        public int? Delivered_Book { get; set; }
        public string Total_Book { get; set; }
    }
}
