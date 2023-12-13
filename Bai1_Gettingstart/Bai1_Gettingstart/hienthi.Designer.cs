namespace Bai1_Gettingstart
{
    partial class hienthi
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
            tbt_namsinh = new DateTimePicker();
            cb_nu = new RadioButton();
            cb_nam = new RadioButton();
            tb_so = new TextBox();
            tb_diachi = new TextBox();
            tb_ten = new TextBox();
            tbt_anh = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)tbt_anh).BeginInit();
            SuspendLayout();
            // 
            // tbt_namsinh
            // 
            tbt_namsinh.Location = new Point(84, 282);
            tbt_namsinh.Name = "tbt_namsinh";
            tbt_namsinh.Size = new Size(200, 23);
            tbt_namsinh.TabIndex = 22;
            // 
            // cb_nu
            // 
            cb_nu.AutoSize = true;
            cb_nu.Location = new Point(176, 231);
            cb_nu.Name = "cb_nu";
            cb_nu.Size = new Size(41, 19);
            cb_nu.TabIndex = 21;
            cb_nu.TabStop = true;
            cb_nu.Text = "Nữ";
            cb_nu.UseVisualStyleBackColor = true;
            // 
            // cb_nam
            // 
            cb_nam.AutoSize = true;
            cb_nam.Location = new Point(84, 231);
            cb_nam.Name = "cb_nam";
            cb_nam.Size = new Size(51, 19);
            cb_nam.TabIndex = 20;
            cb_nam.TabStop = true;
            cb_nam.Text = "Nam";
            cb_nam.UseVisualStyleBackColor = true;
            // 
            // tb_so
            // 
            tb_so.Location = new Point(84, 167);
            tb_so.Name = "tb_so";
            tb_so.Size = new Size(475, 23);
            tb_so.TabIndex = 18;
            // 
            // tb_diachi
            // 
            tb_diachi.Location = new Point(84, 97);
            tb_diachi.Name = "tb_diachi";
            tb_diachi.Size = new Size(475, 23);
            tb_diachi.TabIndex = 16;
            // 
            // tb_ten
            // 
            tb_ten.Location = new Point(84, 24);
            tb_ten.Name = "tb_ten";
            tb_ten.Size = new Size(475, 23);
            tb_ten.TabIndex = 15;
            // 
            // tbt_anh
            // 
            tbt_anh.BackColor = SystemColors.AppWorkspace;
            tbt_anh.Location = new Point(608, 24);
            tbt_anh.Name = "tbt_anh";
            tbt_anh.Size = new Size(159, 222);
            tbt_anh.TabIndex = 14;
            tbt_anh.TabStop = false;
            tbt_anh.Click += tbt_anh_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 282);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 12;
            label7.Text = "Ngày Sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 231);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 11;
            label6.Text = "Giới tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 175);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 10;
            label5.Text = "SĐT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 105);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 13;
            label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 32);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 7;
            label1.Text = "Tên ";
            // 
            // hienthi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbt_namsinh);
            Controls.Add(cb_nu);
            Controls.Add(cb_nam);
            Controls.Add(tb_so);
            Controls.Add(tb_diachi);
            Controls.Add(tb_ten);
            Controls.Add(tbt_anh);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "hienthi";
            Text = "hienthi";
            Load += hienthi_Load;
            ((System.ComponentModel.ISupportInitialize)tbt_anh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker tbt_namsinh;
        private RadioButton cb_nu;
        private RadioButton cb_nam;
        private TextBox tb_so;
        private TextBox tb_diachi;
        private TextBox tb_ten;
        private PictureBox tbt_anh;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label1;
    }
}