using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dis_Klinik_Veritabani
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string text = File.ReadAllText("user.txt");

            string[] str = text.Split('@');

            string userName = str[0];
            string password = str[1];



            if(User.Text == userName && Password.Text == password)
            {
                Anasayfa ana = new Anasayfa();
                ana.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Geçersiz kullanıcı adı veya şifre. Lütfen tekrar deneyin.", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            Password.PasswordChar = '*';

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
