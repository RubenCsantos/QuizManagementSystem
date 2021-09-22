using Quiz.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class login : Form
    {
        UsersClass uc = new UsersClass();

        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registerForm = new Register();
            registerForm.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            static string Encrypt(string value)
            {
                //Using MD5 to encrypt a string
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    UTF8Encoding utf8 = new UTF8Encoding();
                    //Hash data
                    byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                    return Convert.ToBase64String(data);
                }
            }

            StringBuilder sb = new StringBuilder();

            uc.Email = EmailBox.Text;
            uc.Password = passBox.Text;

            if (uc.Email.Equals(""))
                sb.Append("Insira o seu email. ");
            if (uc.Password.Equals(""))
                sb.Append("Insira a sua password. ");
            if (uc.ChexckEmail(uc.Email) == false)
                sb.Append("Email incorreto. ");

            uc.Password = Encrypt(passBox.Text);

            if (uc.ChexckPass(uc.Password) == false)
                sb.Append("Password incorreta.");


            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if ( true)
                {
                    if (uc.FindTypeUser(uc.Email) == 0)
                    {
                        this.Hide();
                        Menu menuForm = new Menu(uc.FindIDUser(uc.Email));
                        menuForm.ShowDialog();
                    }
                    else
                    {
                        this.Hide();
                        MenuAdmin menuAdminForm = new MenuAdmin(uc.FindIDUser(uc.Email));
                        menuAdminForm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Falha ao registar utilizador", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
