using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace ZooTesting
{
    class Alert
    {
        private string myConnectionString = "Server=localhost;Database=zoo;Uid=root;pwd=;";
        private string _id;
        private string _message;

        public Alert() { }
        public Alert(string id, string message)
        {
            _id = id;
            _message = message;
        }

        #region Get And Set
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        #endregion

        public void Update()
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE code_tb SET desciption=@Message WHERE ID_code=" + Id;
                cmd.Parameters.AddWithValue("@Name", Message);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public void Delete()
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "DELETE FROM code_tb WHERE ID_code=" + Id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
