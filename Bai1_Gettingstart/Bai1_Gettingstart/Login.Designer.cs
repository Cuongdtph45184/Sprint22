namespace Bai1_Gettingstart
{
    partial class Login
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
            tbt_Username = new TextBox();
            tbt_Password = new TextBox();
            tbt_button = new Button();
            tbt_checkbox = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            Checkpasss = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // tbt_Username
            // 
            tbt_Username.AccessibleDescription = "";
            tbt_Username.AccessibleName = "";
            tbt_Username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbt_Username.Location = new Point(208, 77);
            tbt_Username.Name = "tbt_Username";
            tbt_Username.PlaceholderText = "Username";
            tbt_Username.Size = new Size(544, 29);
            tbt_Username.TabIndex = 0;
            tbt_Username.TextChanged += tbt_Username_TextChanged;
            tbt_Username.MouseLeave += tbt_Username_MouseLeave;
            tbt_Username.MouseHover += tbt_Username_MouseHover;
            // 
            // tbt_Password
            // 
            tbt_Password.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbt_Password.Location = new Point(208, 153);
            tbt_Password.Name = "tbt_Password";
            tbt_Password.PasswordChar = '*';
            tbt_Password.PlaceholderText = "**********";
            tbt_Password.Size = new Size(544, 29);
            tbt_Password.TabIndex = 1;
            // 
            // tbt_button
            // 
            tbt_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbt_button.Location = new Point(208, 279);
            tbt_button.Name = "tbt_button";
            tbt_button.Size = new Size(141, 48);
            tbt_button.TabIndex = 2;
            tbt_button.Text = "Đăng Nhập";
            tbt_button.UseVisualStyleBackColor = true;
            tbt_button.Click += tbt_button_Click;
            // 
            // tbt_checkbox
            // 
            tbt_checkbox.AutoSize = true;
            tbt_checkbox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbt_checkbox.Location = new Point(208, 214);
            tbt_checkbox.Name = "tbt_checkbox";
            tbt_checkbox.Size = new Size(230, 25);
            tbt_checkbox.TabIndex = 3;
            tbt_checkbox.Text = "Tôi không phải người máy";
            tbt_checkbox.UseVisualStyleBackColor = true;
            tbt_checkbox.CheckedChanged += tbt_checkbox_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 77);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 4;
            label1.Text = "Tên Đăng Nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 153);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 5;
            label2.Text = "Mật Khẩu";
            // 
            // Checkpasss
            // 
            Checkpasss.AutoSize = true;
            Checkpasss.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Checkpasss.Location = new Point(500, 214);
            Checkpasss.Name = "Checkpasss";
            Checkpasss.Size = new Size(141, 25);
            Checkpasss.TabIndex = 3;
            Checkpasss.Text = "Hiện mật khẩu";
            Checkpasss.UseVisualStyleBackColor = true;
            Checkpasss.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(478, 279);
            button1.Name = "button1";
            button1.Size = new Size(141, 48);
            button1.TabIndex = 6;
            button1.Text = "Đăng Ký";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Checkpasss);
            Controls.Add(tbt_checkbox);
            Controls.Add(tbt_button);
            Controls.Add(tbt_Password);
            Controls.Add(tbt_Username);
            Name = "Login";
            RightToLeftLayout = true;
            Text = "Login";
            Load += Login_Load;
            TextChanged += Login_TextChanged;
            MouseLeave += Login_MouseLeave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbt_Username;
        private TextBox tbt_Password;
        private Button tbt_button;
        private CheckBox tbt_checkbox;
        private Label label1;
        private Label label2;

        public Login(TextBox tbt_Username, TextBox tbt_Password, Button tbt_button, CheckBox tbt_checkbox, Label label1, Label label2)
        {
            this.tbt_Username = tbt_Username;
            this.tbt_Password = tbt_Password;
            this.tbt_button = tbt_button;
            this.tbt_checkbox = tbt_checkbox;
            this.label1 = label1;
            this.label2 = label2;
        }

        private CheckBox Checkpasss;
        private Button button1;
    }
}