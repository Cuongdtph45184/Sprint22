using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_Gettingstart
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void tbt_checkbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void tbt_Username_MouseHover(object sender, EventArgs e)
        {
            tbt_Username.BackColor = Color.LightBlue;
        }

        private void tbt_Username_TextChanged(object sender, EventArgs e)
        {
            if (tbt_Username.Text.Length <= 8)
            {
                tbt_Username.ForeColor = Color.Red;
            }
            else
            {
                tbt_Username.ForeColor = Color.Black;
            }
        }

        private void Login_MouseLeave(object sender, EventArgs e)
        {

        }

        private void tbt_Username_MouseLeave(object sender, EventArgs e)
        {
            tbt_Username.BackColor = Color.White;
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            dangky dk = new dangky();
            dk.ShowDialog();
        }
        private void tbt_button_Click(object sender, EventArgs e)
        {
            // điều kiện để đăng nhập
            // username > 8
            //pass chứa in hoa
            // check vào ô ng máy
            // hiển thị ra message thành công
            string username = tbt_Username.Text; string password = tbt_Password.Text;
            account account = Service.CheckLogin(username, password);
            if (username.Length > 8 && password.ToLower() != password && account != null && tbt_checkbox.Checked)
            {
                MessageBox.Show("Đăng nhập thành công");
                //khi dang nhap thanh cong khoi tao 1 doi tuong form hien thi
                //vs tham so account duoc lay tu thông tin đăng nhập được đối chiêus vc file
                hienthi login = new hienthi(account);
                login.ShowDialog();
            }
            else MessageBox.Show("Đăng nhập thất bại");

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (Checkpasss.Checked)
            {
                tbt_Password.PasswordChar = '\0';
            }
            else tbt_Password.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dangky dk = new dangky();
            dk.ShowDialog();
        }
    }
}
