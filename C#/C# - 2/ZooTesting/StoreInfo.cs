using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace ZooTesting
{
    public class StoreInfo
    {
        private static StoreInfo storeInfo;
        private String myConnectionString = "Server=localhost;Database=zoo;Uid=root;pwd=;";

        //Login session
        public string Global_Username = null;
        public string Global_Password = null;
        public Boolean Global_LoginStatus = false;

        //Cage session
        public DataSet Global_CageData = null;

        //Type session
        public Boolean Global_ValidateID = true;
        public static StoreInfo sharedStoreInfo()
        {
            if (storeInfo == null)
            {
                storeInfo = new StoreInfo();
            }
            return storeInfo;
        }

        /// <summary>
        /// Login Session
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Boolean CheckLogin(string username, string password)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM user";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);

                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        if (username == row.ItemArray[0].ToString() && password == row.ItemArray[1].ToString())
                        {
                            this.Global_Username = username;
                            this.Global_Password = password;
                            this.Global_LoginStatus = true;
                        }
                    }
                }
                return this.Global_LoginStatus;
            }
            catch (Exception)
            {
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

        /// <summary>
        /// Cage Session
        /// </summary>
        /// <returns></returns>
        public DataSet CageLoadData()
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM cage_master";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);

                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        foreach (DataColumn column in table.Columns)
                        {
                            System.Diagnostics.Debug.WriteLine(row[column]);
                        }
                    }
                }
                return ds;

            }
            catch (Exception)
            {
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

        //animal


        //location


        //type
        public Boolean AddNewType(string name, string description, int quantity)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO cage_type_master(ID_type_cage, description_type_cage, quantity_type_cage) VALUES(@ID, @Des, @Qty)";
                cmd.Parameters.AddWithValue("@ID", name);
                cmd.Parameters.AddWithValue("@Des", description);
                cmd.Parameters.AddWithValue("@Qty", quantity);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return false;
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

        public Boolean ValidateIdType(string id_name)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM cage_type_master";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);

                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        if (row.ItemArray[0].ToString() == id_name)
                        {
                            this.Global_ValidateID = false;
                            System.Diagnostics.Debug.WriteLine("false");
                        }
                    }
                }
                return Global_ValidateID;
            }
            catch (Exception)
            {
                this.Global_ValidateID = false;
                return Global_ValidateID;
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
