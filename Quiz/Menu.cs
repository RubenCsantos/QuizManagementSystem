using Quiz.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Menu : Form
    {

        UsersClass uc = new UsersClass();
        TurmasClass tc = new TurmasClass();
        QuestoesClass qc = new QuestoesClass();
        TestesClass ttc = new TestesClass();
        SetClass sc = new SetClass();
        Estatisticas ec = new Estatisticas();

        int currentID; // Current ID LOGGED

        string testeEscolhido = ""; // Teste escolhido para resolver

        //Defeniçoes de tempo
        int timevalue = 900;  // 15 minutos

        int count = 0; // auxilia a iteração sobre as questões

        private bool testeConcluido = false;//flag se teste terminou

        int acertos = 0;
        // para calcular se foi aprovado ou não
        int falhas = 0;

        public Menu(int idid)
        {
            InitializeComponent();
            welcome.Text = uc.FindNameUser(idid) + "!";
            welcomeTurma.Text = uc.FindTurmaUser(idid);

            currentID = idid;

            testes.DataSource = ttc.FillComboBoxTestes(uc.FindIDTurmas(uc.FindTurmaUser(idid)));
            testes.DisplayMember = "Teste";
            testes.ValueMember = "Titulo";


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void welcomeTurma_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            //Avaliar se é o primeiro testes que o utilizador vai realizar, caso seja incializam se as suas estatisticas a zero
            if (ec.AlreadyHaveStats(currentID) == false)
                ec.InitializaStats(currentID);

            start.Visible = false;
            seguinte.Visible = true;
            testes.Visible = false;
            labelCorreta.Visible = true;
            Ocorreta.Visible = true;

            List<QuestoesClass> Lista = new List<QuestoesClass>();

            this.timer1.Enabled = true;

            ttc.Titulo = testeEscolhido;
            int[] questoes = new int[sc.FillTable1(ttc).Length];
            questoes = sc.FillTable1(ttc);

            Lista = qc.GetQuestao1(questoes);

            descricaoQuestao.Text = Lista[0].Descricao;
            OA.Text = Lista[0].OA;
            OB.Text = Lista[0].OB;
            OC.Text = Lista[0].OC;
            OD.Text = Lista[0].OD;

            count++;

            seguinte.Click += (sender, EventArgs) =>
            {
                seguinteNextClick(sender, EventArgs, Lista);
            };
        }

        //////////////////////////////CLEAR FIELDS //////////////////////
        ////public void Clear()
        ////{
        //    idTitulo.Text = "";
        //    turmaTeste.Text = "";
        //    questaoN.Text = "";
        //}


        //////////////////////////////BOTÃO DE SEGUINTE PASSAGEM DE PARAMETROS PARA UM BUTTON CLICK////////////////////////////////
        void seguinteNextClick(object sender, EventArgs e, List<QuestoesClass> Lista)
        {
            Ocorreta.Visible = true;
            labelCorreta.Visible = true;

            if (!testeConcluido)
            {
                if (count != Lista.Count)
                {
                    descricaoQuestao.Text = Lista[count].Descricao;
                    OA.Text = Lista[count].OA;
                    OB.Text = Lista[count].OB;
                    OC.Text = Lista[count].OC;
                    OD.Text = Lista[count].OD;

                    qc.IDQuestoes = Lista[count-1].IDQuestoes; //id da questão atual

                    confirmar_Click(sender, e, qc, currentID);  // avaliar atual
                    Ocorreta.Text = "";
                    count++;
                }
                else
                {
                    qc.IDQuestoes = Lista[count - 1].IDQuestoes; //id da questão atual
                    confirmar_Click(sender, e, qc, currentID);
                    MessageBox.Show("Ainda lhe restavam: " + timevalue / 60 + " min.", " Teste concluído. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    testeConcluido = true; // teste concluido
                    timevalue = 900; // reset do tempo;
                    
                    if(acertos >= falhas) //Confere se o teste foi positivo ou negativo e atualiza na BD
                    {
                        ec.InsertAprovados(currentID);  
                    }
                    else
                    {
                        ec.InsertReprovados(currentID);
                    }

                    start.Visible = true;
                    Application.Exit();// fechar automaticamente mal se acabe a prova.
                }
            }
        }


        //void confirmarNextClick(object sender, EventArgs e, QuestoesClass qc)
        //{
        //    string resposta = "";

        //    resposta = Ocorreta.Text;  // ler resposta

        //    if (resposta.Equals(qc.ChexckResposta(qc)))
        //    {
        //        Console.WriteLine("CERTA");
        //        confirmar.Visible = false;
        //    }
        //    else
        //    {
        //        Console.WriteLine("ERROU");
        //        confirmar.Visible = false;
        //    }

        //}


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

     

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //FUNÇÃO DO TIMER PARA TER LIMITE DE RESOLUÇÃO DO TESTE
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timevalue > 0)
            {
                timevalue--;

                int m = timevalue / 60;
                int s = timevalue - (m * 60);

                tempo.Text = m.ToString() + ":" + s.ToString();
            }
            else
            {
                this.timer1.Stop();
                MessageBox.Show("Terminou o seu tempo. ", "Teste Expirado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();

            }
        }

        private void testes_SelectedValueChanged(object sender, EventArgs e)
        {
            testeEscolhido = testes.SelectedValue.ToString();

            nomeTeste.Text = testeEscolhido;
        }

        //FUNÇÃO QUE AVALIA AS QUESTÃO, OU SEJA, SE ESTÃO OU NÃO CORRETAS
        private void confirmar_Click(object sender, EventArgs e, QuestoesClass qc, int idid)
        {
            string resposta = "";

            resposta = Ocorreta.Text;  // ler resposta

            if (resposta.Equals(qc.ChexckResposta(qc)))
            {
                Console.WriteLine("CERTA");
                acertos++;
                ec.InsertRightStats(currentID); //atualiza acertos do user na BD


            }
            else
            {
                Console.WriteLine("ERROU");
                falhas++;
                ec.InsertFalseStats(currentID); //atualiza falhas do user na BD
            }
        }

        private void seguinte_Click(object sender, EventArgs e)
        {
            
        }

        private void descricaoQuestao_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Perfil perfilForm = new Perfil(currentID);
            perfilForm.ShowDialog();
        }
    }
}
