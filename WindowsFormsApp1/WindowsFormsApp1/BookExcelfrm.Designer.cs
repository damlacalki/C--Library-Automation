namespace WindowsFormsApp1
{
    partial class BookExcelfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbSheet = new System.Windows.Forms.ComboBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.book_Table = new WindowsFormsApp1.Book_Table();
            this.bookTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.book_TableTableAdapter = new WindowsFormsApp1.Book_TableTableAdapters.Book_TableTableAdapter();
            this.bookTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.explanationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registirationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveredBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTableBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.pageNumberDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.explanationDataGridViewTextBoxColumn,
            this.bookNumberDataGridViewTextBoxColumn,
            this.registirationDateDataGridViewTextBoxColumn,
            this.shelfNoDataGridViewTextBoxColumn,
            this.barcodeNoDataGridViewTextBoxColumn,
            this.deliveredBookDataGridViewTextBoxColumn,
            this.totalBookDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookTableBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(30, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(748, 306);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbSheet
            // 
            this.cbSheet.FormattingEnabled = true;
            this.cbSheet.Location = new System.Drawing.Point(112, 397);
            this.cbSheet.Name = "cbSheet";
            this.cbSheet.Size = new System.Drawing.Size(94, 21);
            this.cbSheet.TabIndex = 1;
            this.cbSheet.SelectedIndexChanged += new System.EventHandler(this.cbSheet_SelectedIndexChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBrowse.Location = new System.Drawing.Point(703, 352);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(112, 354);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(560, 20);
            this.txtFileName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "File Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sheet:";
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnImport.Location = new System.Drawing.Point(229, 395);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "&Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // book_Table
            // 
            this.book_Table.DataSetName = "Book_Table";
            this.book_Table.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTableBindingSource
            // 
            this.bookTableBindingSource.DataMember = "Book_Table";
            this.bookTableBindingSource.DataSource = this.book_Table;
            // 
            // book_TableTableAdapter
            // 
            this.book_TableTableAdapter.ClearBeforeFill = true;
            // 
            // bookTableBindingSource1
            // 
            this.bookTableBindingSource1.DataSource = this.book_Table;
            this.bookTableBindingSource1.Position = 0;
            // 
            // bookTableBindingSource2
            // 
            this.bookTableBindingSource2.DataMember = "Book_Table";
            this.bookTableBindingSource2.DataSource = this.bookTableBindingSource1;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            // 
            // pageNumberDataGridViewTextBoxColumn
            // 
            this.pageNumberDataGridViewTextBoxColumn.DataPropertyName = "Page_Number";
            this.pageNumberDataGridViewTextBoxColumn.HeaderText = "Page_Number";
            this.pageNumberDataGridViewTextBoxColumn.Name = "pageNumberDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // explanationDataGridViewTextBoxColumn
            // 
            this.explanationDataGridViewTextBoxColumn.DataPropertyName = "Explanation";
            this.explanationDataGridViewTextBoxColumn.HeaderText = "Explanation";
            this.explanationDataGridViewTextBoxColumn.Name = "explanationDataGridViewTextBoxColumn";
            // 
            // bookNumberDataGridViewTextBoxColumn
            // 
            this.bookNumberDataGridViewTextBoxColumn.DataPropertyName = "Book_Number";
            this.bookNumberDataGridViewTextBoxColumn.HeaderText = "Book_Number";
            this.bookNumberDataGridViewTextBoxColumn.Name = "bookNumberDataGridViewTextBoxColumn";
            // 
            // registirationDateDataGridViewTextBoxColumn
            // 
            this.registirationDateDataGridViewTextBoxColumn.DataPropertyName = "Registiration_Date";
            this.registirationDateDataGridViewTextBoxColumn.HeaderText = "Registiration_Date";
            this.registirationDateDataGridViewTextBoxColumn.Name = "registirationDateDataGridViewTextBoxColumn";
            // 
            // shelfNoDataGridViewTextBoxColumn
            // 
            this.shelfNoDataGridViewTextBoxColumn.DataPropertyName = "Shelf_No";
            this.shelfNoDataGridViewTextBoxColumn.HeaderText = "Shelf_No";
            this.shelfNoDataGridViewTextBoxColumn.Name = "shelfNoDataGridViewTextBoxColumn";
            // 
            // barcodeNoDataGridViewTextBoxColumn
            // 
            this.barcodeNoDataGridViewTextBoxColumn.DataPropertyName = "Barcode_No";
            this.barcodeNoDataGridViewTextBoxColumn.HeaderText = "Barcode_No";
            this.barcodeNoDataGridViewTextBoxColumn.Name = "barcodeNoDataGridViewTextBoxColumn";
            // 
            // deliveredBookDataGridViewTextBoxColumn
            // 
            this.deliveredBookDataGridViewTextBoxColumn.DataPropertyName = "Delivered_Book";
            this.deliveredBookDataGridViewTextBoxColumn.HeaderText = "Delivered_Book";
            this.deliveredBookDataGridViewTextBoxColumn.Name = "deliveredBookDataGridViewTextBoxColumn";
            // 
            // totalBookDataGridViewTextBoxColumn
            // 
            this.totalBookDataGridViewTextBoxColumn.DataPropertyName = "Total_Book";
            this.totalBookDataGridViewTextBoxColumn.HeaderText = "Total_Book";
            this.totalBookDataGridViewTextBoxColumn.Name = "totalBookDataGridViewTextBoxColumn";
            // 
            // BookExcelfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.cbSheet);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BookExcelfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read Excel *.xls or *.xlsx";
            this.Load += new System.EventHandler(this.BookExcelfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTableBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbSheet;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImport;
        private Book_Table book_Table;
        private System.Windows.Forms.BindingSource bookTableBindingSource;
        private Book_TableTableAdapters.Book_TableTableAdapter book_TableTableAdapter;
        private System.Windows.Forms.BindingSource bookTableBindingSource2;
        private System.Windows.Forms.BindingSource bookTableBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn explanationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registirationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveredBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBookDataGridViewTextBoxColumn;
    }
}