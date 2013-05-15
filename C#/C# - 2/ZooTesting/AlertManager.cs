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
        private List<Alert> alertList = new List<Alert>();

        public AlertManager() { }

        public void RefreshList()
        {
            alertList = new List<Alert>();
            DataSet data = StoreInfo.sharedStoreInfo().LoadTable("code_tb");
            foreach (DataTable table in data.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    string id = row.ItemArray[0].ToString();
                    string message = row.ItemArray[1].ToString();

                    Alert alert = new Alert(id, message);
                    alertList.Add(alert);
                }
            }
        }

        public ArrayList NameList()
        {
            ArrayList nameList = new ArrayList();
            foreach (Alert alert in alertList)
            {
                nameList.Add(alert.Id);
            }
            return nameList;
        }

        public Alert GetAlert(int index)
        {
            return alertList[index];
        }
    }
}
