namespace Bai1_Gettingstart
{
    partial class dangky
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
            label1 = new Label();
            label2 = new Label();
            Picture_Anh = new PictureBox();
            Name_ten = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            DiaChi_address = new TextBox();
            Username_tendangnhap = new TextBox();
            Password_MatKhau = new TextBox();
            SDT_so = new TextBox();
            label6 = new Label();
            Gender_Nam = new RadioButton();
            Gender_Nu = new RadioButton();
            Dob_sinh = new DateTimePicker();
            label7 = new Label();
            Up_picture = new Button();
            Signup_Dangky = new Button();
            ((System.ComponentModel.ISupportInitialize)Picture_Anh).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 21);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 55);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 0;
            label2.Text = "Địa chỉ";
            label2.Click += label2_Click;
            // 
            // Picture_Anh
            // 
            Picture_Anh.BackColor = SystemColors.AppWorkspace;
            Picture_Anh.Location = new Point(629, 18);
            Picture_Anh.Name = "Picture_Anh";
            Picture_Anh.Size = new Size(159, 222);
            Picture_Anh.TabIndex = 1;
            Picture_Anh.TabStop = false;
            Picture_Anh.Click += Picture_Anh_Click;
            // 
            // Name_ten
            // 
            Name_ten.Location = new Point(123, 18);
            Name_ten.Name = "Name_ten";
            Name_ten.Size = new Size(475, 23);
            Name_ten.TabIndex = 2;
            Name_ten.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 93);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 0;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 131);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 0;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 173);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 0;
            label5.Text = "SĐT";
            // 
            // DiaChi_address
            // 
            DiaChi_address.Location = new Point(123, 52);
            DiaChi_address.Name = "DiaChi_address";
            DiaChi_address.Size = new Size(475, 23);
            DiaChi_address.TabIndex = 2;
            DiaChi_address.TextChanged += textBox1_TextChanged;
            // 
            // Username_tendangnhap
            // 
            Username_tendangnhap.Location = new Point(123, 90);
            Username_tendangnhap.Name = "Username_tendangnhap";
            Username_tendangnhap.Size = new Size(475, 23);
            Username_tendangnhap.TabIndex = 2;
            Username_tendangnhap.TextChanged += textBox1_TextChanged;
            // 
            // Password_MatKhau
            // 
            Password_MatKhau.Location = new Point(123, 128);
            Password_MatKhau.Name = "Password_MatKhau";
            Password_MatKhau.Size = new Size(475, 23);
            Password_MatKhau.TabIndex = 2;
            Password_MatKhau.TextChanged += textBox1_TextChanged;
            // 
            // SDT_so
            // 
            SDT_so.Location = new Point(123, 170);
            SDT_so.Name = "SDT_so";
            SDT_so.Size = new Size(475, 23);
            SDT_so.TabIndex = 2;
            SDT_so.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 211);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 0;
            label6.Text = "Giới tính";
            label6.Click += label6_Click;
            // 
            // Gender_Nam
            // 
            Gender_Nam.AutoSize = true;
            Gender_Nam.Location = new Point(123, 211);
            Gender_Nam.Name = "Gender_Nam";
            Gender_Nam.Size = new Size(51, 19);
            Gender_Nam.TabIndex = 3;
            Gender_Nam.TabStop = true;
            Gender_Nam.Text = "Nam";
            Gender_Nam.UseVisualStyleBackColor = true;
            Gender_Nam.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Gender_Nu
            // 
            Gender_Nu.AutoSize = true;
            Gender_Nu.Location = new Point(217, 211);
            Gender_Nu.Name = "Gender_Nu";
            Gender_Nu.Size = new Size(41, 19);
            Gender_Nu.TabIndex = 3;
            Gender_Nu.TabStop = true;
            Gender_Nu.Text = "Nữ";
            Gender_Nu.UseVisualStyleBackColor = true;
            // 
            // Dob_sinh
            // 
            Dob_sinh.Location = new Point(123, 260);
            Dob_sinh.Name = "Dob_sinh";
            Dob_sinh.Size = new Size(200, 23);
            Dob_sinh.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(61, 260);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 0;
            label7.Text = "Ngày Sinh";
            label7.Click += label6_Click;
            // 
            // Up_picture
            // 
            Up_picture.Location = new Point(673, 246);
            Up_picture.Name = "Up_picture";
            Up_picture.Size = new Size(75, 23);
            Up_picture.TabIndex = 5;
            Up_picture.Text = "Up ảnh";
            Up_picture.UseVisualStyleBackColor = true;
            // 
            // Signup_Dangky
            // 
            Signup_Dangky.Location = new Point(629, 293);
            Signup_Dangky.Name = "Signup_Dangky";
            Signup_Dangky.Size = new Size(159, 40);
            Signup_Dangky.TabIndex = 6;
            Signup_Dangky.Text = "Đăng Ký";
            Signup_Dangky.UseVisualStyleBackColor = true;
            Signup_Dangky.Click += Signup_Dangky_Click;
            // 
            // dangky
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Signup_Dangky);
            Controls.Add(Up_picture);
            Controls.Add(Dob_sinh);
            Controls.Add(Gender_Nu);
            Controls.Add(Gender_Nam);
            Controls.Add(SDT_so);
            Controls.Add(Password_MatKhau);
            Controls.Add(Username_tendangnhap);
            Controls.Add(DiaChi_address);
            Controls.Add(Name_ten);
            Controls.Add(Picture_Anh);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "dangky";
            Text = "dangky";
            ((System.ComponentModel.ISupportInitialize)Picture_Anh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox Picture_Anh;
        private TextBox Name_ten;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox DiaChi_address;
        private TextBox Username_tendangnhap;
        private TextBox Password_MatKhau;
        private TextBox SDT_so;
        private Label label6;
        private RadioButton Gender_Nam;
        private RadioButton Gender_Nu;
        private DateTimePicker Dob_sinh;
        private Label label7;
        private Button Up_picture;
        private Button Signup_Dangky;
    }
}