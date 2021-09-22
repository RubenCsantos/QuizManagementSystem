using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Quiz.Classes
{
    class QuestoesClass
    {
        public int IDQuestoes { get; set; }
        public string Descricao { get; set; }
        public string OA { get; set; }
        public string OB { get; set; }
        public string OC { get; set; }
        public string OD { get; set; }
        public string OCorreta { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


        /////////////////////////////////////////////COMBO BOX//////////////////////////////////////////////////////////
        public DataTable FillComboBox()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable table1 = new DataTable();

            try
            {

                string sql = "SELECT * FROM Questoes";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(table1);

                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return table1;
        }


//////////////////////////////////FILL QUESTIONS TABLE //////////////////////////
        public DataTable FillTable(string id)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable table1 = new DataTable();

            try
            {

                int idid = Convert.ToInt32(id);

                string sql = "SELECT Questoes.IDQuestoes, Questoes.Descricao, Questoes.OA, Questoes.OB, Questoes.OC, Questoes.OD, Questoes.OCorreta FROM Questoes WHERE Questoes.IDQuestoes = '" + idid + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(table1);

                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return table1;
        }


        //////////////////////////////////FILL ALL QUESTIONS TABLE //////////////////////////
        public DataTable FillAllTable()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable table1 = new DataTable();

            try
            {

                string sql = "SELECT Questoes.IDQuestoes, Questoes.Descricao, Questoes.OA, Questoes.OB, Questoes.OC, Questoes.OD, Questoes.OCorreta FROM Questoes";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(table1);

                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return table1;
        }

        //////////////////////////////////// INSERT QUESTOES NA BASE DE DADOS ////////////////////////////////////////////////
        public bool InsertQuestoes(QuestoesClass x)
        {
            //criar conexão
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO Questoes(Descricao, OA, OB, OC, OD, OCorreta) VALUES (@Descricao, @OA, @OB, @OC, @OD, @OCorreta)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Descricao", x.Descricao);
                cmd.Parameters.AddWithValue("@OA", x.OA);
                cmd.Parameters.AddWithValue("@OB", x.OB);
                cmd.Parameters.AddWithValue("@OC", x.OC);
                cmd.Parameters.AddWithValue("@OD", x.OD);
                cmd.Parameters.AddWithValue("@OCorreta", x.OCorreta);

                //abrir conexão
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than zero else its value will be 0
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return false;
        }



        //////////////////////////////////// EDITAR QUESTOES NA BASE DE DADOS ////////////////////////////////////////////////
        public bool EditQuestoes(QuestoesClass x)
        {
            //criar conexão
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE Questoes SET Descricao = @Descricao, OA = @OA, OB = @OB, OC = @OC, OD = @OD, OCorreta = @OCorreta WHERE IDQuestoes = @IDQuestoes";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IDQuestoes", x.IDQuestoes);
                cmd.Parameters.AddWithValue("@Descricao", x.Descricao);
                cmd.Parameters.AddWithValue("@OA", x.OA);
                cmd.Parameters.AddWithValue("@OB", x.OB);
                cmd.Parameters.AddWithValue("@OC", x.OC);
                cmd.Parameters.AddWithValue("@OD", x.OD);
                cmd.Parameters.AddWithValue("@OCorreta", x.OCorreta);

                //abrir conexão
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than zero else its value will be 0
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return false;
        }



        //////////////////////////////////// DELETE QUESTOES NA BASE DE DADOS ////////////////////////////////////////////////
        public bool DeleteQuestoes(QuestoesClass x)
        {
            //criar conexão
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM Questoes WHERE IDQuestoes = @IDQuestoes";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IDQuestoes", x.IDQuestoes);

                //abrir conexão
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than zero else its value will be 0
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return false;
        }


        /////////////////////// VALIDAR RESPOSTA //////////////////////////
        public string ChexckResposta(QuestoesClass x)
        {

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "SELECT OCorreta FROM Questoes WHERE IDQuestoes = @IDQuestoes";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IDQuestoes", x.IDQuestoes);
                conn.Open();
                //int result = cmd.ExecuteNonQuery();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetString(0);
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return "";
        }



        /////////////////////// ENCONTRAR TUDO DA QUESTAO //////////////////////////
        public List<QuestoesClass> GetQuestao1(int[] x)
        {

            SqlConnection conn = new SqlConnection(myconnstrng);

            List<QuestoesClass> ListaQuestoes = new List<QuestoesClass>();

            try
            {
                for(int i=0; i<x.Length; i++)
                {
                    if(conn.State == ConnectionState.Open)
                    {
                        //Console.WriteLine("fechou");
                        conn.Close();
                    }
                        
                    //Console.WriteLine(x.Length);
                    string sql = "SELECT * FROM Questoes WHERE IDQuestoes =" + x[i];
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    //Console.WriteLine("Passou aqui!");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            QuestoesClass questoes = new QuestoesClass();
                            questoes.IDQuestoes = (int)reader["IDQuestoes"];
                            questoes.Descricao = (string)reader["Descricao"];
                            questoes.OA = (string)reader["OA"];
                            questoes.OB = (string)reader["OB"];
                            questoes.OC = (string)reader["OC"];
                            questoes.OD = (string)reader["OD"];
                            questoes.OCorreta = (string)reader["OCorreta"];

                            ListaQuestoes.Add(questoes);
                            //Console.WriteLine("Passou aqui na lista!");
                            //Console.WriteLine("LISTA LENGHT = " +ListaQuestoes.Count);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
                //Console.WriteLine("Não fecha?");
            }
            //Console.WriteLine("Return do nada!");
            return ListaQuestoes;
        }


    }
}
