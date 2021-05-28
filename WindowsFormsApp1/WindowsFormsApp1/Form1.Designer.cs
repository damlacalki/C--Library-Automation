namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gpMember = new System.Windows.Forms.GroupBox();
            this.btnMemberList = new System.Windows.Forms.Button();
            this.btnMemberReg = new System.Windows.Forms.Button();
            this.gpBook = new System.Windows.Forms.GroupBox();
            this.btnPopularBooks = new System.Windows.Forms.Button();
            this.btnListBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.gpLendBook = new System.Windows.Forms.GroupBox();
            this.btnEscBookRet = new System.Windows.Forms.Button();
            this.btnEscBookList = new System.Windows.Forms.Button();
            this.btnLendBooks = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbNameSurname = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUserApprove = new System.Windows.Forms.Button();
            this.btnBooksOnLoan = new System.Windows.Forms.Button();
            this.gpMember.SuspendLayout();
            this.gpBook.SuspendLayout();
            this.gpLendBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpMember
            // 
            this.gpMember.BackColor = System.Drawing.Color.SaddleBrown;
            this.gpMember.Controls.Add(this.btnMemberList);
            this.gpMember.Controls.Add(this.btnUserApprove);
            this.gpMember.Controls.Add(this.btnMemberReg);
            this.gpMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpMember.Location = new System.Drawing.Point(187, 58);
            this.gpMember.Name = "gpMember";
            this.gpMember.Size = new System.Drawing.Size(205, 147);
            this.gpMember.TabIndex = 0;
            this.gpMember.TabStop = false;
            this.gpMember.Text = "Member Transaction";
            // 
            // btnMemberList
            // 
            this.btnMemberList.Location = new System.Drawing.Point(6, 67);
            this.btnMemberList.Name = "btnMemberList";
            this.btnMemberList.Size = new System.Drawing.Size(188, 33);
            this.btnMemberList.TabIndex = 1;
            this.btnMemberList.Text = "Member Listing";
            this.btnMemberList.UseVisualStyleBackColor = true;
            this.btnMemberList.Click += new System.EventHandler(this.btnMemberList_Click);
            // 
            // btnMemberReg
            // 
            this.btnMemberReg.Location = new System.Drawing.Point(6, 28);
            this.btnMemberReg.Name = "btnMemberReg";
            this.btnMemberReg.Size = new System.Drawing.Size(188, 33);
            this.btnMemberReg.TabIndex = 0;
            this.btnMemberReg.Text = "Member Registration";
            this.btnMemberReg.UseVisualStyleBackColor = true;
            this.btnMemberReg.Click += new System.EventHandler(this.btnMemberReg_Click);
            // 
            // gpBook
            // 
            this.gpBook.BackColor = System.Drawing.Color.SaddleBrown;
            this.gpBook.Controls.Add(this.btnPopularBooks);
            this.gpBook.Controls.Add(this.btnListBook);
            this.gpBook.Controls.Add(this.btnAddBook);
            this.gpBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpBook.Location = new System.Drawing.Point(187, 225);
            this.gpBook.Name = "gpBook";
            this.gpBook.Size = new System.Drawing.Size(205, 150);
            this.gpBook.TabIndex = 1;
            this.gpBook.TabStop = false;
            this.gpBook.Text = "Book Transactions";
            // 
            // btnPopularBooks
            // 
            this.btnPopularBooks.Location = new System.Drawing.Point(6, 104);
            this.btnPopularBooks.Name = "btnPopularBooks";
            this.btnPopularBooks.Size = new System.Drawing.Size(188, 34);
            this.btnPopularBooks.TabIndex = 2;
            this.btnPopularBooks.Text = "Popular Books";
            this.btnPopularBooks.UseVisualStyleBackColor = true;
            this.btnPopularBooks.Click += new System.EventHandler(this.btnPopularBooks_Click);
            // 
            // btnListBook
            // 
            this.btnListBook.Location = new System.Drawing.Point(6, 64);
            this.btnListBook.Name = "btnListBook";
            this.btnListBook.Size = new System.Drawing.Size(188, 34);
            this.btnListBook.TabIndex = 1;
            this.btnListBook.Text = "Listing Books";
            this.btnListBook.UseVisualStyleBackColor = true;
            this.btnListBook.Click += new System.EventHandler(this.btnListBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(6, 26);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(188, 32);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Adding a Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // gpLendBook
            // 
            this.gpLendBook.BackColor = System.Drawing.Color.SaddleBrown;
            this.gpLendBook.Controls.Add(this.btnBooksOnLoan);
            this.gpLendBook.Controls.Add(this.btnEscBookRet);
            this.gpLendBook.Controls.Add(this.btnEscBookList);
            this.gpLendBook.Controls.Add(this.btnLendBooks);
            this.gpLendBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpLendBook.Location = new System.Drawing.Point(187, 395);
            this.gpLendBook.Name = "gpLendBook";
            this.gpLendBook.Size = new System.Drawing.Size(205, 187);
            this.gpLendBook.TabIndex = 2;
            this.gpLendBook.TabStop = false;
            this.gpLendBook.Text = "Lend Book Transactions";
            // 
            // btnEscBookRet
            // 
            this.btnEscBookRet.Location = new System.Drawing.Point(6, 109);
            this.btnEscBookRet.Name = "btnEscBookRet";
            this.btnEscBookRet.Size = new System.Drawing.Size(188, 34);
            this.btnEscBookRet.TabIndex = 2;
            this.btnEscBookRet.Text = "Return of Lended Books";
            this.btnEscBookRet.UseVisualStyleBackColor = true;
            this.btnEscBookRet.Click += new System.EventHandler(this.btnEscBookRet_Click);
            // 
            // btnEscBookList
            // 
            this.btnEscBookList.Location = new System.Drawing.Point(6, 69);
            this.btnEscBookList.Name = "btnEscBookList";
            this.btnEscBookList.Size = new System.Drawing.Size(188, 34);
            this.btnEscBookList.TabIndex = 1;
            this.btnEscBookList.Text = "List of Lended Books";
            this.btnEscBookList.UseVisualStyleBackColor = true;
            this.btnEscBookList.Click += new System.EventHandler(this.btnEscBookList_Click);
            // 
            // btnLendBooks
            // 
            this.btnLendBooks.Location = new System.Drawing.Point(6, 31);
            this.btnLendBooks.Name = "btnLendBooks";
            this.btnLendBooks.Size = new System.Drawing.Size(188, 32);
            this.btnLendBooks.TabIndex = 0;
            this.btnLendBooks.Text = "Lend Books";
            this.btnLendBooks.UseVisualStyleBackColor = true;
            this.btnLendBooks.Click += new System.EventHandler(this.btnLendBooks_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.White;
            this.btnProfile.CausesValidation = false;
            this.btnProfile.ImageIndex = 0;
            this.btnProfile.ImageList = this.ımageList1;
            this.btnProfile.Location = new System.Drawing.Point(511, 22);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(55, 44);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "profile.jpg");
            this.ımageList1.Images.SetKeyName(1, "logout-icon.png");
            // 
            // lbNameSurname
            // 
            this.lbNameSurname.AutoSize = true;
            this.lbNameSurname.BackColor = System.Drawing.Color.White;
            this.lbNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbNameSurname.Location = new System.Drawing.Point(501, 69);
            this.lbNameSurname.Name = "lbNameSurname";
            this.lbNameSurname.Size = new System.Drawing.Size(75, 13);
            this.lbNameSurname.TabIndex = 4;
            this.lbNameSurname.Text = "İsim Soyisim";
            this.lbNameSurname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.ImageIndex = 1;
            this.btnLogout.ImageList = this.ımageList1;
            this.btnLogout.Location = new System.Drawing.Point(479, 553);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(97, 53);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUserApprove
            // 
            this.btnUserApprove.Location = new System.Drawing.Point(6, 106);
            this.btnUserApprove.Name = "btnUserApprove";
            this.btnUserApprove.Size = new System.Drawing.Size(188, 32);
            this.btnUserApprove.TabIndex = 23;
            this.btnUserApprove.Text = "User Approve";
            this.btnUserApprove.UseVisualStyleBackColor = true;
            this.btnUserApprove.Click += new System.EventHandler(this.btnUserApprove_Click);
            // 
            // btnBooksOnLoan
            // 
            this.btnBooksOnLoan.Location = new System.Drawing.Point(6, 149);
            this.btnBooksOnLoan.Name = "btnBooksOnLoan";
            this.btnBooksOnLoan.Size = new System.Drawing.Size(188, 32);
            this.btnBooksOnLoan.TabIndex = 24;
            this.btnBooksOnLoan.Text = "Books On Loan";
            this.btnBooksOnLoan.UseVisualStyleBackColor = true;
            this.btnBooksOnLoan.Click += new System.EventHandler(this.btnBooksOnLoan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Library;
            this.ClientSize = new System.Drawing.Size(588, 618);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lbNameSurname);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.gpLendBook);
            this.Controls.Add(this.gpBook);
            this.Controls.Add(this.gpMember);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpMember.ResumeLayout(false);
            this.gpBook.ResumeLayout(false);
            this.gpLendBook.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpMember;
        private System.Windows.Forms.Button btnMemberList;
        private System.Windows.Forms.Button btnMemberReg;
        private System.Windows.Forms.GroupBox gpBook;
        private System.Windows.Forms.Button btnListBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.GroupBox gpLendBook;
        private System.Windows.Forms.Button btnEscBookRet;
        private System.Windows.Forms.Button btnEscBookList;
        private System.Windows.Forms.Button btnLendBooks;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label lbNameSurname;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPopularBooks;
        private System.Windows.Forms.Button btnUserApprove;
        private System.Windows.Forms.Button btnBooksOnLoan;
    }
}

