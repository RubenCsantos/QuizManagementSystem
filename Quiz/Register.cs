using Quiz.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Register : Form
    {

        UsersClass uc = new UsersClass();

        public Register()
        {
            InitializeComponent();

            turmaBox.DataSource = uc.FillComboBox();
            turmaBox.DisplayMember = "Users";
            turmaBox.ValueMember = "Turma";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login loginForm = new login();
            loginForm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void turmaBox_SelectedValueChanged(object sender, EventArgs e)
        {
            uc.TurmaID = uc.FindIDTurmas(turmaBox.SelectedValue.ToString());
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

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


            uc.Nome = nomeBox.Text;
            uc.SobreNome = sobrenomeBox.Text;
            uc.Email = emailBox.Text;
            uc.Password = passBox.Text;
            string confirmPass = passBox2.Text;
            //uc.TurmaID = turmaBox.Text;

            if (uc.Nome.Equals(""))
                sb.Append("Insira o seu nome. ");
            if (uc.SobreNome.Equals(""))
                sb.Append("Insira o seu sobrenome. ");
            if (uc.Email.Equals(""))
                sb.Append("Insira o seu email. ");
            if (uc.Password.Equals(""))
                sb.Append("Insira a sua password. ");
            if (confirmPass.Equals(""))
                sb.Append("Confirme a sua password. ");
            if (!uc.Password.Equals(confirmPass))
                sb.Append("Password's não coincidem. ");
            if (uc.Password.Length < 6)
                sb.Append("Password deve conter mais de 6 caracteres. ");
            if (uc.ChexckEmail(uc.Email) == true)
                sb.Append("Email já se encontra a ser utilizado. ");
            //Encriptar password
            uc.Password = Encrypt(passBox.Text);
            

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Insert data
                bool success = uc.Insert(uc);

                if (success == true)
                {
                    MessageBox.Show("Utilizador " + uc.Nome + " registado com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha ao registar utilizador", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   

            
        }

        private void sobrenomeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void turmaBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
