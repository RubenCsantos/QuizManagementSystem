using Quiz.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quiz
{
    public partial class MenuAdmin : Form
    {
        UsersClass uc = new UsersClass();
        int currentID;
        public MenuAdmin(int idid)
        {
            InitializeComponent();
            welcome.Text = uc.FindNameUser(idid) +"!";
            currentID = idid;

        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Testes testesForm = new Testes(currentID);
            testesForm.ShowDialog();
        }

        private void questoes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Questoes questoesForm = new Questoes(currentID);
            questoesForm.ShowDialog();
        }

        private void turmas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Turmas turmasForm = new Turmas(currentID);
            turmasForm.ShowDialog();
        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void stats_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stats statsForms = new Stats(currentID);
            statsForms.ShowDialog();
        }
    }
}
