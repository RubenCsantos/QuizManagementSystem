using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace Quiz.Classes
{
    class Estatisticas
    {
        //Getters and Setters
        public int IDStats { get; set; }
        public int Acertos { get; set; }
        public int Falhas { get; set; }
        public int TestesAprovados { get; set; }
        public int TestesReprovados { get; set; }
        public int IDUsers { get; set; }

        //string de conexão
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //INSERIR ESTATISTICAS DO UTILIZADOR QUE ESTÁ A REALIZAR O TESTE QUANDO ACERTA UMA QUESTÃO
        public bool InsertRightStats(int idid)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE Estatisticas SET Acertos = Acertos + 1 WHERE IDUsers =" +idid;
                SqlCommand cmd = new SqlCommand(sql, conn);

                //abrir conexão
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than zero else its value will be 0
                if (rows > 0)
                {
                    return true; //caso de sucesso
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


        //INSERIR ESTATISTICAS DO UTILIZADOR QUE ESTÁ A REALIZAR O TESTE QUANDO ERRA UMA QUESTÃO
        public bool InsertFalseStats(int idid)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE Estatisticas SET Falhas = Falhas + 1 WHERE IDUsers =" + idid;
                SqlCommand cmd = new SqlCommand(sql, conn);

                //abrir conexão
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than zero else its value will be 0
                if (rows > 0)
                {
                    return true; //caso de sucesso
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


        //INSERIR ESTATISTICAS DO UTILIZADOR SE O TESTE FOI APROVADO
        public bool InsertAprovados(int idid)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE Estatisticas SET TestesAprovados = TestesAprovados + 1 WHERE IDUsers =" + idid;
                SqlCommand cmd = new SqlCommand(sql, conn);

                //abrir conexão
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than zero else its value will be 0
                if (rows > 0)
                {
                    return true; //caso de sucesso
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


        //INSERIR ESTATISTICAS DO UTILIZADOR SE O TESTE FOI Reprovado
        public bool InsertReprovados(int idid)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                

                string sql = "UPDATE Estatisticas SET TestesReprovados = TestesReprovados + 1 WHERE IDUsers =" + idid;
                SqlCommand cmd = new SqlCommand(sql, conn);

                //abrir conexão
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than zero else its value will be 0
                if (rows > 0)
                {
                    return true; //caso de sucesso
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



        //Verificar se o user existe nas estatisticas
        public bool AlreadyHaveStats(int idid)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "SELECT IDUsers FROM Estatisticas WHERE IDUsers = " +idid;
                SqlCommand cmd = new SqlCommand(sql, conn);

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


        //Verificar se o user existe nas estatisticas
        public bool InitializaStats(int idid)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO Estatisticas(Acertos, Falhas, TestesAprovados, TestesReprovados, IDUsers) VALUES(0, 0, 0, 0," + idid + ")";
                SqlCommand cmd = new SqlCommand(sql, conn);

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


        //Get testesAprovados e Reprovados
        public int[] getAllStats(int idid)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            int [] result = new int[4];

            try
            {
                string sql = "SELECT Acertos, Falhas, TestesAprovados, TestesReprovados FROM Estatisticas WHERE IDUsers = " + idid;
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                //int result = cmd.ExecuteNonQuery();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        for(int i=0; i<4; i++)
                        {
                           result[i] =  reader.GetInt32(i);
                        }
                    }
                    else
                    {
                        return null;
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

            return result;
        }


    }
}
