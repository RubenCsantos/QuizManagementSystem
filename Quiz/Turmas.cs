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
    public partial class Turmas : Form
    {
        UsersClass uc = new UsersClass();
        TurmasClass tc = new TurmasClass();
        
        int currentID; // Current ID LOGGED

        string turmaSelected = "";

        public Turmas(int idid)
        {
            InitializeComponent();
            currentID = idid;

            turmaBox.DataSource = tc.FillComboBox();
            turmaBox.DisplayMember = "Users";
            turmaBox.ValueMember = "Turma";

        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdmin menuAdminForms = new MenuAdmin(currentID);
            menuAdminForms.ShowDialog();
        }

        private void turmaBox_SelectedValueChanged(object sender, EventArgs e)
        {
            turmaSelected = turmaBox.SelectedValue.ToString();

            DataTable dt = uc.FillTable(turmaSelected);
            tableTurmas.DataSource = dt;
        }

        private void Turmas_Load(object sender, EventArgs e)
        {
            DataTable dt = uc.FillTable(turmaSelected);
            tableTurmas.DataSource = dt;
        }

        //ADD TURMA/CLASSE
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            tc.Turma = turmaDes.Text;

            if (tc.Turma.Equals(""))
            {
                MessageBox.Show("Insira a designação da turma a adicionar.", "Campos em falta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (tc.InsertTurmas(tc) == true)
                {
                    MessageBox.Show("Turma adicionada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha ao adicionar turma.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            turmaBox.DataSource = tc.FillComboBox();
            turmaBox.DisplayMember = "Users";
            turmaBox.ValueMember = "Turma";

            DataTable dt = uc.FillTable(turmaSelected);
            tableTurmas.DataSource = dt;
        }


        //DELETE TURMA/CLASSE
        private void button2_Click(object sender, EventArgs e)
        {
            tc.Turma = turmaDes.Text;

            if (tc.Turma.Equals(""))
            {
                MessageBox.Show("Insira a designação da turma a eliminar.", "Campos em falta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (tc.DeleteTurmas(tc.Turma) == false)
                {
                    MessageBox.Show("Turma eliminada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha ao eliminar turma.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }  

        }

        private void turmaBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
