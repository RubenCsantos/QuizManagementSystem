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
    public partial class Testes : Form
    {
        UsersClass uc = new UsersClass();
        TurmasClass tc = new TurmasClass();
        QuestoesClass qc = new QuestoesClass();
        TestesClass ttc = new TestesClass();
        SetClass sc = new SetClass();

        int currentID; // Current ID LOGGED

        string turmaEscolhida = "";
        string questaoEscolhida = "";

        public Testes(int idid)
        {
            InitializeComponent();

            currentID = idid;

            turmas.DataSource = ttc.FillComboBox();
            turmas.DisplayMember = "Turmas";
            turmas.ValueMember = "Turma";

        }

        private void turmas_SelectedValueChanged(object sender, EventArgs e)
        {
            turmaEscolhida = turmas.SelectedValue.ToString();

            DataTable dt = ttc.FillTable(turmaEscolhida);
            dataTestes.DataSource = dt;
        }

        private void Testes_Load(object sender, EventArgs e)
        {
            //Table dos testes
            DataTable dt = ttc.FillTable(turmaEscolhida);
            dataTestes.DataSource = dt;

            //Table das questoes
            DataTable dt2 = qc.FillAllTable();
            dataQuestoes.DataSource = dt2;
        }
         

        private void reset_Click(object sender, EventArgs e)
        { //Combo box das turmas
            turmas.DataSource = ttc.FillComboBox();
            turmas.DisplayMember = "Turmas";
            turmas.ValueMember = "Turma";

            //grid view dos testes
            DataTable dt = ttc.FillTable(turmaEscolhida);
            dataTestes.DataSource = dt;

            //data grid das questoes
            DataTable dt2 = qc.FillAllTable();
            dataQuestoes.DataSource = dt2;

            //id do teste pesquisado
            testeIDBox.Visible = false;
            testeIDD.Visible = false;

            //Convertor de nome da turma em id 
            converterLabel.Visible = false;
            converter.Visible = false;
            result.Visible = false;

            //Esconder botes de ação com o add questoes
            addButton.Visible = false;
            cancelButton.Visible = false;
            questaoLabel.Visible = false;
            questaoN.Visible = false;
            conj.Visible = false;

            //meter visivel botoes de açao com os testes
            addTeste.Visible = true;
            delTeste.Visible = true;
            editTeste.Visible = true;

            newQuestion.Visible = false;

            Clear();
        }

        private void dataTestes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //GET DATA FROM GRID VIEW
            int rowIndex = e.RowIndex;

            testeIDBox.Visible = true;
            testeIDD.Visible = true;

            testeIDBox.Text = dataTestes.Rows[rowIndex].Cells[0].Value.ToString();
            idTitulo.Text = dataTestes.Rows[rowIndex].Cells[1].Value.ToString();
            turmaTeste.Text = dataTestes.Rows[rowIndex].Cells[2].Value.ToString();

            newQuestion.Visible = true;
            

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdmin menuAdminForms = new MenuAdmin(currentID);
            menuAdminForms.ShowDialog();
        }

        private void oA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Q_TextChanged(object sender, EventArgs e)
        {

        }

        private void Q7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        private void Q10_TextChanged(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            idTitulo.Text = "";
            turmaTeste.Text = "";
            questaoN.Text = "";
        }

        private void addTeste_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            ttc.Titulo = idTitulo.Text;
            string turmaAux = turmaTeste.Text;

            if (ttc.Titulo.Equals(""))
                sb.Append("Adicione um título ao teste. ");
            if (turmaAux.Equals(""))
                sb.Append("Adcionone a turma à qual será atribuído o teste. ");



            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Missing Fields!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ttc.IDTurma = Convert.ToInt32(turmaAux);
                if (ttc.InsertTeste(ttc) == true)
                {
                    MessageBox.Show("Teste adicionado com sucesso. ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();

                }
                else
                {
                    MessageBox.Show("Falha ao adicionar teste.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
     
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (questaoN.Text.Equals(""))
            {

                MessageBox.Show("Consulte e insira o ID da questão que deseja adicionar. ", "Missing Fields!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sc.IDQuestoes = Convert.ToInt32(questaoN.Text);
                sc.IDTeste = Convert.ToInt32(testeIDBox.Text);

                if(sc.CheckQuestao(sc) == false)
                {
                    if (sc.InsertQuestaoInTeste(sc) == true)
                    {
                        MessageBox.Show("Questão adicionada ao teste com sucesso. ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        questaoN.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("A questão " + sc.IDQuestoes + " não existe. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        questaoN.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("A questão " + sc.IDQuestoes + " já existe no teste selecionado. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    questaoN.Text = "";
                }
            }

        }

        private void delTeste_Click(object sender, EventArgs e)
        {

            ttc.Titulo = idTitulo.Text;
            string turmaAux = turmaTeste.Text;

            if (turmaAux.Equals(""))
            {
                MessageBox.Show("Selecione a turma a eliminar. ", "Missing Fields!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ttc.IDTurma = Convert.ToInt32(turmaAux);
                if (ttc.DeleteTeste(ttc) == true)
                {
                    MessageBox.Show("Teste eliminado com sucesso. ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();

                }
                else
                {
                    MessageBox.Show("Falha ao eliminar teste.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void editTeste_Click(object sender, EventArgs e)
        {

            string turmaAux = turmaTeste.Text;

            if (turmaAux.Equals(""))
            {
                MessageBox.Show("Selecione um teste a editar. ", "Missing Fields!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ttc.IDTeste = Convert.ToInt32(testeIDBox.Text);
                ttc.Titulo = idTitulo.Text;
                ttc.IDTurma = Convert.ToInt32(turmaAux);
                if (ttc.EditTestes(ttc) == true)
                {
                    MessageBox.Show("Teste editado com sucesso. ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();

                }
                else
                {
                    MessageBox.Show("Falha ao editar teste.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            converterLabel.Visible = true;
            converter.Visible = true;
            converter.Text = "";

        }

        private void converter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tc.Turma = converter.Text;
                int idturma = tc.SearchID(tc);

                if (tc.Turma.Equals(""))
                {
                    MessageBox.Show("Insira a turma a pesquisar. ", "Missing Fields!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int searchh = tc.SearchID(tc);
                    Console.WriteLine(searchh);
                    if (tc.SearchID(tc) != -1)
                    {
                        result.Visible = true;
                        result.Text = "ID " + Convert.ToString(idturma);
                        converter.Text = "";
                        //converter.Clear();
                    }
                    else
                    {
                        converterLabel.Visible = false;
                        converter.Visible = false;
                        result.Visible = false;

                    }
                }
            }
        }

        private void newQuestion_Click(object sender, EventArgs e)
        {
            //colocar invisivel o que nao interessa , ou seja, tudo referente aos testes
            addTeste.Visible = false;
            delTeste.Visible = false;
            editTeste.Visible = false;

            //Colocar visivel opçoes que importam de adicionar questao a um teste
            questaoN.Visible = true;
            addButton.Visible = true;
            cancelButton.Visible = true;
            questaoLabel.Visible = true;
            conj.Visible = true;




        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //id do teste pesquisado
            testeIDBox.Visible = false;
            testeIDD.Visible = false;

            //Esconder botes de ação com o add questoes
            addButton.Visible = false;
            cancelButton.Visible = false;
            questaoLabel.Visible = false;
            questaoN.Visible = false;
            newQuestion.Visible = false;
            conj.Visible = false;

            //meter visivel botoes de açao com os testes
            addTeste.Visible = true;
            delTeste.Visible = true;
            editTeste.Visible = true;

            Clear();
        }

        private void conj_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditQuestoesTestes editQuestoesTesteForms = new EditQuestoesTestes(currentID, Convert.ToInt32(testeIDBox.Text));
            editQuestoesTesteForms.ShowDialog();

        }
    }
}
