using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Quiz.Classes
{
    class TestesClass
    {
        public int IDTeste { get; set; }
        public string Titulo { get; set; }
        public int IDTurma { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;



        /////////////////////////////////////////////COMBO BOX//////////////////////////////////////////////////////////
        public DataTable FillComboBox()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable table1 = new DataTable();

            try
            {

                string sql = "SELECT * FROM Turmas";

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



        /////////////////////////////////////////////COMBO BOX DE TESTES//////////////////////////////////////////////////////////
        public DataTable FillComboBoxTestes(int idid)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable table1 = new DataTable();

            try
            {

                string sql = "SELECT * FROM Teste WHERE IDTurma =" +idid;

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



        //////////////////////////////////FILL TESTES TABLE //////////////////////////
        public DataTable FillTable(string id)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable table1 = new DataTable();

            try
            {

                //int idid = Convert.ToInt32(id);

                string sql = "SELECT Teste.IDTeste, Teste.Titulo, Teste.IDTurma FROM Turmas INNER JOIN Teste ON Turmas.IDTurmas = Teste.IDTurma WHERE Turmas.Turma = '" + id + "'";

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





        //////////////////////////////////// INSERT TESTE NA BASE DE DADOS ////////////////////////////////////////////////
        public bool InsertTeste(TestesClass x)
        {
            //criar conexão
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO Teste(Titulo, IDTurma) VALUES (@Titulo, @IDTurma)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Titulo", x.Titulo);
                cmd.Parameters.AddWithValue("@IDTurma", x.IDTurma);

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


        /////////////////////////////////////////////////  DELETE TESTE FROM DATABASES ////////////////////////////////////////////////////
        public bool DeleteTeste(TestesClass x)
        {
            //criar conexão
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM Teste WHERE Titulo = @Titulo and IDTurma = @IDTurma";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Titulo", x.Titulo);
                cmd.Parameters.AddWithValue("@IDTurma", x.IDTurma);

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



        //////////////////////////////////// EDITAR TESTES NA BASE DE DADOS ////////////////////////////////////////////////
        public bool EditTestes(TestesClass x)
        {
            //criar conexão
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE Teste SET Titulo = @Titulo, IDTurma = @IDTurma WHERE IDTeste = @IDTeste";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Titulo", x.Titulo);
                cmd.Parameters.AddWithValue("@IDTurma", x.IDTurma);
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



        //////////////////////////////////// SEARCH TITULO BY ID NA BASE DE DADOS ////////////////////////////////////////////////
        public string SearchTitulo(int id)
        {
            //criar conexão
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "SELECT Titulo FROM Teste WHERE IDTeste = " + id;
                SqlCommand cmd = new SqlCommand(sql, conn);

                //abrir conexão
                conn.Open();
                //if the query runs successfully then the value of rows will be greater than zero else its value will be 0

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



       

    }
}
