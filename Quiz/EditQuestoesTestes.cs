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
    public partial class EditQuestoesTestes : Form
    {

        UsersClass uc = new UsersClass();
        TurmasClass tc = new TurmasClass();
        QuestoesClass qc = new QuestoesClass();
        TestesClass ttc = new TestesClass();
        SetClass sc = new SetClass();

        int currentID; // Current ID LOGGED
        int testeSelecionado; //Teste selecionado

        public EditQuestoesTestes(int idid, int testeidid)
        {
            InitializeComponent();

            currentID = idid;
            testeSelecionado = testeidid;
            titulo.Text = ttc.SearchTitulo(testeSelecionado);
            ttc.Titulo = titulo.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Testes testesForms = new Testes(currentID);
            testesForms.ShowDialog();

        }

        private void EditQuestoesTestes_Load(object sender, EventArgs e)
        {
            DataTable dt = sc.FillTable(ttc);
            setData.DataSource = dt;

        }

        private void setData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //GET DATA FROM GRID VIEW
            int rowIndex = e.RowIndex;

            idquestao.Text = setData.Rows[rowIndex].Cells[1].Value.ToString();
            descricaoquestao.Text = setData.Rows[rowIndex].Cells[2].Value.ToString();
            
        }

        private void reset_Click(object sender, EventArgs e)
        {
            idquestao.Text = "";
            descricaoquestao.Text = "";
            addquestao.Text = "";

            DataTable dt = sc.FillTable(ttc);
            setData.DataSource = dt;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (addquestao.Text.Equals(""))
            {
                MessageBox.Show("Falha ao editar questão.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sc.IDQuestoes = Convert.ToInt32(idquestao.Text);
                sc.IDTeste = testeSelecionado;

                if (sc.EditSetQuestoes(sc, Convert.ToInt32(addquestao.Text))==false)
                {
                    MessageBox.Show("Questão editada em " +titulo.Text +" .", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    idquestao.Text = "";
                    descricaoquestao.Text = "";
                    addquestao.Text = "";

                    DataTable dt = sc.FillTable(ttc);
                    setData.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Falha ao editar questão. ", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (idquestao.Text.Equals(""))
            {
                MessageBox.Show("Falha ao eliminar questão.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sc.IDQuestoes = Convert.ToInt32(idquestao.Text);
                sc.IDTeste = testeSelecionado;

                if (sc.DeleteSetQuestoes(sc) == false)
                {
                    MessageBox.Show("Questão eliminada em " + titulo.Text + " .", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    idquestao.Text = "";
                    descricaoquestao.Text = "";
                    addquestao.Text = "";

                    DataTable dt = sc.FillTable(ttc);
                    setData.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Falha ao eliminada questão. ", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
