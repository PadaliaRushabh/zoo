using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace ZooTesting
{
    class AlertManager
    {
        private List<Alert> _alertList = new List<Alert>();

        public List<Alert> AlertList
        {
            set { _alertList = value; }
            get { return _alertList; }
        }

        public AlertManager()
        {
            RefreshList();
        }

        public void RefreshList()
        {
            _alertList = new List<Alert>();
            DataSet data = StoreInfo.sharedStoreInfo().LoadTable("alert_details_tb");
            foreach (DataTable table in data.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    int id = Convert.ToInt32(row.ItemArray[0].ToString());
                    string idCode = row.ItemArray[1].ToString();
                    int idCage = Convert.ToInt32(row.ItemArray[2].ToString());
                    string message = row.ItemArray[3].ToString();
                    bool isOpen = Convert.ToBoolean(row.ItemArray[4].ToString());
                    string start = row.ItemArray[5].ToString();
                    string end = row.ItemArray[6].ToString();
                    Alert alert = new Alert(id, idCode, idCage, message, isOpen, start, end);
                    _alertList.Add(alert);
                }
            }
        }

        public ArrayList NameList()
        {
            ArrayList NameList = new ArrayList();
            foreach (Alert alert in _alertList)
            {
                NameList.Add(alert.Id);
            }
            return NameList;
        }

        public Alert GetAlert(int index)
        {
            return _alertList[index];
        }
    }
}
