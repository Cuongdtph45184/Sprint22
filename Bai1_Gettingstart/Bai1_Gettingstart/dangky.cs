using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.IO;
using System.Drawing.Imaging;

namespace Bai1_Gettingstart
{
    public partial class dangky : Form
    {
        string path = ""; //Biến này để lưu 

        public dangky()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Signup_Dangky_Click(object sender, EventArgs e)
        {
            
            bool check = true; // tạo 1 biến check để validate dữ liệu
            foreach (Control item in this.Controls)
            {
                if (item is TextBox && item.Text == "" ) // nếu controls là textbox rỗng
                {
                    
                    MessageBox.Show("Hãy điền đủ thông tin");
                    check = false;
                    break;
                }
                else if (path == "")
                {
                    check = false;
                    item.BackColor = Color.LightPink;
                    MessageBox.Show("Hãy up ảnh");
                    break;
                }
            }
            DialogResult result = MessageBox.Show("Do you want to save ?", "", MessageBoxButtons.YesNoCancel);
            if (check && result == DialogResult.Yes)
            {
                string name = Name_ten.Text;
                string address = DiaChi_address.Text;
                string username = Username_tendangnhap.Text;
                string password = Password_MatKhau.Text;
                string phone = SDT_so.Text;
                bool gender = Gender_Nam.Checked;//true => Nam
                DateTime DOB = Dob_sinh.Value;
                string ImgPath = Picture_Anh.ImageLocation;

                account ac = new account(name, address, username, password, phone, gender, DOB, ImgPath);
                string accountFile = ac.CreateAccount();
                File.AppendAllText("account.txt", accountFile);
            
                foreach (Control c in this.Controls) 
                { if (c is TextBox) 
                { c.Text = ""; }
                }
            }
        }

        private void Picture_Anh_Click(object sender, EventArgs e)
        {
            //tao  1 openfile dialog để lấy file từ máy
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Please select an image file to encrypt.";  //set title - tiêu đề
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;..."; //tạo lọc file
            openFileDialog.ShowDialog(); //hiển thị hộp thoai - dialog
            Picture_Anh.SizeMode = PictureBoxSizeMode.StretchImage; //set size mode để fit với khung hình
            Picture_Anh.ImageLocation = openFileDialog.FileName; // gán hình ảnh pictureboxx bằng file lấy được
            path = openFileDialog.FileName; //gán đường dẫn cho path
        }
    }
}
