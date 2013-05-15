using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace ZooTesting
{
    class Animal
    {
        private string myConnectionString = "Server=localhost;Database=zoo;Uid=root;pwd=;";
        private int _id;
        private string _name;
        private int _OrderId;

        public Animal() 
        {
            _name = "temp";
        }
        public Animal(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public Animal(int id, int orderId)
        {
            _id = id;
            _OrderId = orderId;
            FindNameById();
        }

        #region Get and Set
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int OrderId
        {
            get { return _OrderId; }
            set { _OrderId = value; }
        }

        #endregion

        public void Update()
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE animalrecords_tb SET name_animal=@Name WHERE ID_animalrecord=" + Id;
                cmd.Parameters.AddWithValue("@Name", Name);
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
                cmd.CommandText = "DELETE FROM animalrecords_tb WHERE ID_animalrecord=" + Id;
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

        public void Add()
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO animalrecords_tb(name_animal) VALUES(@Name)";
                cmd.Parameters.AddWithValue("@Name", Name);
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

        public int FindTempId()
        {
            int id = 0;
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT ID_animalrecord FROM animalrecords_tb WHERE name_animal='temp'";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);

                System.Diagnostics.Debug.WriteLine(ds.Tables[0]);
                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        System.Diagnostics.Debug.WriteLine(row.ItemArray[0].ToString() + "def");
                        id = Convert.ToInt32(row.ItemArray[0].ToString());
                    }
                }
                return id;

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

        public void FindNameById()
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT name_animal FROM animalrecords_tb WHERE ID_animalrecord='" + Id +"'";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);

                System.Diagnostics.Debug.WriteLine(ds.Tables[0]);
                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Name = row.ItemArray[0].ToString();
                    }
                }

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
