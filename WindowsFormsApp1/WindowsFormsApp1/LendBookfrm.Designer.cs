namespace WindowsFormsApp1
{
    partial class LendBookfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LendBookfrm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbMemberInformation = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.txtIdentityNo = new System.Windows.Forms.TextBox();
            this.gbBookInformation = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtShelf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtReturnDate = new System.Windows.Forms.DateTimePicker();
            this.txtBookNumber = new System.Windows.Forms.TextBox();
            this.dtDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.txtPageNo = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDeliver = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblRegisteredBook = new System.Windows.Forms.Label();
            this.lblRegisteredBookNumber = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblRemainingRight = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbMemberInformation.SuspendLayout();
            this.gbBookInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(263, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(609, 359);
            this.dataGridView1.TabIndex = 0;
            // 
            // gbMemberInformation
            // 
            this.gbMemberInformation.Controls.Add(this.label4);
            this.gbMemberInformation.Controls.Add(this.label3);
            this.gbMemberInformation.Controls.Add(this.label2);
            this.gbMemberInformation.Controls.Add(this.label1);
            this.gbMemberInformation.Controls.Add(this.txtPhone);
            this.gbMemberInformation.Controls.Add(this.txtEmail);
            this.gbMemberInformation.Controls.Add(this.txtNameSurname);
            this.gbMemberInformation.Controls.Add(this.txtIdentityNo);
            this.gbMemberInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbMemberInformation.Location = new System.Drawing.Point(12, 31);
            this.gbMemberInformation.Name = "gbMemberInformation";
            this.gbMemberInformation.Size = new System.Drawing.Size(225, 134);
            this.gbMemberInformation.TabIndex = 1;
            this.gbMemberInformation.TabStop = false;
            this.gbMemberInformation.Text = "Member Informations";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Identity No";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(119, 100);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(119, 74);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Location = new System.Drawing.Point(119, 45);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(100, 20);
            this.txtNameSurname.TabIndex = 1;
            // 
            // txtIdentityNo
            // 
            this.txtIdentityNo.Location = new System.Drawing.Point(119, 19);
            this.txtIdentityNo.Name = "txtIdentityNo";
            this.txtIdentityNo.Size = new System.Drawing.Size(100, 20);
            this.txtIdentityNo.TabIndex = 0;
            this.txtIdentityNo.TextChanged += new System.EventHandler(this.txtIdentityNo_TextChanged);
            // 
            // gbBookInformation
            // 
            this.gbBookInformation.Controls.Add(this.label10);
            this.gbBookInformation.Controls.Add(this.txtShelf);
            this.gbBookInformation.Controls.Add(this.label5);
            this.gbBookInformation.Controls.Add(this.txtBarcode);
            this.gbBookInformation.Controls.Add(this.label14);
            this.gbBookInformation.Controls.Add(this.label13);
            this.gbBookInformation.Controls.Add(this.label12);
            this.gbBookInformation.Controls.Add(this.label9);
            this.gbBookInformation.Controls.Add(this.label8);
            this.gbBookInformation.Controls.Add(this.label7);
            this.gbBookInformation.Controls.Add(this.label6);
            this.gbBookInformation.Controls.Add(this.dtReturnDate);
            this.gbBookInformation.Controls.Add(this.txtBookNumber);
            this.gbBookInformation.Controls.Add(this.dtDeliveryDate);
            this.gbBookInformation.Controls.Add(this.txtPageNo);
            this.gbBookInformation.Controls.Add(this.txtPublisher);
            this.gbBookInformation.Controls.Add(this.txtAuthor);
            this.gbBookInformation.Controls.Add(this.txtBookName);
            this.gbBookInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbBookInformation.Location = new System.Drawing.Point(12, 182);
            this.gbBookInformation.Name = "gbBookInformation";
            this.gbBookInformation.Size = new System.Drawing.Size(225, 265);
            this.gbBookInformation.TabIndex = 2;
            this.gbBookInformation.TabStop = false;
            this.gbBookInformation.Text = "Book Informations";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Shelf No";
            // 
            // txtShelf
            // 
            this.txtShelf.Location = new System.Drawing.Point(119, 175);
            this.txtShelf.Name = "txtShelf";
            this.txtShelf.Size = new System.Drawing.Size(100, 20);
            this.txtShelf.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Barcode No";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(119, 149);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(100, 20);
            this.txtBarcode.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 234);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Return Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Delivery Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Book Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Page No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Publisher";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Author";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Book Name";
            // 
            // dtReturnDate
            // 
            this.dtReturnDate.Enabled = false;
            this.dtReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReturnDate.Location = new System.Drawing.Point(119, 228);
            this.dtReturnDate.Name = "dtReturnDate";
            this.dtReturnDate.Size = new System.Drawing.Size(100, 20);
            this.dtReturnDate.TabIndex = 3;
            // 
            // txtBookNumber
            // 
            this.txtBookNumber.Location = new System.Drawing.Point(119, 123);
            this.txtBookNumber.Name = "txtBookNumber";
            this.txtBookNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBookNumber.TabIndex = 6;
            this.txtBookNumber.Text = "1";
            this.txtBookNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtDeliveryDate
            // 
            this.dtDeliveryDate.Enabled = false;
            this.dtDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDeliveryDate.Location = new System.Drawing.Point(119, 201);
            this.dtDeliveryDate.Name = "dtDeliveryDate";
            this.dtDeliveryDate.Size = new System.Drawing.Size(100, 20);
            this.dtDeliveryDate.TabIndex = 4;
            // 
            // txtPageNo
            // 
            this.txtPageNo.Location = new System.Drawing.Point(119, 97);
            this.txtPageNo.Name = "txtPageNo";
            this.txtPageNo.Size = new System.Drawing.Size(100, 20);
            this.txtPageNo.TabIndex = 3;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(119, 71);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(100, 20);
            this.txtPublisher.TabIndex = 2;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(119, 45);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 1;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(119, 19);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(100, 20);
            this.txtBookName.TabIndex = 0;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageIndex = 1;
            this.btnAdd.ImageList = this.ımageList1;
            this.btnAdd.Location = new System.Drawing.Point(149, 454);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 43);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cancel.png");
            this.ımageList1.Images.SetKeyName(1, "add.png");
            this.ımageList1.Images.SetKeyName(2, "deliver.png");
            this.ımageList1.Images.SetKeyName(3, "delete.png");
            // 
            // btnDeliver
            // 
            this.btnDeliver.BackColor = System.Drawing.Color.White;
            this.btnDeliver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeliver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeliver.ImageIndex = 2;
            this.btnDeliver.ImageList = this.ımageList1;
            this.btnDeliver.Location = new System.Drawing.Point(690, 404);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(88, 43);
            this.btnDeliver.TabIndex = 4;
            this.btnDeliver.Text = "Deliver";
            this.btnDeliver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeliver.UseVisualStyleBackColor = false;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImageIndex = 0;
            this.btnCancel.ImageList = this.ımageList1;
            this.btnCancel.Location = new System.Drawing.Point(784, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 43);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblRegisteredBook
            // 
            this.lblRegisteredBook.AutoSize = true;
            this.lblRegisteredBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRegisteredBook.Location = new System.Drawing.Point(288, 410);
            this.lblRegisteredBook.Name = "lblRegisteredBook";
            this.lblRegisteredBook.Size = new System.Drawing.Size(101, 13);
            this.lblRegisteredBook.TabIndex = 6;
            this.lblRegisteredBook.Text = "Registered Book";
            // 
            // lblRegisteredBookNumber
            // 
            this.lblRegisteredBookNumber.AutoSize = true;
            this.lblRegisteredBookNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRegisteredBookNumber.Location = new System.Drawing.Point(407, 410);
            this.lblRegisteredBookNumber.Name = "lblRegisteredBookNumber";
            this.lblRegisteredBookNumber.Size = new System.Drawing.Size(0, 13);
            this.lblRegisteredBookNumber.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(480, 410);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Remaining Right";
            // 
            // lblRemainingRight
            // 
            this.lblRemainingRight.AutoSize = true;
            this.lblRemainingRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRemainingRight.Location = new System.Drawing.Point(594, 410);
            this.lblRemainingRight.Name = "lblRemainingRight";
            this.lblRemainingRight.Size = new System.Drawing.Size(0, 13);
            this.lblRemainingRight.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageIndex = 3;
            this.btnDelete.ImageList = this.ımageList1;
            this.btnDelete.Location = new System.Drawing.Point(881, 42);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 40);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // LendBookfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(981, 509);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblRemainingRight);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblRegisteredBookNumber);
            this.Controls.Add(this.lblRegisteredBook);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeliver);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbBookInformation);
            this.Controls.Add(this.gbMemberInformation);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LendBookfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Lending Page";
            this.Load += new System.EventHandler(this.LendBookfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbMemberInformation.ResumeLayout(false);
            this.gbMemberInformation.PerformLayout();
            this.gbBookInformation.ResumeLayout(false);
            this.gbBookInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbMemberInformation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.TextBox txtIdentityNo;
        private System.Windows.Forms.GroupBox gbBookInformation;
        private System.Windows.Forms.DateTimePicker dtReturnDate;
        private System.Windows.Forms.DateTimePicker dtDeliveryDate;
        private System.Windows.Forms.TextBox txtPageNo;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBookNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeliver;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblRegisteredBook;
        private System.Windows.Forms.Label lblRegisteredBookNumber;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblRemainingRight;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtShelf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBarcode;
    }
}