using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_Gettingstart
{
    public partial class hienthi : Form
    {
        string username;

        account accounts;
        // Tạo 1 tham số username để có thể lấy dữ thiệu từ form Login thông qua
        // việc tạo contructor có tham số là string username
        public hienthi(account account) // Constructor
        {
            InitializeComponent();
            this.accounts = account;
            tb_diachi.Text = account.address;
            tb_ten.Text = account.name;
            tb_so.Text = account.phone;
            if (account.gender) cb_nam.Checked = true;
            else cb_nu.Checked = true;
            tbt_anh.Image = Image.FromFile(account.ImgPath);
            tbt_namsinh.Value = account.DOB;
        }



        public hienthi()
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void hienthi_Load(object sender, EventArgs e)
        {

        }

        private void tbt_anh_Click(object sender, EventArgs e)
        {
            tbt_anh.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}