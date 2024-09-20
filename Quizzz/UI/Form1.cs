using Quizzz.Models;
using Quizzz.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Quizzz
{
    public partial class Login : Form
    {
        private QuizzEduContext db;
        private void Desgion_Mod()
        {
            //UserName.SetRoundedCorners(50);
            //Password.SetRoundedCorners(50);
            textbox_Username.BackColor = Color.White;
            textbox_Username.ForeColor = Color.Black;
            textbox_Username.BorderStyle = BorderStyle.FixedSingle;
            textbox_Username.Padding = new Padding(5);

            textbox_Password.BackColor = Color.White;
            textbox_Password.ForeColor = Color.Black;
            textbox_Password.BorderStyle = BorderStyle.FixedSingle;
            textbox_Password.Padding = new Padding(5);

            button_Login.SetRoundedCorners(50);
            textbox_Username.BorderStyle = BorderStyle.FixedSingle;
            textbox_Username.Padding = new Padding(5);

        }
        public Login()
        {
            InitializeComponent();
            Desgion_Mod();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Quizz", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string UserName = textbox_Username.Text;
            string Password = textbox_Password.Text;

            // Kiểm tra xem tên đăng nhập hoặc mật khẩu có bị bỏ trống không
            if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống", "Quizz", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new QuizzEduContext())
            {
                try
                {
                    // Tìm kiếm người dùng theo tên đăng nhập (MaSinhVien)
                    SinhVien user = loginSinhVien(db, UserName, Password); // Pass the db context

                    if (user != null)
                    {
                        Form fromToDisPlay = new AdminForm();
                        this.Hide();
                        fromToDisPlay.Closed += (s, args) => this.Close();
                        fromToDisPlay.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập không tồn tại", "Quizz", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Quizz", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private SinhVien loginSinhVien(QuizzEduContext db, string mssv, string password) // Accept db context as parameter
        {
            var SinhVien = db.SinhViens.SingleOrDefault(s => s.MaSinhVien.ToString() == mssv && s.Password == password);
            return SinhVien;
        }

    }
}



