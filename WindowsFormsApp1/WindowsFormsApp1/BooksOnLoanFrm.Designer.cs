namespace WindowsFormsApp1
{
    partial class BooksOnLoanFrm
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
            this.dgvBooksOnLoan = new System.Windows.Forms.DataGridView();
            this.spcMainContainer = new System.Windows.Forms.SplitContainer();
            this.spcTopContainer = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.spcBottomContainer = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBooksReturned = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksOnLoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcMainContainer)).BeginInit();
            this.spcMainContainer.Panel1.SuspendLayout();
            this.spcMainContainer.Panel2.SuspendLayout();
            this.spcMainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcTopContainer)).BeginInit();
            this.spcTopContainer.Panel1.SuspendLayout();
            this.spcTopContainer.Panel2.SuspendLayout();
            this.spcTopContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcBottomContainer)).BeginInit();
            this.spcBottomContainer.Panel1.SuspendLayout();
            this.spcBottomContainer.Panel2.SuspendLayout();
            this.spcBottomContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksReturned)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooksOnLoan
            // 
            this.dgvBooksOnLoan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBooksOnLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooksOnLoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooksOnLoan.Location = new System.Drawing.Point(0, 0);
            this.dgvBooksOnLoan.Name = "dgvBooksOnLoan";
            this.dgvBooksOnLoan.Size = new System.Drawing.Size(800, 171);
            this.dgvBooksOnLoan.TabIndex = 0;
            // 
            // spcMainContainer
            // 
            this.spcMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMainContainer.Location = new System.Drawing.Point(0, 0);
            this.spcMainContainer.Name = "spcMainContainer";
            this.spcMainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcMainContainer.Panel1
            // 
            this.spcMainContainer.Panel1.Controls.Add(this.spcTopContainer);
            // 
            // spcMainContainer.Panel2
            // 
            this.spcMainContainer.Panel2.Controls.Add(this.spcBottomContainer);
            this.spcMainContainer.Size = new System.Drawing.Size(800, 478);
            this.spcMainContainer.SplitterDistance = 219;
            this.spcMainContainer.TabIndex = 1;
            // 
            // spcTopContainer
            // 
            this.spcTopContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcTopContainer.IsSplitterFixed = true;
            this.spcTopContainer.Location = new System.Drawing.Point(0, 0);
            this.spcTopContainer.Name = "spcTopContainer";
            this.spcTopContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcTopContainer.Panel1
            // 
            this.spcTopContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.spcTopContainer.Panel1.Controls.Add(this.label1);
            // 
            // spcTopContainer.Panel2
            // 
            this.spcTopContainer.Panel2.Controls.Add(this.dgvBooksOnLoan);
            this.spcTopContainer.Size = new System.Drawing.Size(800, 219);
            this.spcTopContainer.SplitterDistance = 44;
            this.spcTopContainer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loaned On User";
            // 
            // spcBottomContainer
            // 
            this.spcBottomContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcBottomContainer.IsSplitterFixed = true;
            this.spcBottomContainer.Location = new System.Drawing.Point(0, 0);
            this.spcBottomContainer.Name = "spcBottomContainer";
            this.spcBottomContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcBottomContainer.Panel1
            // 
            this.spcBottomContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.spcBottomContainer.Panel1.Controls.Add(this.label2);
            // 
            // spcBottomContainer.Panel2
            // 
            this.spcBottomContainer.Panel2.Controls.Add(this.dgvBooksReturned);
            this.spcBottomContainer.Size = new System.Drawing.Size(800, 255);
            this.spcBottomContainer.SplitterDistance = 53;
            this.spcBottomContainer.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Returned To Library";
            // 
            // dgvBooksReturned
            // 
            this.dgvBooksReturned.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBooksReturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooksReturned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooksReturned.Location = new System.Drawing.Point(0, 0);
            this.dgvBooksReturned.Name = "dgvBooksReturned";
            this.dgvBooksReturned.Size = new System.Drawing.Size(800, 198);
            this.dgvBooksReturned.TabIndex = 1;
            // 
            // BooksOnLoanFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.spcMainContainer);
            this.Name = "BooksOnLoanFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books on Loan Page";
            this.Load += new System.EventHandler(this.BooksOnLoanFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksOnLoan)).EndInit();
            this.spcMainContainer.Panel1.ResumeLayout(false);
            this.spcMainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMainContainer)).EndInit();
            this.spcMainContainer.ResumeLayout(false);
            this.spcTopContainer.Panel1.ResumeLayout(false);
            this.spcTopContainer.Panel1.PerformLayout();
            this.spcTopContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcTopContainer)).EndInit();
            this.spcTopContainer.ResumeLayout(false);
            this.spcBottomContainer.Panel1.ResumeLayout(false);
            this.spcBottomContainer.Panel1.PerformLayout();
            this.spcBottomContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcBottomContainer)).EndInit();
            this.spcBottomContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksReturned)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooksOnLoan;
        private System.Windows.Forms.SplitContainer spcMainContainer;
        private System.Windows.Forms.SplitContainer spcTopContainer;
        private System.Windows.Forms.SplitContainer spcBottomContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBooksReturned;
    }
}