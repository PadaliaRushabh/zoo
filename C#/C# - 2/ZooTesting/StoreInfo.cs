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

        #region Cage
        /// <summary>
        /// Add New Cage
        /// </summary>
        /// <param name="name"></param>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="length"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="door"></param>
        /// <returns></returns>
        public Boolean AddNewCage(string name, int height, int width, int length, float latitude, float longitude, int door)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO cage_tb(name, size_height, size_width, size_length, location_latitude, location_longitude, doors) "
                + "VALUES(@Name, @Height, @Width, @Length, @Latitude, @Longitude, @Door)";
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Height", height);
                cmd.Parameters.AddWithValue("@Width", width);
                cmd.Parameters.AddWithValue("@Length", length);
                cmd.Parameters.AddWithValue("@Latitude", latitude);
                cmd.Parameters.AddWithValue("@Longitude", longitude);
                cmd.Parameters.AddWithValue("@Door", door);
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

        /// <summary>
        /// Update Cage
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="name"></param>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="length"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="door"></param>
        /// <returns></returns>
        public Boolean UpdateCage(int ID, string name, int height, int width, int length, float latitude, float longitude, int door)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE cage_tb "
                    + "SET name=@Name,size_height=@Height, size_width=@Width, size_length=@Length, location_latitude=@Latitude, location_longitude=@Longitude, doors=@Door "
                    + "WHERE ID_cage=" + ID ;
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Height", height);
                cmd.Parameters.AddWithValue("@Width", width);
                cmd.Parameters.AddWithValue("@Length", length);
                cmd.Parameters.AddWithValue("@Latitude", latitude);
                cmd.Parameters.AddWithValue("@Longitude", longitude);
                cmd.Parameters.AddWithValue("@Door", door);
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

        /// <summary>
        /// Delete Cage
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Boolean DeleteCage(int ID)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "DELETE FROM cage_tb WHERE ID_cage=" + ID;
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

        #region Animal
        /// <summary>
        /// Add New Animal
        /// </summary>
        /// <param name="cage_id"></param>
        /// <param name="animal_record_id"></param>
        /// <returns></returns>
        public Boolean AddNewAnimal(string animal_name)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO animalrecords_tb(name_animal) VALUES(@Name)";
                cmd.Parameters.AddWithValue("@Name", animal_name);
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

        public Boolean UpdateAnimal(int ID, string name)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE animalrecords_tb SET name_animal=@Name WHERE ID_animalrecord=" + ID;
                cmd.Parameters.AddWithValue("@Name", name);
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

        public Boolean DeleteAnimal(int ID)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "DELETE FROM animalrecords_tb WHERE ID_animalrecord=" + ID; 
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

        #region Animal Manager
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
