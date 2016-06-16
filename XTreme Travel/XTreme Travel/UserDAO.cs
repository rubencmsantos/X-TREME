using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Data.SqlClient;
using System.Data;

namespace SGV
{
    class UserDAO
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;

        public User getUser(String emailu)
        {
            User u = null;
            con = new SqlConnection(@"Data Source=RUBEN-VAIO\RUBENSQL;Initial Catalog=Travel;Integrated Security=True");
            con.Open();
            // Create the command
            cmd = new SqlCommand("SELECT * FROM Utilizador WHERE Email = @0", con);
            // Add the parameters.
            cmd.Parameters.Add(new SqlParameter("0", emailu));
            // Create new SqlDataReader object and read data from the command.
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                // while there is another record present
                if (reader.Read())
                {
                    String email = reader[0].ToString(); ;
                    String pass = reader[1].ToString(); ;
                    String nome = reader[2].ToString(); ;
                    DateTime dataNasc = DateTime.Parse(reader[3].ToString());
                    String morada = reader[4].ToString(); ;
                    String nacionalidade = reader[5].ToString();
                    u = new User(email, pass, nome, dataNasc, morada, nacionalidade, null);
                }
            }
            return u;
        }

        public void inserirUser(User u)
        {
            con = new SqlConnection(@"Data Source=JOSESANTOS\SQLUNI;Initial Catalog=Travel;Integrated Security=True");
            con.Open();
            // Create the command
            SqlCommand insertCommand = new SqlCommand("INSERT INTO TableName (Email, Pass, Nome, DataNasc, Morada, Nacionalidade) VALUES (@0, @1, @2, @3, @4, @5)", con);
            insertCommand.Parameters.Add(new SqlParameter("0", u.Email));
            insertCommand.Parameters.Add(new SqlParameter("1", u.Password));
            insertCommand.Parameters.Add(new SqlParameter("2", u.Nome));
            insertCommand.Parameters.Add(new SqlParameter("3", u.DataNasc));
            insertCommand.Parameters.Add(new SqlParameter("4", u.Morada));
            insertCommand.Parameters.Add(new SqlParameter("5", u.Nacionalidade));
        }

    }
}