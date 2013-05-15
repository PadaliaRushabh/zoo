using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace ZooTesting
{
    class CageManager
    {
        private List<Cage> CageList = new List<Cage>();

        public CageManager() 
        {
            RefreshList();
        }

        public void RefreshList()
        {
            CageList = new List<Cage>();
            DataSet data = StoreInfo.sharedStoreInfo().LoadTable("cage_tb");
            foreach (DataTable table in data.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    int id = Convert.ToInt32(row.ItemArray[0].ToString());
                    string name = row.ItemArray[1].ToString();
                    int height = Convert.ToInt32(row.ItemArray[2].ToString());
                    int width = Convert.ToInt32(row.ItemArray[3].ToString());
                    int length = Convert.ToInt32(row.ItemArray[4].ToString());
                    float latitude = float.Parse(row.ItemArray[5].ToString());
                    float longitude = float.Parse(row.ItemArray[6].ToString());
                    int doors = Convert.ToInt32(row.ItemArray[7].ToString());
                    int animalLimit = Convert.ToInt32(row.ItemArray[8].ToString());
                    int peopleLimit = Convert.ToInt32(row.ItemArray[9].ToString());
                    bool open = Convert.ToBoolean(row.ItemArray[10].ToString());
                    bool humanInside = Convert.ToBoolean(row.ItemArray[11].ToString());
                    bool exhibitInside = Convert.ToBoolean(row.ItemArray[12].ToString());

                    Cage cage = new Cage(id, name, height, width, length, latitude, longitude, doors, peopleLimit, animalLimit, open, humanInside, exhibitInside);
                    CageList.Add(cage);
                }
            }
        }

        public ArrayList NameList()
        {
            ArrayList nameList = new ArrayList();
            foreach(Cage cage in CageList)
            {
                nameList.Add(cage.Name);
            }
            return nameList;
        }

        public Cage GetCage(int index)
        {
            return CageList[index];
        }
    }
}
