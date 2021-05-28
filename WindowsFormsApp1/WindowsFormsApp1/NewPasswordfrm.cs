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
    // şifre güncellemesinin yapıldığı sayfa
    public partial class NewPasswordfrm : Form
    {
        public NewPasswordfrm()
        {
            InitializeComponent();
        }
        Userfrm u = new Userfrm();
        
        // butona tıklandığı zaman password ve password confirmation alanlarındaki değerler eşleşiyorsa kullanıcının şifresi değiştirilir, eşleşmiyorsa hata mesajı ekrana getirilir.
        private void btnNewPassword_Click(object sender, EventArgs e)
        {
            u.NewPassword(txtIdentity_No, txtEmail, txtPw, txtPw2, groupBox2);
        }

        // girilen şifrenin normal veya yıldızlı olarak gösterilmesini sağlar
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPw.UseSystemPasswordChar = true;
            }
            else
            {
                txtPw.UseSystemPasswordChar = false;
            }
        }


        // girilen şifrenin normal veya yıldızlı olarak gösterilmesini sağlar
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txtPw2.UseSystemPasswordChar = true;
            }
            else
            {
                txtPw2.UseSystemPasswordChar = false;
            }
        }

        private void NewPasswordfrm_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            txtPw.UseSystemPasswordChar = true;
            checkBox2.Checked = true;
            txtPw2.UseSystemPasswordChar = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
