using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections;

namespace ZooTesting
{
    public class StoreInfo
    {
        private static StoreInfo storeInfo;
        private String myConnectionString = "Server=localhost;Database=zoo;Uid=root;pwd=;";
        //Main Form
        public Main_Form main = null;
        //Login session
        public string Global_Username = null;
        public string Global_Password = null;
        public Boolean Global_LoginStatus = false;

        //Cage session
        public DataSet Global_CageData = null;

        //Type session
        



        public static StoreInfo sharedStoreInfo()
        {
            if (storeInfo == null)
            {
                storeInfo = new StoreInfo();
            }
            return storeInfo;
        }

        #region Login
        /// <summary>
        /// Checking username and password
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
                cmd.CommandText = "SELECT * FROM user_tb";
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
        #endregion

        

        
        
       

        #region Animal Manager

        /// <summary>
        /// Add new Animal Manager
        /// </summary>
        /// <param name="cage_id"></param>
        /// <param name="animalrecord_id"></param>
        /// <returns></returns>
        public Boolean AddNewAnimalManager(int cage_id, int animalrecord_id)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO animal_tb(ID_cage, ID_animalrecord) VALUES(@Cage, @Animal)";
                cmd.Parameters.AddWithValue("@Cage", cage_id);
                cmd.Parameters.AddWithValue("@Animal", animalrecord_id);
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
        #endregion

        #region Loading All Table

        /// <summary>
        /// Load Table based on table name
        /// </summary>
        /// <param name="table_name"></param>
        /// <returns></returns>
        public DataSet LoadTable(string table_name)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM " + table_name;
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);

                System.Diagnostics.Debug.WriteLine(ds.Tables[0]);
                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        foreach (DataColumn column in table.Columns)
                        {
                            //System.Diagnostics.Debug.WriteLine(row[column].ToString());
                        }
                    }
                }
                return ds;

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
        #endregion
    }
}
