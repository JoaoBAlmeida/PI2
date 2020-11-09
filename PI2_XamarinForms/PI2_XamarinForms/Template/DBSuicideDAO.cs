using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using MySql.Data.MySqlClient;
using PI2_XamarinForms.Models;

namespace PI2_XamarinForms.Template
{
    public abstract class DBSuicideDAO
    {
        private string ConnectionURL = "SERVER=localhost;DATABASE=pi2;UID=root;PASSWORD=;";
        protected abstract string GetQuery();

        protected string compare = "=";
        private MySqlConnection connection;
        private MySqlCommand cmd;
        private MySqlDataReader rdr;

        //Public function to open the DB connection
        public void OpenDB()
        {
            connection = new MySqlConnection(ConnectionURL);
            connection.Open();
        }

        //Public function to get info from DB
        public MySqlDataReader GetFromDB()
        {
            try
            {
                cmd = new MySqlCommand(GetQuery(), connection);
                rdr = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                rdr = null;
            }

            return rdr;
        }

        //Public Function to close DB connection
        public void CloseDB()
        {
            connection.Close();
        }
    }
}
