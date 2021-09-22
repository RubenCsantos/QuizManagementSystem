using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Quiz.Classes
{
    class TurmasClass
    {
        public int IDTurmas { get; set; }
        public string Turma { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


        //////////////////////////////////// INSERT TURMAS NA BASE DE DADOS ////////////////////////////////////////////////
        public bool InsertTurmas(TurmasClass x)
        {
            //criar conexão
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO Turmas(Turma) VALUES (@Turma)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Turma", x.Turma);

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



        //////////////////////////////////// DELETE TURMAS NA BASE DE DADOS ////////////////////////////////////////////////
        public bool DeleteTurmas(string turma)
        {
            //criar conexão
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM Turmas WHERE Turma = '"+turma +"'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                //abrir conexão
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return true;
                    }
                    else
                    {
                        return false; //sucesso
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





        /////////////////////////////////////////////COMBO BOX//////////////////////////////////////////////////////////
        public DataTable FillComboBox()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable table1 = new DataTable();

            try
            {

                string sql = "SELECT Turma FROM Turmas";

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


        ///////////////////////////////////////////// CONVERTER TURMA PARA O ID ///////////////////////////////////
        public int SearchID(TurmasClass x)
        {
            //criar conexão
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "SELECT IDTurmas FROM Turmas WHERE Turma = @Turma";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Turma", x.Turma);

                //abrir conexão
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                    else
                    {
                        return -1; //sucesso
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

            return -1;
        }
    }
}
