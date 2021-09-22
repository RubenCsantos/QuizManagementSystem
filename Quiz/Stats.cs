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
    public partial class Stats : Form
    {
        UsersClass uc = new UsersClass();
        TurmasClass tc = new TurmasClass();
        QuestoesClass qc = new QuestoesClass();
        TestesClass ttc = new TestesClass();
        SetClass sc = new SetClass();
        Estatisticas ec = new Estatisticas();

        int currentID; // id logado

        string turmaEscolhida = ""; //turma escolhida no comobo box

        string alunoEscolhido= ""; //aluno escolhida no comobo box

        public Stats(int idid)
        {
            InitializeComponent();

            currentID = idid;

            ComboTurma.DataSource = tc.FillComboBox();
            ComboTurma.DisplayMember = "Turmas";
            ComboTurma.ValueMember = "Turma";
        }

        private void Stats_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdmin menuAdminForms = new MenuAdmin(currentID);
            menuAdminForms.ShowDialog();
        }

        private void ComboTurma_SelectedValueChanged(object sender, EventArgs e)
        {
            tc.Turma = ComboTurma.SelectedValue.ToString();
            turmaEscolhida = tc.Turma;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ComboAluno.Visible = true;
            Search.Visible = true;
            LabelAluno.Visible = true;

            ComboAluno.DataSource = uc.FillComboBoxAlunos(tc.SearchID(tc));
            ComboAluno.DisplayMember = "Users";
            ComboAluno.ValueMember = "Nome";
        }


        private void ComboAluno_SelectedValueChanged(object sender, EventArgs e)
        {
            alunoEscolhido = ComboAluno.SelectedValue.ToString();
        }

        private void Search_Click(object sender, EventArgs e)
        {
                LabelAluno.Visible = false;
                Search.Visible = false;
                ComboAluno.Visible = false;

                NomeR.Text = alunoEscolhido;
                TurmaR.Text = turmaEscolhida;

                int[] infos = ec.getAllStats(uc.FindIDUserByName(alunoEscolhido));

                if(infos != null)
                {
                    TaR.Text = Convert.ToString(infos[2]); //Testes Aprovados
                    TrR.Text = Convert.ToString(infos[3]); //Testes Reprovados
                    PaR.Text = Convert.ToString(infos[0] * 100 / (infos[0] + infos[1])) + " %";  //Percentagem de acerto
                    TestesRealizadosR.Text = Convert.ToString(infos[2] + infos[3]); // testes realizados

                    if (infos[0] * 100 / (infos[0] + infos[1]) >= 50)
                    {
                        Result.Text = "Aprovado";
                        Result.BackColor = Color.Lime;
                        Result.Visible = true;
                    }
                    else
                    {
                        Result.Text = "Reprovado";
                        Result.BackColor = Color.Red;
                        Result.Visible = true;
                    }
                }
                else
                {
                        MessageBox.Show("Aluno ainda não efetuou nenhum teste.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        NomeR.Text = "";
                        TurmaR.Text = "";
                        TaR.Text = "";
                        TrR.Text = "";
                        PaR.Text = "";
                        TestesRealizadosR.Text = "";
                        Result.Visible = false;
                }    
        }

    }
}
