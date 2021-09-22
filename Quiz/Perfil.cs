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
    public partial class Perfil : Form
    {

        UsersClass uc = new UsersClass();
        TurmasClass tc = new TurmasClass();
        QuestoesClass qc = new QuestoesClass();
        Estatisticas ec = new Estatisticas();

        int currentID; // Current ID LOGGED


        public Perfil(int idid)
        {
            InitializeComponent();
            currentID = idid;

            Nome.Text = uc.FindNameUser(currentID);
            string emaill = uc.FindEmailUser(currentID);
            Email.Text = emaill;

            int[] infos = ec.getAllStats(currentID);

                Tr.Text = Convert.ToString(infos[2] + infos[3]); //Testes Realizados TOTAL
                Ta.Text = Convert.ToString(infos[2]); //Testes Aprovados
                Trep.Text = Convert.ToString(infos[3]); //Testes reprovados
                Tq.Text = Convert.ToString(infos[0] + infos[1]); //Total de Questões
                Pa.Text = Convert.ToString(infos[0] * 100 / (infos[0] + infos[1])) + " %";  //Percentagem de acerto

        }

        private void Perfil_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menuForms = new Menu(currentID);
            menuForms.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
