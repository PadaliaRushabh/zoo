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
        private string myConnectionString = "Server=localhost;Database=zoo;Uid=root;pwd=;Allow Zero Datetime=true";
        private int _id;
        private string _idCode;
        private int _idCage;
        private string _adminMessage;
        private bool _isopen;
        private string _timeStart;
        private string _timeEnd;

        public Alert()
        {
        }

        public Alert(int id, string idCode, int idCage, string adminMessage, bool isOpen, string timeStart, string timeEnd)
        {
            _id = id;
            _idCode = idCode;
            _idCage = idCage;
            _adminMessage = adminMessage;
            _isopen = isOpen;
            _timeStart = timeStart;
            _timeEnd = timeEnd;
        }

        #region Setter and Getter
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string IdCode
        {
            get { return _idCode; }
            set { _idCode = value; }
        }
        public int IdCage
        {
            get { return _idCage; }
            set { _idCage = value; }
        }
        public string AdminMessage
        {
            get { return _adminMessage; }
            set { _adminMessage = value; }
        }

        public bool IsOpen
        {
            get { return _isopen; }
            set { _isopen = value; }
        }

        public string TimeStart
        {
            get { return _timeStart; }
            set { _timeStart = value; }
        }

        public string TimeEnd
        {
            get { return _timeEnd; }
            set { _timeEnd = value; }
        }
        #endregion

        public void Update()
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE alert_details_tb SET ID_code=@IDCode, ID_cage=@IDCage, admin_message=@Message, isopen=@Open, time_start=@Start, time_end=@End WHERE ID_Alert_details='" + Id + "'";
                cmd.Parameters.AddWithValue("@IDCode", IdCode);
                cmd.Parameters.AddWithValue("@IDCage", IdCage);
                cmd.Parameters.AddWithValue("@Open", IsOpen);
                cmd.Parameters.AddWithValue("@Start", TimeStart);
                cmd.Parameters.AddWithValue("@End", TimeEnd);
                cmd.Parameters.AddWithValue("@Message", AdminMessage);
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
                cmd.CommandText = "DELETE FROM alert_details_tb WHERE ID_Alert_details='" + Id + "'";
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
                cmd.CommandText = "INSERT INTO alert_details_tb(ID_code, ID_cage, admin_message, isopen, time_start, time_end) VALUES(@IdCode, @IdCage, @Message, @Open, @Start, @End)";
                cmd.Parameters.AddWithValue("@IdCode", IdCode);
                cmd.Parameters.AddWithValue("@IdCage", IdCage);
                cmd.Parameters.AddWithValue("@Message", AdminMessage);
                cmd.Parameters.AddWithValue("@Open", IsOpen);
                cmd.Parameters.AddWithValue("@Start", TimeStart);
                cmd.Parameters.AddWithValue("@End", TimeEnd);
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
