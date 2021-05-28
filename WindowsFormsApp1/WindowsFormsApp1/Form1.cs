using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    // giriş yapıldıktan sonra bu ekrana yönlendirme yapılır
    public partial class Form1 : Form
    {
        public static User user;
        public Form1(User loginUser)
        {
            //user = loginUser;
            GetUser(loginUser);
            InitializeComponent();
        }

        public void GetUser(User loginUser)
        {
            user = loginUser;
        }

        private void btnMemberReg_Click(object sender, EventArgs e)
        {
            MemberRegisterfrm memberreg = new MemberRegisterfrm();
            memberreg.ShowDialog();
        }

        private void btnMemberList_Click(object sender, EventArgs e)
        {
            MemberListingfrm memberlist = new MemberListingfrm();
            memberlist.ShowDialog();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookfrm addbook = new AddBookfrm();
            addbook.ShowDialog();
        }

        private void btnListBook_Click(object sender, EventArgs e)
        {
            BookListingfrm booklist = new BookListingfrm(user.adminUser);
            booklist.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbNameSurname.Text = user.nameSurname;

            // giriş yapan kullanıcı normal kullanıcı ise bazı ekranlar için yetkisi olmayacağı için o butonlar kaldırılmaktadır.
            if (user.adminUser == 0)
            {
                btnUserApprove.Hide();
                gpMember.Hide();
                btnAddBook.Hide();
                btnEscBookList.Hide();
                btnEscBookRet.Hide();
                gpBook.Location = new Point(187, 58);
                gpBook.Height = 120;
                btnListBook.Location = new Point(6, 26);
                btnPopularBooks.Location = new Point(6, 64);
                gpLendBook.Location = new Point(187, 218);
                gpLendBook.Height = 120;
                btnBooksOnLoan.Location = new Point(6,68);
            }
            else 
            {
                btnBooksOnLoan.Hide();
                gpLendBook.Height = 150;
            }

        }

        private void btnLendBooks_Click(object sender, EventArgs e)
        {
            LendBookfrm lendbook = new LendBookfrm(user.adminUser, user.identityNo);
            lendbook.ShowDialog();
        }

        private void btnEscBookList_Click(object sender, EventArgs e)
        {
            LendedBooksListfrm lendbooklist = new LendedBooksListfrm();
            lendbooklist.ShowDialog();
        }

        private void btnEscBookRet_Click(object sender, EventArgs e)
        {
            LendedBooksReturnfrm lendedreturn = new LendedBooksReturnfrm();
            lendedreturn.ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(user);
            profile.ShowDialog();
        }

        // butona tıklanınca sistemden çıkış yapılır ve login sayfasına yönlendirme yapılır
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            UserLoginfrm Logout = new UserLoginfrm();
            Logout.ShowDialog();
            user = null;
        }

        private void btnPopularBooks_Click(object sender, EventArgs e)
        {
            PopularBooks popular = new PopularBooks();
            popular.ShowDialog();
        }

        private void btnUserApprove_Click(object sender, EventArgs e)
        {
            UserApproveFrm approve = new UserApproveFrm();
            approve.ShowDialog();
        }

        private void btnBooksOnLoan_Click(object sender, EventArgs e)
        {
            BooksOnLoanFrm loanBooks = new BooksOnLoanFrm(user.identityNo);
            loanBooks.ShowDialog();
        }
    }
}
