using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace ZooTesting
{
  class Cage
  {
    private string myConnectionString = "Server=localhost;Database=zoo;Uid=root;pwd=;";
    private int _id;
    private string _name;
    private int _height;
    private int _width;
    private int _length;
    private float _latitude;
    private float _longitude;
    private int _numOfDoor;
    private bool _open;
    private bool _humanInside;
    private bool _exhibitInside;
    private List<Animal> _inventory;

    public Cage()
    {
      _name = "temp";
      _height = 1;
      _width = 1;
      _length = 1;
      _latitude = 1;
      _longitude = 1;
      _numOfDoor = 1;
      _open = false;
      _humanInside = false;
      _exhibitInside = false;
      _inventory = ShowInventory();
    }

    public Cage(int id, string name, int height, int width, int length, float latitude, float longitude, int doors, bool open, bool humanInside, bool exhibitInside)
    {
      _id = id;
      _name = name;
      _height = height;
      _width = width;
      _length = length;
      _latitude = latitude;
      _longitude = longitude;
      _numOfDoor = doors;
      _open = open;
      _humanInside = humanInside;
      _exhibitInside = exhibitInside;
      _inventory = ShowInventory();
    }

    #region Set and Get
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

    public int Height
    {
      get { return _height; }
      set { _height = value; }
    }

    public int Width
    {
      get { return _width; }
      set { _width = value; }
    }

    public int Length
    {
      get { return _length; }
      set { _length = value; }
    }

    public float Latitude
    {
      get { return _latitude; }
      set { _latitude = value; }
    }

    public float Longitude
    {
      get { return _longitude; }
      set { _longitude = value; }
    }

    public int NumberOfDoors
    {
      get { return _numOfDoor; }
      set { _numOfDoor = value; }
    }

    public bool Open
    {
      get { return _open; }
      set { _open = value; }
    }

    public bool HumanInside
    {
      get { return _humanInside; }
      set { _humanInside = value; }
    }

    public bool ExhibitInside
    {
      get { return _exhibitInside; }
      set { _exhibitInside = value; }
    }

    public List<Animal> Inventory
    {
      get { return _inventory; }
      set { _inventory = value; }
    }
    #endregion

    public void Update()
    {
      MySqlConnection connection = new MySqlConnection(myConnectionString);
      connection.Open();
      try
      {
        MySqlCommand cmd = connection.CreateCommand();
        cmd.CommandText = "UPDATE cage_tb "
            + "SET name=@Name,size_height=@Height, size_width=@Width, size_length=@Length, location_latitude=@Latitude, location_longitude=@Longitude, doors=@Door, isopen=@Open, human_inside=@HumanInside, exhibit_inside=@ExhibitInside"
            + " WHERE ID_cage=" + Id;
        cmd.Parameters.AddWithValue("@Name", Name);
        cmd.Parameters.AddWithValue("@Height", Height);
        cmd.Parameters.AddWithValue("@Width", Width);
        cmd.Parameters.AddWithValue("@Length", Length);
        cmd.Parameters.AddWithValue("@Latitude", Latitude);
        cmd.Parameters.AddWithValue("@Longitude", Longitude);
        cmd.Parameters.AddWithValue("@Door", NumberOfDoors);
        cmd.Parameters.AddWithValue("@Open", Open);
        cmd.Parameters.AddWithValue("@HumanInside", HumanInside);
        cmd.Parameters.AddWithValue("@ExhibitInside", ExhibitInside);
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
        cmd.CommandText = "DELETE FROM cage_tb WHERE ID_cage=" + Id;
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
        cmd.CommandText = "INSERT INTO cage_tb(name, size_height, size_width, size_length, location_latitude, location_longitude, doors, isopen, human_inside, exhibit_inside) "
        + "VALUES(@Name, @Height, @Width, @Length, @Latitude, @Longitude, @Door, @Open, @HumanInside, @ExhibitInside)";
        cmd.Parameters.AddWithValue("@Name", Name);
        cmd.Parameters.AddWithValue("@Height", Height);
        cmd.Parameters.AddWithValue("@Width", Width);
        cmd.Parameters.AddWithValue("@Length", Length);
        cmd.Parameters.AddWithValue("@Latitude", Latitude);
        cmd.Parameters.AddWithValue("@Longitude", Longitude);
        cmd.Parameters.AddWithValue("@Door", NumberOfDoors);
        cmd.Parameters.AddWithValue("@Open", Open);
        cmd.Parameters.AddWithValue("@HumanInside", HumanInside);
        cmd.Parameters.AddWithValue("@ExhibitInside", ExhibitInside);
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
        cmd.CommandText = "SELECT ID_cage FROM cage_tb WHERE name='temp'";
        MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adap.Fill(ds);

        //System.Diagnostics.Debug.WriteLine(ds.Tables[0]);
        foreach (DataTable table in ds.Tables)
        {
          foreach (DataRow row in table.Rows)
          {
            //System.Diagnostics.Debug.WriteLine(row.ItemArray[0].ToString() + "def");
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

    public void AddAnimalToInventory(int animalId)
    {
      MySqlConnection connection = new MySqlConnection(myConnectionString);
      connection.Open();
      try
      {
        MySqlCommand cmd = connection.CreateCommand();
        cmd.CommandText = "INSERT INTO animal_tb(ID_cage, ID_animalrecord) VALUES(@Cage, @Animal)";
        cmd.Parameters.AddWithValue("@Cage", Id);
        cmd.Parameters.AddWithValue("@Animal", animalId);
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

    public void DeleteAnimalFromInventory(int animalId)
    {
      MySqlConnection connection = new MySqlConnection(myConnectionString);
      connection.Open();
      try
      {
        MySqlCommand cmd = connection.CreateCommand();
        cmd.CommandText = "DELETE FROM animal_tb WHERE ID_cage='" + Id + "' AND ID_animal='" + animalId + "'";
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

    public List<Animal> ShowInventory()
    {
      List<Animal> animalList = new List<Animal>();
      MySqlConnection connection = new MySqlConnection(myConnectionString);
      connection.Open();
      try
      {
        MySqlCommand cmd = connection.CreateCommand();
        cmd.CommandText = "SELECT ID_animalrecord, ID_animal FROM animal_tb WHERE ID_cage='" + Id + "'";
        MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adap.Fill(ds);

        foreach (DataTable table in ds.Tables)
        {
          foreach (DataRow row in table.Rows)
          {
            //System.Diagnostics.Debug.WriteLine(row.ItemArray[0].ToString() + "def");
            int id = Convert.ToInt32(row.ItemArray[0].ToString());
            int orderId = Convert.ToInt32(row.ItemArray[1].ToString());
            Animal animal = new Animal(id, orderId);
            animalList.Add(animal);
          }
        }
        return animalList;
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

    public int CountItems()
    {
      int count = 0;
      foreach (Animal animal in ShowInventory())
      {
        count++;
      }
      return count;
    }

    public bool CheckAlert()
    {
        MySqlConnection connection = new MySqlConnection(myConnectionString);
        connection.Open();
        try
        {
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT ID_code FROM alert_details_tb WHERE ID_cage='" + Id + "'";
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);

            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    System.Diagnostics.Debug.WriteLine(row.ItemArray[0].ToString() + "hahahaha");
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
