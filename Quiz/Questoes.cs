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
    public partial class Questoes : Form
    {

        UsersClass uc = new UsersClass();
        TurmasClass tc = new TurmasClass();
        QuestoesClass qc = new QuestoesClass();

        int currentID; // Current ID LOGGED

        string questaoIDescolhida = "";

        public Questoes(int idid)
        {
            InitializeComponent();
            currentID = idid;

            questions.DataSource = qc.FillComboBox();
            questions.DisplayMember = "Questoes";
            questions.ValueMember = "IDQuestoes";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdmin menuAdminForms = new MenuAdmin(currentID);
            menuAdminForms.ShowDialog();
        }

        private void questions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void questions_SelectedValueChanged(object sender, EventArgs e)
        {
            questaoIDescolhida = questions.SelectedValue.ToString();

            DataTable dt = qc.FillTable(questaoIDescolhida);
            dataQuestoes.DataSource = dt;
        }

        private void Questoes_Load(object sender, EventArgs e)
        {
            DataTable dt = qc.FillTable(questaoIDescolhida);
            dataQuestoes.DataSource = dt;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            questions.DataSource = qc.FillComboBox();
            questions.DisplayMember = "Questoes";
            questions.ValueMember = "IDQuestoes";

            DataTable dt = qc.FillTable(questaoIDescolhida);
            dataQuestoes.DataSource = dt;

            idLabel.Visible = false;
            idBOX.Visible = false;
            Clear();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            qc.Descricao = enunciado.Text;
            qc.OA = oA.Text;
            qc.OB = oB.Text;
            qc.OC = oC.Text;
            qc.OD = oD.Text;
            qc.OCorreta = oCorrect.Text;

            if (qc.Descricao.Equals(""))
                sb.Append("Adicione um enunciado à questão. ");
            if (qc.OA.Equals(""))
                sb.Append("Adcione a opção A. ");
            if (qc.OB.Equals(""))
                sb.Append("Adcione a opção B. ");
            if (qc.OC.Equals(""))
                sb.Append("Adcione a opção C. ");
            if (qc.OD.Equals(""))
                sb.Append("Adcione a opção D. ");
            if (qc.OCorreta.Equals(""))
                sb.Append("Adcione a opção correta. ");

            if(sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Missing Fields!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(qc.InsertQuestoes(qc) == true)
                {
                    MessageBox.Show("Questão adicionada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    
                }
                else
                {
                    MessageBox.Show("Falha ao adicionar questão.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Clear()
        {
            idLabel.Visible = false;
            idBOX.Visible = false;
            enunciado.Text = "";
            oA.Text = "";
            oB.Text = "";
            oC.Text = "";
            oD.Text = "";
            oCorrect.Text = "";
        }

        private void enunciado_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataQuestoes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //GET DATA FROM GRID VIEW
            int rowIndex = e.RowIndex;

            idLabel.Visible = true;
            idBOX.Visible = true;

            idBOX.Text = dataQuestoes.Rows[rowIndex].Cells[0].Value.ToString();
            enunciado.Text = dataQuestoes.Rows[rowIndex].Cells[1].Value.ToString();
            oA.Text = dataQuestoes.Rows[rowIndex].Cells[2].Value.ToString(); ;
            oB.Text = dataQuestoes.Rows[rowIndex].Cells[3].Value.ToString(); ;
            oC.Text = dataQuestoes.Rows[rowIndex].Cells[4].Value.ToString(); ;
            oD.Text = dataQuestoes.Rows[rowIndex].Cells[5].Value.ToString(); ;
            oCorrect.Text = dataQuestoes.Rows[rowIndex].Cells[6].Value.ToString(); ;

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            qc.IDQuestoes = Convert.ToInt32(idBOX.Text);
            qc.Descricao = enunciado.Text;
            qc.OA = oA.Text;
            qc.OB = oB.Text;
            qc.OC = oC.Text;
            qc.OD = oD.Text;
            qc.OCorreta = oCorrect.Text;

            if (qc.Descricao.Equals(""))
                sb.Append("Adicione um enunciado à questão. ");
            if (qc.OA.Equals(""))
                sb.Append("Adcione a opção A. ");
            if (qc.OB.Equals(""))
                sb.Append("Adcione a opção B. ");
            if (qc.OC.Equals(""))
                sb.Append("Adcione a opção C. ");
            if (qc.OD.Equals(""))
                sb.Append("Adcione a opção D. ");
            if (qc.OCorreta.Equals(""))
                sb.Append("Adcione a opção correta. ");

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Missing Fields!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (qc.EditQuestoes(qc) == true)
                {
                    MessageBox.Show("Questão editada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();

                }
                else
                {
                    MessageBox.Show("Falha ao editar questão.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            qc.IDQuestoes = Convert.ToInt32(idBOX.Text);
            qc.Descricao = enunciado.Text;
            qc.OA = oA.Text;
            qc.OB = oB.Text;
            qc.OC = oC.Text;
            qc.OD = oD.Text;
            qc.OCorreta = oCorrect.Text;

            if (qc.Descricao.Equals(""))
                sb.Append("Adicione um enunciado à questão. ");
            if (qc.OA.Equals(""))
                sb.Append("Adcione a opção A. ");
            if (qc.OB.Equals(""))
                sb.Append("Adcione a opção B. ");
            if (qc.OC.Equals(""))
                sb.Append("Adcione a opção C. ");
            if (qc.OD.Equals(""))
                sb.Append("Adcione a opção D. ");
            if (qc.OCorreta.Equals(""))
                sb.Append("Adcione a opção correta. ");

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Missing Fields!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (qc.DeleteQuestoes(qc) == true)
                {
                    MessageBox.Show("Questão eliminada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();

                }
                else
                {
                    MessageBox.Show("Falha ao eliminar questão.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
