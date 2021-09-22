using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Quiz.Classes
{
    class SetClass
    {
        public int IDSet { get; set; }
        public int IDQuestoes { get; set; }
        public int IDTeste { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


        //////////////////////////////////// INSERT QUESTAO NO TESTE NA BASE DE DADOS ////////////////////////////////////////////////
        public bool InsertQuestaoInTeste(SetClass x)
        {
            //criar conexão
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO SetQuestaoToTeste(IDQuestoes, IDTeste) VALUES (@IDQuestoes, @IDTeste)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IDQuestoes", x.IDQuestoes);
                cmd.Parameters.AddWithValue("@IDTeste", x.IDTeste);

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

        //////////////////////////////////FILL SET TABLE //////////////////////////
        public DataTable FillTable(TestesClass x)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable table1 = new DataTable();

            try
            {

                //int idid = Convert.ToInt32(id);

                string sql = "SELECT a.Titulo as Teste, b.IDQuestoes as 'Questão ID', b.Descricao as Questão, b.OA as 'Opção A', b.OB as 'Opção B', b.OC as 'Opção C', b.OD as 'Opção D', b.OCorreta as 'Opção Correta' from Teste a inner join SetQuestaoToTeste c on c.IDTeste = a.IDTeste inner join Questoes b on b.IDQuestoes = c.IDQuestoes where a.Titulo = @Titulo";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Titulo", x.Titulo);

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



        //////////////////////////////////// VERIFICAR SE QUESTAO JA EXISTE NO TESTE NA BASE DE DADOS ////////////////////////////////////////////////
        public bool CheckQuestao(SetClass x)
        {

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "SELECT IDQuestoes FROM SetQuestaoToTeste WHERE IDTeste = @IDTeste and IDQuestoes = @IDQuestoes";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IDTeste", x.IDTeste);
                cmd.Parameters.AddWithValue("@IDQuestoes", x.IDQuestoes);

                conn.Open();
                //int result = cmd.ExecuteNonQuery();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
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

            return false;
        }



        //////////////////////////////////// EDITAR QUESTAO QUE JA EXISTE NO TESTE NA BASE DE DADOS ////////////////////////////////////////////////
        public bool EditSetQuestoes(SetClass x, int newId)
        {

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE SetQuestaoToTeste SET IDQuestoes =" + newId + "WHERE IDTeste = @IDTeste AND IDQuestoes = @IDQuestoes";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IDTeste", x.IDTeste);
                cmd.Parameters.AddWithValue("@IDQuestoes", x.IDQuestoes);

                conn.Open();
                //int result = cmd.ExecuteNonQuery();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
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

            return false;
        }




        //////////////////////////////////// APAGAR QUESTAO QUE JA EXISTE NO TESTE NA BASE DE DADOS ////////////////////////////////////////////////
        public bool DeleteSetQuestoes(SetClass x)
        {

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM SetQuestaoToTeste WHERE IDTeste = @IDTeste AND IDQuestoes = @IDQuestoes";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IDTeste", x.IDTeste);
                cmd.Parameters.AddWithValue("@IDQuestoes", x.IDQuestoes);

                conn.Open();
                //int result = cmd.ExecuteNonQuery();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
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

            return false;
        }


        //////////////////////////////////FILL SET TABLE 2//////////////////////////
        public int[] FillTable1(TestesClass x)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {

                //int idid = Convert.ToInt32(id);

                string sql = "SELECT count (b.IDQuestoes) as 'Questão ID' from Teste a inner join SetQuestaoToTeste c on c.IDTeste = a.IDTeste inner join Questoes b on b.IDQuestoes = c.IDQuestoes where a.Titulo = @Titulo";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Titulo", x.Titulo);

                conn.Open();

                int result;

                using (SqlDataReader reader1 = cmd.ExecuteReader())
                {
                    if (reader1.Read())
                    {
                        result = reader1.GetInt32(0);
                    }
                    else
                    {
                        return null;
                    }
                }

                string sql2 = "SELECT b.IDQuestoes as 'Questão ID' from Teste a inner join SetQuestaoToTeste c on c.IDTeste = a.IDTeste inner join Questoes b on b.IDQuestoes = c.IDQuestoes where a.Titulo = @Titulo";

                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                cmd2.Parameters.AddWithValue("@Titulo", x.Titulo);

                int[] questoes = new int[result];

                using (SqlDataReader reader = cmd2.ExecuteReader())
                {
                    for(int i=0; i<questoes.Length; i++)
                    {
                        while (reader.Read())
                        {
                            questoes[i] = (int)reader["Questão ID"];
                            break;
                        }

                    }
                    return questoes;
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

            return null;
        }

    }


}
