using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Quiz.Classes
{
    class UsersClass
    {
        //Getters and Setters
        public int IDUsers { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int TurmaID { get; set; }
        public int Type { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;



        ///////////////////////////////////INSERT USERS DATA TO DATABASE////////////////////////////////////////
        public bool Insert (UsersClass x)
        {
            //Creating a default return type and settings its value to false
            bool isSuccess = false;

            //Step1: Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Step 2: Create a SQL Query to insert data
                string sql = "INSERT INTO Users (Nome, Sobrenome, Email, Password, IDTurmas, Tipo) VALUES (@Nome, @Sobrenome, @Email, @Password, @IDTurmas, 0)";
                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add data
                cmd.Parameters.AddWithValue("@Nome", x.Nome);
                cmd.Parameters.AddWithValue("@Sobrenome", x.SobreNome);
                cmd.Parameters.AddWithValue("@Email", x.Email);
                cmd.Parameters.AddWithValue("@Password", x.Password);
                cmd.Parameters.AddWithValue("@IDTurmas", x.TurmaID);

                //Connection open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than zero else its value will be 0
                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
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

            return isSuccess;
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


        /////////////////////////////////////////////COMBO BOX DE ALUNOS//////////////////////////////////////////////////////////
        public DataTable FillComboBoxAlunos(int idid)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable table1 = new DataTable();

            try
            {

                string sql = "SELECT * FROM Users WHERE IDTurmas = " +idid;

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



        ////////////////////////////////////////////////Retornar ID da Turma///////////////////////////////////////////////////
        public int FindIDTurmas(string turma)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            int result = 0;
            try
            {
                string sql = "SELECT IDTurmas FROM Turmas WHERE Turma = '" +turma +"'";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);

                conn.Open();

                if (dt.Rows.Count != 1)
                    return -1;
                else
                {
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                    return result;
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

        ////////////////////////////////////////////////Retornar ID do User ///////////////////////////////////////////////////
        public int FindIDUser(string x)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            int result = 0;
            try
            {
                string sql = "SELECT IDUsers FROM Users WHERE Email = '" + x + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);

                conn.Open();

                if (dt.Rows.Count != 1)
                    return -1;
                else
                {
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                    return result;
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



        ////////////////////////////////////////////////Retornar ID do User atraves do nome ///////////////////////////////////////////////////
        public int FindIDUserByName(string x)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            int result = 0;
            try
            {
                string sql = "SELECT IDUsers FROM Users WHERE Nome = '" + x + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);

                conn.Open();

                if (dt.Rows.Count != 1)
                    return -1;
                else
                {
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                    return result;
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


        /////////////////////// VALIDAR EXISTÊNCIA DO EMAIL //////////////////////////
        public bool ChexckEmail(string x)
        {

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "SELECT Email FROM Users WHERE Email = '" +x +"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                //int result = cmd.ExecuteNonQuery();

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
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



        /////////////////////// VALIDAR EXISTÊNCIA DA PASSWORD //////////////////////////
        public bool ChexckPass(string x)
        {

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "SELECT Password FROM Users WHERE Password = '" + x + "'";
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



        ///////////////////////////////////////////////RETORNAR NOME DO USER ///////////////////////////////////////////////////
        public string FindNameUser(int x)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            string result = "";
            try
            {
                string sql = "SELECT Nome FROM Users WHERE IDUsers = '" + x + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                //int result = cmd.ExecuteNonQuery();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result = reader.GetString(0);
                        return result;
                    }
                    else
                    {
                        return result;
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

        ///////////////////////////////////////////////RETORNAR EMAIL DO USER ///////////////////////////////////////////////////
        public string FindEmailUser(int x)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            string result = "";
            try
            {
                string sql = "SELECT Email FROM Users WHERE IDUsers = '" + x + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                //int result = cmd.ExecuteNonQuery();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result = reader.GetString(0);
                        return result;
                    }
                    else
                    {
                        return result;
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

        ///////////////////////////////////////////////RETORNAR TIPO DO USER ///////////////////////////////////////////////////
        public int FindTypeUser(string x)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "SELECT Tipo FROM Users WHERE Email = '" + x + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                //int result = cmd.ExecuteNonQuery();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                    else
                    {
                        return -1;
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



        ///////////////////////////////////////////////RETORNAR TURMA DO USER ///////////////////////////////////////////////////
        public string FindTurmaUser(int x)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);


            try
            {
                string sql = "SELECT Turma FROM Turmas INNER JOIN Users ON Turmas.IDTurmas = Users.IDTurmas WHERE Users.IDUsers = '" + x + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);
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



        /////////////////////////////////////////////  DATA VIEW TABLE  //////////////////////////////////////////////////////////
        public DataTable FillTable(string turma)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable table1 = new DataTable();

            try
            {

                string sql = "SELECT Users.Nome, Users.Sobrenome, Users.Email, Turmas.Turma FROM Users INNER JOIN Turmas ON Users.IDTurmas = Turmas.IDTurmas WHERE Turmas.Turma = '" +turma +"'";

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
    }
}
