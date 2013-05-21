using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace ZooTesting
{
  class Code
  {
    private string myConnectionString = "Server=localhost;Database=zoo;Uid=root;pwd=;";
    private string _id;
    private string _message;

    public Code() { }
    public Code(string id, string message)
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
        cmd.CommandText = "UPDATE code_tb SET description=@Message WHERE ID_code='" + Id + "'";
        cmd.Parameters.AddWithValue("@Message", Message);
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
        cmd.CommandText = "DELETE FROM code_tb WHERE ID_code='" + Id + "'";
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
            cmd.CommandText = "INSERT INTO code_tb(ID_code, Description) VALUES(@Id, @Message)";
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Message", Message);
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

    public bool CheckAlert()
    {
        MySqlConnection connection = new MySqlConnection(myConnectionString);
        connection.Open();
        try
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT ID_Code FROM alert_details_tb WHERE ID_Code='" + Id + "'";
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);

            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    return true;
                }
            }
            return false;
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
