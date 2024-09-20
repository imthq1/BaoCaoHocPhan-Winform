using System.Windows.Forms;

namespace Quizzz
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Exit = new Button();
            textbox_Username = new TextBox();
            textbox_Password = new TextBox();
            button_Login = new Button();
            label_LoginToQuizz = new Label();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.BackColor = SystemColors.ActiveBorder;
            Exit.BackgroundImage = Properties.Resources.Login_BackGround;
            Exit.Image = Properties.Resources.Login_Exit1;
            Exit.Location = new Point(385, 9);
            Exit.Margin = new Padding(3, 2, 3, 2);
            Exit.Name = "Exit";
            Exit.Size = new Size(26, 22);
            Exit.TabIndex = 0;
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // textbox_Username
            // 
            textbox_Username.Font = new Font("Segoe UI Variable Text", 16F);
            textbox_Username.Location = new Point(26, 150);
            textbox_Username.Margin = new Padding(3, 2, 3, 2);
            textbox_Username.Name = "textbox_Username";
            textbox_Username.PlaceholderText = "Tên Đăng Nhập";
            textbox_Username.Size = new Size(386, 36);
            textbox_Username.TabIndex = 8;
            // 
            // textbox_Password
            // 
            textbox_Password.Font = new Font("Segoe UI Variable Text", 16F);
            textbox_Password.Location = new Point(26, 188);
            textbox_Password.Margin = new Padding(3, 2, 3, 2);
            textbox_Password.Name = "textbox_Password";
            textbox_Password.PlaceholderText = "Mật Khẩu";
            textbox_Password.Size = new Size(386, 36);
            textbox_Password.TabIndex = 9;
            // 
            // button_Login
            // 
            button_Login.BackColor = Color.FromArgb(24, 119, 242);
            button_Login.FlatAppearance.BorderSize = 0;
            button_Login.FlatStyle = FlatStyle.Flat;
            button_Login.Font = new Font("Segoe UI Variable Text", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Login.ForeColor = Color.White;
            button_Login.Location = new Point(131, 262);
            button_Login.Margin = new Padding(3, 2, 3, 2);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(175, 38);
            button_Login.TabIndex = 10;
            button_Login.Text = "Đăng Nhập";
            button_Login.UseVisualStyleBackColor = false;
            button_Login.Click += button_Login_Click;
            // 
            // label_LoginToQuizz
            // 
            label_LoginToQuizz.AutoSize = true;
            label_LoginToQuizz.BackColor = Color.Transparent;
            label_LoginToQuizz.Font = new Font("Segoe UI Variable Text", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_LoginToQuizz.ForeColor = Color.White;
            label_LoginToQuizz.Location = new Point(105, 52);
            label_LoginToQuizz.Name = "label_LoginToQuizz";
            label_LoginToQuizz.Size = new Size(219, 27);
            label_LoginToQuizz.TabIndex = 11;
            label_LoginToQuizz.Text = "Đăng Nhập Vào Quizz";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(438, 375);
            Controls.Add(label_LoginToQuizz);
            Controls.Add(button_Login);
            Controls.Add(textbox_Password);
            Controls.Add(textbox_Username);
            Controls.Add(Exit);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Exit;
        private TextBox textbox_Username;
        private TextBox textbox_Password;
        private Button button_Login;
        private Label label_LoginToQuizz;
    }
}
